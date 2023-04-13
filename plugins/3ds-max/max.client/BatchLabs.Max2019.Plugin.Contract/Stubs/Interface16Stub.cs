
using System;
using System.Collections.Generic;
using System.Drawing;

using Autodesk.Max;
using Autodesk.Max.BaseInterface;
using Autodesk.Max.Interface7;
using Autodesk.Max.MaxSDK;
using Autodesk.Max.MaxSDK.AssetManagement;

using PivotMode = Autodesk.Max.Interface7.PivotMode;

namespace BatchLabs.Max2019.Plugin.Contract.Stubs
{
    /// <summary>
    /// Override functionality from the Max SDK for when we are running in local debug mode. 
    /// </summary>
    public class Interface16Stub : IInterface16
    {
        public delegate void MessageHandler(object sender, string message);
        public event MessageHandler PushMessage = delegate { };

        private string _renderer;

        public Interface16Stub()
        {
            Log = new LogSys();
            _renderer = "Default Scanline Renderer";
        }

        public ILogSys Log { get; }

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

        public string MatLibFileName { get; }
        public bool FileSave { get; }
        public bool FileSaveAs { get; }
        public bool CheckForSave { get; }
        public bool FileImport { get; }
        public bool FileExport { get; }
        public bool ImportZoomExtents { get; set; }
        public bool CheckMAXMessages { get; }
        public IAssetUser BkgImageAsset { get; }
        public int BkgImageAspect { get; set; }
        public bool BkgImageAnimate { get; set; }
        public int BkgStartTime { get; set; }
        public int BkgSyncFrame { get; set; }
        public IPoint3 ViewportBGColor { get; set; }
        public bool UseDraftRenderer { get; set; }
        public RenderSettingID CurrentRenderSetting { get; }
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
        public NodeHideFlags HideByCategoryFlags { get; }
        public ITexmap EnvironmentMap { get; set; }
        public bool UseEnvironmentMap { get; set; }
        public IControl AmbientController { get; set; }
        public IControl LightTintController { get; set; }
        public IControl LightLevelController { get; set; }
        public int NumAtmospheric { get; }
        public IControl BackGroundController { get; set; }
        public int NumEffects { get; }
        public ISoundObj SoundObject { get; set; }
        public IDllDir DllDir { get; }
        public IDllDir DllDirectory { get; }
        public IReferenceTarget ScenePointer { get; }
        public IITrackViewNode TrackViewRootNode { get; }
        public IITrackBar TrackBar { get; }
        public IINode ImportCtxNode { get; }
        public bool KeyStepsSelOnly { get; set; }
        public bool KeyStepsUseTrans { get; set; }
        public bool KeyStepsPos { get; set; }
        public bool KeyStepsRot { get; set; }
        public bool KeyStepsScale { get; set; }
        public bool KeyStepsUseTrackBar { get; set; }
        public bool UseTransformGizmo { get; set; }
        public bool TransformGizmoRestoreAxis { get; set; }
        public bool ConstantAxisRestriction { get; set; }
        public bool IncludeXRefsInHierarchy { get; set; }
        public bool IsXRefAutoUpdateSuspended { get; }
        public bool IsTrialLicense { get; }
        public bool IsNetworkLicense { get; }
        public bool DeferredPluginLoadingEnabled { get; }
        public IPickModeCallback CurPickMode { get; }
        public uint CurrentValidityToken { get; }
        public bool MEditRendererLocked { get; set; }
        public bool MEditRendererLockedDefaultValue { get; set; }
        public bool RendSimplifyAreaLights { get; set; }
        public IIOsnapManager OsnapManager { get; }
        public IMouseManager MouseManager { get; }
        public bool IsNetworkRenderServer { get; }
        public IShadowType GlobalShadowGenerator { get; set; }
        public IMacroRecorder MacroRecorder { get; }

        public IntPtr GetSysCursor(int id)
        {
            throw new NotImplementedException();
        }

        public void RedrawViews(int t, RedrawFlags vpFlags, IReferenceTarget change)
        {
            throw new NotImplementedException();
        }

