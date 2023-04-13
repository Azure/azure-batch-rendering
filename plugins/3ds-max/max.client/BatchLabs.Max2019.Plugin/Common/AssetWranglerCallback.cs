
using System.Collections.Generic;

using Autodesk.Max.MaxSDK.AssetManagement;
using Autodesk.Max.Plugins;

using BatchLabs.Max2019.Plugin.Models;
using BatchLabs.Plugin.Common.Contract;

namespace BatchLabs.Max2019.Plugin.Common
{
    public class AssetWranglerCallback : AssetEnumCallback
    {
        private readonly Dictionary<string, IAssetFile> _assets;

        public AssetWranglerCallback()
        {
            _assets = new Dictionary<string, IAssetFile>();
        }

        public override void RecordAsset(IAssetUser asset)
        {
            if (_assets.ContainsKey(asset.IdAsString) == false)
            {
                _assets.Add(asset.IdAsString, new AssetFile(asset));
            }
        }

        public Dictionary<string, IAssetFile> AssetDictionary => _assets;

        public List<IAssetFile> AssetList => new List<IAssetFile>(_assets.Values);
    }
}
