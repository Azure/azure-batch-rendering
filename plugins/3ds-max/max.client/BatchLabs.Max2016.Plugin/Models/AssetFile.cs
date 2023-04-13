
using System;
using System.Windows.Input;
using System.Windows.Media;

using Autodesk.Max.MaxSDK.AssetManagement;

using BatchLabs.Plugin.Common.Commands;
using BatchLabs.Plugin.Common.Contract;

namespace BatchLabs.Max2016.Plugin.Models
{
    public class AssetFile : IAssetFile
    {
        public event EventHandler RemoveFileInfo;

        private RelayCommand _removeMissingFileCommand;

        public AssetFile(IAssetUser asset)
        {
            Id = asset.IdAsString ?? "";
            FullFilePath = asset.FullFilePath ?? "";
            FileName = asset.FileName ?? "";
        }

        public string Id { get; set; }

        public string FileName { get; set; }

        public string FullFilePath { get; set; }

        public bool IsSelected { get; set; }

        public Brush RemoveButtonBrush { get; set; }

        public ICommand RemoveMissingFileCommand => _removeMissingFileCommand ?? (_removeMissingFileCommand = new RelayCommand(OnRemoveItem));

        private void OnRemoveItem(object sender)
        {
            // send the item to the model to be removed
            RemoveFileInfo.Raise(sender, new EventArgs());
        }
    }
}
