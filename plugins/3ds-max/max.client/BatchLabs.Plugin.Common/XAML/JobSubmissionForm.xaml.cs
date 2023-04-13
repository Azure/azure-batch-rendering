
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

using BatchLabs.Plugin.Common.Code;
using BatchLabs.Plugin.Common.Commands;
using BatchLabs.Plugin.Common.Contract;
using BatchLabs.Plugin.Common.Models;

using Cursors = System.Windows.Input.Cursors;

namespace BatchLabs.Plugin.Common.XAML
{
    /// <summary>
    /// Window for populating job data before it's sent to BatchLabs for processing.
    /// </summary>
    public partial class JobSubmissionForm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly string _maxFileFolderPath;
        private readonly IMaxRequestHandler _maxRequestHandler;
        private readonly ILabsRequestHandler _labsRequestHandler;
        private readonly IMaxLogger _logger;

        private Visibility _assetSpinnerVisible;
        private Visibility _missingSpinnerVisible;
        private RelayCommand _addDirectoryCommand;
        private RelayCommand _removeDirectoryCommand;
        private RelayCommand _selectParentCommand;
        private RelayCommand _findFileCommand;
        private string _selectedRenderer;

        public JobSubmissionForm(ILabsRequestHandler labsRequestHandler, IMaxRequestHandler maxRequestHandler, IMaxLogger logger)
        {
            _logger = logger;
            _labsRequestHandler = labsRequestHandler;
            _maxRequestHandler = maxRequestHandler;

            InitializeComponent();
            DataContext = this;
            
            SetWindowColor();
            SetControlColors();

            Templates = TemplateHelper.GetApplicationTemplates(logger);
            SelectedTemplate = TemplateHelper.TemplateStandard;

            Renderers = new ObservableCollection<KeyValuePair<string, string>>();
            Renderers.AddRange(TemplateHelper.GetRenderers(TemplateHelper.TemplateStandard));
            // todo: read this from the scene
            SelectedRenderer = GetSelectedRenderer(TemplateHelper.TemplateStandard);

            MissingAssets = new ObservableCollection<IAssetFile>();
            MissingAssets.CollectionChanged += OnMissingCollectionChanged;
            MissingSpinnerVisibility = Visibility.Collapsed;

            AssetDirectories = new ObservableCollection<AssetFolder>();
            AssetDirectories.CollectionChanged += OnDirectoryCollectionChanged;
            AssetSpinnerVisibility = Visibility.Collapsed;

            // only load assets if we have a current scene
            if (HasSceneFile)
            {
                _logger.Debug($"Current renrder is set to: '{_maxRequestHandler.CurrentRenderer}'");

                _maxFileFolderPath = Path.GetDirectoryName(_maxRequestHandler.CurrentSceneFilePath);
                AssetDirectories.Add(new AssetFolder(_maxFileFolderPath, true));

                SceneFile.Text = _maxRequestHandler.CurrentSceneFileName;
                JobId.Text = Utils.ContainerizeMaxFile(SceneFile.Text);

                FrameWidth.Text = _maxRequestHandler.RenderWidth.ToString();
                FrameHeight.Text = _maxRequestHandler.RenderHeight.ToString();

                SetAssetCollection();
            }
            else
            {
                SetButtonState(false);
                Status.Text = "No scene loaded, unable to submit a job.";
                RenderTemplates.IsEnabled = false;
                RendererType.IsEnabled = false;
            }
        }

        public ICommand AddDirectoryCommand => _addDirectoryCommand ?? (_addDirectoryCommand = new RelayCommand(AddDirectory));

        public ICommand SelectParentCommand => _selectParentCommand ?? (_selectParentCommand = new RelayCommand(SelectParentDirectory, CanRemoveDirectory));

        public ICommand RemoveDirectoryCommand => _removeDirectoryCommand ?? (_removeDirectoryCommand = new RelayCommand(RemoveDirectory, CanRemoveDirectory));

        public ICommand FindFileCommand => _findFileCommand ?? (_findFileCommand = new RelayCommand(FindMissingFile));


