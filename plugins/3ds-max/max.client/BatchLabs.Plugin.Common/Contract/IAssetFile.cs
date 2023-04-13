
using System;
using System.Windows.Input;
using System.Windows.Media;

namespace BatchLabs.Plugin.Common.Contract
{
    public interface IAssetFile
    {
        event EventHandler RemoveFileInfo;

        string Id { get; set; }

        string FileName { get; set; }

        string FullFilePath { get; set; }

        bool IsSelected { get; set; }

        Brush RemoveButtonBrush { get; set; }

        ICommand RemoveMissingFileCommand { get; }
    }
}
