
using System;
using System.Windows;

#if !DEBUG
using System.Windows.Media.Imaging;
using System.Windows.Interop;
#endif

using BatchLabs.Max2016.Plugin.Common;
using BatchLabs.Max2016.Plugin.Max;

using BatchLabs.Plugin.Common.Actions;
using BatchLabs.Plugin.Common.Resources;
using BatchLabs.Plugin.Common.XAML;

using ManagedServices;

using MessageBox = System.Windows.Forms.MessageBox;

namespace BatchLabs.Max2016.Plugin.Actions
{
    public class SubmitJobAction : ActionBase
    {
        private MaxRequestInterceptor _maxRequestInterceptor;

        public override void InternalExecute()
        {
            MaxGlobalInterface.Instance.COREInterface16.PushPrompt(Strings.SubmitJob_Log);
            Log.Instance.Debug(Strings.SubmitJob_Log);

            OpenJobConfigWindow();
        }

        private void OpenJobConfigWindow()
        {
            try
            {
                var dialog = new Window
                {
                    Title = Strings.SubmitJob_Title,
                    SizeToContent = SizeToContent.WidthAndHeight,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    ResizeMode = ResizeMode.CanResizeWithGrip,
                    ShowInTaskbar = true
                };

                _maxRequestInterceptor = new MaxRequestInterceptor();
                var jobSubmissionForm = new JobSubmissionForm(LabsRequestHandler, _maxRequestInterceptor, Log.Instance);
                dialog.Content = jobSubmissionForm;

#if !DEBUG
                // only works in the context of 3ds Max
                var maxIcon = GetMaxIcon();
                if (maxIcon != null)
                {
                    dialog.Icon = maxIcon;
                }

                var windowHandle = new WindowInteropHelper(dialog);
                windowHandle.Owner = AppSDK.GetMaxHWND();
                AppSDK.ConfigureWindowForMax(dialog);
#endif
                dialog.Show();

            }
            catch (Exception ex)
            {
                Log.Instance.Error($"{ex.Message}\n{ex}", Strings.SubmitJob_Error, true);
                MessageBox.Show($"{Strings.SubmitJob_Error}.\n{ex.Message}\n{ex}");
            }
        }

#if !DEBUG
        private BitmapSource GetMaxIcon()
        {
            // only works in the context of 3ds Max
            try
            {
                var hBitmap = AppSDK.GetMainApplicationIcon().ToBitmap().GetHbitmap();
                return Imaging.CreateBitmapSourceFromHBitmap(hBitmap, IntPtr.Zero, Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
            }
            catch (Exception ex)
            {
                Log.Instance.Error($"{ex.Message}\n{ex}", Strings.SubmitJob_Icon_Error);
                return null;
            }
        }
#endif

        public override string InternalActionText => ActionStrings.SubmitJobActionText;
    }
}