        public string SelectedRenderer
        {
            get { return _selectedRenderer; }
            set
            {
                _selectedRenderer = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<KeyValuePair<string, string>> Renderers { get; }

        public string SelectedTemplate { get; set; }

        public bool HasSceneFile => !string.IsNullOrEmpty(_maxRequestHandler.CurrentSceneFilePath);

        public List<KeyValuePair<string, string>> Templates { get; }

        public ObservableCollection<AssetFolder> AssetDirectories { get; set; }

        public ObservableCollection<IAssetFile> MissingAssets { get; set; }

        public Visibility AssetSpinnerVisibility
        {
            get { return _assetSpinnerVisible; }
            set
            {
                _assetSpinnerVisible = value;
                RaisePropertyChanged();
            }
        }

        public Visibility MissingSpinnerVisibility
        {
            get { return _missingSpinnerVisible; }
            set
            {
                _missingSpinnerVisible = value;
                RaisePropertyChanged();
            }
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string GetSelectedRenderer(string template)
        {
            var current = _maxRequestHandler.CurrentRenderer?.ToLower();
            _logger.Debug($"Getting selected renderer for template: '{template}' and renderer: '{current}'");
            SetButtonState(HasSceneFile);

            if (string.IsNullOrEmpty(current))
            {
                // unlikely to happen but who knows
                return TemplateHelper.RendererVRay;
            }

            if (template == TemplateHelper.TemplateDistributed)
            {
                if (current.Contains("v-ray adv"))
                {
                    _logger.Debug($"setting selected renderer to: '{TemplateHelper.RendererVRayAdv}'");
                    return TemplateHelper.RendererVRayAdv;
                }

                if (current.Contains("v-ray rt"))
                {
                    _logger.Debug($"setting selected renderer to: '{TemplateHelper.RendererVRayRt}'");
                    return TemplateHelper.RendererVRayRt;
                }

                // block job submission as well based on this.
                _logger.Error("Based on the Render Setup, the distributed render template will not work unless your scene is set to use either the 'V-Ray Adv' or 'V-Ray RT' renderers.", "Invalid Template Selection", true);
                SetButtonState(false);

                return string.Empty;
            }

            var renderer = current.Contains(TemplateHelper.RendererArnold)
                ? TemplateHelper.RendererArnold
                : TemplateHelper.RendererVRay;

            _logger.Debug($"setting selected renderer to: '{renderer}'");

            return renderer;
        }


        private void SetButtonState(bool enabled)
        {
            SubmitButton.IsEnabled = enabled;
        }

        /// <summary>
        /// Get current 3ds Max background color and match our dialog to it
        /// </summary>
        private void SetWindowColor()
        {
            LayoutRoot.Background = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.Window);
        }

        /// <summary>
        /// Get current 3ds Max text color and match our labels to it
        /// </summary>
        private void SetControlColors()
        {
            var textBrush = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.Text);
            var textBoxBrush = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.InputBox);
            var spinnerBrush = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.Spinner);

            JobDetailsTitle.Foreground = textBrush;
            JobNameLabel.Foreground = textBrush;
            JobId.Foreground = textBrush;
            JobId.Background = textBoxBrush;
            TemplateLabel.Foreground = textBrush;

            FrameStartLabel.Foreground = textBrush;
            FrameStart.Foreground = textBrush;
            FrameStart.Background = textBoxBrush;
            FrameEndLabel.Foreground = textBrush;
            FrameEnd.Foreground = textBrush;
            FrameEnd.Background = textBoxBrush;
            FrameWidthLabel.Foreground = textBrush;
            FrameWidth.Foreground = textBrush;
            FrameWidth.Background = textBoxBrush;
            FrameHeightLabel.Foreground = textBrush;
            FrameHeight.Foreground = textBrush;
            FrameHeight.Background = textBoxBrush;

            RendererLabel.Foreground = textBrush;

            AdditionalArgsLabel.Foreground = textBrush;
            AdditionalArgs.Foreground = textBrush;
            AdditionalArgs.Background = textBoxBrush;

            AssetsTitle.Foreground = textBrush;

            SceneFileLabel.Foreground = textBrush;
            SceneFile.Foreground = textBrush;
            SceneFile.Background = textBoxBrush;

            AssetsLabel.Foreground = textBrush;
            AssetsLabelNote.Foreground = textBrush;
            AssetListView.Foreground = textBrush;
            AssetListView.Background = textBoxBrush;
            AssetListSpinner.Foreground = spinnerBrush;

            MissingLabel.Foreground = textBrush;
            MissingLabelNote.Foreground = textBrush;
            MissingListView.Foreground = textBrush;
            MissingListView.Background = textBoxBrush;
            MissingSpinner.Foreground = spinnerBrush;

