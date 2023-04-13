
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

using BatchLabs.Plugin.Common.Contract;
using BatchLabs.Plugin.Common.Models;

namespace BatchLabs.Plugin.Common.XAML
{
    /// <summary>
    /// Shows the color palette for the current version of 3ds Max.
    /// </summary>
    public partial class ColorPalette : Window
    {
        public ColorPalette(IMaxRequestHandler maxRequestHandler, IMaxLogger logger)
        {
            InitializeComponent();
            DataContext = this;

            Brushes = new ObservableCollection<MaxColorBrush>();
            var uiColors = maxRequestHandler.GetAllColorBrushes();

            foreach (Tuple<string, Brush> color in uiColors)
            {
                logger.Debug($"case GuiColors.{color.Item1}: return ColorTranslator.FromHtml(\"{ color.Item2.ToString()}\");");
                Brushes.Add(new MaxColorBrush(color.Item1, color.Item2));
            }
        }

        public ObservableCollection<MaxColorBrush> Brushes { get; set; }

        private void CopyName_Click(object sender, RoutedEventArgs e)
        {
            if (BrushList.SelectedIndex != -1)
            {
                Clipboard.SetText(((MaxColorBrush)BrushList.SelectedItem).Name);
            }
        }

        private void CopyHex_Click(object sender, RoutedEventArgs e)
        {
            if (BrushList.SelectedIndex != -1)
            {
                Clipboard.SetText(((MaxColorBrush)BrushList.SelectedItem).Hex);
            }
        }
    }
}
