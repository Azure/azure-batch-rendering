
using System;
using System.Drawing;

using Autodesk.Max;
using Autodesk.Max.MaxSDK.Util;
using Autodesk.Max.Renderer;

namespace BatchLabs.Max2019.Plugin.Contract.Stubs
{
    public class Renderer : IRenderer
    {
        public Renderer(string name)
        {
            ClassName = name;
            ClassName_ = name;
        }

        public string ClassName { get; }

        public string ClassName_ { get; }

        public string NodeName { get; }

        public bool Equals(IInterfaceServer other)
        {
            return other != null && NativePointer == other.NativePointer;
        }

        public void Dispose() { }

        public IntPtr NativePointer { get; }

        public IBaseInterface GetInterface(IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        public bool Equals(INoncopyable other)
        {
            throw new NotImplementedException();
        }

        public void SetAFlag(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public void ClearAFlag(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public bool TestAFlag(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public void SetAFlagEx(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public void ClearAFlagEx(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public bool TestAFlagEx(AnimatableFlags mask)
        {
            throw new NotImplementedException();
        }

        public bool TestFlagBit(int index)
        {
            throw new NotImplementedException();
        }

        public void SetFlagBit(int index, bool newValue)
        {
            throw new NotImplementedException();
        }

        public void ClearFlagBit(int index)
        {
            throw new NotImplementedException();
        }

        public void BeginEditParams(IIObjParam ip, uint flags, IAnimatable prev)
        {
            throw new NotImplementedException();
        }

        public void EndEditParams(IIObjParam ip, uint flags, IAnimatable next)
        {
            throw new NotImplementedException();
        }

        public object GetInterface(InterfaceID id)
        {
            throw new NotImplementedException();
        }

        public void ReleaseInterface(uint id, IntPtr i)
        {
            throw new NotImplementedException();
        }

        public int SetProperty(uint id, IntPtr data)
        {
            throw new NotImplementedException();
        }

        public IntPtr GetProperty(uint id)
        {
            throw new NotImplementedException();
        }

        public void AppendProperty(IAnimProperty prop)
        {
            throw new NotImplementedException();
        }

        public IAnimProperty FindProperty(uint id)
        {
            throw new NotImplementedException();
        }

        public void AddAppDataChunk(IClass_ID cid, SClass_ID sid, uint sbid, byte[] data)
        {
            throw new NotImplementedException();
        }

        public IAppDataChunk GetAppDataChunk(IClass_ID cid, SClass_ID sid, uint sbid)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAppDataChunk(IClass_ID cid, SClass_ID sid, uint sbid)
        {
            throw new NotImplementedException();
        }

        public void ClearAllAppData()
        {
            throw new NotImplementedException();
        }

        public int GetKeyTime(int index)
        {
            throw new NotImplementedException();
        }

        public int GetKeyIndex(int t)
        {
            throw new NotImplementedException();
        }

        public bool GetNextKeyTime(int t, uint flags, ref int nt)
        {
            throw new NotImplementedException();
        }

        public void CopyKeysFromTime(int src, int dst, uint flags)
        {
            throw new NotImplementedException();
        }

        public void DeleteKeyAtTime(int t)
        {
            throw new NotImplementedException();
        }

        public bool IsKeyAtTime(int t, uint flags)
        {
            throw new NotImplementedException();
        }

        public int GetKeyTimes(ITab<int> times, IInterval range, uint flags)
        {
            throw new NotImplementedException();
        }

        public int GetKeySelState(IBitArray sel, IInterval range, uint flags)
        {
            throw new NotImplementedException();
        }

        public void OpenTreeEntry(int type, uint tv)
        {
            throw new NotImplementedException();
        }

        public void CloseTreeEntry(int type, uint tv)
        {
            throw new NotImplementedException();
        }

        public bool IsTreeEntryOpen(int type, uint tv)
        {
            throw new NotImplementedException();
        }

        public bool GetSelInTrackView(uint tv)
        {
            throw new NotImplementedException();
        }

        public void SetSelInTrackView(uint tv, bool sel)
        {
            throw new NotImplementedException();
        }

        public bool InTrackViewSelSet(int which)
        {
            throw new NotImplementedException();
        }

        public void SetTrackViewSelSet(int which, bool inOut)
        {
            throw new NotImplementedException();
        }

        public bool AssignController(IAnimatable control, int subAnim)
        {
            throw new NotImplementedException();
        }

        public bool CanAssignController(int subAnim)
        {
            throw new NotImplementedException();
        }

        public bool CanDeleteSubAnim(int i)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubAnim(int i)
        {
            throw new NotImplementedException();
        }

        public uint GetSubAnimCurveColor(int subNum)
        {
            throw new NotImplementedException();
        }

        public int SubNumToRefNum(int subNum)
        {
            throw new NotImplementedException();
        }

        public int HasSubElements(int type)
        {
            throw new NotImplementedException();
        }

        public bool GetSubFCurveExtents(int subNum, IParamDimensionBase dim, ref float min, ref float max, DisplayCurveFlags flags)
        {
            throw new NotImplementedException();
        }

        public IParamDimension GetParamDimension(int i)
        {
            throw new NotImplementedException();
        }

        public bool SelectSubAnim(int subNum)
        {
            throw new NotImplementedException();
        }

        public int EnumAnimTree(IAnimEnum animEnum, IAnimatable client, int subNum)
        {
            throw new NotImplementedException();
        }

        public void EnumAuxFiles(IAssetEnumCallback assetEnum, uint flags)
        {
            throw new NotImplementedException();
        }

        public int RenderBegin(int t, uint flags)
        {
            throw new NotImplementedException();
        }

        public int RenderEnd(int t)
        {
            throw new NotImplementedException();
        }

        public IInterval GetTimeRange(uint flags)
        {
            throw new NotImplementedException();
        }

        public void EditTimeRange(IInterval range, uint flags)
        {
            throw new NotImplementedException();
        }

        public void DeleteTime(IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public void ReverseTime(IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public void ScaleTime(IInterval iv, float s)
        {
            throw new NotImplementedException();
        }

        public void InsertTime(int ins, int amount)
        {
            throw new NotImplementedException();
        }

        public void MapKeys(ITimeMap map, uint flags)
        {
            throw new NotImplementedException();
        }

        public void DeleteKeys(uint flags)
        {
            throw new NotImplementedException();
        }

        public void DeleteKeyByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void SelectKeys(ITab<ITrackHitRecord> sel, uint flags)
        {
            throw new NotImplementedException();
        }

        public void SelectSubKeys(int subNum, ITab<ITrackHitRecord> sel, uint flags)
        {
            throw new NotImplementedException();
        }

        public void SelectSubCurve(int subNum, bool sel)
        {
            throw new NotImplementedException();
        }

        public void SelectKeyByIndex(int i, bool sel)
        {
            throw new NotImplementedException();
        }

        public bool IsKeySelected(int i)
        {
            throw new NotImplementedException();
        }

        public void FlagKey(ITrackHitRecord hit)
        {
            throw new NotImplementedException();
        }

        public void CloneSelectedKeys(bool offset)
        {
            throw new NotImplementedException();
        }

        public void AddNewKey(int t, uint flags)
        {
            throw new NotImplementedException();
        }

        public void MoveKeys(IParamDimensionBase dim, float delta, uint flags)
        {
            throw new NotImplementedException();
        }

        public void ScaleKeyValues(IParamDimensionBase dim, float origin, float scale, uint flags)
        {
            throw new NotImplementedException();
        }

        public void SelectCurve(bool sel)
        {
            throw new NotImplementedException();
        }

        public bool IsSubCurveSelected(int subNum)
        {
            throw new NotImplementedException();
        }

        public int GetSelKeyCoords(ref int t, ref float val, uint flags)
        {
            throw new NotImplementedException();
        }

        public void SetSelKeyCoords(int t, float val, uint flags)
        {
            throw new NotImplementedException();
        }

        public int SetSelKeyCoordsExpr(IParamDimension dim, string timeExpr, string valExpr, uint flags)
        {
            throw new NotImplementedException();
        }

        public void AdjustTangents(ITrackHitRecord hit, IParamDimensionBase dim, IBox2 rcGraph, float tzoom, int tscroll, float vzoom,
            int vscroll, int dx, int dy, uint flags)
        {
            throw new NotImplementedException();
        }

        public bool CanCopyTrack(IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public bool CanPasteTrack(ITrackClipObject cobj, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public ITrackClipObject CopyTrack(IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public void PasteTrack(ITrackClipObject cobj, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public bool CanCopySubTrack(int subNum, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public bool CanPasteSubTrack(int subNum, ITrackClipObject cobj, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public ITrackClipObject CopySubTrack(int subNum, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public void PasteSubTrack(int subNum, ITrackClipObject cobj, IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public int GetTrackVSpace(int lineHeight)
        {
            throw new NotImplementedException();
        }

        public int HitTestTrack(ITab<ITrackHitRecord> hits, IBox2 rcHit, IBox2 rcTrack, float zoom, int scroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public int PaintTrack(IParamDimensionBase dim, IntPtr hdc, IBox2 rcTrack, IBox2 rcPaint, float zoom, int scroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public int PaintSubTrack(int subNum, IParamDimensionBase dim, IntPtr hdc, IBox2 rcTrack, IBox2 rcPaint, float zoom, int scroll,
            uint flags)
        {
            throw new NotImplementedException();
        }

        public int PaintFCurves(IParamDimensionBase dim, IntPtr hdc, IBox2 rcGraph, IBox2 rcPaint, float tzoom, int tscroll,
            float vzoom, int vscroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public int HitTestFCurves(IParamDimensionBase dim, ITab<ITrackHitRecord> hits, IBox2 rcHit, IBox2 rcGraph, float tzoom, int tscroll,
            float vzoom, int vscroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public int PaintSubFCurves(int subNum, IParamDimensionBase dim, IntPtr hdc, IBox2 rcGraph, IBox2 rcPaint, float tzoom,
            int tscroll, float vzoom, int vscroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public int HitTestSubFCurves(int subNum, IParamDimensionBase dim, ITab<ITrackHitRecord> hits, IBox2 rcHit, IBox2 rcGraph, float tzoom,
            int tscroll, float vzoom, int vscroll, uint flags)
        {
            throw new NotImplementedException();
        }

        public void EditTrackParams(int t, IParamDimensionBase dim, string pname, IntPtr hParent, IIObjParam ip, EditTrackFlags flags)
        {
            throw new NotImplementedException();
        }

        public bool GetFCurveExtents(IParamDimensionBase dim, ref float min, ref float max, DisplayCurveFlags flags)
        {
            throw new NotImplementedException();
        }

        public void AddNoteTrack(INoteTrack note)
        {
            throw new NotImplementedException();
        }

        public void DeleteNoteTrack(INoteTrack note, bool delNote)
        {
            throw new NotImplementedException();
        }

        public INoteTrack GetNoteTrack(int i)
        {
            throw new NotImplementedException();
        }

        public void FreeAllBitmaps()
        {
            throw new NotImplementedException();
        }

        public void GetSystemNodes(IINodeTab nodes, SysNodeContext Context)
        {
            throw new NotImplementedException();
        }

        public void MouseCycleCompleted(int t)
        {
            throw new NotImplementedException();
        }

        public void MouseCycleStarted(int t)
        {
            throw new NotImplementedException();
        }

        public IIParamBlock2 GetParamBlock(int i)
        {
            throw new NotImplementedException();
        }

        public IIParamBlock2 GetParamBlockByID(short id)
        {
            throw new NotImplementedException();
        }

        public bool SvSaveData(IISave isave, ushort id)
        {
            throw new NotImplementedException();
        }

        public bool SvLoadData(IILoad iLoad)
        {
            throw new NotImplementedException();
        }

        public void SvSetRefIndex(uint i)
        {
            throw new NotImplementedException();
        }

        public ISvGraphNodeReference SvTraverseAnimGraph(IIGraphObjectManager gom, IAnimatable owner, int id, uint flags)
        {
            throw new NotImplementedException();
        }

        public ISvGraphNodeReference SvStdTraverseAnimGraph(IIGraphObjectManager gom, IAnimatable owner, int id, uint flags)
        {
            throw new NotImplementedException();
        }

        public bool SvCanInitiateLink(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvCanConcludeLink(IIGraphObjectManager gom, IIGraphNode gNode, IIGraphNode gNodeChild)
        {
            throw new NotImplementedException();
        }

        public string SvGetName(IIGraphObjectManager gom, IIGraphNode gNode, bool isBeingEdited)
        {
            throw new NotImplementedException();
        }

        public bool SvCanSetName(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvSetName(IIGraphObjectManager gom, IIGraphNode gNode, string name)
        {
            throw new NotImplementedException();
        }

        public bool SvCanRemoveThis(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvRemoveThis(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvIsSelected(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvIsHighlighted(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public Color SvHighlightColor(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public Color SvGetSwatchColor(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvIsInactive(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvLinkChild(IIGraphObjectManager gom, IIGraphNode gNodeThis, IIGraphNode gNodeChild)
        {
            throw new NotImplementedException();
        }

        public bool SvHandleDoubleClick(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public IMultiSelectCallback SvGetMultiSelectCallback(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvCanSelect(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvEditProperties(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public string SvGetTip(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public string SvGetRefTip(IIGraphObjectManager gom, IIGraphNode gNode, IIGraphNode gNodeMaker)
        {
            throw new NotImplementedException();
        }

        public bool SvCanDetach(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public bool SvDetach(IIGraphObjectManager gom, IIGraphNode gNode)
        {
            throw new NotImplementedException();
        }

        public string SvGetRelTip(IIGraphObjectManager gom, IIGraphNode gNodeTarget, int id, IIGraphNode gNodeMaker)
        {
            throw new NotImplementedException();
        }

        public bool SvCanDetachRel(IIGraphObjectManager gom, IIGraphNode gNodeTarget, int id, IIGraphNode gNodeMaker)
        {
            throw new NotImplementedException();
        }

        public bool SvDetachRel(IIGraphObjectManager gom, IIGraphNode gNodeTarget, int id, IIGraphNode gNodeMaker)
        {
            throw new NotImplementedException();
        }

        public bool SvHandleRelDoubleClick(IIGraphObjectManager gom, IIGraphNode gNodeTarget, int id, IIGraphNode gNodeMaker)
        {
            throw new NotImplementedException();
        }

        public void AllocCustAttribContainer()
        {
            throw new NotImplementedException();
        }

        public void DeleteCustAttribContainer()
        {
            throw new NotImplementedException();
        }

        public void FreeCaches()
        {
            throw new NotImplementedException();
        }

        public IAnimatable SubAnim(int i)
        {
            throw new NotImplementedException();
        }

        public string SubAnimName(int i)
        {
            throw new NotImplementedException();
        }

        public IAnimatable ChildAnim(int i)
        {
            throw new NotImplementedException();
        }

        public void EditTrack()
        {
            throw new NotImplementedException();
        }

        public bool SubAnimSetKeyBufferPresent(int subNum)
        {
            throw new NotImplementedException();
        }

        public void SubAnimCommitSetKeyBuffer(int t, int subNum)
        {
            throw new NotImplementedException();
        }

        public void CommitSetKeyBuffer(int t)
        {
            throw new NotImplementedException();
        }

        public void SubAnimRevertSetKeyBuffer(int subNum)
        {
            throw new NotImplementedException();
        }

        public void RevertSetKeyBuffer()
        {
            throw new NotImplementedException();
        }

        public IntPtr TrackViewWinProc(IntPtr hwnd, uint message, UIntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        public bool IsSubClassOf(IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        public bool IsParamBlockDesc2Used(IParamBlockDesc2 desc)
        {
            throw new NotImplementedException();
        }

        public bool GetMacroRecorderName(bool used_as_rhs_value, ref string objectSpecifiedName)
        {
            throw new NotImplementedException();
        }

        public SClass_ID SuperClassID { get; }
        public IClass_ID ClassID { get; }
        public bool BypassTreeView { get; }
        public bool BypassTrackBar { get; }
        public bool BypassPropertyLevel { get; }
        public bool InvisibleProperty { get; }
        public int NumKeys { get; }
        public bool CanCopyAnim { get; }
        public bool CanMakeUnique { get; }
        public bool SupportTimeOperations { get; }
        public int FlagKeyIndex { get; }
        public int NumSelKeys { get; }
        public bool IsCurveSelected { get; }
        public bool IsAnimated { get; }
        public TrackParamsFlags TrackParamsType { get; }
        public bool NoteTracks { get; }
        public int NumNoteTracks { get; }
        public int NumParamBlocks { get; }
        public uint SvGetRefIndex { get; }
        public bool SvDeleteRefIndex { get; }
        public IICustAttribContainer CustAttribContainer { get; }
        public int NumSubs { get; }
        public int NumChildren { get; }
        
        public bool SetKeyBufferPresent { get; }
        public bool IsRefMaker { get; }
        public void DeleteMe()
        {
            throw new NotImplementedException();
        }

        public void SetReference(int i, IReferenceTarget rtarg)
        {
            throw new NotImplementedException();
        }

        public IReferenceTarget GetReference(int i)
        {
            throw new NotImplementedException();
        }

        public RefResult NotifyRefChanged(IInterval changeInt, IReferenceTarget hTarget, ref UIntPtr partID, RefMessage message,
            bool propagate)
        {
            throw new NotImplementedException();
        }

        public RefResult ReplaceReference(int which, IReferenceTarget newtarg, bool delOld)
        {
            throw new NotImplementedException();
        }

        public RefResult DeleteAllRefsFromMe()
        {
            throw new NotImplementedException();
        }

        public RefResult DeleteAllRefsToMe()
        {
            throw new NotImplementedException();
        }

        public RefResult DeleteAllRefs()
        {
            throw new NotImplementedException();
        }

        public RefResult DeleteReference(int i)
        {
            throw new NotImplementedException();
        }

        public bool CanTransferReference(int i)
        {
            throw new NotImplementedException();
        }

        public IOResult Save(IISave isave)
        {
            throw new NotImplementedException();
        }

        public IOResult Load(IILoad iload)
        {
            throw new NotImplementedException();
        }

        public int RemapRefOnLoad(int iref)
        {
            throw new NotImplementedException();
        }

        public void RescaleWorldUnits(float f)
        {
            throw new NotImplementedException();
        }

        public RefResult NotifyDependents_(IInterval changeInt, UIntPtr partID, RefMessage message, SClass_ID sclass, bool propagate,
            IReferenceTarget hTarg)
        {
            throw new NotImplementedException();
        }

        public void SaveEnum(ISaveEnumProc sep, bool isNodeCall)
        {
            throw new NotImplementedException();
        }

        public bool SpecifySaveReferences(IReferenceSaveManager referenceSaveManager)
        {
            throw new NotImplementedException();
        }

        public int DoEnumDependents(IDependentEnumProc dep)
        {
            throw new NotImplementedException();
        }

        public int DoEnumDependentsImpl(IDependentEnumProc dep)
        {
            throw new NotImplementedException();
        }

        public bool EnumRefHierarchy(IRefEnumProc proc, bool includeCustAttribs, bool includeIndirectRefs,
            bool includeNonPersistentRefs, bool preventDuplicatesViaFlag)
        {
            throw new NotImplementedException();
        }

        public int FindRef(IReferenceTarget rtarg)
        {
            throw new NotImplementedException();
        }

        public bool IsRealDependency(IReferenceTarget rtarg)
        {
            throw new NotImplementedException();
        }

        public bool ShouldPersistWeakRef(IReferenceTarget rtarg)
        {
            throw new NotImplementedException();
        }

        public int NumRefs { get; }
        public IReferenceSaveManager ReferenceSaveManager { get; }
        public bool IsRefTarget { get; }
        public RefResult AutoDelete()
        {
            throw new NotImplementedException();
        }

        public RefResult MaybeAutoDelete()
        {
            throw new NotImplementedException();
        }

        public RefResult TestForLoop(IInterval refInterval, IReferenceMaker hmaker)
        {
            throw new NotImplementedException();
        }

        public void BeginDependencyTest()
        {
            throw new NotImplementedException();
        }

        public void RefAdded(IReferenceMaker rm)
        {
            throw new NotImplementedException();
        }

        public void RefAddedUndoRedo(IReferenceMaker rm)
        {
            throw new NotImplementedException();
        }

        public void RefDeleted()
        {
            throw new NotImplementedException();
        }

        public void RefDeletedUndoRedo()
        {
            throw new NotImplementedException();
        }

        public RefResult TransferReferences(IReferenceTarget oldTarget, bool delOld)
        {
            throw new NotImplementedException();
        }

        public IReferenceTarget Clone(IRemapDir remap)
        {
            throw new NotImplementedException();
        }

        public void BaseClone(IReferenceTarget @from, IReferenceTarget to, IRemapDir remap)
        {
            throw new NotImplementedException();
        }

        public void FlagDependents(int t, UIntPtr which)
        {
            throw new NotImplementedException();
        }

        public void NotifyForeground(int t)
        {
            throw new NotImplementedException();
        }

        public void NotifyTarget(int message, IReferenceMaker hMaker)
        {
            throw new NotImplementedException();
        }

        public bool Dependents { get; }
        public bool RealDependents { get; }
        public bool EndDependencyTest { get; }

        public int Open(IINode scene, IINode vnode, IViewParams viewPar, IRendParams rp, IntPtr hwnd, IDefaultLight defaultLights,
            int numDefLights, IRendProgressCallback prog)
        {
            throw new NotImplementedException();
        }

        public int Render(int t, IBitmap tobm, IFrameRendParams frp, IntPtr hwnd, IRendProgressCallback prog, IViewParams viewPar)
        {
            throw new NotImplementedException();
        }

        public void Close(IntPtr hwnd, IRendProgressCallback prog)
        {
            throw new NotImplementedException();
        }

        public bool ApplyRenderEffects(int t, IBitmap pBitmap, bool updateDisplay)
        {
            throw new NotImplementedException();
        }

        public IRendParamDlg CreateParamDialog(IIRendParams ir, bool prog)
        {
            throw new NotImplementedException();
        }

        public void ResetParams()
        {
            throw new NotImplementedException();
        }

        public bool RenderPresetsIsCompatible(int version)
        {
            throw new NotImplementedException();
        }

        public string RenderPresetsMapIndexToCategory(int catIndex)
        {
            throw new NotImplementedException();
        }

        public int RenderPresetsMapCategoryToIndex(string category)
        {
            throw new NotImplementedException();
        }

        public int RenderPresetsPreSave(IITargetedIO root, IBitArray saveCategories)
        {
            throw new NotImplementedException();
        }

        public int RenderPresetsPostSave(IITargetedIO root, IBitArray loadCategories)
        {
            throw new NotImplementedException();
        }

        public int RenderPresetsPreLoad(IITargetedIO root, IBitArray saveCategories)
        {
            throw new NotImplementedException();
        }

        public int RenderPresetsPostLoad(IITargetedIO root, IBitArray loadCategories)
        {
            throw new NotImplementedException();
        }

        public int AAFilterSupport { get; }
        public bool SupportsTexureBaking { get; }
        public bool SupportsCustomRenderPresets { get; }
        public int RenderPresetsFileVersion { get; }

        public void AdjustTangents(ITrackHitRecord hit, IParamDimensionBase dim, float angle, float length, uint flags)
        {
            throw new NotImplementedException();
        }

        public RefResult NotifyDependents(IInterval changeInt, UIntPtr partID, RefMessage message, SClass_ID sclass, bool propagate,
            IReferenceTarget hTarg, NotifyDependentsOption notifyDependentsOption)
        {
            throw new NotImplementedException();
        }

        public void StopRendering()
        {
            throw new NotImplementedException();
        }

        public void PauseRendering()
        {
            throw new NotImplementedException();
        }

        public void ResumeRendering()
        {
            throw new NotImplementedException();
        }

        public bool HasRequirement(Requirement requirement)
        {
            throw new NotImplementedException();
        }

        public bool CompatibleWithRenderElement(IIRenderElement pIRenderElement)
        {
            throw new NotImplementedException();
        }

        public void GetVendorInformation(ref string info)
        {
            throw new NotImplementedException();
        }

        public void GetPlatformInformation(ref string info)
        {
            throw new NotImplementedException();
        }

        public bool IsStopSupported { get; }
        public PauseSupport IsPauseSupported { get; }
        public bool CompatibleWithAnyRenderElement { get; }
        public IIInteractiveRender IInteractiveRender { get; }
    }
}
