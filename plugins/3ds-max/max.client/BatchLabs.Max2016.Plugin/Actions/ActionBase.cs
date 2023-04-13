
using System;
using System.Windows.Forms;

using UiViewModels.Actions;

using BatchLabs.Max2016.Plugin.Common;

using BatchLabs.Plugin.Common.Labs;
using BatchLabs.Plugin.Common.Resources;

namespace BatchLabs.Max2016.Plugin.Actions
{
    /// <inheritdoc />
    /// <summary>
    /// Base class to avoid having to declare ActionText and Category in more than one location.
    /// </summary>
    public abstract class ActionBase : CuiActionCommandAdapter
    {
        protected ActionBase()
        {
            LabsRequestHandler = new BatchLabsRequestHandler(Log.Instance);
        }

        public BatchLabsRequestHandler LabsRequestHandler { get; }

        public override string ActionText => InternalActionText;

        public override string Category => InternalCategory;

        public override string InternalCategory => Loader.ActionCategory;

        /// <summary>
        /// Execute is called when the user clicks on the action in the UI.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        {
            try
            {
                InternalExecute();
            }
            catch (Exception ex)
            {
                Log.Instance.Error($"{ex.Message}\n{ex}", Strings.UncaughtException_Title, true);
                MessageBox.Show($"{Strings.UncaughtException_Title}: {ex.Message}");
            }
        }

        public abstract void InternalExecute();
    }
}
