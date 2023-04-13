
using System;

using BatchLabs.Max2016.Plugin.Common;
using BatchLabs.Max2016.Plugin.Max;

using BatchLabs.Plugin.Common.XAML;

using MessageBox = System.Windows.Forms.MessageBox;

namespace BatchLabs.Max2016.Plugin.Actions
{
    public class ColorPaletteAction : ActionBase
    {
        public override void InternalExecute()
        {
            MaxGlobalInterface.Instance.COREInterface16.PushPrompt("Showing UI Colors");
            OpenJobConfigWindow();
        }

        private void OpenJobConfigWindow()
        {
            try
            {
                var paletteWindow = new ColorPalette(new MaxRequestInterceptor(), Log.Instance);
                paletteWindow.Show();
            }
            catch (Exception ex)
            {
                Log.Instance.Error($"{ex.Message}\n{ex}", "Failed to show color palette", true);
                MessageBox.Show($"Failed to show color palette.\n{ex.Message}\n{ex}");
            }
        }

        public override string InternalActionText => "Max Color Palette";
    }
}