            MissingNoteLabel.Foreground = textBrush;
            Status.Foreground = textBrush;
            SubmitButton.Foreground = textBrush;
            SubmitButton.Background = textBoxBrush;
        }

        /// <summary>
        /// Input validator for the frameStart and frameEnd textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateNumber(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void SetAssetCollection()
        {
            try
            {
                // indicate we are doing something
                AssetSpinnerVisibility = Visibility.Visible;
                MissingSpinnerVisibility = Visibility.Visible;

                // get the assets in the project directory on disk
                Status.Text = "Scanning project directory";
                var projectFolderFiles = AssetWrangler.GetProjectFiles(_maxFileFolderPath);
                _logger.Debug($"found '{projectFolderFiles.Keys.Count}' files in the project directory: '{_maxFileFolderPath}'");

                // process the scene files and any missing assets
                await ProcessSceneFiles(projectFolderFiles);

                // find and add any missing assets to the list
                await ProcessMissingAssets();

                Status.Text = "Asset scanning completed";
                SetButtonState(true);
            }
            catch (Exception ex)
            {
                _logger.Error($"Failed to get or display assets from scene: {ex.Message}. {ex}");
            }
        }



        /// <summary>
        /// Get the assets from the scene and make sure they exist in the project directory. Any 
        /// that don't add them to the missing asset list. Any folders we encounter we add to the 
        /// asset folder list.
        /// </summary>
        /// <param name="projectFolderFiles"></param>
        private async Task<bool> ProcessSceneFiles(IReadOnlyDictionary<string, List<string>> projectFolderFiles)
        {
            Status.Text = "Loading assets from the scene file, this can take a while";
            var sceneFiles = await _maxRequestHandler.GetFoundSceneAssets();

            // TODO: Debug ... remove foreach log.
            _logger.Debug($"found '{sceneFiles.Count}' scene assets");
            foreach (var asset in sceneFiles)
            {
                var assetName = Path.GetFileName(asset.FileName) ?? "";
                if (projectFolderFiles.ContainsKey(assetName))
                {
                    // found a file with the same name in the project directory, get the locations as it could exist in more than one folder on disk
                    var locations = projectFolderFiles[assetName];
                    if (string.IsNullOrEmpty(locations.Find(file => file == asset.FullFilePath)))
                    {
                        // the filename exists in the project direrctory, but not with the same path
                        // see if we can match up any directories and make a guess if its the correct one.
                        _logger.Debug($"Did not find: {asset.FullFilePath}, locations: {locations.Count}");
                        var matchingDirCount = AssetWrangler.FindMatchingDirectories(asset.FullFilePath, locations);
                        if (matchingDirCount == 0)
                        {
                            // add it to the missing asset list for the user to find
                            MissingAssets.Add(asset);
                            _logger.Debug($"Add to missing asset list: {asset.FileName} :: {asset.FullFilePath}");
                        }
                        else
                        {
                            _logger.Debug($"Found partial match for [{asset.FullFilePath}] in [{string.Join(":::", locations)}] with '{matchingDirCount}' matching dirs");
                        }
                    }
                    else
                    {
                        // no else needed as we found it and it matches the path. do nothing.
                        _logger.Debug($"Found in project directory: {asset.FullFilePath}");
                    }

                }
                else
                {
                    // asset was not found in project directory, but Max has a reference to it elsewhere. add folder to collection
                    _logger.Debug($"Asset '{assetName}' was not found in project directory, but Max has a reference to it elsewhere: [{asset.FullFilePath}] -> [{asset.FileName}]");
                    SafeAddAssetFolder(Path.GetDirectoryName(asset.FullFilePath));
                }
            }

            AssetSpinnerVisibility = Visibility.Collapsed;
            return true;
        }

        /// <summary>
        /// Find and add any missing scene assets to the list
        /// </summary>
        private async Task<bool> ProcessMissingAssets()
        {
            Status.Text = "Loading missing assets from the scene file";
            var missing = await _maxRequestHandler.GetMissingAssets();
            MissingAssets.AddRange(missing);

            _logger.Debug($"found '{missing.Count}' missing assets");
            foreach (var asset in missing)
            {
                _logger.Debug($"missing -> {asset.FileName} --- {asset.FullFilePath}");
            }

            MissingSpinnerVisibility = Visibility.Collapsed;
            return true;
        }

        /// <summary>
        /// Called when a row is either added or removed from the missing asset list so we can add or 
        /// remove the event handlers for the missing file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMissingCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var missingBrush = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.Warning);
            if (e.NewItems != null && e.NewItems.Count != 0)
            {
                foreach (IAssetFile viewModel in e.NewItems)
                {
                    viewModel.RemoveFileInfo += OnRemoveAsset;
                    viewModel.RemoveButtonBrush = missingBrush;
                }
            }

            if (e.OldItems != null && e.OldItems.Count != 0)
            {
                foreach (IAssetFile viewModel in e.OldItems)
                {
                    viewModel.RemoveFileInfo -= OnRemoveAsset;
                }
            }
        }

        /// <summary>
        /// Called when a row is either added or removed from the asset directory list so we can add or 
        /// remove the event handlers for the directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDirectoryCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var missingBrush = _maxRequestHandler.GetUiColorBrush(BrushColorEnum.Warning);
            if (e.NewItems != null && e.NewItems.Count != 0)
            {
                foreach (AssetFolder viewModel in e.NewItems)
                {
                    viewModel.RemoveDirectory += OnRemoveDirectory;
                    viewModel.RemoveButtonBrush = missingBrush;
                }
            }

            if (e.OldItems != null && e.OldItems.Count != 0)
            {
                foreach (AssetFolder viewModel in e.OldItems)
                {
                    viewModel.RemoveDirectory -= OnRemoveDirectory;
                }
            }
        }

        /// <summary>
        /// Handler to remove a missing file from the list
        /// </summary>
        /// <param name="sender">display name of the file</param>
        /// <param name="args"></param>
        private void OnRemoveAsset(object sender, EventArgs args)
        {
            var filePath = sender as string;
            var item = MissingAssets.FirstOrDefault(file => file.FullFilePath == filePath);
            if (item != null)
            {
                MissingAssets.Remove(item);
                _logger.Debug($"Removed {item.FileName} from missing asset list");
            }
        }

        /// <summary>
        /// Handler to remove a selected directory from the list
        /// </summary>
        /// <param name="sender">display name of the file</param>
        /// <param name="args"></param>
        private void OnRemoveDirectory(object sender, EventArgs args)
        {
            var folderPath = sender as string;
            var item = AssetDirectories.FirstOrDefault(file => file.Path == folderPath);
            if (item != null)
            {
                AssetDirectories.Remove(item);
                _logger.Debug($"Removed {folderPath} from folder list");
                Status.Text = "Removed folder from list";
            }
        }

        private void AddDirectory(object eventArgs)
        {
            Status.Text = "Adding directory";
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }

                _logger.Debug($"GOT :: {result.ToString()}, {dialog.SelectedPath}");
                
                // make sure the directory is not empty as this will kill the CLI
                if (!FileActions.GetFilesInDirectory(dialog.SelectedPath, SearchOption.AllDirectories).Any())
                {
                    _logger.Debug($"Ignoring: '{dialog.SelectedPath}' as the folder is empty");
                    return;
                }
                
                if (SafeAddAssetFolder(dialog.SelectedPath))
                {
                    Status.Text = $"Added: {dialog.SelectedPath}";
                    CheckMissingAssets(dialog.SelectedPath);
                }
            }
        }

        private void CheckMissingAssets(string newFolderPath)
        {
            _logger.Debug($"checking for missing assets in new folder: [{newFolderPath}]");
            foreach (var missingAsset in MissingAssets.ToList())
            {
                if (missingAsset.FileName.StartsWith(newFolderPath, StringComparison.InvariantCultureIgnoreCase) ||
                    missingAsset.FullFilePath.StartsWith(newFolderPath, StringComparison.InvariantCultureIgnoreCase))
                {
                    _logger.Debug($"no longer missing -> [{missingAsset.FileName} :: {missingAsset.FullFilePath}]");
                    // if our file path starts with the new folder we are adding then we can remove it from the missing list
                    MissingAssets.Remove(missingAsset);
                }
            }
        }

        private void SelectParentDirectory(object eventArgs)
        {
            if (eventArgs != null && CanRemoveDirectory(eventArgs))
            {
                var folder = eventArgs as AssetFolder;
                _logger.Debug($"Select parent for: {folder?.Path}");
                if (folder != null)
                {
                    
                    var parentDir = new DirectoryInfo(folder.Path).Parent;
                    if (parentDir != null)
                    {
                        var existing = AssetDirectories.FirstOrDefault(assetDir => assetDir.Path.Equals(parentDir.FullName, StringComparison.InvariantCultureIgnoreCase));
                        if (existing != null)
                        {
                            // the parent dir is already in the list so just remove this one.
                            Status.Text = "Parent already exists, removing folder.";
                            folder.RemoveItem(folder.Path);
                            return;
                        }

                        Status.Text = "Selecting parent directory";
                        folder.Path = parentDir.FullName;
                    }
                }
            }
        }

        private static void RemoveDirectory(object eventArgs)
        {
            if (eventArgs != null && CanRemoveDirectory(eventArgs))
            {
                var folder = eventArgs as AssetFolder;
                folder?.RemoveItem(folder.Path);
            }
        }

        private static bool CanRemoveDirectory(object eventArgs)
        {
            var folder = eventArgs as AssetFolder;
            return folder != null && folder.CanRemove;
        }

        private void FindMissingFile(object eventArgs)
        {
            var asset = eventArgs as IAssetFile;
            if (asset == null)
            {
                return;
            }

            try
            {
                var filename = Path.GetFileName(asset.FileName);
                var extension = Path.GetExtension(filename);
                Status.Text = $"Locating asset: {filename}";
                using (var dialog = new OpenFileDialog { Filter = $"{extension} files (*{extension})|*{extension}|All files (*.*)|*.*" })
                {
                    var result = dialog.ShowDialog();
                    if (result != DialogResult.OK || string.IsNullOrEmpty(dialog.FileName))
                    {
                        return;
                    }

                    _logger.Debug($"User selected :: {dialog.FileName}");
                    if (asset.FileName.Equals(dialog.FileName, StringComparison.InvariantCultureIgnoreCase) ||
                        asset.FullFilePath.Equals(dialog.FileName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Status.Text = "Found missing asset";

                        // selected file is the correct one, so add the directory and re-check missing assets.
                        SafeAddAssetFolder(Path.GetDirectoryName(dialog.FileName));
                        CheckMissingAssets(dialog.FileName);
                    }
                    else
                    {
                        _logger.Debug($"Selected file '{dialog.FileName}' was not the missing asset: [{asset.FileName} :: {asset.FullFilePath}");
                        Status.Text = "Selected file was not the missing asset";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Failed process missing asset: {ex.Message}. {ex}");
            }
        }

        private bool SafeAddAssetFolder(string folderPath)
        {
            var existing = AssetDirectories.FirstOrDefault(file => file.Path.Equals(folderPath, StringComparison.InvariantCultureIgnoreCase));
            if (existing == null)
            {
                AssetDirectories.Add(new AssetFolder(folderPath));
                _logger.Debug($"Added folder to list: {folderPath}");

                return true;
            }

            return false;
        }

        private void RenderTemplates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var template = RenderTemplates.SelectedValue as string;

            Renderers.Clear();
            Renderers.AddRange(TemplateHelper.GetRenderers(template));
            SelectedRenderer = GetSelectedRenderer(template);
        }

        /// <summary>
        /// Handle submit button click. Set up any values we want to pass to BatchLabs and 
        /// then call the request handler to make the call.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var launchUrl = $"market/3dsmax/actions/{SelectedTemplate}/submit";

                // set up the basic arguments
                var arguments = new Dictionary<string, string>
                {
                    ["auto-pool"] = "0",
                    ["input-parameter"] = "inputFilegroup",
                    ["jobName"] = JobId.Text,
                    ["frameStart"] = FrameStart.Text,
                    ["frameEnd"] = FrameEnd.Text,
                    ["frameWidth"] = FrameWidth.Text,
                    ["frameHeight"] = FrameHeight.Text,
                    ["renderer"] = SelectedRenderer
                };

                if (!string.IsNullOrEmpty(AdditionalArgs.Text))
                {
                    arguments["additionalArgs"] = AdditionalArgs.Text;
                }

                // if we have a max file loaded then we pass this as well
                var sceneFile = _maxRequestHandler.CurrentSceneFileName;
                if (false == string.IsNullOrEmpty(sceneFile))
                {
                    arguments["sceneFile"] = sceneFile;
                    arguments["asset-container"] = Utils.ContainerizeMaxFile(sceneFile);
                    arguments["asset-paths"] = string.Join(",", from folder in AssetDirectories select folder.Path);
                    
                }

#if DEBUG
                // show what we are about to send to labs
                var debug = $"Launch:{launchUrl}\n";
                foreach (var arg in arguments)
                {
                    debug = string.Concat(debug, $"{arg.Key}:{Uri.EscapeUriString(arg.Value)}\n");
                }

                _logger.Debug(debug);
#endif

                // call labs with all the parameters, will open correct gallery template
                _labsRequestHandler.CallBatchLabs(launchUrl, arguments);
            }
            catch (Exception ex)
            {
                _logger.Error($"Failed to submit job: {ex.Message}. {ex}");
                _logger.Error($"Hit exception while attempting to submit job: {ex.Message}.", "Failed to submit job", true);
            }
        }
    }
}
