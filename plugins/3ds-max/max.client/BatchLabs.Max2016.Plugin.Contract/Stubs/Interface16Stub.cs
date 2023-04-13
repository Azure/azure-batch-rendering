
using System;
using System.Collections.Generic;
using System.Drawing;

using Autodesk.Max;
using Autodesk.Max.BaseInterface;
using Autodesk.Max.Interface7;
using Autodesk.Max.MaxSDK;
using Autodesk.Max.MaxSDK.AssetManagement;

using PivotMode = Autodesk.Max.Interface7.PivotMode;

namespace BatchLabs.Max2016.Plugin.Contract.Stubs
{
    /// <summary>
    /// Override functionality from the Max SDK for when we are running in local debug mode. 
    /// </summary>
    public class Interface16Stub : IInterface16
    {
        public delegate void MessageHandler(object sender, string message);
        public event MessageHandler PushMessage = delegate { };

        private IInterface_ID _id1;
        private string _internalName;
        private IntPtr _description;
        private IClassDesc _cd;
        private ushort _flags;
        private ITab<IFPFunctionDef> _functions;
        private ITab<IFPPropDef> _props;
        private ITab<IFPEnum> _enumerations;
        private IRollout _rollout;
        private IActionTable _actionTable1;
        private string _renderer;

        public Interface16Stub()
        {
            Id = null;
            NativePointer = IntPtr.Zero;
            HInstance = IntPtr.Zero;
            LifetimeControl = LifetimeType.NoRelease;
            AcquireInterface = null;
            ActionTable = null;
            Desc = null;

            Log = new LogSys();
            _renderer = "Default Scanline Renderer";
        }

        public ILogSys Log { get; }

        public void PushPrompt(string promptString)
        {
            PushMessage(this, promptString);
        }

        public string CurFileName => "Introduction-to-Arnold_robot_final.max";

        public string CurFilePath => @"D:\_azure\rendering-scenes\3dsmax\arnold\Introduction-to-Arnold_robot_final\Introduction-to-Arnold_robot_final.max";

        public int RendWidth
        {
            get { return 1024; }
            set { value = 0;  }
        }

        public int RendHeight
        {
            get { return 768; }
            set { value = 0; }
        }

        public void SetRenderer(string renderer)
        {
            _renderer = renderer;
        }

        public IRenderer GetCurrentRenderer(bool createRendererIfItDoesntExist)
        {
            return new Renderer(_renderer);
        }

        public void EnumAuxFiles(IAssetEnumCallback assetEnum, uint flags)
        {
            if (flags == 262)
            {
                // Missing assets
            }
            else
            {
                // Normal assets
            }
        }

        #region Unused Properties and Overrides

        bool IEquatable<IInterfaceServer>.Equals(IInterfaceServer other)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr NativePointer { get; }

