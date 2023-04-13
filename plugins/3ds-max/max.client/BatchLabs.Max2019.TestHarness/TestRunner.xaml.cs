
using System.Windows;

using BatchLabs.Max2019.Plugin.Actions;
using BatchLabs.Max2019.Plugin.Contract.Stubs;
using BatchLabs.Max2019.Plugin.Max;

namespace BatchLabs.Max2019.TestHarness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TestRunner : Window
    {
        public TestRunner()
        {
            InitializeComponent();

            var myInterface16 = (MaxGlobalInterface.Instance.COREInterface16 as Interface16Stub);
            if (myInterface16 != null)
            {
                myInterface16.PushMessage += (sender, message) => { ShowPrompt(message); };
            }
        }

        private void ShowPrompt(string prompt)
        {
            Footer.Content = prompt;
        }

        private void JobsButton_Click(object sender, RoutedEventArgs e)
        {
            var action = new MonitorJobsAction();
            action.InternalExecute();
        }

        private void PoolsButton_Click(object sender, RoutedEventArgs e)
        {
            var action = new MonitorPoolsAction();
            action.InternalExecute();
        }

        private void DataButton_Click(object sender, RoutedEventArgs e)
        {
            var action = new ManageDataAction();
            action.InternalExecute();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var action = new SubmitJobAction();
            action.InternalExecute();
        }
    }
}
