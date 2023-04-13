
using System;

using Autodesk.Max;
using Autodesk.Max.BaseInterface;
using Autodesk.Max.MaxSDK.AssetManagement;
using Autodesk.Max.MaxSDK.Util;

namespace BatchLabs.Max2016.Plugin.Contract.Stubs
{
    /// <summary>
    /// Override functionality from the Max SDK for when we are running in local debug mode. 
    /// </summary>
    public class FakeAsset : IAssetUser
    {
        public FakeAsset(string filename, string path)
        {
            IdAsString = Guid.NewGuid().ToString();
            FileName = filename;
            FullFilePath = path;
        }

        public string IdAsString { get; }


        public string FileName { get; }

        public string FullFilePath { get; }

        #region Unused Properties and Overrides

        public IAssetId Id_ { get; }

        public AssetType GetType_ { get; }


        public bool Equals(IInterfaceServer other)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr NativePointer { get; }

        public IBaseInterface GetInterface(IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        public IBaseInterface GetInterfaceAt(int i)
        {
            throw new NotImplementedException();
        }

        public int NumInterfaces { get; }
        public void AcquireIObject()
        {
            throw new NotImplementedException();
        }

        public void ReleaseIObject()
        {
            throw new NotImplementedException();
        }

        public void DeleteIObject()
        {
            throw new NotImplementedException();
        }

        public string IObjectName { get; }

        public bool RegisterNotifyCallback(IInterfaceNotifyCallback incb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterNotifyCallback(IInterfaceNotifyCallback incb)
        {
            throw new NotImplementedException();
        }

        public void ReleaseInterface()
        {
            throw new NotImplementedException();
        }

        public void DeleteInterface()
        {
            throw new NotImplementedException();
        }

        public IBaseInterface CloneInterface(IntPtr remapDir)
        {
            throw new NotImplementedException();
        }

        public IInterface_ID Id { get; }

        public LifetimeType LifetimeControl { get; }

        public IBaseInterface AcquireInterface { get; }

        public int _DispatchFn(short fid, int t, IFPValue result, IFPParams p)
        {
            throw new NotImplementedException();
        }

        public int Invoke(short fid, int t, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        public int Invoke(short fid, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        public int Invoke(short fid, int t, IFPValue result, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        public int Invoke(short fid, IFPValue result, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        public short FindFn(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(short actionID)
        {
            throw new NotImplementedException();
        }

        public bool IsChecked(short actionID)
        {
            throw new NotImplementedException();
        }

        public bool IsVisible(short actionID)
        {
            throw new NotImplementedException();
        }

        public short GetIsEnabled(short actionID)
        {
            throw new NotImplementedException();
        }

        public short GetIsChecked(short actionID)
        {
            throw new NotImplementedException();
        }

        public short GetIsVisible(short actionID)
        {
            throw new NotImplementedException();
        }

        public void EnableActions(bool onOff)
        {
            throw new NotImplementedException();
        }

        public IFPInterfaceDesc Desc { get; }

        public IActionTable ActionTable { get; }

        public IFPInterfaceDesc GetDescByID(IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        public IAssetUser Assign(IAssetUser assetU)
        {
            throw new NotImplementedException();
        }

        public bool GetFullFilePath(IPath filePath)
        {
            throw new NotImplementedException();
        }

        public bool GetFullFilePath(ref string filePath)
        {
            throw new NotImplementedException();
        }

        public void SetUsedInFileSave()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public IOResult Save(IISave isave)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