        IBaseInterface IInterfaceServer.GetInterface(IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        bool IBaseInterface.RegisterNotifyCallback(IInterfaceNotifyCallback incb)
        {
            throw new NotImplementedException();
        }

        void IBaseInterface.UnRegisterNotifyCallback(IInterfaceNotifyCallback incb)
        {
            throw new NotImplementedException();
        }

        void IBaseInterface.ReleaseInterface()
        {
            throw new NotImplementedException();
        }

        void IBaseInterface.DeleteInterface()
        {
            throw new NotImplementedException();
        }

        IBaseInterface IBaseInterface.CloneInterface(IntPtr remapDir)
        {
            throw new NotImplementedException();
        }

        public IInterface_ID Id { get; }

        public LifetimeType LifetimeControl { get; }

        public IBaseInterface AcquireInterface { get; }

        int IFPInterface._DispatchFn(short fid, int t, IFPValue result, IFPParams p)
        {
            throw new NotImplementedException();
        }

        int IFPInterface.Invoke(short fid, int t, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        int IFPInterface.Invoke(short fid, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        int IFPInterface.Invoke(short fid, int t, IFPValue result, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        int IFPInterface.Invoke(short fid, IFPValue result, IFPParams params_)
        {
            throw new NotImplementedException();
        }

        short IFPInterface.FindFn(string name)
        {
            throw new NotImplementedException();
        }

        bool IFPInterface.IsEnabled(short actionID)
        {
            throw new NotImplementedException();
        }

        bool IFPInterface.IsChecked(short actionID)
        {
            throw new NotImplementedException();
        }

        bool IFPInterface.IsVisible(short actionID)
        {
            throw new NotImplementedException();
        }

        short IFPInterface.GetIsEnabled(short actionID)
        {
            throw new NotImplementedException();
        }

        short IFPInterface.GetIsChecked(short actionID)
        {
            throw new NotImplementedException();
        }

        short IFPInterface.GetIsVisible(short actionID)
        {
            throw new NotImplementedException();
        }

        void IFPInterface.EnableActions(bool onOff)
        {
            throw new NotImplementedException();
        }

        public IFPInterfaceDesc Desc { get; }

        public IActionTable ActionTable { get; }

        void IFPInterfaceDesc.Init()
        {
            throw new NotImplementedException();
        }

        void IFPInterfaceDesc.LoadDescriptor(IInterface_ID id, string int_name, IntPtr descr, IClassDesc cd, uint flag, params object[] param5)
        {
            throw new NotImplementedException();
        }

        void IFPInterfaceDesc.AppendFunction(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        void IFPInterfaceDesc.AppendProperty(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        void IFPInterfaceDesc.AppendEnum(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        void IFPInterfaceDesc.SetClassDesc(IClassDesc i_cd)
        {
            throw new NotImplementedException();
        }

        IFPFunctionDef IFPInterfaceDesc.GetFnDef(short fid)
        {
            throw new NotImplementedException();
        }

        string IFPInterfaceDesc.GetRsrcString(IntPtr id)
        {
            throw new NotImplementedException();
        }

        IInterface_ID IFPInterfaceDesc.Id_
        {
            get { return _id1; }
            set { _id1 = value; }
        }

        string IFPInterfaceDesc.InternalName
        {
            get { return _internalName; }
            set { _internalName = value; }
        }

        IntPtr IFPInterfaceDesc.Description
        {
            get { return _description; }
            set { _description = value; }
        }

        IClassDesc IFPInterfaceDesc.Cd
        {
            get { return _cd; }
            set { _cd = value; }
        }

        ushort IFPInterfaceDesc.Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        ITab<IFPFunctionDef> IFPInterfaceDesc.Functions
        {
            get { return _functions; }
            set { _functions = value; }
        }

        ITab<IFPPropDef> IFPInterfaceDesc.Props
        {
            get { return _props; }
            set { _props = value; }
        }

        ITab<IFPEnum> IFPInterfaceDesc.Enumerations
        {
            get { return _enumerations; }
            set { _enumerations = value; }
        }

        IRollout IFPInterfaceDesc.Rollout
        {
            get { return _rollout; }
            set { _rollout = value; }
        }

        IActionTable IFPInterfaceDesc.ActionTable_
        {
            get { return _actionTable1; }
            set { _actionTable1 = value; }
        }

        public IntPtr HInstance { get; }

        void IInterface.RedrawViews(int t, RedrawFlags vpFlags, IReferenceTarget change)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetActiveViewport(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.ForceCompleteRedraw(bool doDisabled)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetActiveViewportTransparencyDisplay(int transType)
        {
            throw new NotImplementedException();
        }

        void IInterface.DisableSceneRedraw()
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableSceneRedraw()
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterRedrawViewsCallback(IRedrawViewsCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterRedrawViewsCallback(IRedrawViewsCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterSelectFilterCallback(ISelectFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterSelectFilterCallback(ISelectFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterDisplayFilterCallback(IDisplayFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterDisplayFilterCallback(IDisplayFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetSelectionType(bool autoWinCross, int winCrossOrAutoDir)
        {
            throw new NotImplementedException();
        }

        void IInterface.MakeExtendedViewportActive(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.PutUpViewMenu(IntPtr hWnd, Point pt)
        {
            throw new NotImplementedException();
        }

        bool IInterface.TrackViewPickDlg(IntPtr hParent, ITrackViewPick res, ITrackViewFilter filter, uint flags)
        {
            throw new NotImplementedException();
        }

        bool IInterface.TrackViewPickMultiDlg(IntPtr hParent, IArray<ITrackViewPick> res, ITrackViewFilter filter, uint flags)
        {
            throw new NotImplementedException();
        }

        void IInterface.PushCommandMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        void IInterface.PopCommandMode()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetStdCommandMode(int cid)
        {
            throw new NotImplementedException();
        }

        void IInterface.PushStdCommandMode(int cid)
        {
            throw new NotImplementedException();
        }

        void IInterface.RemoveMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeleteMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetPickMode(IPickModeCallback pc)
        {
            throw new NotImplementedException();
        }

        void IInterface.ClearPickMode()
        {
            throw new NotImplementedException();
        }

        bool IInterface.DoHitByNameDialog(IHitByNameDlgCallback hbncb)
        {
            throw new NotImplementedException();
        }

        void IInterface.PopPrompt()
        {
            throw new NotImplementedException();
        }

        void IInterface.ReplacePrompt(string s)
        {
            throw new NotImplementedException();
        }

        void IInterface.DisplayTempPrompt(string s, int msec)
        {
            throw new NotImplementedException();
        }

        void IInterface.RemoveTempPrompt()
        {
            throw new NotImplementedException();
        }

        void IInterface.ChooseDirectory(IntPtr hWnd, string title, string dir, string desc)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableAutoBackup(bool onOff)
        {
            throw new NotImplementedException();
        }

        bool IInterface.ProgressStart(string title, bool dispBar, IntPtr fn, IntPtr arg)
        {
            throw new NotImplementedException();
        }

        void IInterface.ProgressUpdate(int pct, bool showPct, string title)
        {
            throw new NotImplementedException();
        }

        void IInterface.ProgressEnd()
        {
            throw new NotImplementedException();
        }

        void IInterface.CreatePreview(IPreviewParams pvp)
        {
            throw new NotImplementedException();
        }

        void IInterface.DisableStatusXYZ()
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableStatusXYZ()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetStatusXYZ(IPoint3 xyz, int type)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetStatusXYZ(IAngAxis aa)
        {
            throw new NotImplementedException();
        }

        IntPtr IInterface.GetSysCursor(int id)
        {
            throw new NotImplementedException();
        }

        void IInterface.RealizeParamPanel()
        {
            throw new NotImplementedException();
        }

        float IInterface.SnapAngle(float angleIn, bool fastSnap, bool forceSnap)
        {
            throw new NotImplementedException();
        }

        float IInterface.SnapPercent(float percentIn)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetSnapMode(int mode)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.PickNode(IntPtr hWnd, IIPoint2 pt, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        void IInterface.BoxPickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        void IInterface.CirclePickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        void IInterface.FencePickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterSubObjectTypes(string types, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        void IInterface.AppendSubObjectNamedSelSet(string set)
        {
            throw new NotImplementedException();
        }

        void IInterface.ClearSubObjectNamedSelSets()
        {
            throw new NotImplementedException();
        }

        void IInterface.ClearCurNamedSelSet()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetCurNamedSelSet(string setName)
        {
            throw new NotImplementedException();
        }

        void IInterface.NamedSelSetListChanged()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetSubObjectLevel(int level, bool force)
        {
            throw new NotImplementedException();
        }

        void IInterface.PipeSelLevelChanged()
        {
            throw new NotImplementedException();
        }

        void IInterface.GetPipelineSubObjLevel(IDWORDTab levels)
        {
            throw new NotImplementedException();
        }

        void IInterface.GetModContexts(IModContextList list, IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        int IInterface.SubObHitTest(int t, int type, int crossing, int flags, IIPoint2 p, IViewExp vpt)
        {
            throw new NotImplementedException();
        }

        void IInterface.FreezeSelection()
        {
            throw new NotImplementedException();
        }

        void IInterface.ThawSelection()
        {
            throw new NotImplementedException();
        }

        IINode IInterface.GetSelNode(int i)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableShowEndResult(bool enabled)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetToolButtonState(int button, bool state)
        {
            throw new NotImplementedException();
        }

        bool IInterface.GetToolButtonState(int button)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableToolButton(int button, bool enable)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableUndo(bool enable)
        {
            throw new NotImplementedException();
        }

        IViewExp IInterface.GetViewExp(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableAnimateButton(bool enable)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetAnimateButtonState(bool onOff)
        {
            throw new NotImplementedException();
        }

        void IInterface.BeginProgressiveMode()
        {
            throw new NotImplementedException();
        }

        void IInterface.EndProgressiveMode()
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterAxisChangeCallback(IAxisChangeCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterAxisChangeCallback(IAxisChangeCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableAxisConstraints(int c, bool enabled)
        {
            throw new NotImplementedException();
        }

        void IInterface.PushAxisConstraints(int c)
        {
            throw new NotImplementedException();
        }

        void IInterface.PopAxisConstraints()
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableCoordCenter(bool enabled)
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableRefCoordSys(bool enabled)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetSelectFilterName(int index)
        {
            throw new NotImplementedException();
        }

        bool IInterface.GetDisplayFilter(int index)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetDisplayFilter(int index, bool @on)
        {
            throw new NotImplementedException();
        }

        bool IInterface.DisplayFilterIsNodeVisible(int index, int sid, IClass_ID cid, IINode node)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetDisplayFilterName(int index)
        {
            throw new NotImplementedException();
        }

        IMatrix3 IInterface.GetTransformAxis(IINode node, int subIndex, IntPtr local)
        {
            throw new NotImplementedException();
        }

        void IInterface.LockAxisTripods(bool onOff)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterDlgWnd(IntPtr hDlg)
        {
            throw new NotImplementedException();
        }

        int IInterface.UnRegisterDlgWnd(IntPtr hDlg)
        {
            throw new NotImplementedException();
        }

        IntPtr IInterface.AddRollupPage(IntPtr hInst, string dlgTemplate, IntPtr dlgProc, string title, IntPtr param, uint flags,
            int category)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeleteRollupPage(IntPtr hRollup)
        {
            throw new NotImplementedException();
        }

        IntPtr IInterface.ReplaceRollupPage(IntPtr hOldRollup, IntPtr hInst, string dlgTemplate, IntPtr dlgProc, string title,
            IntPtr param, uint flags, int category)
        {
            throw new NotImplementedException();
        }

        void IInterface.RollupMouseMessage(IntPtr hDlg, uint message, UIntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetTime(int t, bool redraw)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterTimeChangeCallback(ITimeChangeCallback tc)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterTimeChangeCallback(ITimeChangeCallback tc)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterCommandModeChangedCallback(ICommandModeChangedCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterCommandModeChangedCallback(ICommandModeChangedCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterViewportDisplayCallback(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterViewportDisplayCallback(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.NotifyViewportDisplayCallbackChanged(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterExitMAXCallback(IExitMAXCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterExitMAXCallback(IExitMAXCallback cb)
        {
            throw new NotImplementedException();
        }

        void IInterface.RegisterDeleteUser(IEventUser user)
        {
            throw new NotImplementedException();
        }

        void IInterface.UnRegisterDeleteUser(IEventUser user)
        {
            throw new NotImplementedException();
        }

        void IInterface.MakeNameUnique(ref string name)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.CreateObjectNode(IObject obj)
        {
            throw new NotImplementedException();
        }

        IGenCamera IInterface.CreateCameraObject(int type)
        {
            throw new NotImplementedException();
        }

        IObject IInterface.CreateTargetObject()
        {
            throw new NotImplementedException();
        }

        IGenLight IInterface.CreateLightObject(int type)
        {
            throw new NotImplementedException();
        }

        object IInterface.CreateInstance(SClass_ID superID, IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        int IInterface.BindToTarget(IINode laNode, IINode targNode)
        {
            throw new NotImplementedException();
        }

        uint IInterface.DeleteNode(IINode node, bool redraw, bool overrideSlaves)
        {
            throw new NotImplementedException();
        }

        void IInterface.SelectNode(IINode node, bool clearSel)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeSelectNode(IINode node)
        {
            throw new NotImplementedException();
        }

        void IInterface.SelectNodeTab(IINodeTab nodes, bool sel, bool redraw)
        {
            throw new NotImplementedException();
        }

        void IInterface.ClearNodeSelection(bool redraw)
        {
            throw new NotImplementedException();
        }

        void IInterface.AddLightToScene(IINode node)
        {
            throw new NotImplementedException();
        }

        void IInterface.AddGridToScene(IINode node)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetNodeTMRelConstPlane(IINode node, IMatrix3 mat)
        {
            throw new NotImplementedException();
        }

        void IInterface.StopCreating()
        {
            throw new NotImplementedException();
        }

        IObject IInterface.NonMouseCreate(IMatrix3 tm)
        {
            throw new NotImplementedException();
        }

        void IInterface.NonMouseCreateFinish(IMatrix3 tm)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetDir(int which)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetPlugInDesc(int i)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetPlugInDir(int i)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        bool IInterface.AddAssetDir(string dir, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        bool IInterface.AddSessionAssetDir(string dir, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetSessionAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetSessionAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        bool IInterface.DeleteSessionAssetDir(int i, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetCurAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        string IInterface.GetCurAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        int IInterface.DoExclusionListDialog(IExclList nl, bool doShadows)
        {
            throw new NotImplementedException();
        }

        void IInterface.ConvertNameTabToExclList(INameTab nt, IExclList excList)
        {
            throw new NotImplementedException();
        }

        IMtlBase IInterface.DoMaterialBrowseDlg(IntPtr hParent, MaterialBrowseFlags flags, ref int newMat, ref int cancel)
        {
            throw new NotImplementedException();
        }

        void IInterface.PutMtlToMtlEditor(IMtlBase mb, int slot)
        {
            throw new NotImplementedException();
        }

        IMtlBase IInterface.GetMtlSlot(int slot)
        {
            throw new NotImplementedException();
        }

        bool IInterface.OkMtlForScene(IMtlBase m)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileOpen()
        {
            throw new NotImplementedException();
        }

        void IInterface.FileSaveSelected()
        {
            throw new NotImplementedException();
        }

        void IInterface.FileReset(bool noPrompt)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileMerge()
        {
            throw new NotImplementedException();
        }

        void IInterface.FileHold()
        {
            throw new NotImplementedException();
        }

        void IInterface.FileFetch()
        {
            throw new NotImplementedException();
        }

        void IInterface.FileOpenMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileSaveMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileSaveAsMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        void IInterface.LoadDefaultMatLib()
        {
            throw new NotImplementedException();
        }

        int IInterface.LoadFromFile(string name, bool refresh)
        {
            throw new NotImplementedException();
        }

        int IInterface.SaveToFile(string fname, bool clearNeedSaveFlag, bool useNewFile)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileSaveSelected(string fname)
        {
            throw new NotImplementedException();
        }

        void IInterface.FileSaveNodes(IINodeTab nodes, string fname)
        {
            throw new NotImplementedException();
        }

        int IInterface.LoadMaterialLib(string name, IMtlBaseLib lib)
        {
            throw new NotImplementedException();
        }

        int IInterface.SaveMaterialLib(string name, IMtlBaseLib lib)
        {
            throw new NotImplementedException();
        }

        int IInterface.MergeFromFile(string name, bool mergeAll, bool selMerged, bool refresh, int dupAction, INameTab mrgList,
            int dupMtlAction, int reparentAction)
        {
            throw new NotImplementedException();
        }

        bool IInterface.ImportFromFile(string name, bool suppressPrompts, IClass_ID importerID)
        {
            throw new NotImplementedException();
        }

        bool IInterface.ExportToFile(string name, bool suppressPrompts, uint options, IClass_ID exporterID)
        {
            throw new NotImplementedException();
        }

        bool IInterface.NodeColorPicker(IntPtr hWnd, ref Color col)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.GroupNodes(IINodeTab nodes, IntPtr name, bool selGroup)
        {
            throw new NotImplementedException();
        }

        void IInterface.UngroupNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        void IInterface.ExplodeNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        void IInterface.OpenGroup(IINodeTab nodes, bool clearSel)
        {
            throw new NotImplementedException();
        }

        void IInterface.CloseGroup(IINodeTab nodes, bool selGroup)
        {
            throw new NotImplementedException();
        }

        bool IInterface.AttachNodesToGroup(IINodeTab nodes, IINode pTargetNode)
        {
            throw new NotImplementedException();
        }

        bool IInterface.DetachNodesFromGroup(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        void IInterface.FlashNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetBkgImageAsset(IAssetUser asset)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetBkgFrameRange(int start, int end, int step)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetBkgFrameRangeVal(int which)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetBkgORType(int which, int type)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetBkgORType(int which)
        {
            throw new NotImplementedException();
        }

        int IInterface.GetBkgFrameNum(int t)
        {
            throw new NotImplementedException();
        }

        void IInterface.StartAnimPlayback(int selOnly)
        {
            throw new NotImplementedException();
        }

        void IInterface.EndAnimPlayback()
        {
            throw new NotImplementedException();
        }

        void IInterface.IncrementValidityToken()
        {
            throw new NotImplementedException();
        }

        int IInterface.OpenCurRenderer(IINode camNode, IViewExp view, RendType t, int w, int h)
        {
            throw new NotImplementedException();
        }

        int IInterface.OpenCurRenderer(IViewParams vpar, RendType t, int w, int h)
        {
            throw new NotImplementedException();
        }

        void IInterface.CloseCurRenderer()
        {
            throw new NotImplementedException();
        }

        int IInterface.CurRendererRenderFrame(int t, IBitmap bm, IRendProgressCallback prog, float frameDur, IViewParams vp,
            Rectangle regionRect)
        {
            throw new NotImplementedException();
        }

        IIScanRenderer IInterface.CreateDefaultScanlineRenderer()
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.CreateDefaultRenderer(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        IClass_ID IInterface.GetDefaultRendererClassID(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetDefaultRendererClassID(RenderSettingID renderSettingID, IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        int IInterface.OpenRenderer(IRenderer pRenderer, IINode camNode, IViewExp view, RendType type, int w, int h)
        {
            throw new NotImplementedException();
        }

        int IInterface.OpenRenderer(IRenderer pRenderer, IViewParams vpar, RendType type, int w, int h)
        {
            throw new NotImplementedException();
        }

        int IInterface.RendererRenderFrame(IRenderer pRenderer, int t, IBitmap bm, IRendProgressCallback prog, float frameDur,
            IViewParams vp, Rectangle regionRect)
        {
            throw new NotImplementedException();
        }

        void IInterface.CloseRenderer(IRenderer pRenderer)
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.GetProductionRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.GetDraftRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.GetRenderer(RenderSettingID renderSettingID, bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignCurRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignProductionRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignDraftRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignRenderer(RenderSettingID renderSettingID, IRenderer rend)
        {
            throw new NotImplementedException();
        }

        void IInterface.ChangeRenderSetting(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.GetMEditRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignMEditRenderer(IRenderer renderer)
        {
            throw new NotImplementedException();
        }

        IRenderer IInterface.GetActualMEditRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        IIRenderElementMgr IInterface.GetRenderElementMgr(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetupRendParams(IRendParams rp, IViewExp vpt, RendType t)
        {
            throw new NotImplementedException();
        }

        void IInterface.GetViewParamsFromNode(IINode vnode, IViewParams vp, int t)
        {
            throw new NotImplementedException();
        }

        void IInterface.AbortRender()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetRendAspect(float a)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetRendForce2Side(bool onOff)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetRendDither256(bool onOff)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetHideByCategoryFlags(uint f)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetViewportMax(bool max)
        {
            throw new NotImplementedException();
        }

        void IInterface.ViewportZoomExtents(bool doAll, bool skipPersp)
        {
            throw new NotImplementedException();
        }

        void IInterface.ZoomToBounds(bool doAll, IBox3 box)
        {
            throw new NotImplementedException();
        }

        void IInterface.GetSelectionWorldBox(int t, IBox3 box)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.GetINodeByName(string name)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.GetINodeByHandle(uint handle)
        {
            throw new NotImplementedException();
        }

        IINode IInterface.GetINodeFromRenderID(ushort id)
        {
            throw new NotImplementedException();
        }

        void IInterface.ExecuteMAXCommand(int id)
        {
            throw new NotImplementedException();
        }

        INameMaker IInterface.NewNameMaker(bool initFromScene)
        {
            throw new NotImplementedException();
        }

        IPoint3 IInterface.GetAmbient(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetAmbient(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        IPoint3 IInterface.GetLightTint(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetLightTint(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        float IInterface.GetLightLevel(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetLightLevel(int t, float lev)
        {
            throw new NotImplementedException();
        }

        IAtmospheric IInterface.GetAtmospheric(int i)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetAtmospheric(int i, IAtmospheric a)
        {
            throw new NotImplementedException();
        }

        void IInterface.AddAtmosphere(IAtmospheric atmos)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeleteAtmosphere(int i)
        {
            throw new NotImplementedException();
        }

        void IInterface.EditAtmosphere(IAtmospheric a, IINode gizmo)
        {
            throw new NotImplementedException();
        }

        IEffect IInterface.GetEffect(int i)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetEffect(int i, IEffect e)
        {
            throw new NotImplementedException();
        }

        void IInterface.AddEffect(IEffect eff)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeleteEffect(int i)
        {
            throw new NotImplementedException();
        }

        void IInterface.EditEffect(IEffect e, IINode gizmo)
        {
            throw new NotImplementedException();
        }

        IPoint3 IInterface.GetBackGround(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetBackGround(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        void IInterface.InvalidateOsnapdraw()
        {
            throw new NotImplementedException();
        }

        IntPtr IInterface.Execute(int cmd, UIntPtr arg1, UIntPtr arg2, UIntPtr arg3, UIntPtr arg4, UIntPtr arg5, UIntPtr arg6)
        {
            throw new NotImplementedException();
        }

        IntPtr IInterface.GetInterface(uint id)
        {
            throw new NotImplementedException();
        }

        void IInterface.FreeSceneBitmaps()
        {
            throw new NotImplementedException();
        }

        void IInterface.RenderTexmap(ITexmap tex, IBitmap bm, float scale3d, bool filter, bool display, float z, int t)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeActivateTexture(IMtlBase tx, IMtl mtl, int subNum)
        {
            throw new NotImplementedException();
        }

        void IInterface.ActivateTexture(IMtlBase tx, IMtl mtl, int subNum)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignNewName(IMtl m)
        {
            throw new NotImplementedException();
        }

        void IInterface.AssignNewName(ITexmap m)
        {
            throw new NotImplementedException();
        }

        void IInterface.RescaleWorldUnits(float f, bool selected)
        {
            throw new NotImplementedException();
        }

        int IInterface.InitSnapInfo(ISnapInfo info)
        {
            throw new NotImplementedException();
        }

        int IInterface.HitTestTransformGizmo(IIPoint2 p, IViewExp vpt, int axisFlags)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeactivateTransformGizmo()
        {
            throw new NotImplementedException();
        }

        bool IInterface.DoSpaceArrayDialog(ISpaceArrayCallback sacb)
        {
            throw new NotImplementedException();
        }

        int IInterface.AddClass(IClassDesc cd)
        {
            throw new NotImplementedException();
        }

        int IInterface.DeleteClass(IClassDesc cd)
        {
            throw new NotImplementedException();
        }

        ICommandMode IInterface.GetCommandStackEntry(int entry)
        {
            throw new NotImplementedException();
        }

        void IInterface.AddSFXRollupPage(uint flags)
        {
            throw new NotImplementedException();
        }

        void IInterface.DeleteSFXRollupPage()
        {
            throw new NotImplementedException();
        }

        void IInterface.RefreshSFXRollupPage()
        {
            throw new NotImplementedException();
        }

        int IInterface.GetNumProperties(int PropertySet)
        {
            throw new NotImplementedException();
        }

        bool IInterface.RegisterViewWindow(IViewWindow vw)
        {
            throw new NotImplementedException();
        }

        bool IInterface.UnRegisterViewWindow(IViewWindow vw)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetXRefAutoUpdateSuspended(bool onOff)
        {
            throw new NotImplementedException();
        }

        void IInterface.UpdateMtlEditorBrackets()
        {
            throw new NotImplementedException();
        }

        void IInterface.SetMAXFileOpenDlg(IMAXFileOpenDialog dlg)
        {
            throw new NotImplementedException();
        }

        void IInterface.SetMAXFileSaveDlg(IMAXFileSaveDialog dlg)
        {
            throw new NotImplementedException();
        }

        void IInterface.RAMPlayer(IntPtr hWndParent, string szChanA, string szChanB)
        {
            throw new NotImplementedException();
        }

        void IInterface.FlushUndoBuffer()
        {
            throw new NotImplementedException();
        }

        void IInterface.EnableDeferredPluginLoading(bool onOff)
        {
            throw new NotImplementedException();
        }

        bool IInterface.IsSceneXRefNode(IINode node)
        {
            throw new NotImplementedException();
        }

        bool IInterface.CanImportFile(string filename)
        {
            throw new NotImplementedException();
        }

        bool IInterface.IsMaxFile(string filename)
        {
            throw new NotImplementedException();
        }

        bool IInterface.IsInternetCachedFile(string filename)
        {
            throw new NotImplementedException();
        }

        bool IInterface.CanImportBitmap(string filename)
        {
            throw new NotImplementedException();
        }

        bool IInterface.CaptureSubObjectRegistration(bool OnOff, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        bool IInterface.DownloadUrl(IntPtr hwnd, string url, string filename, uint flags)
        {
            throw new NotImplementedException();
        }

        IITreeView IInterface.CreateTreeViewChild(IReferenceTarget root, IntPtr hParent, uint style, uint id, int open)
        {
            throw new NotImplementedException();
        }

        void IInterface.ConvertMtl(int t, IMaterial gm, IMtl mtl, bool doTex, int subNum, float vis, ref int needDecal, IINode node,
            IBitArray needTex, IGraphicsWindow gw)
        {
            throw new NotImplementedException();
        }

        bool IInterface.IsFeatureLicensed(int subNum)
        {
            throw new NotImplementedException();
        }

        bool IInterface.CloneNodes(IINodeTab nodes, IPoint3 offset, bool expandHierarchies, CloneType cloneType, IINodeTab resultSource,
            IINodeTab resultTarget)
        {
            throw new NotImplementedException();
        }

        void IInterface.CollapseNode(IINode node, bool noWarning)
        {
            throw new NotImplementedException();
        }

        bool IInterface.CollapseNodeTo(IINode node, int modIndex, bool noWarning)
        {
            throw new NotImplementedException();
        }

        bool IInterface.ConvertNode(IINode node, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        bool IInterface.SetQuietMode(bool onOff)
        {
            throw new NotImplementedException();
        }

        bool IInterface.GetQuietMode(bool checkServerMode)
        {
            throw new NotImplementedException();
        }

        public IList<IAtmospheric> Atmospherics { get; }
        public IList<IEffect> Effects { get; }
        public IntPtr AppHFont { get; }
        public IViewExp ActiveViewExp { get; }
        public IIObjCreate IObjCreate { get; }
        public IIObjParam IObjParam { get; }
        public IntPtr MAXHWnd { get; }
        public bool DisplayActiveCameraViewWithMultiPassEffect { get; }
        public bool IsSceneRedrawDisabled { get; }
        public ICommandMode CommandMode { get; set; }
        public IPickModeCallback CurPickMode { get; }
        public float AutoBackupTime { get; set; }
        public bool AutoBackupEnabled { get; }
        public bool Cancel { get; set; }
        public float GridSpacing { get; }
        public int GridMajorLines { get; }
        public int ExtendedDisplayMode { get; set; }
        public int FlyOffTime { get; set; }
        public bool CrossHairCur { get; set; }
        public bool SnapState { get; }
        public int SnapMode { get; }
        public int SubObjectLevel { get; }
        public int NumSubObjectLevels { get; }
        public IBaseObject CurEditObject { get; }
        public bool SelectionFrozen { get; }
        public int SelNodeCount { get; }
        public bool ShowEndResult { get; set; }
        public bool Crossing { get; }
        public int CommandPanelTaskMode { get; set; }
        public bool IsAnimateEnabled { get; }
        public bool InProgressiveMode { get; }
        public int AxisConstraints { get; set; }
        public int CoordCenter { get; set; }
        public int RefCoordSys { get; set; }
        public int SelectFilter { get; set; }
        public int NumberSelectFilters { get; }
        public int NumberDisplayFilters { get; }
        public int NumAxis { get; }
        public bool AxisTripodLocked { get; }
        public IIActionManager ActionManager { get; }
        public IIMenuManager MenuManager { get; }
        public IIRollupWindow CommandPanelRollup { get; }
        public int Time { get; }
        public IInterval AnimRange { get; set; }
        public IRightClickMenuManager RightClickMenuManager { get; }
        public bool IsCPEdgeOnInView { get; }
        public IINode RootNode { get; }
        public IINode ActiveGrid { get; set; }
        public int PlugInEntryCount { get; }
        public float LightConeConstraint { get; }
        public IMtlBaseLib SceneMtls { get; }
        public string MatLibFileName { get; }
        public bool FileSave { get; }
        public bool FileSaveAs { get; }
        public bool FileImport { get; }
        public bool FileExport { get; }
        public bool CheckMAXMessages { get; }
        public IAssetUser BkgImageAsset { get; }
        public int BkgImageAspect { get; set; }
        public bool BkgImageAnimate { get; set; }
        public int BkgStartTime { get; set; }
        public int BkgSyncFrame { get; set; }
        public bool RealTimePlayback { get; set; }
        public bool PlayActiveOnly { get; set; }
        public bool IsAnimPlaying { get; }
        public int PlaybackSpeed { get; set; }
        public bool PlaybackLoop { get; set; }
        public uint CurrentValidityToken { get; }
        public bool UseDraftRenderer { get; set; }
        public RenderSettingID CurrentRenderSetting { get; }
        public bool MEditRendererLocked { get; set; }
        public bool MEditRendererLockedDefaultValue { get; set; }
        public IIRenderElementMgr CurRenderElementMgr { get; }
        public bool CheckForRenderAbort { get; }
        public int RendTimeType { get; set; }
        public int RendStart { get; set; }
        public int RendEnd { get; set; }
        public int RendNThFrame { get; set; }
        public bool RendShowVFB { get; set; }
        public bool RendSaveFile { get; set; }
        public bool RendUseDevice { get; set; }
        public bool RendUseNet { get; set; }
        public IBitmapInfo RendFileBI { get; }
        public IBitmapInfo RendDeviceBI { get; }
        public float RendApect { get; }
        public float RendImageAspect { get; }
        public float RendApertureWidth { get; set; }
        public bool RendFieldRender { get; set; }
        public bool RendColorCheck { get; set; }
        public bool RendSuperBlack { get; set; }
        public bool RendHidden { get; set; }
        public bool RendForce2Side { get; }
        public bool RendAtmosphere { get; set; }
        public bool RendEffects { get; set; }
        public bool RendDisplacement { get; set; }
        public string RendPickFramesString { get; }
        public bool RendDitherTrue { get; set; }
        public bool RendDither256 { get; }
        public bool RendMultiThread { get; set; }
        public bool RendNThSerial { get; set; }
        public int RendVidCorrectMethod { get; set; }
        public int RendFieldOrder { get; set; }
        public int RendNTSCPal { get; set; }
        public int RendSuperBlackThresh { get; set; }
        public int RendFileNumberBase { get; set; }
        public bool SkipRenderedFrames { get; set; }
        public bool RendSimplifyAreaLights { get; set; }
        public NodeHideFlags HideByCategoryFlags { get; }
        public int ViewportLayout { get; set; }
        public bool IsViewportMaxed { get; }
        public IPoint3 ViewportBGColor { get; set; }
        public ITexmap EnvironmentMap { get; set; }
        public bool UseEnvironmentMap { get; set; }
        public IControl AmbientController { get; set; }
        public IControl LightTintController { get; set; }
        public IControl LightLevelController { get; set; }
        public int NumAtmospheric { get; }
        public int NumEffects { get; }
        public IControl BackGroundController { get; set; }
        public ISoundObj SoundObject { get; set; }
        public IIOsnapManager OsnapManager { get; }
        public IMouseManager MouseManager { get; }
        public IMtlBaseLib MaterialLibrary { get; }
        public bool IsNetworkRenderServer { get; }
        public IDllDir DllDir { get; }
        public IReferenceTarget ScenePointer { get; }
        public IITrackViewNode TrackViewRootNode { get; }
        public IDllDir DllDirectory { get; }
        public bool KeyStepsSelOnly { get; set; }
        public bool KeyStepsUseTrans { get; set; }
        public bool KeyStepsPos { get; set; }
        public bool KeyStepsRot { get; set; }
        public bool KeyStepsScale { get; set; }
        public bool KeyStepsUseTrackBar { get; set; }
        public bool UseTransformGizmo { get; set; }
        public bool TransformGizmoRestoreAxis { get; set; }
        public bool ConstantAxisRestriction { get; set; }
        public int ConfigureBitmapPaths { get; }
        public int CommandStackSize { get; }
        public IShadowType GlobalShadowGenerator { get; set; }
        public bool ImportZoomExtents { get; set; }
        public bool CheckForSave { get; }
        public IITrackBar TrackBar { get; }
        public bool IncludeXRefsInHierarchy { get; set; }
        public bool IsXRefAutoUpdateSuspended { get; }
        public IMacroRecorder MacroRecorder { get; }
        public bool IsTrialLicense { get; }
        public bool IsNetworkLicense { get; }
        public bool DeferredPluginLoadingEnabled { get; }
        public IINode ImportCtxNode { get; }
        public int ProductVersion { get; }
        public int LicenseBehavior { get; }
        public int LicenseDaysLeft { get; }
        public IIRenderPresetsManager RenderPresetsManager { get; }
        public IDefaultActionSys DefaultActions { get; }
        public void GetSelNodeTab(IINodeTab selectedNodes)
        {
            throw new NotImplementedException();
        }

        public void GetCurRefCoordSysName(ref string name)
        {
            throw new NotImplementedException();
        }

        public void AddRefCoordNode(IINode node)
        {
            throw new NotImplementedException();
        }

        public void SetupFrameRendParams(IFrameRendParams frp, IRendParams rp, IViewExp vx, Rectangle r)
        {
            throw new NotImplementedException();
        }

        public void SetupFrameRendParamsMxs(IFrameRendParams frp, IRendParams rp, IViewExp vx, Rectangle r, bool useSelBox)
        {
            throw new NotImplementedException();
        }

        public int InitDefaultLights(IDefaultLight dl, int maxn, bool applyGlobalLevel, IViewExp vx, bool forRenderer)
        {
            throw new NotImplementedException();
        }

        public void IncrRenderActive()
        {
            throw new NotImplementedException();
        }

        public void DecrRenderActive()
        {
            throw new NotImplementedException();
        }

        public void XRefRenderEnd()
        {
            throw new NotImplementedException();
        }

        public void OpenRenderDialog()
        {
            throw new NotImplementedException();
        }

        public void CancelRenderDialog()
        {
            throw new NotImplementedException();
        }

        public void CloseRenderDialog()
        {
            throw new NotImplementedException();
        }

        public void CommitRenderDialogParameters()
        {
            throw new NotImplementedException();
        }

        public void UpdateRenderDialogParameters()
        {
            throw new NotImplementedException();
        }

        public int MAXScriptHelp(string keyword)
        {
            throw new NotImplementedException();
        }

        public bool OpenTrackViewWindow(string tv_name, string layoutName, IPoint2 pos, int width, int height, int dock)
        {
            throw new NotImplementedException();
        }

        public bool BringTrackViewWindowToTop(string tv_name)
        {
            throw new NotImplementedException();
        }

        public bool TrackViewZoomSelected(string tv_name)
        {
            throw new NotImplementedException();
        }

        public bool TrackViewZoomOn(string tv_name, IAnimatable parent, int subNum)
        {
            throw new NotImplementedException();
        }

        public bool CloseTrackView(string tv_name)
        {
            throw new NotImplementedException();
        }

        public string GetTrackViewName(int i)
        {
            throw new NotImplementedException();
        }

        public bool SetTrackViewFilter(string tv_name, uint mask, int which, bool redraw)
        {
            throw new NotImplementedException();
        }

        public bool ClearTrackViewFilter(string tv_name, uint mask, int which, bool redraw)
        {
            throw new NotImplementedException();
        }

        public uint TestTrackViewFilter(string tv_name, uint mask, int which)
        {
            throw new NotImplementedException();
        }

        public void FlushAllTrackViewWindows()
        {
            throw new NotImplementedException();
        }

        public void UnFlushAllTrackViewWindows()
        {
            throw new NotImplementedException();
        }

        public void CloseAllTrackViewWindows()
        {
            throw new NotImplementedException();
        }

        public void SetCurEditObject(IBaseObject obj, IBaseNode hintNode)
        {
            throw new NotImplementedException();
        }

        public void AddModToSelection(IModifier mod)
        {
            throw new NotImplementedException();
        }

        public void InvalidateObCache(IINode node)
        {
            throw new NotImplementedException();
        }

        public IINode FindNodeFromBaseObject(IReferenceTarget obj)
        {
            throw new NotImplementedException();
        }

        public void SelectedHistoryChanged()
        {
            throw new NotImplementedException();
        }

        public void SuspendEditing(uint whichPanels, bool alwaysSuspend)
        {
            throw new NotImplementedException();
        }

        public void ResumeEditing(uint whichPanels, bool alwaysSuspend)
        {
            throw new NotImplementedException();
        }

        public void SuspendMotionEditing()
        {
            throw new NotImplementedException();
        }

        public void ResumeMotionEditing()
        {
            throw new NotImplementedException();
        }

        public int AddClass(IClassDesc cdesc, int dllNum, int index, bool load)
        {
            throw new NotImplementedException();
        }

        public void ReBuildSuperList()
        {
            throw new NotImplementedException();
        }

        public void ChangeHistory(int upDown)
        {
            throw new NotImplementedException();
        }

        public void StartCreatingObject(IClassDesc cd)
        {
            throw new NotImplementedException();
        }

        public bool IsCreatingObject(IClass_ID id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLockCheckObjectCounts()
        {
            throw new NotImplementedException();
        }

        public IINode CreateObjectNode(IObject obj, string name)
        {
            throw new NotImplementedException();
        }

        public bool SetDir(int which, string dir)
        {
            throw new NotImplementedException();
        }

        public bool AddAssetDir(string dir, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAssetDir(int i, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        public void UpdateAssetSection(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public bool AppendToCurFilePath(string toAppend)
        {
            throw new NotImplementedException();
        }

        public bool OpenSchematicViewWindow(string sv_name)
        {
            throw new NotImplementedException();
        }

        public bool SchematicViewZoomSelected(string sv_name)
        {
            throw new NotImplementedException();
        }

        public bool CloseSchematicView(string sv_name)
        {
            throw new NotImplementedException();
        }

        public string GetSchematicViewName(int i)
        {
            throw new NotImplementedException();
        }

        public void CloseAllSchematicViewWindows()
        {
            throw new NotImplementedException();
        }

        public void FlushAllSchematicViewWindows()
        {
            throw new NotImplementedException();
        }

        public void UnFlushAllSchematicViewWindows()
        {
            throw new NotImplementedException();
        }

        public void EnableDrawing(bool onOff)
        {
            throw new NotImplementedException();
        }

        public void SetSceneDisplayFlag(uint flag, bool onOff, bool updateUI)
        {
            throw new NotImplementedException();
        }

        public bool GetSceneDisplayFlag(uint flag)
        {
            throw new NotImplementedException();
        }

        public void SetMtlSlot(int i, IMtlBase m)
        {
            throw new NotImplementedException();
        }

        public void FlushMtlDlg()
        {
            throw new NotImplementedException();
        }

        public void UnFlushMtlDlg()
        {
            throw new NotImplementedException();
        }

        public bool IsMtlInstanced(IMtlBase m)
        {
            throw new NotImplementedException();
        }

        public IMtl FindMtlNameInScene(ref string name)
        {
            throw new NotImplementedException();
        }

        public void PutMaterial(IMtlBase mtl, IMtlBase oldMtl, bool delOld, IReferenceMaker skipThis)
        {
            throw new NotImplementedException();
        }

        public void OpenMtlDlg()
        {
            throw new NotImplementedException();
        }

        public void CloseMtlDlg()
        {
            throw new NotImplementedException();
        }

        public bool SetActiveViewport(int index)
        {
            throw new NotImplementedException();
        }

        public IViewExp GetViewExp(int i)
        {
            throw new NotImplementedException();
        }

        public void ResetAllViews()
        {
            throw new NotImplementedException();
        }

        public string GetViewportLabel(int index)
        {
            throw new NotImplementedException();
        }

        public void SetRegionRect(int index, IBox2 r)
        {
            throw new NotImplementedException();
        }

        public IBox2 GetRegionRect(int index)
        {
            throw new NotImplementedException();
        }

        public void SetBlowupRect(int index, IBox2 r)
        {
            throw new NotImplementedException();
        }

        public IBox2 GetBlowupRect(int index)
        {
            throw new NotImplementedException();
        }

        public void SetRegionRect2(int index, IBox2 r)
        {
            throw new NotImplementedException();
        }

        public IBox2 GetRegionRect2(int index)
        {
            throw new NotImplementedException();
        }

        public void SetBlowupRect2(int index, IBox2 r)
        {
            throw new NotImplementedException();
        }

        public IBox2 GetBlowupRect2(int index)
        {
            throw new NotImplementedException();
        }

        public void SetViewportGridVisible(int index, bool state)
        {
            throw new NotImplementedException();
        }

        public bool GetViewportGridVisible(int index)
        {
            throw new NotImplementedException();
        }

        public void ViewportInvalidate(int index)
        {
            throw new NotImplementedException();
        }

        public void ViewportInvalidateBkgImage(int index)
        {
            throw new NotImplementedException();
        }

        public void InvalidateAllViewportRects()
        {
            throw new NotImplementedException();
        }

        public void RedrawViewportsNow(int t, uint vpFlags)
        {
            throw new NotImplementedException();
        }

        public void RedrawViewportsLater(int t, uint vpFlags)
        {
            throw new NotImplementedException();
        }

        public void SetTestOnlyFrozen(int onOff)
        {
            throw new NotImplementedException();
        }

        public void SetScaleMode(int mode)
        {
            throw new NotImplementedException();
        }

        public void SetCenterMode(int mode)
        {
            throw new NotImplementedException();
        }

        public void StartManipulateMode()
        {
            throw new NotImplementedException();
        }

        public void EndManipulateMode()
        {
            throw new NotImplementedException();
        }

        public bool IsViewportCommandMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        public void ConvertFlagedNodesToXRefs(IAssetUser fname, IINode rootNode, ITab<IINode> nodes, int xFlags)
        {
            throw new NotImplementedException();
        }

        public void XRefSceneSetIgnoreFlag(int index, uint f, bool onOff)
        {
            throw new NotImplementedException();
        }

        public void UpdateSceneXRefState()
        {
            throw new NotImplementedException();
        }

        public void ToggleASnap()
        {
            throw new NotImplementedException();
        }

        public void TogglePSnap()
        {
            throw new NotImplementedException();
        }

        public void SetGridSpacing(float newVal)
        {
            throw new NotImplementedException();
        }

        public void SetGridMajorLines(float newVal)
        {
            throw new NotImplementedException();
        }

        public bool GetPrimaryVisibility(IINode node)
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryVisibility(IINode node, bool onOff)
        {
            throw new NotImplementedException();
        }

        public bool GetSecondaryVisibility(IINode node)
        {
            throw new NotImplementedException();
        }

        public void SetSecondaryVisibility(IINode node, bool onOff)
        {
            throw new NotImplementedException();
        }

        public void SetNodeAttribute(IINodeTab nodes, int whatAttrib, int onOff)
        {
            throw new NotImplementedException();
        }

        public void SetNodeAttribute(IINode node, int whatAttrib, int onOff)
        {
            throw new NotImplementedException();
        }

        public void LoadCUIConfig(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteCUIConfig()
        {
            throw new NotImplementedException();
        }

        public void SaveCUIAs()
        {
            throw new NotImplementedException();
        }

        public void LoadCUI()
        {
            throw new NotImplementedException();
        }

        public void RevertToBackupCUI()
        {
            throw new NotImplementedException();
        }

        public void ResetToFactoryDefaultCUI()
        {
            throw new NotImplementedException();
        }

        public void DoUICustomization(int startPage)
        {
            throw new NotImplementedException();
        }

        public int GetDefaultImageListBaseIndex(SClass_ID sid, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        public IntPtr GetDefaultImageListFilePrefix(SClass_ID sid, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        public void UpdateColors(bool useGridColor, int gridIntensity, bool whiteOrigin)
        {
            throw new NotImplementedException();
        }

        public void RepaintTimeSlider()
        {
            throw new NotImplementedException();
        }

        public string GetTabPageTitle(IITabPage page)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxFileSaveAsDlg(ref string fileName, bool setAsCurrent)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxFileOpenDlg(ref string fileName, IntPtr defDir, IntPtr defFile)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxFileMergeDlg(ref string fileName, IntPtr defDir, IntPtr defFile)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxFileXRefDlg(ref string fileName, IntPtr defDir, IntPtr defFile)
        {
            throw new NotImplementedException();
        }

        public void StartAnimPlayback2(int selOnly)
        {
            throw new NotImplementedException();
        }

        public bool IsValidModForSelection(IClassEntry ce)
        {
            throw new NotImplementedException();
        }

        public bool IsValidModifier(IINode node, IModifier mod)
        {
            throw new NotImplementedException();
        }

        public ResCode AddModifier(IINode node, IModifier mod, int beforeIdx)
        {
            throw new NotImplementedException();
        }

        public ResCode DeleteModifier(IINode node, IModifier mod)
        {
            throw new NotImplementedException();
        }

        public ResCode DeleteModifier(IINode node, int modIdx)
        {
            throw new NotImplementedException();
        }

        public IIDerivedObject FindModifier(IINode node, IModifier mod, ref int modStackIdx, ref int derivedObjIdx)
        {
            throw new NotImplementedException();
        }

        public IIDerivedObject FindModifier(IINode node, int modIdx, ref int idx, ref IModifier mod)
        {
            throw new NotImplementedException();
        }

        public IIDerivedObject FindModifier(IINode node, IModifier mod, IModContext mc, ref int modStackIdx, ref int dobjidx)
        {
            throw new NotImplementedException();
        }

        public ResCode DoDeleteModifier(IINode node, IIDerivedObject dobj, int idx)
        {
            throw new NotImplementedException();
        }

        public IObject GetReplaceableObjRef(IINode node)
        {
            throw new NotImplementedException();
        }

        public void OpenEnvEffectsDialog()
        {
            throw new NotImplementedException();
        }

        public void CloseEnvEffectsDialog()
        {
            throw new NotImplementedException();
        }

        public PivotMode PivotMode { get; set; }
        public bool AffectChildren { get; set; }
        public IINode RefCoordNode { get; }
        public bool ShouldContinueRenderOnError { get; }
        public bool IsRenderActive { get; }
        public bool XRefRenderBegin { get; }
        public bool RenderDialogOpen { get; }
        public IBitmap LastRenderedImage { get; }
        public IntPtr StatusPanelHWnd { get; }
        public IntPtr ListenerMiniHWnd { get; set; }
        public IMAXScriptPrefs MAXScriptPrefs { get; }
        public int NumTrackViews { get; }
        public bool CmdPanelOpen { get; set; }
        public bool IsEditing { get; }
        public bool IsCreatingObject_ { get; }
        public string MAXIniFile { get; }
        public int NumSchematicViews { get; }
        public bool DrawingEnabled { get; }
        public bool SceneResetting { get; }
        public bool QuitingApp { get; }
        public bool HideFrozen { get; }
        public IIScene Scene { get; }
        public int ActiveMtlSlot { get; set; }
        public int NumMtlSlots { get; }
        public bool IsMtlDlgShowing { get; }
        public IntPtr ViewPanelHWnd { get; }
        public int ActiveViewportIndex { get; }
        public int NumViewports { get; }
        public string ActiveViewportLabel { get; }
        public int RenderType { get; set; }
        public bool LockImageAspRatio { get; set; }
        public float ImageAspRatio { get; set; }
        public bool LockPixelAspRatio { get; set; }
        public float PixelAspRatio { get; set; }
        public int ActiveViewportRenderLevel { get; set; }
        public bool ActiveViewportShowEdgeFaces { get; set; }
        public int ActiveViewportTransparencyLevel { get; set; }
        public bool DualPlanes { get; set; }
        public bool InManipMode { get; }
        public bool SnapActive { get; set; }
        public int SnapType { get; set; }
        public int ASnapStatus { get; }
        public int PSnapStatus { get; }
        public float SnapAngle_ { get; set; }
        public float SnapPercent_ { get; set; }
        public int ExpertMode { get; set; }
        public float GridIntens { get; set; }
        public bool WhiteOrigin { get; set; }
        public bool UseGridColor { get; set; }
        public IIMenu IMenu { get; }
        public IIMenuItem IMenuItem { get; }
        public bool EnvEffectsDialogOpen { get; }
        public int QuickRender(int t, IBitmap rendbm, IRendProgressCallback prog)
        {
            throw new NotImplementedException();
        }

        public void GetRendFrameList(ITab<int> frameNums)
        {
            throw new NotImplementedException();
        }

        public void CreateRendImgSeq(ICreateRendImgSeqCallback cb)
        {
            throw new NotImplementedException();
        }

        public void GetDefaultTangentType(ref int dfltInTangentType, ref int dfltOutTangentType)
        {
            throw new NotImplementedException();
        }

        public void SetDefaultTangentType(int dfltInTangentType, int dfltOutTangentType, bool writeInCfgFile)
        {
            throw new NotImplementedException();
        }

        public void ColorById(uint id, IColor c)
        {
            throw new NotImplementedException();
        }

        public void RegisterExitMAXCallback(IExitMAXCallback2 cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterExitMAXCallback(IExitMAXCallback2 cb)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxSaveAsDialog(IntPtr parentWnd, string title, ref string filename, ref string initialDir,
            IFilterList extensionList)
        {
            throw new NotImplementedException();
        }

        public bool DoMaxOpenDialog(IntPtr parentWnd, string title, ref string filename, ref string initialDir,
            IFilterList extensionList)
        {
            throw new NotImplementedException();
        }

        public void RegisterModelessRenderWindow(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterModelessRenderWindow(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public bool LoadFromFile(string szFilename, uint lFlags)
        {
            throw new NotImplementedException();
        }

        public bool RevealInExplorer(string path)
        {
            throw new NotImplementedException();
        }

        public IRendProgressCallback RendProgressCallback { get; set; }
        public IINode RendCamNode { get; set; }
        public bool RendUseImgSeq { get; set; }
        public int RendImgSeqType { get; set; }
        public IAssetUser PreRendScriptAsset { get; set; }
        public bool UsePreRendScript { get; set; }
        public bool LocalPreRendScript { get; set; }
        public IAssetUser PostRendScriptAsset { get; set; }
        public bool UsePostRendScript { get; set; }
        public bool ControllerOverrideRangeDefault { get; set; }
        public bool SpringQuickEditMode { get; set; }
        public int SpringRollingStart { get; set; }
        public bool IsSavingToFile { get; }
        public bool DoMaxBrowseForFolder(IntPtr aOwner, string aInstructions, ref string aDir)
        {
            throw new NotImplementedException();
        }

        public uint DeleteNodes(IINodeTab aNodes, bool aKeepChildTM, bool aRedraw, bool overrideSlaveTM)
        {
            throw new NotImplementedException();
        }

        public void DeleteSelectedTrajectoryKey()
        {
            throw new NotImplementedException();
        }

        public void FindNodes(ITab<IINode> templateNodes, ITab<IINode> foundNodes, uint nodePropsToMatch)
        {
            throw new NotImplementedException();
        }

        public void FormatRenderTime(uint msec, ref string str, bool hundredths)
        {
            throw new NotImplementedException();
        }

        public bool TrajectoryMode { get; set; }
        public bool TrajectoryKeySubMode { get; set; }
        public bool TrajectoryAddKeyMode { get; set; }
        public bool AutoKeyDefaultKeyOn { get; set; }
        public int AutoKeyDefaultKeyTime { get; set; }
        public string Prompt { get; }
        public IntPtr OpenMAXStorageFile(string filename, IIStorage pIStorage)
        {
            throw new NotImplementedException();
        }

        public string GetRenderPresetMRUListDisplayName(int i)
        {
            throw new NotImplementedException();
        }

        public string GetRenderPresetMRUListFileName(int i)
        {
            throw new NotImplementedException();
        }

        public void DisplayViewportConfigDialogPage(int i)
        {
            throw new NotImplementedException();
        }

        public bool RendUseActiveView { get; set; }
        public int RenderPresetMRUListCount { get; }
        public IMatrix3 TransformGizmoTM { get; }
        public Rectangle MainWindowClientRect { get; }
        public IClassDesc DoPickClassDlg(IntPtr hParent, string title, SClass_ID super, IPickClassCallback pPickClassCB)
        {
            throw new NotImplementedException();
        }

        public int DoMultiplePickClassDlg(IntPtr hParent, string title, SClass_ID super, IPickClassCallback pPickClassCB,
            ITab<IClassDesc> classDescTab)
        {
            throw new NotImplementedException();
        }

        public bool SaveSceneAsVersion(string fname, bool clearNeedSaveFlag, bool useNewFile, uint saveAsVersion)
        {
            throw new NotImplementedException();
        }

        public bool SaveNodesAsVersion(string fname, IINodeTab nodes, uint saveAsVersion)
        {
            throw new NotImplementedException();
        }

        public bool SaveSelectedNodesAsVersion(string fname, uint saveAsVersion)
        {
            throw new NotImplementedException();
        }

        public bool IsMtlDlgShowing_(int mode)
        {
            throw new NotImplementedException();
        }

        public void OpenMtlDlg(int mode)
        {
            throw new NotImplementedException();
        }

        public void CloseMtlDlg(int mode)
        {
            throw new NotImplementedException();
        }

        public ushort NameSuffixLength { get; set; }
        public bool RendUseIterative { get; set; }
        public IILayerManager LayerManager { get; }
        public int MtlDlgMode { get; set; }
        public IViewExp GetViewExpByID(int viewID)
        {
            throw new NotImplementedException();
        }

        public bool LegacyFilesCanBeStoredUsingUTF8()
        {
            throw new NotImplementedException();
        }

        public void SetLegacyFilesCanBeStoredUsingUTF8(bool allowUTF8)
        {
            throw new NotImplementedException();
        }

        public void ConvertAppDataChunksContainingStringToUTF8(IAnimatable anim, IClass_ID classID, SClass_ID superClassID,
            ITab<uint> subIDs, uint codePage)
        {
            throw new NotImplementedException();
        }

        public uint DefaultTextSaveCodePage(bool allow_utf8)
        {
            throw new NotImplementedException();
        }

        public int RendViewID { get; set; }
        public IPreviewParams PreviewParams { get; }
        public bool OverrideLanguageSpecifiedInSceneFile { get; set; }
        public bool UseCodePageSpecifiedInSceneFile { get; set; }
        public uint DefaultTextLoadCodePage { get; }
        public uint MainThreadID { get; }
        public string CurTemplateAssetPath { get; }
        public int GetRendViewID(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        public void SetRendViewID(RenderSettingID renderSettingID, int viewportID)
        {
            throw new NotImplementedException();
        }

        public IViewExp CurrentRenderView { get; }

        #endregion
    }
}