        public bool SetActiveViewport(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        public void ForceCompleteRedraw(bool doDisabled)
        {
            throw new NotImplementedException();
        }

        public void DisableSceneRedraw()
        {
            throw new NotImplementedException();
        }

        public void EnableSceneRedraw()
        {
            throw new NotImplementedException();
        }

        public void MakeExtendedViewportActive(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public void PutUpViewMenu(IntPtr hWnd, Point pt)
        {
            throw new NotImplementedException();
        }

        public void SetViewportMax(bool max)
        {
            throw new NotImplementedException();
        }

        public void ViewportZoomExtents(bool doAll, bool skipPersp)
        {
            throw new NotImplementedException();
        }

        public void ZoomToBounds(bool doAll, IBox3 box)
        {
            throw new NotImplementedException();
        }

        public bool RegisterViewWindow(IViewWindow vw)
        {
            throw new NotImplementedException();
        }

        public bool UnRegisterViewWindow(IViewWindow vw)
        {
            throw new NotImplementedException();
        }

        public int OpenCurRenderer(IINode camNode, IViewExp view, RendType t, int w, int h)
        {
            throw new NotImplementedException();
        }

        public int OpenCurRenderer(IViewParams vpar, RendType t, int w, int h)
        {
            throw new NotImplementedException();
        }

        public void CloseCurRenderer()
        {
            throw new NotImplementedException();
        }

        public int CurRendererRenderFrame(int t, IBitmap bm, IRendProgressCallback prog, float frameDur, IViewParams vp,
            Rectangle regionRect)
        {
            throw new NotImplementedException();
        }

        public IIScanRenderer CreateDefaultScanlineRenderer()
        {
            throw new NotImplementedException();
        }

        public void RegisterRedrawViewsCallback(IRedrawViewsCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterRedrawViewsCallback(IRedrawViewsCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterSelectFilterCallback(ISelectFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterSelectFilterCallback(ISelectFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterDisplayFilterCallback(IDisplayFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterDisplayFilterCallback(IDisplayFilterCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterAxisChangeCallback(IAxisChangeCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterAxisChangeCallback(IAxisChangeCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterTimeChangeCallback(ITimeChangeCallback tc)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterTimeChangeCallback(ITimeChangeCallback tc)
        {
            throw new NotImplementedException();
        }

        public void RegisterCommandModeChangedCallback(ICommandModeChangedCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterCommandModeChangedCallback(ICommandModeChangedCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterViewportDisplayCallback(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterViewportDisplayCallback(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        public void NotifyViewportDisplayCallbackChanged(bool preScene, IViewportDisplayCallback cb)
        {
            throw new NotImplementedException();
        }

        public void RegisterExitMAXCallback(IExitMAXCallback cb)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterExitMAXCallback(IExitMAXCallback cb)
        {
            throw new NotImplementedException();
        }

        public bool TrackViewPickDlg(IntPtr hParent, ITrackViewPick res, ITrackViewFilter filter, uint pickTrackFlags)
        {
            throw new NotImplementedException();
        }

        public bool TrackViewPickMultiDlg(IntPtr hParent, IArray<ITrackViewPick> res, ITrackViewFilter filter, uint pickTrackFlags)
        {
            throw new NotImplementedException();
        }

        public bool DoHitByNameDialog(IHitByNameDlgCallback hbncb)
        {
            throw new NotImplementedException();
        }

        public void ChooseDirectory(IntPtr hWnd, string title, string dir, string desc)
        {
            throw new NotImplementedException();
        }

        public int DoExclusionListDialog(IExclList nl, bool doShadows)
        {
            throw new NotImplementedException();
        }

        public void ConvertNameTabToExclList(INameTab nt, IExclList excList)
        {
            throw new NotImplementedException();
        }

        public IMtlBase DoMaterialBrowseDlg(IntPtr hParent, MaterialBrowseFlags vflags, ref int newMat, ref int cancel)
        {
            throw new NotImplementedException();
        }

        public void PutMtlToMtlEditor(IMtlBase mb, int slot)
        {
            throw new NotImplementedException();
        }

        public bool NodeColorPicker(IntPtr hWnd, ref Color col)
        {
            throw new NotImplementedException();
        }

        public bool DoSpaceArrayDialog(ISpaceArrayCallback sacb)
        {
            throw new NotImplementedException();
        }

        public void PushCommandMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        public void PopCommandMode()
        {
            throw new NotImplementedException();
        }

        public void SetStdCommandMode(int cid)
        {
            throw new NotImplementedException();
        }

        public void PushStdCommandMode(int cid)
        {
            throw new NotImplementedException();
        }

        public void RemoveMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        public void DeleteMode(ICommandMode m)
        {
            throw new NotImplementedException();
        }

        public ICommandMode GetCommandStackEntry(int entry)
        {
            throw new NotImplementedException();
        }

        void IInterface.PushPrompt(string promptString)
        {
            PushMessage(this, promptString);
        }

        public void PopPrompt()
        {
            throw new NotImplementedException();
        }

        public void ReplacePrompt(string s)
        {
            throw new NotImplementedException();
        }

        public void DisplayTempPrompt(string s, int msec)
        {
            throw new NotImplementedException();
        }

        public void RemoveTempPrompt()
        {
            throw new NotImplementedException();
        }

        public void DisableStatusXYZ()
        {
            throw new NotImplementedException();
        }

        public void EnableStatusXYZ()
        {
            throw new NotImplementedException();
        }

        public void SetStatusXYZ(IPoint3 xyz, int type)
        {
            throw new NotImplementedException();
        }

        public void SetStatusXYZ(IAngAxis aa)
        {
            throw new NotImplementedException();
        }

        public void EnableAutoBackup(bool onOff)
        {
            throw new NotImplementedException();
        }

        public bool ProgressStart(string title, bool dispBar, IntPtr fn, IntPtr arg)
        {
            throw new NotImplementedException();
        }

        public void ProgressUpdate(int pct, bool showPct, string title)
        {
            throw new NotImplementedException();
        }

        public void ProgressEnd()
        {
            throw new NotImplementedException();
        }

        public void CreatePreview(IPreviewParams pvp)
        {
            throw new NotImplementedException();
        }

        public void AddGridToScene(IINode node)
        {
            throw new NotImplementedException();
        }

        public void SetToolButtonState(int button, bool state)
        {
            throw new NotImplementedException();
        }

        public void EnableAxisConstraints(int c, bool enabled)
        {
            throw new NotImplementedException();
        }

        public void PushAxisConstraints(int c)
        {
            throw new NotImplementedException();
        }

        public void PopAxisConstraints()
        {
            throw new NotImplementedException();
        }

        public void EnableCoordCenter(bool enabled)
        {
            throw new NotImplementedException();
        }

        public void EnableRefCoordSys(bool enabled)
        {
            throw new NotImplementedException();
        }

        public float SnapAngle(float angleIn, bool fastSnap, bool forceSnap)
        {
            throw new NotImplementedException();
        }

        public float SnapPercent(float percentIn)
        {
            throw new NotImplementedException();
        }

        public bool SetSnapMode(int mode)
        {
            throw new NotImplementedException();
        }

        public int InitSnapInfo(ISnapInfo info)
        {
            throw new NotImplementedException();
        }

        public void SetPickMode(IPickModeCallback pCB)
        {
            throw new NotImplementedException();
        }

        public void ClearPickMode()
        {
            throw new NotImplementedException();
        }

        public IINode PickNode(IntPtr hWnd, IIPoint2 pt, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        public void BoxPickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        public void CirclePickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        public void FencePickNode(IViewExp vpt, IIPoint2 pt, bool crossing, IPickNodeCallback filt)
        {
            throw new NotImplementedException();
        }

        public void FlashNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        public void RegisterSubObjectTypes(string types, int count, int startIndex)
        {
            throw new NotImplementedException();
        }

        public void SetSubObjectLevel(int level, bool force)
        {
            throw new NotImplementedException();
        }

        public void PipeSelLevelChanged()
        {
            throw new NotImplementedException();
        }

        public void GetPipelineSubObjLevel(IDWORDTab levels)
        {
            throw new NotImplementedException();
        }

        public int SubObHitTest(int t, int type, int crossing, int vflags, IIPoint2 p, IViewExp vpt)
        {
            throw new NotImplementedException();
        }

        public void AppendSubObjectNamedSelSet(string set)
        {
            throw new NotImplementedException();
        }

        public void ClearSubObjectNamedSelSets()
        {
            throw new NotImplementedException();
        }

        public void ClearCurNamedSelSet()
        {
            throw new NotImplementedException();
        }

        public void SetCurNamedSelSet(string setName)
        {
            throw new NotImplementedException();
        }

        public void NamedSelSetListChanged()
        {
            throw new NotImplementedException();
        }

        public void GetModContexts(IModContextList list, IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        public void FreezeSelection()
        {
            throw new NotImplementedException();
        }

        public void ThawSelection()
        {
            throw new NotImplementedException();
        }

        public IINode GetSelNode(int i)
        {
            throw new NotImplementedException();
        }

        public void SelectNode(IINode node, bool clearSel)
        {
            throw new NotImplementedException();
        }

        public void DeSelectNode(IINode node)
        {
            throw new NotImplementedException();
        }

        public void SelectNodeTab(IINodeTab nodes, bool sel, bool redraw)
        {
            throw new NotImplementedException();
        }

        public void ClearNodeSelection(bool redraw)
        {
            throw new NotImplementedException();
        }

        public void GetSelectionWorldBox(int t, IBox3 box)
        {
            throw new NotImplementedException();
        }

        public bool CloneNodes(IINodeTab nodes, IPoint3 offset, bool expandHierarchies, CloneType cloneType, IINodeTab resultSource,
            IINodeTab resultTarget)
        {
            throw new NotImplementedException();
        }

        public void CollapseNode(IINode node, bool noWarning)
        {
            throw new NotImplementedException();
        }

        public bool CollapseNodeTo(IINode node, int modIndex, bool noWarning)
        {
            throw new NotImplementedException();
        }

        public bool ConvertNode(IINode node, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        public bool SetQuietMode(bool onOff)
        {
            throw new NotImplementedException();
        }

        public bool GetQuietMode(bool checkServerMode)
        {
            throw new NotImplementedException();
        }

        public void EnableShowEndResult(bool enabled)
        {
            throw new NotImplementedException();
        }

        public IntPtr AddRollupPage(IntPtr hInst, string dlgTemplate, IntPtr dlgProc, string title, IntPtr param, uint rollUpFlags,
            int category)
        {
            throw new NotImplementedException();
        }

        public void DeleteRollupPage(IntPtr hRollup)
        {
            throw new NotImplementedException();
        }

        public IntPtr ReplaceRollupPage(IntPtr hOldRollup, IntPtr hInst, string dlgTemplate, IntPtr dlgProc, string title,
            IntPtr param, uint rollUpFlags, int category)
        {
            throw new NotImplementedException();
        }

        public void RollupMouseMessage(IntPtr hDlg, uint message, UIntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        public void EnableAnimateButton(bool enable)
        {
            throw new NotImplementedException();
        }

        public void SetAnimateButtonState(bool onOff)
        {
            throw new NotImplementedException();
        }

        public void BeginProgressiveMode()
        {
            throw new NotImplementedException();
        }

        public void EndProgressiveMode()
        {
            throw new NotImplementedException();
        }

        public void SetTime(int t, bool redraw)
        {
            throw new NotImplementedException();
        }

        public void StartAnimPlayback(int selOnly)
        {
            throw new NotImplementedException();
        }

        public void EndAnimPlayback()
        {
            throw new NotImplementedException();
        }

        public string GetSelectFilterName(int index)
        {
            throw new NotImplementedException();
        }

        public bool GetDisplayFilter(int index)
        {
            throw new NotImplementedException();
        }

        public void SetDisplayFilter(int index, bool @on)
        {
            throw new NotImplementedException();
        }

        public bool DisplayFilterIsNodeVisible(int index, int sid, IClass_ID cid, IINode node)
        {
            throw new NotImplementedException();
        }

        public string GetDisplayFilterName(int index)
        {
            throw new NotImplementedException();
        }

        public IMatrix3 GetTransformAxis(IINode node, int subIndex, IntPtr local)
        {
            throw new NotImplementedException();
        }

        public void LockAxisTripods(bool onOff)
        {
            throw new NotImplementedException();
        }

        public void RegisterDlgWnd(IntPtr hDlg)
        {
            throw new NotImplementedException();
        }

        public int UnRegisterDlgWnd(IntPtr hDlg)
        {
            throw new NotImplementedException();
        }

        public void RegisterDeleteUser(IEventUser user)
        {
            throw new NotImplementedException();
        }

        public void UnRegisterDeleteUser(IEventUser user)
        {
            throw new NotImplementedException();
        }

        public void MakeNameUnique(ref string name)
        {
            throw new NotImplementedException();
        }

        public INameMaker NewNameMaker(bool initFromScene)
        {
            throw new NotImplementedException();
        }

        public IINode CreateObjectNode(IObject obj)
        {
            throw new NotImplementedException();
        }

        public IGenCamera CreateCameraObject(int type)
        {
            throw new NotImplementedException();
        }

        public IObject CreateTargetObject()
        {
            throw new NotImplementedException();
        }

        public IGenLight CreateLightObject(int type)
        {
            throw new NotImplementedException();
        }

        public object CreateInstance(SClass_ID superID, IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        public int BindToTarget(IINode laNode, IINode targNode)
        {
            throw new NotImplementedException();
        }

        public void StopCreating()
        {
            throw new NotImplementedException();
        }

        public IObject NonMouseCreate(IMatrix3 tm)
        {
            throw new NotImplementedException();
        }

        public void NonMouseCreateFinish(IMatrix3 tm)
        {
            throw new NotImplementedException();
        }

        public uint DeleteNode(IINode node, bool redraw, bool overrideSlaves)
        {
            throw new NotImplementedException();
        }

        public void SetNodeTMRelConstPlane(IINode node, IMatrix3 mat)
        {
            throw new NotImplementedException();
        }

        public IINode GetINodeByName(string name)
        {
            throw new NotImplementedException();
        }

        public IINode GetINodeByHandle(uint handle)
        {
            throw new NotImplementedException();
        }

        public void AddLightToScene(IINode node)
        {
            throw new NotImplementedException();
        }

        public void AddSFXRollupPage(uint vflags)
        {
            throw new NotImplementedException();
        }

        public void DeleteSFXRollupPage()
        {
            throw new NotImplementedException();
        }

        public void RefreshSFXRollupPage()
        {
            throw new NotImplementedException();
        }

        public string GetDir(int which)
        {
            throw new NotImplementedException();
        }

        public string GetPlugInDesc(int i)
        {
            throw new NotImplementedException();
        }

        public string GetPlugInDir(int i)
        {
            throw new NotImplementedException();
        }

        public IMtlBase GetMtlSlot(int slot)
        {
            throw new NotImplementedException();
        }

        public bool OkMtlForScene(IMtlBase m)
        {
            throw new NotImplementedException();
        }

        public void DeActivateTexture(IMtlBase tx, IMtl mtl, int subNum)
        {
            throw new NotImplementedException();
        }

        public void ActivateTexture(IMtlBase tx, IMtl mtl, int subNum)
        {
            throw new NotImplementedException();
        }

        public void AssignNewName(IMtl m)
        {
            throw new NotImplementedException();
        }

        public void AssignNewName(ITexmap m)
        {
            throw new NotImplementedException();
        }

        public void UpdateMtlEditorBrackets()
        {
            throw new NotImplementedException();
        }

        public void ConvertMtl(int t, IMaterial gm, IMtl mtl, bool doTex, int subNum, float vis, ref int needDecal, IINode node,
            IBitArray needTex, IGraphicsWindow gw)
        {
            throw new NotImplementedException();
        }

        public void FileOpen()
        {
            throw new NotImplementedException();
        }

        public void FileSaveSelected()
        {
            throw new NotImplementedException();
        }

        public void FileReset(bool noPrompt)
        {
            throw new NotImplementedException();
        }

        public void FileMerge()
        {
            throw new NotImplementedException();
        }

        public void FileHold()
        {
            throw new NotImplementedException();
        }

        public void FileFetch()
        {
            throw new NotImplementedException();
        }

        public void FileOpenMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public void FileSaveMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public void FileSaveAsMatLib(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public void LoadDefaultMatLib()
        {
            throw new NotImplementedException();
        }

        public int LoadFromFile(string name, bool refresh)
        {
            throw new NotImplementedException();
        }

        public int SaveToFile(string fname, bool clearNeedSaveFlag, bool useNewFile)
        {
            throw new NotImplementedException();
        }

        public void FileSaveSelected(string fname)
        {
            throw new NotImplementedException();
        }

        public void FileSaveNodes(IINodeTab nodes, string fname)
        {
            throw new NotImplementedException();
        }

        public int LoadMaterialLib(string name, IMtlBaseLib lib)
        {
            throw new NotImplementedException();
        }

        public int SaveMaterialLib(string name, IMtlBaseLib lib)
        {
            throw new NotImplementedException();
        }

        public int MergeFromFile(string name, bool mergeAll, bool selMerged, bool refresh, int dupAction, INameTab mrgList,
            int dupMtlAction, int reparentAction)
        {
            throw new NotImplementedException();
        }

        public void SetMAXFileOpenDlg(IMAXFileOpenDialog dlg)
        {
            throw new NotImplementedException();
        }

        public void SetMAXFileSaveDlg(IMAXFileSaveDialog dlg)
        {
            throw new NotImplementedException();
        }

        public bool IsMaxFile(string filename)
        {
            throw new NotImplementedException();
        }

        public bool IsInternetCachedFile(string filename)
        {
            throw new NotImplementedException();
        }

        public bool ImportFromFile(string name, bool suppressPrompts, IClass_ID importerID)
        {
            throw new NotImplementedException();
        }

        public bool ExportToFile(string name, bool suppressPrompts, uint options, IClass_ID exporterID)
        {
            throw new NotImplementedException();
        }

        public bool CanImportFile(string filename)
        {
            throw new NotImplementedException();
        }

        public IINode GroupNodes(IINodeTab nodes, IntPtr name, bool selGroup)
        {
            throw new NotImplementedException();
        }

        public void UngroupNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        public void ExplodeNodes(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        public void OpenGroup(IINodeTab nodes, bool clearSel)
        {
            throw new NotImplementedException();
        }

        public void CloseGroup(IINodeTab nodes, bool selGroup)
        {
            throw new NotImplementedException();
        }

        public bool SetBkgImageAsset(IAssetUser asset)
        {
            throw new NotImplementedException();
        }

        public void SetBkgFrameRange(int start, int end, int step)
        {
            throw new NotImplementedException();
        }

        public int GetBkgFrameRangeVal(int which)
        {
            throw new NotImplementedException();
        }

        public void SetBkgORType(int which, int type)
        {
            throw new NotImplementedException();
        }

        public int GetBkgORType(int which)
        {
            throw new NotImplementedException();
        }

        public int GetBkgFrameNum(int t)
        {
            throw new NotImplementedException();
        }

        public int OpenRenderer(IRenderer pRenderer, IINode camNode, IViewExp view, RendType type, int w, int h)
        {
            throw new NotImplementedException();
        }

        public int OpenRenderer(IRenderer pRenderer, IViewParams vpar, RendType type, int w, int h)
        {
            throw new NotImplementedException();
        }

        public int RendererRenderFrame(IRenderer pRenderer, int t, IBitmap bm, IRendProgressCallback prog, float frameDur,
            IViewParams vp, Rectangle regionRect)
        {
            throw new NotImplementedException();
        }

        public void CloseRenderer(IRenderer pRenderer)
        {
            throw new NotImplementedException();
        }

        public IRenderer GetProductionRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        public IRenderer GetDraftRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        public IRenderer GetRenderer(RenderSettingID renderSettingID, bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        public void AssignCurRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        public void AssignProductionRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        public void AssignDraftRenderer(IRenderer rend)
        {
            throw new NotImplementedException();
        }

        public void AssignRenderer(RenderSettingID renderSettingID, IRenderer rend)
        {
            throw new NotImplementedException();
        }

        public void ChangeRenderSetting(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        public IIRenderElementMgr GetRenderElementMgr(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        public void SetupRendParams(IRendParams rp, IViewExp vpt, RendType t)
        {
            throw new NotImplementedException();
        }

        public void GetViewParamsFromNode(IINode vnode, IViewParams vp, int t)
        {
            throw new NotImplementedException();
        }

        public void AbortRender()
        {
            throw new NotImplementedException();
        }

        public void SetRendAspect(float a)
        {
            throw new NotImplementedException();
        }

        public void SetRendForce2Side(bool onOff)
        {
            throw new NotImplementedException();
        }

        public void SetRendDither256(bool onOff)
        {
            throw new NotImplementedException();
        }

        public void SetHideByCategoryFlags(uint f)
        {
            throw new NotImplementedException();
        }

        public IINode GetINodeFromRenderID(ushort id)
        {
            throw new NotImplementedException();
        }

        public void ExecuteMAXCommand(int id)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetAmbient(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        public void SetAmbient(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetLightTint(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        public void SetLightTint(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        public float GetLightLevel(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        public void SetLightLevel(int t, float lev)
        {
            throw new NotImplementedException();
        }

        public IAtmospheric GetAtmospheric(int i)
        {
            throw new NotImplementedException();
        }

        public void SetAtmospheric(int i, IAtmospheric a)
        {
            throw new NotImplementedException();
        }

        public void AddAtmosphere(IAtmospheric atmos)
        {
            throw new NotImplementedException();
        }

        public void DeleteAtmosphere(int i)
        {
            throw new NotImplementedException();
        }

        public void EditAtmosphere(IAtmospheric a, IINode gizmo)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetBackGround(int t, IInterval valid)
        {
            throw new NotImplementedException();
        }

        public void SetBackGround(int t, IPoint3 col)
        {
            throw new NotImplementedException();
        }

        public IEffect GetEffect(int i)
        {
            throw new NotImplementedException();
        }

        public void SetEffect(int i, IEffect e)
        {
            throw new NotImplementedException();
        }

        public void AddEffect(IEffect eff)
        {
            throw new NotImplementedException();
        }

        public void DeleteEffect(int i)
        {
            throw new NotImplementedException();
        }

        public void EditEffect(IEffect e, IINode gizmo)
        {
            throw new NotImplementedException();
        }

        public IntPtr Execute(int cmd, UIntPtr arg1, UIntPtr arg2, UIntPtr arg3, UIntPtr arg4, UIntPtr arg5, UIntPtr arg6)
        {
            throw new NotImplementedException();
        }

        public IITreeView CreateTreeViewChild(IReferenceTarget root, IntPtr hParent, uint style, uint id, int open)
        {
            throw new NotImplementedException();
        }

        public void FreeSceneBitmaps()
        {
            throw new NotImplementedException();
        }

        public IMtlBaseLib MaterialLibrary { get; }

        public void RenderTexmap(ITexmap tex, IBitmap bm, float scale3d, bool filter, bool display, float z, int t, bool bake)
        {
            throw new NotImplementedException();
        }

        public bool CanImportBitmap(string filename)
        {
            throw new NotImplementedException();
        }

        public bool CaptureSubObjectRegistration(bool OnOff, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        public bool DownloadUrl(IntPtr hwnd, string url, string filename, uint downloadFlags)
        {
            throw new NotImplementedException();
        }

        public void RescaleWorldUnits(float f, bool selected)
        {
            throw new NotImplementedException();
        }

        public int HitTestTransformGizmo(IIPoint2 p, IViewExp vpt, int axisFlags)
        {
            throw new NotImplementedException();
        }

        public void DeactivateTransformGizmo()
        {
            throw new NotImplementedException();
        }

        public int AddClass(IClassDesc pCD)
        {
            throw new NotImplementedException();
        }

        public int DeleteClass(IClassDesc pCD)
        {
            throw new NotImplementedException();
        }

        public int GetNumProperties(int PropertySet)
        {
            throw new NotImplementedException();
        }

        public void SetXRefAutoUpdateSuspended(bool onOff)
        {
            throw new NotImplementedException();
        }

        public bool IsSceneXRefNode(IINode node)
        {
            throw new NotImplementedException();
        }

        public void RAMPlayer(IntPtr hWndParent, string szChanA, string szChanB)
        {
            throw new NotImplementedException();
        }

        public void FlushUndoBuffer()
        {
            throw new NotImplementedException();
        }

        public void EnableDeferredPluginLoading(bool onOff)
        {
            throw new NotImplementedException();
        }

        public bool SetActiveViewportTransparencyDisplay(int transType)
        {
            throw new NotImplementedException();
        }

        public bool SetSelectionType(bool autoWinCross, int winCrossOrAutoDir)
        {
            throw new NotImplementedException();
        }

        public void RealizeParamPanel()
        {
            throw new NotImplementedException();
        }

        public bool GetToolButtonState(int button)
        {
            throw new NotImplementedException();
        }

        public void EnableToolButton(int button, bool enable)
        {
            throw new NotImplementedException();
        }

        public void EnableUndo(bool enable)
        {
            throw new NotImplementedException();
        }

        public IViewExp GetViewExp(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        public int GetAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public string GetAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public bool AddAssetDir(string dir, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public bool AddSessionAssetDir(string dir, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        public int GetSessionAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public string GetSessionAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSessionAssetDir(int i, AssetType assetType, int update)
        {
            throw new NotImplementedException();
        }

        public int GetCurAssetDirCount(AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public string GetCurAssetDir(int i, AssetType assetType)
        {
            throw new NotImplementedException();
        }

        public bool AttachNodesToGroup(IINodeTab nodes, IINode pTargetNode)
        {
            throw new NotImplementedException();
        }

        public bool DetachNodesFromGroup(IINodeTab nodes)
        {
            throw new NotImplementedException();
        }

        public void IncrementValidityToken()
        {
            throw new NotImplementedException();
        }

        public IRenderer CreateDefaultRenderer(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        public IClass_ID GetDefaultRendererClassID(RenderSettingID renderSettingID)
        {
            throw new NotImplementedException();
        }

        public void SetDefaultRendererClassID(RenderSettingID renderSettingID, IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        public IRenderer GetMEditRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        public void AssignMEditRenderer(IRenderer renderer)
        {
            throw new NotImplementedException();
        }

        public IRenderer GetActualMEditRenderer(bool createRendererIfItDoesntExist)
        {
            throw new NotImplementedException();
        }

        public void InvalidateOsnapdraw()
        {
            throw new NotImplementedException();
        }

        public IntPtr GetInterface(uint id)
        {
            throw new NotImplementedException();
        }

        public IList<IAtmospheric> Atmospherics { get; }
        public IList<IEffect> Effects { get; }
        public IntPtr AppHFont { get; }
        public bool CrossHairCur { get; set; }
        public IViewExp ActiveViewExp { get; }
        public bool IsSceneRedrawDisabled { get; }
        public bool IsCPEdgeOnInView { get; }
        public int ViewportLayout { get; set; }
        public bool IsViewportMaxed { get; }
        public IIObjCreate IObjCreate { get; }
        public IIObjParam IObjParam { get; }
        public IntPtr MAXHWnd { get; }
        public bool DisplayActiveCameraViewWithMultiPassEffect { get; }
        public int ConfigureBitmapPaths { get; }
        public ICommandMode CommandMode { get; set; }
        public int CommandStackSize { get; }
        public float AutoBackupTime { get; set; }
        public bool AutoBackupEnabled { get; }
        public bool Cancel { get; set; }
        public float GridSpacing { get; }
        public int GridMajorLines { get; }
        public IINode ActiveGrid { get; set; }
        public int ExtendedDisplayMode { get; set; }
        public int FlyOffTime { get; set; }
        public bool Crossing { get; }
        public int AxisConstraints { get; set; }
        public int CoordCenter { get; set; }
        public int RefCoordSys { get; set; }
        public bool SnapState { get; }
        public int SnapMode { get; }
        public int SubObjectLevel { get; }
        public int NumSubObjectLevels { get; }
        public IBaseObject CurEditObject { get; }
        public bool SelectionFrozen { get; }
        public int SelNodeCount { get; }
        public IIRenderPresetsManager RenderPresetsManager { get; }
        public IDefaultActionSys DefaultActions { get; }
        public bool AutoGridEnable { get; set; }
        public bool AutoGridState { get; set; }
        public bool ShowEndResult { get; set; }
        public int CommandPanelTaskMode { get; set; }
        public IIRollupWindow CommandPanelRollup { get; }
        public bool IsAnimateEnabled { get; }
        public bool InProgressiveMode { get; }
        public int Time { get; }
        public IInterval AnimRange { get; set; }
        public bool RealTimePlayback { get; set; }
        public bool PlayActiveOnly { get; set; }
        public bool IsAnimPlaying { get; }
        public int PlaybackSpeed { get; set; }
        public bool PlaybackLoop { get; set; }
        public int SelectFilter { get; set; }
        public int NumberSelectFilters { get; }
        public int NumberDisplayFilters { get; }
        public int NumAxis { get; }
        public bool AxisTripodLocked { get; }
        public IIActionManager ActionManager { get; }
        public IIMenuManager MenuManager { get; }
        public IRightClickMenuManager RightClickMenuManager { get; }
        public IINode RootNode { get; }
        public float LightConeConstraint { get; }
        public int PlugInEntryCount { get; }
        public IMtlBaseLib SceneMtls { get; }

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
        public void Init()
        {
            throw new NotImplementedException();
        }

        public void LoadDescriptor(IInterface_ID id, string int_name, IntPtr descr, IClassDesc pCD, uint flag, params object[] param5)
        {
            throw new NotImplementedException();
        }

        public void AppendFunction(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        public void AppendProperty(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        public void AppendEnum(int id, params object[] param1)
        {
            throw new NotImplementedException();
        }

        public void SetClassDesc(IClassDesc i_cd)
        {
            throw new NotImplementedException();
        }

        public IFPFunctionDef GetFnDef(short fid)
        {
            throw new NotImplementedException();
        }

        public string GetRsrcString(IntPtr id)
        {
            throw new NotImplementedException();
        }

        public IInterface_ID Id_ { get; set; }
        public string InternalName { get; set; }
        public IntPtr Description { get; set; }
        public IClassDesc Cd { get; set; }
        public ushort Flags { get; set; }
        public ITab<IFPFunctionDef> Functions { get; set; }
        public ITab<IFPPropDef> Props { get; set; }
        public ITab<IFPEnum> Enumerations { get; set; }
        public IRollout Rollout { get; set; }
        public IActionTable ActionTable_ { get; set; }
        public IntPtr HInstance { get; }
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

        public void SetCurEditObject(IBaseObject obj, IINode hintNode)
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

        public void StartCreatingObject(IClassDesc pCD)
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
        public int OpenMAXStorageFile(string filename, IIStorage pIStorage)
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
        public bool ShowWorldAxis { get; set; }
        public IMtlBase OverrideRenderSettingMtl { get; set; }

        #endregion
    }
}

