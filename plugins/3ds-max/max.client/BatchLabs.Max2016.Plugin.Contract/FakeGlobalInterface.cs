
using System;
using System.Drawing;

using Autodesk.Max;
using Autodesk.Max.IImageViewer;
using Autodesk.Max.IRendererRequirements;
using Autodesk.Max.MaxSDK;
using Autodesk.Max.MaxSDK.Graphics;
using Autodesk.Max.MaxSDK.Util;

using BatchLabs.Max2016.Plugin.Contract.Stubs;

namespace BatchLabs.Max2016.Plugin.Contract
{
    /// <summary>
    /// Implement what we need in here to get the test handler running. Would prefer to use 
    /// dependancy injection, but unsure how that will work with Max application code. 
    /// </summary>
    public class FakeGlobalInterface : IGlobal
    {
        private IInterface16 _interface16;
        private IIColorManager _colorMananger;

        public FakeGlobalInterface()
        {
            _interface16 = new Interface16Stub();
            _colorMananger = new ColorManagerStub();
        }

        public override IInterface16 COREInterface16 => _interface16;

        public override IIColorManager ColorManager => _colorMananger;

        #region Unused Properties and Overrides

        public override void _QuatToEuler(IQuat q, IntPtr ang)
        {
            throw new NotImplementedException();
        }

        public override void _EulerToQuat(IntPtr ang, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override bool DLGetWindowLongPtr(IntPtr hWnd, int n, bool param2)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetWindowProc(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetWindowProcA(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetWindowProcW(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetWindowInstance(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override bool DLSetWindowLongPtr(IntPtr hWnd, bool bo, int n)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLSetWindowLongPtr(IntPtr hWnd, IntPtr pfn)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLSetWindowProc(IntPtr hWnd, IntPtr pfn)
        {
            throw new NotImplementedException();
        }

        public override bool DLGetClassLongPtr(IntPtr hWnd, int n, bool param2)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetClassWindowProc(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetClassWindowProcA(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLGetClassWindowProcW(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override bool DLSetClassLongPtr(IntPtr hWnd, bool bo, int n)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLSetClassWindowProc(IntPtr hWnd, IntPtr pfn)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLSetClassWindowProcA(IntPtr hWnd, IntPtr pfn)
        {
            throw new NotImplementedException();
        }

        public override IntPtr DLSetClassWindowProcW(IntPtr hWnd, IntPtr pfn)
        {
            throw new NotImplementedException();
        }

        public override bool DLTextOut(IntPtr hDC, int x, int y, string text)
        {
            throw new NotImplementedException();
        }

        public override int DLTabbedTextOut(IntPtr hDC, int x, int y, string text, int nTabs, IntPtr pTabPositions, int nTabOrigin)
        {
            throw new NotImplementedException();
        }

        public override uint Fnv32Buf(IntPtr buf, int len, uint hval)
        {
            throw new NotImplementedException();
        }

        public override int DlAbs(int n)
        {
            throw new NotImplementedException();
        }

        public override long DlAbs(long n)
        {
            throw new NotImplementedException();
        }

        public override float DlAbs(float f)
        {
            throw new NotImplementedException();
        }

        public override double DlAbs(double f)
        {
            throw new NotImplementedException();
        }

        public override double DlAbs_(double f)
        {
            throw new NotImplementedException();
        }

        public override IAColor Multiply(float f, IAColor a)
        {
            throw new NotImplementedException();
        }

        public override IAColor Multiply(IAColor a, float f)
        {
            throw new NotImplementedException();
        }

        public override IAColor CompOver(IAColor fg, IAColor bg)
        {
            throw new NotImplementedException();
        }

        public override IAppLoad NewAppLoad(IntPtr buf, int bufSize)
        {
            throw new NotImplementedException();
        }

        public override IAppSave NewAppSave(int initBufSize)
        {
            throw new NotImplementedException();
        }

        public override IArcballDialog CreateArcballDialog(IArcballCallback cb, IntPtr hwndOwner, string title)
        {
            throw new NotImplementedException();
        }

        public override int Assert1(int line, string file, string function, string expr)
        {
            throw new NotImplementedException();
        }

        public override int Assert1_(int line, string file, string function, string expr)
        {
            throw new NotImplementedException();
        }

        public override ICAssertCB SetAssertCB(ICAssertCB cb)
        {
            throw new NotImplementedException();
        }

        public override void DeclareBitmapAsset(IIEnumAuxAssetsCallback enumCallback, IIAssetAccessor anAccessor, IBitmapInfo bitmapInfo,
            int flags)
        {
            throw new NotImplementedException();
        }

        public override IBitmapStorage BMMCreateStorage(IBitmapManager manager, uint type)
        {
            throw new NotImplementedException();
        }

        public override IBitmapFilter BMMCreateFilter(IBitmapManager manager, uint type)
        {
            throw new NotImplementedException();
        }

        public override IBitmapDither BMMCreateDither(IBitmapManager manager, uint type)
        {
            throw new NotImplementedException();
        }

        public override int BMMCalcPalette(IBitmap map, int colors, IBMM_Color_48 palette)
        {
            throw new NotImplementedException();
        }

        public override byte BMMClosestColor(IBMM_Color_64 color, IBMM_Color_48 palette, int colors)
        {
            throw new NotImplementedException();
        }

        public override string BMMGetBitmapTypeDescription(int bitmapType, uint bitmapFlags)
        {
            throw new NotImplementedException();
        }

        public override void OpenBMM(IBMMInterface i)
        {
            throw new NotImplementedException();
        }

        public override void CloseBMM()
        {
            throw new NotImplementedException();
        }

        public override int BMMCreateNumberedFilename(string namein, int frame, string nameout)
        {
            throw new NotImplementedException();
        }

        public override int BMMFindNumberedFilenames(IPath baseFilename, IArray<IPath> foundFiles)
        {
            throw new NotImplementedException();
        }

        public override int BMMGetFullFilename(IBitmapInfo bi)
        {
            throw new NotImplementedException();
        }

        public override bool BMMGetFullFilename(string namein, string nameout)
        {
            throw new NotImplementedException();
        }

        public override bool BMMIsFile(string filename)
        {
            throw new NotImplementedException();
        }

        public override void BMMSplitFilename(string name, string directory, string filename, string extension)
        {
            throw new NotImplementedException();
        }

        public override void BMMAppendSlash(string path)
        {
            throw new NotImplementedException();
        }

        public override void BMMRemoveSlash(string path)
        {
            throw new NotImplementedException();
        }

        public override void BMMAppendSlash(ref string path)
        {
            throw new NotImplementedException();
        }

        public override void BMMRemoveSlash(ref string path)
        {
            throw new NotImplementedException();
        }

        public override bool BMMGetUniversalName(string out_uncname, string in_path)
        {
            throw new NotImplementedException();
        }

        public override bool BMMFindNetworkShare(string in_localpath, string out_sharename, string out_sharepath)
        {
            throw new NotImplementedException();
        }

        public override bool BMMGetLocalShare(string local_path, string share)
        {
            throw new NotImplementedException();
        }

        public override IColorPacker BMMNewColorPacker(int w, IBMM_Color_48 pal, int npal, IntPtr remap)
        {
            throw new NotImplementedException();
        }

        public override void FixPaletteForWindows(IBMM_Color_48 pal, IBMM_Color_48 newpal, int ncols, IntPtr remap)
        {
            throw new NotImplementedException();
        }

        public override void PushAllocFrame()
        {
            throw new NotImplementedException();
        }

        public override void PopAllocFrame()
        {
            throw new NotImplementedException();
        }

        public override void PopAllocFrame(ref IValue result)
        {
            throw new NotImplementedException();
        }

        public override void MsFree(IntPtr p)
        {
            throw new NotImplementedException();
        }

        public override void MsMakeCollectable(ICollectable v)
        {
            throw new NotImplementedException();
        }

        public override IRealPixel MakeRealPixel(float r, float g, float b)
        {
            throw new NotImplementedException();
        }

        public override void ExpandRealPixel(IRealPixel rp, ref float r, ref float g, ref float b)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IColor param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IColor param0)
        {
            throw new NotImplementedException();
        }

        public override float MaxVal(IColor param0)
        {
            throw new NotImplementedException();
        }

        public override float MinVal(IColor param0)
        {
            throw new NotImplementedException();
        }

        public override float Length(IColor v)
        {
            throw new NotImplementedException();
        }

        public override IColor Multiply(float f, IColor a)
        {
            throw new NotImplementedException();
        }

        public override IColor Multiply(IColor a, float f)
        {
            throw new NotImplementedException();
        }

        public override IColor Divide(IColor a, float f)
        {
            throw new NotImplementedException();
        }

        public override IColor Add(IColor a, float f)
        {
            throw new NotImplementedException();
        }

        public override IColor Add(float f, IColor a)
        {
            throw new NotImplementedException();
        }

        public override IColor Subtract(IColor a, float f)
        {
            throw new NotImplementedException();
        }

        public override IColor Subtract(float f, IColor a)
        {
            throw new NotImplementedException();
        }

        public override void ApplyScaling(IMatrix3 m, IScaleValue v)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Add(IScaleValue s0, IScaleValue s1)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Subtract(IScaleValue s0, IScaleValue s1)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Multiply(IScaleValue s, float f)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Multiply(float f, IScaleValue s)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Add(IScaleValue s, float f)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue Add(float f, IScaleValue s)
        {
            throw new NotImplementedException();
        }

        public override int CycleTime(IInterval i, int t)
        {
            throw new NotImplementedException();
        }

        public override int NumCycles(IInterval i, int t)
        {
            throw new NotImplementedException();
        }

        public override IQuat LinearExtrapolate(int t0, int t1, IQuat val0, IQuat val1, IQuat endVal)
        {
            throw new NotImplementedException();
        }

        public override IQuat RepeatExtrapolate(IInterval range, int t, IQuat startVal, IQuat endVal, IQuat cycleVal)
        {
            throw new NotImplementedException();
        }

        public override IQuat IdentityExtrapolate(int endPoint, int t, IQuat endVal)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue LinearExtrapolate(int t0, int t1, IScaleValue val0, IScaleValue val1, IScaleValue endVal)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue RepeatExtrapolate(IInterval range, int t, IScaleValue startVal, IScaleValue endVal, IScaleValue cycleVal)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue IdentityExtrapolate(int endPoint, int t, IScaleValue endVal)
        {
            throw new NotImplementedException();
        }

        public override IQuat LinearInterpolate(IQuat v0, IQuat v1, float u)
        {
            throw new NotImplementedException();
        }

        public override IScaleValue LinearInterpolate(IScaleValue v0, IScaleValue v1, float u)
        {
            throw new NotImplementedException();
        }

        public override IInterval TestInterval(IInterval iv, uint flags)
        {
            throw new NotImplementedException();
        }

        public override IQuat ScaleQuat(IQuat q, float s)
        {
            throw new NotImplementedException();
        }

        public override void AnimateOn()
        {
            throw new NotImplementedException();
        }

        public override void AnimateOff()
        {
            throw new NotImplementedException();
        }

        public override void SuspendAnimate()
        {
            throw new NotImplementedException();
        }

        public override void ResumeAnimate()
        {
            throw new NotImplementedException();
        }

        public override bool AreWeAnimating(int t)
        {
            throw new NotImplementedException();
        }

        public override bool AreWeKeying(int t)
        {
            throw new NotImplementedException();
        }

        public override IControl NewDefaultMatrix3Controller()
        {
            throw new NotImplementedException();
        }

        public override IControl CreateInterpFloat()
        {
            throw new NotImplementedException();
        }

        public override IControl CreateInterpPosition()
        {
            throw new NotImplementedException();
        }

        public override IControl CreateInterpRotation()
        {
            throw new NotImplementedException();
        }

        public override IControl CreateInterpScale()
        {
            throw new NotImplementedException();
        }

        public override IControl CreatePRSControl()
        {
            throw new NotImplementedException();
        }

        public override IControl CreateLookatControl()
        {
            throw new NotImplementedException();
        }

        public override void SetDefaultController(SClass_ID sid, IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override IClassDesc GetDefaultController(SClass_ID sid)
        {
            throw new NotImplementedException();
        }

        public override void SetDefaultColorController(IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override void SetDefaultFRGBAController(IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override void SetDefaultBoolController(IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override void SuspendSetKeyMode()
        {
            throw new NotImplementedException();
        }

        public override void ResumeSetKeyMode()
        {
            throw new NotImplementedException();
        }

        public override IIPublishedCustAttrib GetPublishedCustAttribInterface(IInterfaceServer iServer)
        {
            throw new NotImplementedException();
        }

        public override void MakeBrushesSolid(bool onOff)
        {
            throw new NotImplementedException();
        }

        public override void UpdateButtonOutlines()
        {
            throw new NotImplementedException();
        }

        public override IICUIFrame GetICUIFrame(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICUIFrame(IICUIFrame icf)
        {
            throw new NotImplementedException();
        }

        public override IntPtr CreateCUIFrameWindow(IntPtr hParent, string title, int x, int y, int cx, int cy)
        {
            throw new NotImplementedException();
        }

        public override void DoCUICustomizeDialog()
        {
            throw new NotImplementedException();
        }

        public override void ResizeFloatingTB(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override IISpinnerControl GetISpinner(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseISpinner(IISpinnerControl isc)
        {
            throw new NotImplementedException();
        }

        public override IISliderControl GetISlider(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseISlider(IISliderControl isc)
        {
            throw new NotImplementedException();
        }

        public override IISliderControl SetupIntSlider(IntPtr hwnd, int idSlider, int idEdit, int min, int max, int val, int numSegs)
        {
            throw new NotImplementedException();
        }

        public override IISliderControl SetupFloatSlider(IntPtr hwnd, int idSlider, int idEdit, float min, float max, float val, int numSegs)
        {
            throw new NotImplementedException();
        }

        public override IISliderControl SetupUniverseSlider(IntPtr hwnd, int idSlider, int idEdit, float min, float max, float val,
            int numSegs)
        {
            throw new NotImplementedException();
        }

        public override bool IsRollupPanelOpen(IntPtr hDlg)
        {
            throw new NotImplementedException();
        }

        public override IIRollupWindow GetIRollup(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIRollup(IIRollupWindow irw)
        {
            throw new NotImplementedException();
        }

        public override IICustEdit GetICustEdit(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustEdit(IICustEdit ice)
        {
            throw new NotImplementedException();
        }

        public override IICustStatusEdit GetICustStatusEdit(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustStatusEdit(IICustStatusEdit ice)
        {
            throw new NotImplementedException();
        }

        public override IICustButton GetICustButton(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustButton(IICustButton icb)
        {
            throw new NotImplementedException();
        }

        public override IICustStatus GetICustStatus(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustStatus(IICustStatus ics)
        {
            throw new NotImplementedException();
        }

        public override IICustSeparator GetICustSeparator(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustSeparator(IICustSeparator ics)
        {
            throw new NotImplementedException();
        }

        public override IICustToolbar GetICustToolbar(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustToolbar(IICustToolbar ict)
        {
            throw new NotImplementedException();
        }

        public override IIVertToolbar GetIVertToolbar(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIVertToolbar(IIVertToolbar ict)
        {
            throw new NotImplementedException();
        }

        public override IICustImage GetICustImage(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseICustImage(IICustImage ici)
        {
            throw new NotImplementedException();
        }

        public override IIOffScreenBuf CreateIOffScreenBuf(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override void DestroyIOffScreenBuf(IIOffScreenBuf iBuf)
        {
            throw new NotImplementedException();
        }

        public override IIColorSwatch GetIColorSwatch(IntPtr hCtrl, IColor col, string name)
        {
            throw new NotImplementedException();
        }

        public override IIColorSwatch GetIColorSwatch(IntPtr hCtrl, IAColor col, string name)
        {
            throw new NotImplementedException();
        }

        public override IIColorSwatch GetIColorSwatch(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIColorSwatch(IIColorSwatch ics)
        {
            throw new NotImplementedException();
        }

        public override void RefreshAllColorSwatches()
        {
            throw new NotImplementedException();
        }

        public override IIDADWindow GetIDADWindow(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIDADWindow(IIDADWindow idw)
        {
            throw new NotImplementedException();
        }

        public override void InstallThumbTack(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        public override void RemoveThumbTack(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        public override IISpinnerControl SetupIntSpinner(IntPtr hwnd, int idSpin, int idEdit, int min, int max, int val)
        {
            throw new NotImplementedException();
        }

        public override IISpinnerControl SetupFloatSpinner(IntPtr hwnd, int idSpin, int idEdit, float min, float max, float val, float scale)
        {
            throw new NotImplementedException();
        }

        public override IISpinnerControl SetupUniverseSpinner(IntPtr hwnd, int idSpin, int idEdit, float min, float max, float val,
            float scale)
        {
            throw new NotImplementedException();
        }

        public override void DisableAccelerators()
        {
            throw new NotImplementedException();
        }

        public override void EnableAccelerators()
        {
            throw new NotImplementedException();
        }

        public override void SetSaveRequiredFlag(bool requireSave, bool requireAutoBackupSave)
        {
            throw new NotImplementedException();
        }

        public override void SpectralDecomp(IMatrix3 m, IPoint3 s, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override void DecompAffine(IMatrix3 A, IAffineParts parts)
        {
            throw new NotImplementedException();
        }

        public override void InvertAffine(IAffineParts parts, IAffineParts inverse)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 RotateXMatrix(double angle)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 RotateYMatrix(double angle)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 RotateZMatrix(double angle)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 TransMatrix(IDPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 RotateYPRMatrix(double yaw, double pitch, double roll)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 RotAngleAxisMatrix(IDPoint3 axis, double angle)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 Inverse(IDMatrix3 m)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Multiply(IDMatrix3 a, IDPoint3 v)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Multiply(IDPoint3 v, IDMatrix3 a)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 VectorTransform(IDMatrix3 m, IDPoint3 v)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 VectorTransform(IDPoint3 v, IDMatrix3 m)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 TransformPlane(IDMatrix3 m, IPoint4 plane)
        {
            throw new NotImplementedException();
        }

        public override IDMatrix3 XFormMat(IDMatrix3 xm, IDMatrix3 m)
        {
            throw new NotImplementedException();
        }

        public override void MirrorMatrix(IDMatrix3 tm, Axis axis, bool scaleMatrix)
        {
            throw new NotImplementedException();
        }

        public override void MatrixMultiply(IDMatrix3 outMatrix, IDMatrix3 matrixA, IDMatrix3 matrixB)
        {
            throw new NotImplementedException();
        }

        public override void Inverse(IDMatrix3 outMatrix, IDMatrix3 m)
        {
            throw new NotImplementedException();
        }

        public override double Length(IDPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IDPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IDPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Normalize(IDPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Multiply(double param0, IDPoint3 param1)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Multiply(IDPoint3 param0, double param1)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 Divide(IDPoint3 param0, double param1)
        {
            throw new NotImplementedException();
        }

        public override IDPoint3 CrossProd(IDPoint3 a, IDPoint3 b)
        {
            throw new NotImplementedException();
        }

        public override double DotProd(IDPoint3 a, IDPoint3 b)
        {
            throw new NotImplementedException();
        }

        public override void QuatToEuler(IQuat q, IntPtr ang, int type, bool flag)
        {
            throw new NotImplementedException();
        }

        public override void EulerToQuat(IntPtr ang, IQuat q, int type)
        {
            throw new NotImplementedException();
        }

        public override void MatrixToEuler(IMatrix3 mat, IntPtr ang, int type, bool flag)
        {
            throw new NotImplementedException();
        }

        public override void EulerToMatrix(IntPtr ang, IMatrix3 mat, int type)
        {
            throw new NotImplementedException();
        }

        public override float GetEulerQuatAngleRatio(IQuat quat1, IQuat quat2, IntPtr euler1, IntPtr euler2, int type)
        {
            throw new NotImplementedException();
        }

        public override float GetEulerMatAngleRatio(IMatrix3 mat1, IMatrix3 mat2, IntPtr euler1, IntPtr euler2, int type)
        {
            throw new NotImplementedException();
        }

        public override IExposureMaterialControl GetExposureMaterialControl(IInterfaceServer mtl)
        {
            throw new NotImplementedException();
        }

        public override void OpenFLT(IFLTInterface i)
        {
            throw new NotImplementedException();
        }

        public override void CloseFLT()
        {
            throw new NotImplementedException();
        }

        public override Color GammaCorrect(uint c)
        {
            throw new NotImplementedException();
        }

        public override byte GammaCorrect(byte b)
        {
            throw new NotImplementedException();
        }

        public override float GammaCorrect(float v, float gamma)
        {
            throw new NotImplementedException();
        }

        public override float DeGammaCorrect(float v, float gamma)
        {
            throw new NotImplementedException();
        }

        public override byte GammaCorrect(byte v, float gamma)
        {
            throw new NotImplementedException();
        }

        public override byte DeGammaCorrect(byte v, float gamma)
        {
            throw new NotImplementedException();
        }

        public override ushort GammaCorrect(ushort c, float gamma)
        {
            throw new NotImplementedException();
        }

        public override ushort DeGammaCorrect(ushort c, float gamma)
        {
            throw new NotImplementedException();
        }

        public override int GBDataSize(int i)
        {
            throw new NotImplementedException();
        }

        public override string GBChannelName(int i)
        {
            throw new NotImplementedException();
        }

        public override void SinCos(float angle, IntPtr sine, IntPtr cosine)
        {
            throw new NotImplementedException();
        }

        public override float Sin(float angle)
        {
            throw new NotImplementedException();
        }

        public override float Cos(float angle)
        {
            throw new NotImplementedException();
        }

        public override float Sqrt(float arg)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 GetUIColor(int which)
        {
            throw new NotImplementedException();
        }

        public override void SetUIColor(int which, IPoint3 clr)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 GetDefaultUIColor(int which)
        {
            throw new NotImplementedException();
        }

        public override int Abs(int x)
        {
            throw new NotImplementedException();
        }

        public override int WIsFacingBack(IIPoint3 v0, IIPoint3 v1, IIPoint3 v2, int flip)
        {
            throw new NotImplementedException();
        }

        public override int HIsFacingBack(IIPoint3 v0, IIPoint3 v1, IIPoint3 v2, int flip)
        {
            throw new NotImplementedException();
        }

        public override FacingType WFacingType(IIPoint3 v0, IIPoint3 v1, IIPoint3 v2, int flip)
        {
            throw new NotImplementedException();
        }

        public override FacingType HFacingType(IIPoint3 v0, IIPoint3 v1, IIPoint3 v2, int flip)
        {
            throw new NotImplementedException();
        }

        public override IGraphicsWindow CreateGW(IntPtr hWnd, IGWinSetup gws)
        {
            throw new NotImplementedException();
        }

        public override void GetRegionRect(IHitRegion hr, Rectangle rect)
        {
            throw new NotImplementedException();
        }

        public override int DistToLine(int x, int y, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override float DistToSegment(int x, int y, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override int ZDepthToLine(int x, int y, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override int LineCrossesRect(Rectangle rc, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override int SegCrossesRect(Rectangle rc, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override int SegCrossesCircle(int cx, int cy, int r, IntPtr p1, IntPtr p2)
        {
            throw new NotImplementedException();
        }

        public override bool InsideTriangle(IIPoint3 p0, IIPoint3 p1, IIPoint3 p2, IIPoint3 q)
        {
            throw new NotImplementedException();
        }

        public override int GetZfromTriangle(IIPoint3 p0, IIPoint3 p1, IIPoint3 p2, IIPoint3 q)
        {
            throw new NotImplementedException();
        }

        public override int GetClosestPowerOf2(int num)
        {
            throw new NotImplementedException();
        }

        public override void OpenGUP(IGUPInterface i)
        {
            throw new NotImplementedException();
        }

        public override void CloseGUP()
        {
            throw new NotImplementedException();
        }

        public override IGUP OpenGupPlugIn(IClass_ID id)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 BaryCoords(IPoint3 p0, IPoint3 p1, IPoint3 p2, IPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 BaryCoords(IPoint2 p0, IPoint2 p1, IPoint2 p2, IPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override bool RayHitsBox(IRay ray, IBox3 b)
        {
            throw new NotImplementedException();
        }

        public override float DistPtToLine(IPoint2 p0, IPoint2 p1, IPoint2 q)
        {
            throw new NotImplementedException();
        }

        public override float Dist3DPtToLine(IPoint3 p0, IPoint3 p1, IPoint3 q)
        {
            throw new NotImplementedException();
        }

        public override IUVTangentVectors ComputeUVTangents(IPoint3 p0, IPoint3 p1, IPoint3 p2, IPoint2 uv0, IPoint2 uv1, IPoint2 uv2)
        {
            throw new NotImplementedException();
        }

        public override uint CompressNormal(IPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 DeCompressNormal(uint n)
        {
            throw new NotImplementedException();
        }

        public override void ArbAxis(IPoint3 zAxis, IMatrix3 matrix)
        {
            throw new NotImplementedException();
        }

        public override int DefaultEqFn(IntPtr key1, IntPtr key2)
        {
            throw new NotImplementedException();
        }

        public override UIntPtr DefaultHashFn(IntPtr key)
        {
            throw new NotImplementedException();
        }

        public override void BuildHotTable(int video_type)
        {
            throw new NotImplementedException();
        }

        public override int HotLimit(IColor48 thepix, int method)
        {
            throw new NotImplementedException();
        }

        public override IntPtr HSVDlgDo(IntPtr hwndOwner, IntPtr lpc, IIPoint2 spos, IHSVCallback callBack, string name)
        {
            throw new NotImplementedException();
        }

        public override IntPtr HSVDlgDo(IntPtr hwndOwner, IAColor lpc, IIPoint2 spos, IHSVCallback callBack, string name)
        {
            throw new NotImplementedException();
        }

        public override void RGBtoHSV(uint rgb, IntPtr ho, IntPtr so, IntPtr vo)
        {
            throw new NotImplementedException();
        }

        public override uint HSVtoRGB(int H, int S, int V)
        {
            throw new NotImplementedException();
        }

        public override void HSVtoHWBt(int h, int s, int v, IntPtr ho, IntPtr w, IntPtr bt)
        {
            throw new NotImplementedException();
        }

        public override void HWBttoHSV(int h, int w, int bt, IntPtr ho, IntPtr s, IntPtr v)
        {
            throw new NotImplementedException();
        }

        public override IColor RGBtoHSV(IColor rgb)
        {
            throw new NotImplementedException();
        }

        public override IColor HSVtoRGB(IColor hsv)
        {
            throw new NotImplementedException();
        }

        public override IColorPicker CreateColorPicker(IntPtr hwndOwner, uint initColor, IIPoint2 spos, IHSVCallback pcallback, string name,
            int objClr)
        {
            throw new NotImplementedException();
        }

        public override IColorPicker CreateColorPicker(IntPtr hwndOwner, IAColor initColor, IIPoint2 spos, IHSVCallback pcallback, string name,
            int objClr)
        {
            throw new NotImplementedException();
        }

        public override IColPick SetCurColPick(IColPick colpick)
        {
            throw new NotImplementedException();
        }

        public override IIAssembly GetAssemblyInterface(IBaseInterface baseIfc)
        {
            throw new NotImplementedException();
        }

        public override void SaveColors()
        {
            throw new NotImplementedException();
        }

        public override void DeleteColorManager(IIColorManager pColorMan)
        {
            throw new NotImplementedException();
        }

        public override IFPInterface GetFPInterface(IBaseInterface bi)
        {
            throw new NotImplementedException();
        }

        public override IFPInterfaceDesc GetFPInterfaceDesc(IBaseInterface bi)
        {
            throw new NotImplementedException();
        }

        public override IFPMixinInterface GetFPMixinInterface(IBaseInterface bi)
        {
            throw new NotImplementedException();
        }

        public override IIMaxBitmapViewer CreateIMaxBitmapViewer(IBitmap pBitmap, DisplayStyle displayStyle)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIMaxBitmapViewer(IIMaxBitmapViewer param0)
        {
            throw new NotImplementedException();
        }

        public override IIKMasterControl CreateIKMasterControl()
        {
            throw new NotImplementedException();
        }

        public override IIKSlaveControl CreateIKSlaveControl(IIKMasterControl master, IINode slaveNode)
        {
            throw new NotImplementedException();
        }

        public override void InitMacroScriptDir()
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals(IItemID a, IItemID b)
        {
            throw new NotImplementedException();
        }

        public override Color MakeCOLORREF(IColor c)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIMenuItem(IIMenuItem param0)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIMenu(IIMenu param0)
        {
            throw new NotImplementedException();
        }

        public override void ReleaseIQuadMenu(IIQuadMenu param0)
        {
            throw new NotImplementedException();
        }

        public override IimrShader GetIMRShader(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override bool IsIMRShader(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IReferenceTarget GetReferenceTarget(IimrShader shader)
        {
            throw new NotImplementedException();
        }

        public override IimrShaderClassDesc GetMrShaderClassDesc(IClassDesc cd)
        {
            throw new NotImplementedException();
        }

        public override IimrShaderTranslation GetIMRShaderTranslation(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IimrMaterialPhenomenonTranslation GetIMRMaterialPhenomenonTranslation(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IimrGeomShaderTranslation GetIMRGeomShaderTranslation(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IimrShaderTranslation_ClassInfo GetImrShaderTranslationClassInfo(IClassDesc mtlBaseClassDesc)
        {
            throw new NotImplementedException();
        }

        public override float Intens(IAColor c)
        {
            throw new NotImplementedException();
        }

        public override float Intens(IColor c)
        {
            throw new NotImplementedException();
        }

        public override void DiscardISect(IISect is_)
        {
            throw new NotImplementedException();
        }

        public override void SetLoadingMtlLib(IMtlLib ml)
        {
            throw new NotImplementedException();
        }

        public override void SetLoadingMtlBaseLib(IMtlBaseLib ml)
        {
            throw new NotImplementedException();
        }

        public override bool IsMtl(IAnimatable m)
        {
            throw new NotImplementedException();
        }

        public override bool IsTex(IAnimatable m)
        {
            throw new NotImplementedException();
        }

        public override bool IsMtlBase(IAnimatable m)
        {
            throw new NotImplementedException();
        }

        public override IMtl CombineMaterials(IMtl mat1, IMtl mat2, ref int mat2Offset)
        {
            throw new NotImplementedException();
        }

        public override IMtl FitMaterialToMeshIDs(IMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl FitMaterialToShapeIDs(IBezierShape shape, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl FitMaterialToPatchIDs(IPatchMesh patch, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl FitMaterialToPolyMeshIDs(IMNMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override void FitMeshIDsToMaterial(IMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override void FitShapeIDsToMaterial(IBezierShape shape, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override void FitPatchIDsToMaterial(IPatchMesh patch, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override void FitPolyMeshIDsToMaterial(IMNMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl CondenseMatAssignments(IMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl CondenseMatAssignments(IBezierShape shape, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl CondenseMatAssignments(IPatchMesh patch, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override IMtl CondenseMatAssignments(IMNMesh mesh, IMtl mat)
        {
            throw new NotImplementedException();
        }

        public override bool DoAttachMatOptionDialog(IIObjParam ip, IAttachMatDlgUser user)
        {
            throw new NotImplementedException();
        }

        public override void DeleteINodeTransformed(IINodeTransformed n)
        {
            throw new NotImplementedException();
        }

        public override IINodeTransformed CreateINodeTransformed(IINode n, IMatrix3 tm, bool dm)
        {
            throw new NotImplementedException();
        }

        public override void QuatBeginIKParams(IControl cont, IIObjParam ip, uint flags, IAnimatable prev)
        {
            throw new NotImplementedException();
        }

        public override bool CanCopyIKParams(IControl cont, int which)
        {
            throw new NotImplementedException();
        }

        public override IIKClipObject CopyIKParams(IControl cont, int which)
        {
            throw new NotImplementedException();
        }

        public override bool CanPasteIKParams(IControl cont, IIKClipObject co, int which)
        {
            throw new NotImplementedException();
        }

        public override void PasteIKParams(IControl cont, IIKClipObject co, int which)
        {
            throw new NotImplementedException();
        }

        public override void EscapeChecker()
        {
            throw new NotImplementedException();
        }

        public override IIParamBlock2 CreateParameterBlock2(IParamBlockDesc2 pdesc, IReferenceMaker iowner)
        {
            throw new NotImplementedException();
        }

        public override void SetPB2MacroRecorderInterface(IMacroRecorder mri)
        {
            throw new NotImplementedException();
        }

        public override IIParamBlock2 UpdateParameterBlock2(IParamBlockDescID pdescOld, int oldCount, IIParamBlock oldPB,
            IParamBlockDesc2 pdescNew, IIParamBlock2 newPB)
        {
            throw new NotImplementedException();
        }

        public override int CopyParamBlock2ToParamBlock(IIParamBlock2 pb2, IIParamBlock pb1, IParamBlockDescID pdescPB1, int pb1Count)
        {
            throw new NotImplementedException();
        }

        public override bool IsParamTypeAnimatable(ParamType2 t)
        {
            throw new NotImplementedException();
        }

        public override IIParamBlock CreateParameterBlock(IParamBlockDesc pdesc, int count)
        {
            throw new NotImplementedException();
        }

        public override IIParamBlock CreateParameterBlock(IParamBlockDescID pdesc, int count, uint version)
        {
            throw new NotImplementedException();
        }

        public override IIParamBlock UpdateParameterBlock(IParamBlockDescID pdescOld, int oldCount, IIParamBlock oldPB,
            IParamBlockDescID pdescNew, int newCount, uint newVersion)
        {
            throw new NotImplementedException();
        }

        public override bool CreateModalParamMap2(short map_id, IIParamBlock2 pb, int t, IntPtr hInst, string dlgTemplate, IntPtr hParent,
            IParamMap2UserDlgProc proc)
        {
            throw new NotImplementedException();
        }

        public override bool CreateModalParamMap2(IIParamBlock2 pb, int t, IntPtr hInst, string dlgTemplate, IntPtr hParent,
            IParamMap2UserDlgProc proc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateModelessParamMap2(short map_id, IIParamBlock2 pb, int t, IntPtr hInst, string dlgTemplate,
            IntPtr hParent, IParamMap2UserDlgProc proc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateModelessParamMap2(IIParamBlock2 pb, int t, IntPtr hInst, string dlgTemplate, IntPtr hParent,
            IParamMap2UserDlgProc proc)
        {
            throw new NotImplementedException();
        }

        public override void DestroyModelessParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateCPParamMap2(short map_id, IIParamBlock2 pb, IInterface ip, IntPtr hInst, string dlgTemplate,
            string title, uint flags, IParamMap2UserDlgProc dlgProc, IntPtr hOldRollup, int category)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateCPParamMap2(IIParamBlock2 pb, IInterface ip, IntPtr hInst, string dlgTemplate, string title,
            uint flags, IParamMap2UserDlgProc dlgProc, IntPtr hOldRollup, int category)
        {
            throw new NotImplementedException();
        }

        public override void DestroyCPParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildCPParamMap2(short map_id, IIParamBlock2 pb, IInterface ip, IntPtr hInst, IIParamMap2 parent,
            string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildCPParamMap2(IIParamBlock2 pb, IInterface ip, IntPtr hInst, IIParamMap2 parent,
            string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override void DestroyChildCPParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateRParamMap2(short map_id, IIParamBlock2 pb, IIRendParams ip, IntPtr hInst, string dlgTemplate,
            string title, uint flags, IParamMap2UserDlgProc dlgProc, int category)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateRParamMap2(IIParamBlock2 pb, IIRendParams ip, IntPtr hInst, string dlgTemplate, string title,
            uint flags, IParamMap2UserDlgProc dlgProc, int category)
        {
            throw new NotImplementedException();
        }

        public override void DestroyRParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildRParamMap2(short map_id, IIParamBlock2 pb, IIRendParams ip, IntPtr hInst, IIParamMap2 parent,
            string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildRParamMap2(IIParamBlock2 pb, IIRendParams ip, IntPtr hInst, IIParamMap2 parent,
            string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override void DestroyChildRParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateMParamMap2(short map_id, IIParamBlock2 pb, IIMtlParams ip, IntPtr hInst, IntPtr hmedit,
            ITexDADMgr tdad, IMtlDADMgr mdad, string dlgTemplate, string title, uint flags, IParamMap2UserDlgProc dlgProc,
            IntPtr hOldRollup, int category)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateMParamMap2(IIParamBlock2 pb, IIMtlParams ip, IntPtr hInst, IntPtr hmedit, ITexDADMgr tdad,
            IMtlDADMgr mdad, string dlgTemplate, string title, uint flags, IParamMap2UserDlgProc dlgProc, IntPtr hOldRollup,
            int category)
        {
            throw new NotImplementedException();
        }

        public override void DestroyMParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildMParamMap2(short map_id, IIParamBlock2 pb, IIMtlParams ip, IntPtr hInst, IIParamMap2 parent,
            IntPtr hmedit, ITexDADMgr tdad, IMtlDADMgr mdad, string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateChildMParamMap2(IIParamBlock2 pb, IIMtlParams ip, IntPtr hInst, IIParamMap2 parent, IntPtr hmedit,
            ITexDADMgr tdad, IMtlDADMgr mdad, string dlgTemplate, string title, IParamMap2UserDlgProc dlgProc)
        {
            throw new NotImplementedException();
        }

        public override void DestroyChildMParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateRWParamMap2(short map_id, IIParamBlock2 pb, IIRollupWindow rw, IntPtr hInst, string dlgTemplate,
            string title, uint flags, IParamMap2UserDlgProc dlgProc, bool bindPBlockToMap)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap2 CreateRWParamMap2(IIParamBlock2 pb, IIRollupWindow rw, IntPtr hInst, string dlgTemplate, string title,
            uint flags, IParamMap2UserDlgProc dlgProc, bool bindPBlockToMap)
        {
            throw new NotImplementedException();
        }

        public override void DestroyRWParamMap2(IIParamMap2 m)
        {
            throw new NotImplementedException();
        }

        public override IIAutoMParamDlg CreateAutoMParamDlg(short map_id, IntPtr hMedit, IIMtlParams i, IReferenceTarget obj, IIParamBlock2 pb,
            IClassDesc2 cd, IntPtr inst, string dlgTemplate, string title, int rollFlags, IParamMap2UserDlgProc dlgProc,
            IntPtr hOldRollup, int category)
        {
            throw new NotImplementedException();
        }

        public override IIAutoMParamDlg CreateAutoMParamDlg(IntPtr hMedit, IIMtlParams i, IReferenceTarget obj, IIParamBlock2 pb,
            IClassDesc2 cd, IntPtr inst, string dlgTemplate, string title, int rollFlags, IParamMap2UserDlgProc dlgProc,
            IntPtr hOldRollup, int category)
        {
            throw new NotImplementedException();
        }

        public override IIAutoEParamDlg CreateAutoEParamDlg(short map_id, IIRendParams i, ISpecialFX e, IIParamBlock2 pb, IClassDesc2 cd,
            IntPtr inst, string dlgTemplate, string title, int rollFlags, IParamMap2UserDlgProc dlgProc, int category)
        {
            throw new NotImplementedException();
        }

        public override IIAutoEParamDlg CreateAutoEParamDlg(IIRendParams i, ISpecialFX e, IIParamBlock2 pb, IClassDesc2 cd, IntPtr inst,
            string dlgTemplate, string title, int rollFlags, IParamMap2UserDlgProc dlgProc, int category)
        {
            throw new NotImplementedException();
        }

        public override bool CreateModalParamMap(IParamUIDesc desc, int count, IIParamArray pb, int t, IntPtr hInst, string dlgTemplate,
            IntPtr hParent, IParamMapUserDlgProc proc)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap CreateCPParamMap(IParamUIDesc desc, int count, IIParamArray pb, IInterface ip, IntPtr hInst,
            string dlgTemplate, string title, uint flags)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap ReplaceCPParamMap(IntPtr oldhw, IParamUIDesc desc, int count, IIParamArray pb, IInterface ip, IntPtr hInst,
            string dlgTemplate, string title, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void DestroyCPParamMap(IIParamMap m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap CreateRParamMap(IParamUIDesc desc, int count, IIParamArray pb, IIRendParams ip, IntPtr hInst,
            string dlgTemplate, string title, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void DestroyRParamMap(IIParamMap m)
        {
            throw new NotImplementedException();
        }

        public override IIParamMap CreateMParamMap(IParamUIDesc desc, int count, IIParamArray pb, IIMtlParams ip, IntPtr hInst,
            string dlgTemplate, string title, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void DestroyMParamMap(IIParamMap m)
        {
            throw new NotImplementedException();
        }

        public override IIBaseWireControl GetWireControlInterface(IAnimatable a)
        {
            throw new NotImplementedException();
        }

        public override int Length(IIPoint2 param0)
        {
            throw new NotImplementedException();
        }

        public override IIPoint2 Multiply(int param0, IIPoint2 param1)
        {
            throw new NotImplementedException();
        }

        public override IIPoint2 Multiply(IIPoint2 param0, int param1)
        {
            throw new NotImplementedException();
        }

        public override IIPoint2 Divide(IIPoint2 param0, int param1)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IIPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IIPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IIPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IIPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override float Length(IIPoint3 v)
        {
            throw new NotImplementedException();
        }

        public override void SetBezierDefaultTangentType(int in_, int out_)
        {
            throw new NotImplementedException();
        }

        public override void GetBezierDefaultTangentType(ref int in_, ref int out_)
        {
            throw new NotImplementedException();
        }

        public override void SetTCBDefaultParams(float t, float c, float b, float easeIn, float easeOut)
        {
            throw new NotImplementedException();
        }

        public override void GetTCBDefaultParams(ref float t, ref float c, ref float b, ref float easeIn, ref float easeOut)
        {
            throw new NotImplementedException();
        }

        public override void RegisterObjectAppDataReader(IObjectDataReaderCallback cb)
        {
            throw new NotImplementedException();
        }

        public override IObject ObjectFromAppData(ITriObject obj, string name, IntPtr data, uint len)
        {
            throw new NotImplementedException();
        }

        public override void GetIDStr(string chunk, string idstring)
        {
            throw new NotImplementedException();
        }

        public override int FindAppDataChunk(IntPtr appd, uint len, string idstring)
        {
            throw new NotImplementedException();
        }

        public override IntPtr GetAppDataChunk(IntPtr appd, uint len, string idstring)
        {
            throw new NotImplementedException();
        }

        public override int SetAppDataChunk(IntPtr pappd, ref uint len, IntPtr chunk)
        {
            throw new NotImplementedException();
        }

        public override int DeleteAppDataChunk(IntPtr pappd, ref uint len, string idstring)
        {
            throw new NotImplementedException();
        }

        public override IIADTCategory GetADTCategoryInterface(IBaseInterface baseIfc)
        {
            throw new NotImplementedException();
        }

        public override IIADTStyle GetADTStyleInterface(IBaseInterface baseIfc)
        {
            throw new NotImplementedException();
        }

        public override IIBlockRefComponent GetBlockRefComponent(IINode n)
        {
            throw new NotImplementedException();
        }

        public override IILuminaire GetLuminaireInterface(IBaseInterface baseIfc)
        {
            throw new NotImplementedException();
        }

        public override int ApplyKeyReduction(IControl cont, IInterval range, float thresh, int step, IKeyReduceStatus status)
        {
            throw new NotImplementedException();
        }

        public override int GetCurLine(IntPtr window, ref string line, bool stripEOL)
        {
            throw new NotImplementedException();
        }

        public override void SetEditBoxFont(IntPtr window, string font_name)
        {
            throw new NotImplementedException();
        }

        public override void SetEditBoxFontSize(IntPtr window, int fontSize)
        {
            throw new NotImplementedException();
        }

        public override void InitMacroRecorder()
        {
            throw new NotImplementedException();
        }

        public override string CommandNameFromCode(int com)
        {
            throw new NotImplementedException();
        }

        public override IMesh MakeSphere(IPoint3 pos, float radius, int segments)
        {
            throw new NotImplementedException();
        }

        public override IMesh MakeTorus(IPoint3 pos, float radius, float radius2, int segs, int sides)
        {
            throw new NotImplementedException();
        }

        public override IMesh MakeBox(IPoint3 pos, float l, float w, float h, int lsegs, int wsegs, int hsegs)
        {
            throw new NotImplementedException();
        }

        public override void AddCubeShape(IPolyShape shape, IPoint3 pos, float size)
        {
            throw new NotImplementedException();
        }

        public override IMarketDefaults GetMarketDefaults(string name)
        {
            throw new NotImplementedException();
        }

        public override string GetMarketDefaultsFileName(string name)
        {
            throw new NotImplementedException();
        }

        public override IMarketDefaults13 GetMarketDefaults13(string name)
        {
            throw new NotImplementedException();
        }

        public override IMatrix2 RotateMatrix(float angle)
        {
            throw new NotImplementedException();
        }

        public override IMatrix2 TransMatrix(IPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override IMatrix2 Inverse(IMatrix2 M)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Multiply(IMatrix2 A, IPoint2 V)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Multiply(IPoint2 V, IMatrix2 A)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 VectorTransform(IMatrix2 M, IPoint2 V)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 RotateXMatrix(float angle)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 RotateYMatrix(float angle)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 RotateZMatrix(float angle)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 TransMatrix(IPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 RotateYPRMatrix(float Yaw, float Pitch, float Roll)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 RotAngleAxisMatrix(IPoint3 axis, float angle)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 Inverse(IMatrix3 M)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 InverseHighPrecision(IMatrix3 M)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 Multiply(IMatrix3 A, IPoint3 V)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 Multiply(IPoint3 V, IMatrix3 A)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 VectorTransform(IMatrix3 M, IPoint3 V)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 VectorTransform(IPoint3 V, IMatrix3 M)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 TransformPlane(IMatrix3 M, IPoint4 plane)
        {
            throw new NotImplementedException();
        }

        public override IMatrix3 XFormMat(IMatrix3 xm, IMatrix3 m)
        {
            throw new NotImplementedException();
        }

        public override void MirrorMatrix(IMatrix3 tm, Axis axis, bool scaleMatrix)
        {
            throw new NotImplementedException();
        }

        public override void MatrixMultiply(IMatrix3 outMatrix, IMatrix3 matrixA, IMatrix3 matrixB)
        {
            throw new NotImplementedException();
        }

        public override void Inverse(IMatrix3 outMatrix, IMatrix3 M)
        {
            throw new NotImplementedException();
        }

        public override void SetDontRepeatRefMsg(bool value, bool commitToInit)
        {
            throw new NotImplementedException();
        }

        public override void PreRefNotifyDependents()
        {
            throw new NotImplementedException();
        }

        public override void PostRefNotifyDependents()
        {
            throw new NotImplementedException();
        }

        public override void SetInvalidateTMOpt(bool value, bool commitToInit)
        {
            throw new NotImplementedException();
        }

        public override void AssignJobEx(IMaxNetManager mgr, IMaxNetworkInterface maxIface, IJob job, string archive, IHSERVER servers,
            ICJobText jobtext, uint blocksize)
        {
            throw new NotImplementedException();
        }

        public override void AssignJobEx(IMaxNetManager mgr, IMaxNetworkInterface2 maxIface, IJob job, string archive, IHSERVER servers,
            ICJobText jobtext, uint blocksize)
        {
            throw new NotImplementedException();
        }

        public override void AssignJobToServersGroup(IMaxNetManager mgr, IMaxNetworkInterface2 maxIface, IJob job, string archive,
            string serversGroupName, ICJobText jobtext)
        {
            throw new NotImplementedException();
        }

        public override double Eps(float v)
        {
            throw new NotImplementedException();
        }

        public override double Eps(double v)
        {
            throw new NotImplementedException();
        }

        public override double Eps(int v)
        {
            throw new NotImplementedException();
        }

        public override double Eps(uint v)
        {
            throw new NotImplementedException();
        }

        public override double Eps(short v)
        {
            throw new NotImplementedException();
        }

        public override IValue _GetKeyArg(IValue arg_list, int count, IValue key_name)
        {
            throw new NotImplementedException();
        }

        public override IValue _GetKeyArgOrDefault(IValue arg_list, int count, IValue key_name, IValue def)
        {
            throw new NotImplementedException();
        }

        public override string SaveString(string str)
        {
            throw new NotImplementedException();
        }

        public override IObject GetObjectOrXRefBaseObject(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override int Namify(string n, int type, bool bStripTrailing)
        {
            throw new NotImplementedException();
        }

        public override void InstallUtilityPage(IRollout rollout)
        {
            throw new NotImplementedException();
        }

        public override void MxsSeed(int param0)
        {
            throw new NotImplementedException();
        }

        public override int RandomRange(int @from, int to)
        {
            throw new NotImplementedException();
        }

        public override float RandomRange(float @from, float to)
        {
            throw new NotImplementedException();
        }

        public override double RandomRange(double @from, double to)
        {
            throw new NotImplementedException();
        }

        public override void DlxDetaching(IntPtr hinstance)
        {
            throw new NotImplementedException();
        }

        public override void DefineSystemGlobal(string name, GlobalDelegates.Delegate15 getter, GlobalDelegates.Delegate16 setter)
        {
            throw new NotImplementedException();
        }

        public override void DefineSystemGlobalReplace(string name, GlobalDelegates.Delegate15 getter, GlobalDelegates.Delegate16 setter)
        {
            throw new NotImplementedException();
        }

        public override void DefineStructGlobal(string name, string struct_name, GlobalDelegates.Delegate15 getter, GlobalDelegates.Delegate16 setter)
        {
            throw new NotImplementedException();
        }

        public override void ShowSourcePos()
        {
            throw new NotImplementedException();
        }

        public override void ShowListener()
        {
            throw new NotImplementedException();
        }

        public override void InitMAXScript()
        {
            throw new NotImplementedException();
        }

        public override void SetUtilityInstaller(GlobalDelegates.Delegate25 ui)
        {
            throw new NotImplementedException();
        }

        public override void ResetUtilityInstaller()
        {
            throw new NotImplementedException();
        }

        public override void ErrorMessageBox(IMAXScriptException e, string caption)
        {
            throw new NotImplementedException();
        }

        public override void IncrementErrorTraceBackLevel()
        {
            throw new NotImplementedException();
        }

        public override bool ExecuteMAXScriptScript(string s, bool quietErrors, IFPValue fpv)
        {
            throw new NotImplementedException();
        }

        public override IValue ExecuteScript(ICharStream source, bool res)
        {
            throw new NotImplementedException();
        }

        public override void FileinScript(string filename)
        {
            throw new NotImplementedException();
        }

        public override bool FileinScriptEx(string filename, string error_message)
        {
            throw new NotImplementedException();
        }

        public override void OpenScriptEditor(string filename)
        {
            throw new NotImplementedException();
        }

        public override uint ProcessDefaultActionVal(IValue inpActionVal, uint defaultAction)
        {
            throw new NotImplementedException();
        }

        public override int _CountWithKeys(IValue arg_list, int count)
        {
            throw new NotImplementedException();
        }

        public override bool CanChangeGroupFlags(IINode node)
        {
            throw new NotImplementedException();
        }

        public override bool FindMxsNameForObj(IAnimatable obj, ref string name, bool explicitName)
        {
            throw new NotImplementedException();
        }

        public override void ReplaceLfWithCrlf(ref string string_)
        {
            throw new NotImplementedException();
        }

        public override void ReplaceCrlfWithLf(ref string string_)
        {
            throw new NotImplementedException();
        }

        public override void CheckFileOpenModeValidity(string mode)
        {
            throw new NotImplementedException();
        }

        public override bool MaxNameMatch(string max_name, string pattern, bool caseSensitive)
        {
            throw new NotImplementedException();
        }

        public override IBitmap CreateBitmapFromBitmapInfo(IBitmapInfo bitmapInfo)
        {
            throw new NotImplementedException();
        }

        public override int GetStorableBitmapInfoTypeForBitmapInfoType(int type)
        {
            throw new NotImplementedException();
        }

        public override float AffectRegionFunction(float dist, float falloff, float pinch, float bubble)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 SoftSelectionColor(float selAmount)
        {
            throw new NotImplementedException();
        }

        public override void MatrixFromNormal(IPoint3 normal, IMatrix3 mat)
        {
            throw new NotImplementedException();
        }

        public override void AverageVertexNormals(IMesh mesh, ITab<IPoint3> vnormals)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 AverageSelVertNormal(IMesh mesh)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 AverageSelVertCenter(IMesh mesh)
        {
            throw new NotImplementedException();
        }

        public override void DeselectHiddenFaces(IMesh mesh)
        {
            throw new NotImplementedException();
        }

        public override void DeselectHiddenEdges(IMesh mesh)
        {
            throw new NotImplementedException();
        }

        public override void HiddenFacesToVerts(IMesh mesh, IBitArray alsoHide)
        {
            throw new NotImplementedException();
        }

        public override void SelectionDistance(IMesh mesh, IntPtr selDist, float falloffLimit)
        {
            throw new NotImplementedException();
        }

        public override void SelectionDistance(IMesh mesh, IntPtr selDist, int iters, IAdjEdgeList ae)
        {
            throw new NotImplementedException();
        }

        public override void ClustDistances(IMesh mesh, uint numClusts, IntPtr vclust, ITab<float> clustDist)
        {
            throw new NotImplementedException();
        }

        public override void ClustDistances(IMesh mesh, uint numClusts, IntPtr vclust, ITab<float> clustDist, int iters, IAdjEdgeList ae)
        {
            throw new NotImplementedException();
        }

        public override void FindTriangulation(IMesh m, int deg, IntPtr vv, IntPtr tri)
        {
            throw new NotImplementedException();
        }

        public override uint MapChannelID(int mp)
        {
            throw new NotImplementedException();
        }

        public override int MapChannelNum(int mp)
        {
            throw new NotImplementedException();
        }

        public override int VertexDataType(int vdID)
        {
            throw new NotImplementedException();
        }

        public override IntPtr VertexDataDefault(int vdID)
        {
            throw new NotImplementedException();
        }

        public override void SetMeshIntrFunc(GlobalDelegates.Delegate6 fn)
        {
            throw new NotImplementedException();
        }

        public override int CalcBoolOp(IMesh mesh, IMesh mesh1, IMesh mesh2, int op, IMeshOpProgress prog, IMatrix3 tm1, IMatrix3 tm2,
            int whichInv, int weld)
        {
            throw new NotImplementedException();
        }

        public override void CombineMeshes(IMesh mesh, IMesh mesh1, IMesh mesh2, IMatrix3 tm1, IMatrix3 tm2, int whichInv)
        {
            throw new NotImplementedException();
        }

        public override void SliceMesh(IMesh mesh, IPoint3 N, float off, bool split, bool remove)
        {
            throw new NotImplementedException();
        }

        public override IMesh CreateNewMesh()
        {
            throw new NotImplementedException();
        }

        public override void MIDIManSuspend()
        {
            throw new NotImplementedException();
        }

        public override void MIDIManResume()
        {
            throw new NotImplementedException();
        }

        public override bool BigMatMult(IBigMatrix a, IBigMatrix b, IBigMatrix c)
        {
            throw new NotImplementedException();
        }

        public override void DiagSort(int dnum, IntPtr diag)
        {
            throw new NotImplementedException();
        }

        public override int EdgeDataType(int edID)
        {
            throw new NotImplementedException();
        }

        public override IntPtr EdgeDataDefault(int edID)
        {
            throw new NotImplementedException();
        }

        public override void SelectionDistance(IMNMesh mesh, IntPtr selDist, int iters, uint selFlags)
        {
            throw new NotImplementedException();
        }

        public override void ClustDistances(IMNMesh mesh, int numClusts, IntPtr vclust, ITab<float> clustDist)
        {
            throw new NotImplementedException();
        }

        public override void ClustDistances(IMNMesh mesh, int numClusts, IntPtr vclust, ITab<float> clustDist, int iters)
        {
            throw new NotImplementedException();
        }

        public override IIDerivedObject CreateWSDerivedObject(IObject pob)
        {
            throw new NotImplementedException();
        }

        public override IIDerivedObject CreateDerivedObject(IObject pob)
        {
            throw new NotImplementedException();
        }

        public override int EnumGeomPipeline(IGeomPipelineEnumProc gpep, IINode start, bool includeEmptyDOs)
        {
            throw new NotImplementedException();
        }

        public override int EnumGeomPipeline(IGeomPipelineEnumProc gpep, IObject start, bool includeEmptyDOs)
        {
            throw new NotImplementedException();
        }

        public override int EnumGeomPipeline(IGeomPipelineEnumProc gpep, IIDerivedObject start, int modIndex, bool includeEmptyDOs)
        {
            throw new NotImplementedException();
        }

        public override ImrShaderFilter GetMrShaderFilter(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IMAXSuperClass LookupMAXSuperClass(SClass_ID scid)
        {
            throw new NotImplementedException();
        }

        public override IMAXClass LookupMAXClass(IClass_ID cid, SClass_ID scid, bool make_new_if_missing)
        {
            throw new NotImplementedException();
        }

        public override IntPtr MaxwrapperGenref(IntPtr pObject, IntPtr index)
        {
            throw new NotImplementedException();
        }

        public override IntPtr MaxwrapperGenref_(IntPtr pObject1, IntPtr pObject2)
        {
            throw new NotImplementedException();
        }

        public override void InvalidateNodeRect(IINode node, int t)
        {
            throw new NotImplementedException();
        }

        public override GetINodeTabResult GetINodeTabFromValue(IValue val, IINodeTab nodeTab, IINodeTab pResult)
        {
            throw new NotImplementedException();
        }

        public override IValue CollectNodes(IValue arg_list, int count)
        {
            throw new NotImplementedException();
        }

        public override int GetMaxVerFromMxsMaxFileVer(EMxsMaxFileVersion mxsMaxFileVer)
        {
            throw new NotImplementedException();
        }

        public override EMxsMaxFileVersion GetMxsMaxFileVerFromMaxVer(int maxVersion)
        {
            throw new NotImplementedException();
        }

        public override IINaturalLightClass GetNaturalLightClass(SClass_ID s, IClass_ID id)
        {
            throw new NotImplementedException();
        }

        public override IINaturalLightClass GetNaturalLightClass(IAnimatable a)
        {
            throw new NotImplementedException();
        }

        public override IINaturalLightClass GetNaturalLightClassInterface(IClassDesc c)
        {
            throw new NotImplementedException();
        }

        public override IISunLight GetSunLightInterface(IAnimatable o)
        {
            throw new NotImplementedException();
        }

        public override IISkyLight GetSkyLightInterface(IAnimatable o)
        {
            throw new NotImplementedException();
        }

        public override int RegisterNotification(GlobalDelegates.Delegate5 proc, object param, SystemNotificationCode code)
        {
            throw new NotImplementedException();
        }

        public override int UnRegisterNotification(GlobalDelegates.Delegate5 proc, object param, SystemNotificationCode code)
        {
            throw new NotImplementedException();
        }

        public override void BroadcastNotification(SystemNotificationCode code)
        {
            throw new NotImplementedException();
        }

        public override void BroadcastNotification(SystemNotificationCode code, object callParam)
        {
            throw new NotImplementedException();
        }

        public override int UnRegisterNotification(GlobalDelegates.Delegate5 proc, object param)
        {
            throw new NotImplementedException();
        }

        public override void SetMeshNamedSelClip(IMeshNamedSelClip clip, int which)
        {
            throw new NotImplementedException();
        }

        public override IMeshNamedSelClip GetMeshNamedSelClip(int which)
        {
            throw new NotImplementedException();
        }

        public override void SetPatchNamedSelClip(IPatchNamedSelClip clip, int which)
        {
            throw new NotImplementedException();
        }

        public override IPatchNamedSelClip GetPatchNamedSelClip(int which)
        {
            throw new NotImplementedException();
        }

        public override void GetPolygonCount(int t, IObject pObj, ref int numFaces, ref int numVerts)
        {
            throw new NotImplementedException();
        }

        public override void GetTriMeshFaceCount(int t, IObject pObj, ref int numFaces, ref int numVerts)
        {
            throw new NotImplementedException();
        }

        public override void SetShapeObjectCCSThreshold(float angle)
        {
            throw new NotImplementedException();
        }

        public override void MakeHitRegion(IHitRegion hr, int type, int crossing, int epsi, IIPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override void DoModifiedBox(IBox3 box, IDeformer def, IPolyLineProc lp)
        {
            throw new NotImplementedException();
        }

        public override void DoModifiedLimit(IBox3 box, float z, int axis, IDeformer def, IPolyLineProc lp)
        {
            throw new NotImplementedException();
        }

        public override void DrawCenterMark(IPolyLineProc lp, IBox3 box)
        {
            throw new NotImplementedException();
        }

        public override void DoSphericalMapIcon(bool sel, float radius, IPolyLineProc lp)
        {
            throw new NotImplementedException();
        }

        public override void DoCylindricalMapIcon(bool sel, float radius, float height, IPolyLineProc lp)
        {
            throw new NotImplementedException();
        }

        public override void DoPlanarMapIcon(bool sel, float width, float length, IPolyLineProc lp)
        {
            throw new NotImplementedException();
        }

        public override IObject MakeObjectDerivedObject(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override string GetSpaceWarpCatString(int id)
        {
            throw new NotImplementedException();
        }

        public override bool RegisterObjectConverter(IObjectConverter conv)
        {
            throw new NotImplementedException();
        }

        public override int CanConvertTriObject(IClass_ID to)
        {
            throw new NotImplementedException();
        }

        public override int CanConvertPatchObject(IClass_ID to)
        {
            throw new NotImplementedException();
        }

        public override int CanConvertSplineShape(IClass_ID to)
        {
            throw new NotImplementedException();
        }

        public override void RegisterStaticEditTri(IObject triob)
        {
            throw new NotImplementedException();
        }

        public override void RegisterCollapseType(IClass_ID cid, string name, bool canSelfConvert)
        {
            throw new NotImplementedException();
        }

        public override IColorPacker NewColorPacker(int w, IBMM_Color_48 pal, int npal, IntPtr remap, bool dither)
        {
            throw new NotImplementedException();
        }

        public override void SetPatchIntrFunc(GlobalDelegates.Delegate6 fn)
        {
            throw new NotImplementedException();
        }

        public override void ConvertMeshToPatch(IMesh m, IPatchMesh pm, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void ConvertPatchToMesh(IPatchMesh pm, IMesh m, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void ConvertPatchToMeshWithMapping(IPatchMesh pm, IMesh m, ITab<int> mapping, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void RelaxMesh(IMesh mesh, float value, int iter, bool boundary, bool saddle)
        {
            throw new NotImplementedException();
        }

        public override IntPtr CreateInstance(SClass_ID superID, IClass_ID classID)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Add(IPoint2 a, float f)
        {
            throw new NotImplementedException();
        }

        public override float Length(IPoint2 param0)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IPoint2 param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IPoint2 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Normalize(IPoint2 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Multiply(float param0, IPoint2 param1)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Multiply(IPoint2 param0, float param1)
        {
            throw new NotImplementedException();
        }

        public override IPoint2 Divide(IPoint2 param0, float param1)
        {
            throw new NotImplementedException();
        }

        public override float LengthSquared(IPoint2 v)
        {
            throw new NotImplementedException();
        }

        public override float Length(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override float FLength(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override float LengthSquared(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 Normalize(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 FNormalize(IPoint3 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint3 CrossProd(IPoint3 a, IPoint3 b)
        {
            throw new NotImplementedException();
        }

        public override float Length(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override float FLength(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override float LengthSquared(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override int MaxComponent(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override int MinComponent(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 Normalize(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 FNormalize(IPoint4 param0)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 CrossProd(IPoint4 a, IPoint4 b, IPoint4 c)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 Multiply(float f, IPoint4 a)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 Multiply(IPoint4 a, float f)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 Divide(IPoint4 a, float f)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 Add(IPoint4 a, float f)
        {
            throw new NotImplementedException();
        }

        public override float DotProd(IPoint4 a, IPoint4 b)
        {
            throw new NotImplementedException();
        }

        public override void RegisterEditPolyObjDesc(IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override IPolyObject CreateEditablePolyObject()
        {
            throw new NotImplementedException();
        }

        public override void ConvertPolyToPatch(IMNMesh @from, IPatchMesh to, uint flags)
        {
            throw new NotImplementedException();
        }

        public override void ConvertPatchToPoly(IPatchMesh @from, IMNMesh to, uint flags)
        {
            throw new NotImplementedException();
        }

        public override bool PreparePolyObjectDisplay(IMNMesh mesh, IUpdateDisplayContext updateDisplayContext)
        {
            throw new NotImplementedException();
        }

        public override bool UpdatePolyObjectPerNodeItemsDisplay(IMNMesh mesh, IUpdateDisplayContext updateDisplayContext,
            IUpdateNodeContext nodeContext, IIRenderItemContainer targetRenderItemContainer)
        {
            throw new NotImplementedException();
        }

        public override IQuat Multiply(float param0, IQuat param1)
        {
            throw new NotImplementedException();
        }

        public override IQuat Multiply(IQuat param0, float param1)
        {
            throw new NotImplementedException();
        }

        public override IQuat Divide(IQuat param0, float param1)
        {
            throw new NotImplementedException();
        }

        public override IQuat Inverse(IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat Conjugate(IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat LogN(IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat Exp(IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat Slerp(IQuat p, IQuat q, float t)
        {
            throw new NotImplementedException();
        }

        public override IQuat LnDif(IQuat p, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat QCompA(IQuat qprev, IQuat q, IQuat qnext)
        {
            throw new NotImplementedException();
        }

        public override IQuat Squad(IQuat p, IQuat a, IQuat b, IQuat q, float t)
        {
            throw new NotImplementedException();
        }

        public override IQuat Qorthog(IQuat p, IPoint3 axis)
        {
            throw new NotImplementedException();
        }

        public override IQuat Squadrev(float angle, IPoint3 axis, IQuat p, IQuat a, IQuat b, IQuat q, float t)
        {
            throw new NotImplementedException();
        }

        public override void RotateMatrix(IMatrix3 mat, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override void PreRotateMatrix(IMatrix3 mat, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IQuat QFromAngAxis(float ang, IPoint3 axis)
        {
            throw new NotImplementedException();
        }

        public override void AngAxisFromQ(IQuat q, IntPtr ang, IPoint3 axis)
        {
            throw new NotImplementedException();
        }

        public override float QangAxis(IQuat p, IQuat q, IPoint3 axis)
        {
            throw new NotImplementedException();
        }

        public override void DecomposeMatrix(IMatrix3 mat, IPoint3 p, IQuat q, IPoint3 s)
        {
            throw new NotImplementedException();
        }

        public override IQuat TransformQuat(IMatrix3 m, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override void QuatToEuler(IQuat q, IntPtr ang)
        {
            throw new NotImplementedException();
        }

        public override void EulerToQuat(IntPtr ang, IQuat q)
        {
            throw new NotImplementedException();
        }

        public override IRadiosityMesh GetRadiosityMesh(IRadiosityEffect rad)
        {
            throw new NotImplementedException();
        }

        public override IRemapDir NewRemapDir(bool use_A_WORK2_flag)
        {
            throw new NotImplementedException();
        }

        public override IReferenceTarget CloneRefHierarchy(IReferenceTarget rm)
        {
            throw new NotImplementedException();
        }

        public override void RegisterGlobalReference(Autodesk.Max.IGlobalReferenceMaker maker)
        {
            throw new NotImplementedException();
        }

        public override void UnRegisterGlobalReference(Autodesk.Max.IGlobalReferenceMaker maker)
        {
            throw new NotImplementedException();
        }

        public override void ClearAFlagInHierarchy(IReferenceMaker rm, uint mask)
        {
            throw new NotImplementedException();
        }

        public override void ClearAFlagInAllAnimatables(uint mask)
        {
            throw new NotImplementedException();
        }

        public override bool DependsOn(IReferenceMaker mkr, IReferenceMaker targ)
        {
            throw new NotImplementedException();
        }

        public override uint SetSavingVersion(uint version)
        {
            throw new NotImplementedException();
        }

        public override void DisableRefMsgs()
        {
            throw new NotImplementedException();
        }

        public override void EnableRefMsgs()
        {
            throw new NotImplementedException();
        }

        public override IIRenderElementRequirements GetRenderElementRequirements(IIRenderElement element)
        {
            throw new NotImplementedException();
        }

        public override IIRendererRequirements GetRendererRequirements(IRenderer renderer)
        {
            throw new NotImplementedException();
        }

        public override bool RendererHasRequirement(IRenderer renderer, Requirement requirement)
        {
            throw new NotImplementedException();
        }

        public override IValue _GetControlParam(IValue keyparms, int count, IValue key_name)
        {
            throw new NotImplementedException();
        }

        public override IValue _GetControlParamOrDefault(IValue keyparms, int count, IValue key_name, IValue def)
        {
            throw new NotImplementedException();
        }

        public override IValue LoadValue(IILoad iload, IValueLoader vload)
        {
            throw new NotImplementedException();
        }

        public override void OpenScript(string filename, Iedit_window ew, string path)
        {
            throw new NotImplementedException();
        }

        public override Iedit_window ShowEditorPos(string file_name, int pos)
        {
            throw new NotImplementedException();
        }

        public override Iedit_window GetEditorWindow(string file_name)
        {
            throw new NotImplementedException();
        }

        public override bool ShowEditorPosEx(string file_name, int pos)
        {
            throw new NotImplementedException();
        }

        public override bool LocateScriptResourceFile(string scriptFileName, ref string resourceFileName)
        {
            throw new NotImplementedException();
        }

        public override IHashTable LoadScriptResourceFile(string resourceFileName)
        {
            throw new NotImplementedException();
        }

        public override string GetSystemLocaleName(bool user_default_locale)
        {
            throw new NotImplementedException();
        }

        public override int ApplyOffset(IInterface intf, IINode node, float amount)
        {
            throw new NotImplementedException();
        }

        public override int MeasureOffset(IInterface intf, IINode node, IPoint3 point, IntPtr result)
        {
            throw new NotImplementedException();
        }

        public override void RegisterSXPReader(string sxpName, IClass_ID cid)
        {
            throw new NotImplementedException();
        }

        public override ITex3D GetSXPReaderClass(string sxpName)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals(string param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals_(string param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals__(string param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals___(string param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals(int param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals(string param0, int param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals_(int param0, string param1)
        {
            throw new NotImplementedException();
        }

        public override bool OperatorEquals_(string param0, int param1)
        {
            throw new NotImplementedException();
        }

        public override void SplitFilename(string full_path, IntPtr directory, IntPtr filename, IntPtr extension)
        {
            throw new NotImplementedException();
        }

        public override void SplitFilename_(string full_path, IntPtr directory, IntPtr filename, IntPtr extension)
        {
            throw new NotImplementedException();
        }

        public override void SplitFilenameOld(string full_path, IntPtr directory, IntPtr filename, IntPtr extension)
        {
            throw new NotImplementedException();
        }

        public override void SplitFilenameOld_(string full_path, IntPtr directory, IntPtr filename, IntPtr extension)
        {
            throw new NotImplementedException();
        }

        public override void SplitPathFile(string full_path, IntPtr directory, IntPtr filename)
        {
            throw new NotImplementedException();
        }

        public override void SplitPathFileOld(string full_path, IntPtr directory, IntPtr filename)
        {
            throw new NotImplementedException();
        }

        public override bool MatchPattern(string pString, string pattern, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override int MaxAlphaNumComp(string a, string b)
        {
            throw new NotImplementedException();
        }

        public override int MaxAlphaNumCompI(string a, string b)
        {
            throw new NotImplementedException();
        }

        public override string ExpandFileName(string file_name)
        {
            throw new NotImplementedException();
        }

        public override string ExpandFileDir(string dir_name)
        {
            throw new NotImplementedException();
        }

        public override string ExpandSymbolicPathnameInFileName(string file_name)
        {
            throw new NotImplementedException();
        }

        public override string ExpandSymbolicPathnameInDirName(string dir_name)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSCVSurfaceProceedurally(INURBSProceeduralSurface pSurf, double tolerence, INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSCVCurveProceedurally(INURBSProceeduralCurve pCrv, double tolerence, INURBSCVCurve crv)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSLatheSurface(INURBSCVCurve curve, IPoint3 origin, IPoint3 north, float start, float end,
            INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSSphereSurface(float radius, IPoint3 center, IPoint3 northAxis, IPoint3 refAxis, float startAngleU,
            float endAngleU, float startAngleV, float endAngleV, bool open, INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSCylinderSurface(float radius, float height, IPoint3 origin, IPoint3 symAxis, IPoint3 refAxis,
            float startAngle, float endAngle, bool open, INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSConeSurface(float radius1, float radius2, float height, IPoint3 origin, IPoint3 symAxis,
            IPoint3 refAxis, float startAngle, float endAngle, bool open, INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GenNURBSTorusSurface(float majorRadius, float minorRadius, IPoint3 origin, IPoint3 symAxis, IPoint3 refAxis,
            float startAngleU, float endAngleU, float startAngleV, float endAngleV, bool open, INURBSCVSurface surf)
        {
            throw new NotImplementedException();
        }

        public override IObject CreateNURBSObject(IIObjParam ip, INURBSSet nset, IMatrix3 mat)
        {
            throw new NotImplementedException();
        }

        public override int AddNURBSObjects(IObject obj, IIObjParam ip, INURBSSet nset)
        {
            throw new NotImplementedException();
        }

        public override IObject CreateNURBSLatheShape(IIObjParam ip, string name, int t, IShapeObject shape, IMatrix3 axis, float degrees,
            int capStart, int capEnd, int capType, bool weldCore, bool flipNormals, bool texturing, int segs, bool matIds,
            bool shapeIDs)
        {
            throw new NotImplementedException();
        }

        public override IObject CreateNURBSExtrudeShape(IIObjParam ip, string name, int t, IShapeObject shape, float amount, int capStart,
            int capEnd, int capType, bool texturing, bool matIds, bool shapeIDs)
        {
            throw new NotImplementedException();
        }

        public override bool GetNURBSSet(IObject object_, int t, INURBSSet nset, bool Relational)
        {
            throw new NotImplementedException();
        }

        public override UIntPtr ValidateId(IObject obj, UIntPtr id)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetSurfaceApprox(IObject obj, bool viewport, ITessApprox tess, bool clearSurfs)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetCurveApprox(IObject obj, bool viewport, ITessApprox tess, bool clearSurfs)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetDispApprox(IObject obj, ITessApprox tess, bool clearSurfs)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetSurfaceDisplaySettings(IObject obj, INURBSDisplay disp)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GetSurfaceDisplaySettings(IObject obj, INURBSDisplay disp)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult BreakCurve(IObject obj, UIntPtr id, double u, int t)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult BreakSurface(IObject obj, UIntPtr id, bool breakU, double param, int t)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult JoinCurves(IObject obj, UIntPtr id1, UIntPtr id2, bool begin1, bool begin2, double tolerance, double ten1,
            double ten2, int t)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult JoinSurfaces(IObject obj, UIntPtr id1, UIntPtr id2, int edge1, int edge2, double tolerance, double ten1,
            double ten2, int t)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult ZipCurves(IObject obj, UIntPtr id1, UIntPtr id2, bool begin1, bool begin2, double tolerance, int t)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult ZipSurfaces(IObject obj, UIntPtr id1, UIntPtr id2, int edge1, int edge2, double tolerance, int t)
        {
            throw new NotImplementedException();
        }

        public override UIntPtr MakeIndependent(IObject obj, UIntPtr id, int t)
        {
            throw new NotImplementedException();
        }

        public override UIntPtr MakeRigid(IObject obj, UIntPtr id, int t)
        {
            throw new NotImplementedException();
        }

        public override void SetApproxPreset(IObject pObj, int i)
        {
            throw new NotImplementedException();
        }

        public override void ToggleShadedLattice(IObject pObj)
        {
            throw new NotImplementedException();
        }

        public override ITessApprox GetTessPreset(int which, int preset)
        {
            throw new NotImplementedException();
        }

        public override void SetTessPreset(int which, int preset, ITessApprox tess)
        {
            throw new NotImplementedException();
        }

        public override IObject BuildEMObjectFromLofterObject(IObject loftObject, double tolerance)
        {
            throw new NotImplementedException();
        }

        public override IObject BuildEMObjectFromPatchObject(IObject patchObject)
        {
            throw new NotImplementedException();
        }

        public override NURBSSubObjectLevel GetSelectionLevel(IObject pObj)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetSelectionLLevel(IObject pObj, NURBSSubObjectLevel level)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GetSelection(IObject pObj, NURBSSubObjectLevel level, IBitArray selset)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetSelection(IObject pObj, NURBSSubObjectLevel level, IBitArray selset)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult MoveCurrentSelection(IObject pObj, NURBSSubObjectLevel level, int t, IMatrix3 partm, IMatrix3 tmAxis,
            IPoint3 val, bool localOrigin)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult RotateCurrentSelection(IObject pObj, NURBSSubObjectLevel level, int t, IMatrix3 partm, IMatrix3 tmAxis,
            IQuat val, bool localOrigin)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult ScaleCurrentSelection(IObject pObj, NURBSSubObjectLevel level, int t, IMatrix3 partm, IMatrix3 tmAxis,
            IPoint3 val, bool localOrigin)
        {
            throw new NotImplementedException();
        }

        public override int SubObjectCount(IObject pObj, NURBSSubObjectLevel level)
        {
            throw new NotImplementedException();
        }

        public override int NamedSelSetCount(IObject pObj, NURBSSubObjectLevel level)
        {
            throw new NotImplementedException();
        }

        public override string GetNamedSelSetName(IObject pObj, NURBSSubObjectLevel level, int i)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult GetNamedSelSet(IObject pObj, NURBSSubObjectLevel level, string name, IBitArray selSet)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult SetNamedSelSet(IObject pObj, NURBSSubObjectLevel level, string name, IBitArray sel)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult AppendNamedSelSet(IObject pObj, NURBSSubObjectLevel level, string name, IBitArray sel)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult DeleteCurrentSelection(IObject pObj, NURBSSubObjectLevel level)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult MapNURBSIdToSelSetIndex(IObject pObj, UIntPtr id, ref int index, ref NURBSSubObjectLevel level)
        {
            throw new NotImplementedException();
        }

        public override NURBSResult MapSelSetIndexToNURBSId(IObject pObj, int index, NURBSSubObjectLevel level, ref UIntPtr id)
        {
            throw new NotImplementedException();
        }

        public override void ApplyUVWMapAsTextureSurface(IObject pObj, int type, float utile, float vtile, float wtile, int uflip, int vflip,
            int wflip, int cap, IMatrix3 tm, int channel)
        {
            throw new NotImplementedException();
        }

        public override void UpdateSurfaceMapper(IModifier pMod)
        {
            throw new NotImplementedException();
        }

        public override bool IsWindows9x()
        {
            throw new NotImplementedException();
        }

        public override bool IsWindows98or2000()
        {
            throw new NotImplementedException();
        }

        public override bool GetSpecDir(int index, string dirName, string buf)
        {
            throw new NotImplementedException();
        }

        public override bool TryCSIDLDir(int csidl, string dirName, string buf)
        {
            throw new NotImplementedException();
        }

        public override IInterface7 UtilGetCOREInterface7()
        {
            throw new NotImplementedException();
        }

        public override IInterface8 UtilGetCOREInterface8()
        {
            throw new NotImplementedException();
        }

        public override IInterface9 UtilGetCOREInterface9()
        {
            throw new NotImplementedException();
        }

        public override IInterface10 UtilGetCOREInterface10()
        {
            throw new NotImplementedException();
        }

        public override IInterface11 UtilGetCOREInterface11()
        {
            throw new NotImplementedException();
        }

        public override IInterface12 UtilGetCOREInterface12()
        {
            throw new NotImplementedException();
        }

        public override IInterface13 UtilGetCOREInterface13()
        {
            throw new NotImplementedException();
        }

        public override IInterface14 UtilGetCOREInterface14()
        {
            throw new NotImplementedException();
        }

        public override IInterface15 UtilGetCOREInterface15()
        {
            throw new NotImplementedException();
        }

        public override IInterface16 UtilGetCOREInterface16()
        {
            throw new NotImplementedException();
        }

        public override int TBMakeSize(ITabHdr pth, int num, int elsize)
        {
            throw new NotImplementedException();
        }

        public override int TBInsertAt(ITabHdr pth, int at, int num, IntPtr el, int elsize, int extra)
        {
            throw new NotImplementedException();
        }

        public override int TBCopy(ITabHdr pth, int at, int num, IntPtr el, int elsize)
        {
            throw new NotImplementedException();
        }

        public override int TBDelete(ITabHdr pth, int starting, int num, int elsize)
        {
            throw new NotImplementedException();
        }

        public override void TBSetCount(ITabHdr pth, int n, int elsize, bool resize)
        {
            throw new NotImplementedException();
        }

        public override void Zfree(IntPtr p)
        {
            throw new NotImplementedException();
        }

        public override void InitTCBGraph(IntPtr hInst)
        {
            throw new NotImplementedException();
        }

        public override int GapTessellate(IntPtr surf, SurfaceType type, IMatrix3 otm, IMesh mesh, ITessApprox tess, ITessApprox disp,
            IView view, IMtl mtl, bool dumpMiFile, bool splitmesh)
        {
            throw new NotImplementedException();
        }

        public override float Bias(float a, float b)
        {
            throw new NotImplementedException();
        }

        public override float Gain(float a, float b)
        {
            throw new NotImplementedException();
        }

        public override float Clamp(float x, float a, float b)
        {
            throw new NotImplementedException();
        }

        public override float Boxstep(float a, float b, float x)
        {
            throw new NotImplementedException();
        }

        public override float Smoothstep(float a, float b, float x)
        {
            throw new NotImplementedException();
        }

        public override float Mod(float x, float m)
        {
            throw new NotImplementedException();
        }

        public override int Mod(int x, int m)
        {
            throw new NotImplementedException();
        }

        public override float Sramp(float x, float a, float b, float d)
        {
            throw new NotImplementedException();
        }

        public override float Threshold(float x, float a, float b)
        {
            throw new NotImplementedException();
        }

        public override void Setdebug(int i)
        {
            throw new NotImplementedException();
        }

        public override float Noise1(float arg)
        {
            throw new NotImplementedException();
        }

        public override float Noise2(IPoint2 p)
        {
            throw new NotImplementedException();
        }

        public override float Noise3(IPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override float Noise4(IPoint3 p, float time)
        {
            throw new NotImplementedException();
        }

        public override float Noise3DS(IPoint3 p)
        {
            throw new NotImplementedException();
        }

        public override float Turbulence(IPoint3 p, float freq)
        {
            throw new NotImplementedException();
        }

        public override int Perm(int v)
        {
            throw new NotImplementedException();
        }

        public override float FBm1(float point, float H, float lacunarity, float octaves)
        {
            throw new NotImplementedException();
        }

        public override float FBm1(IPoint2 point, float H, float lacunarity, float octaves)
        {
            throw new NotImplementedException();
        }

        public override float FBm1(IPoint3 point, float H, float lacunarity, float octaves)
        {
            throw new NotImplementedException();
        }

        public override float Spline(float x, int nknots, IntPtr knot)
        {
            throw new NotImplementedException();
        }

        public override IColor ColorSpline(float x, int nknots, IColor knot)
        {
            throw new NotImplementedException();
        }

        public override int Floor(float x)
        {
            throw new NotImplementedException();
        }

        public override float Frac(float x)
        {
            throw new NotImplementedException();
        }

        public override float Fmax(float x, float y)
        {
            throw new NotImplementedException();
        }

        public override float Fmin(float x, float y)
        {
            throw new NotImplementedException();
        }

        public override IAColor AComp(IAColor cbot, IAColor ctop)
        {
            throw new NotImplementedException();
        }

        public override void CellFunction(IPoint3 v, int n, IntPtr dist, IntPtr celIDs, IPoint3 grads, float gradSmooth)
        {
            throw new NotImplementedException();
        }

        public override void FractalCellFunction(IPoint3 v, float iterations, float lacunarity, int n, IntPtr dist, IntPtr celIDs,
            IPoint3 grads, float gradSmooth)
        {
            throw new NotImplementedException();
        }

        public override float RandFromCellID(int id)
        {
            throw new NotImplementedException();
        }

        public override void SetDisplacmentPreset(int preset, ITessApprox approx)
        {
            throw new NotImplementedException();
        }

        public override void RegisterEditTriObjDesc(IClassDesc desc)
        {
            throw new NotImplementedException();
        }

        public override ITriObject CreateNewTriObject()
        {
            throw new NotImplementedException();
        }

        public override IITrackViewNode CreateITrackViewNode(bool hidden)
        {
            throw new NotImplementedException();
        }

        public override double GetMasterScale(int type)
        {
            throw new NotImplementedException();
        }

        public override double GetRelativeScale(int fromType, float fromScale, int toType, float toScale)
        {
            throw new NotImplementedException();
        }

        public override void GetMasterUnitInfo(IntPtr type, IntPtr scale)
        {
            throw new NotImplementedException();
        }

        public override int SetMasterUnitInfo(int type, float scale)
        {
            throw new NotImplementedException();
        }

        public override void GetUnitDisplayInfo(IDispInfo info)
        {
            throw new NotImplementedException();
        }

        public override int SetUnitDisplayInfo(IDispInfo info)
        {
            throw new NotImplementedException();
        }

        public override int SetUnitDisplayType(int type)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidUnitCharacter(int ch)
        {
            throw new NotImplementedException();
        }

        public override string FormatUniverseValue(float value)
        {
            throw new NotImplementedException();
        }

        public override float DecodeUniverseValue(string string_, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override void TimeToString(int t, ref string string_)
        {
            throw new NotImplementedException();
        }

        public override bool StringToTime(string string_, ref int t)
        {
            throw new NotImplementedException();
        }

        public override int LegalFrameRate(int r)
        {
            throw new NotImplementedException();
        }

        public override void RegisterDistanceDefault(string section, string key, float inchesDefault, float metersDefault)
        {
            throw new NotImplementedException();
        }

        public override void RestoreDistanceDefault(string section, string key, float inchesDefault, float metersDefault)
        {
            throw new NotImplementedException();
        }

        public override float GetDistanceDefault(string section, string key)
        {
            throw new NotImplementedException();
        }

        public override void SetDistanceDefault(string section, string key, float value)
        {
            throw new NotImplementedException();
        }

        public override IValue HeapPtr(IValue v)
        {
            throw new NotImplementedException();
        }

        public override IValue LivePtr(IValue v)
        {
            throw new NotImplementedException();
        }

        public override void ViewFileDestroy(IViewFile v)
        {
            throw new NotImplementedException();
        }

        public override float GetWindowFloat(IntPtr hwnd, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override int GetWindowInt(IntPtr hwnd, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override bool SetWindowTextInt(IntPtr hwnd, int i)
        {
            throw new NotImplementedException();
        }

        public override bool SetWindowTextFloat(IntPtr hwnd, float f, int precision)
        {
            throw new NotImplementedException();
        }

        public override bool SetDlgItemFloat(IntPtr hwnd, int idControl, float val)
        {
            throw new NotImplementedException();
        }

        public override float GetDlgItemFloat(IntPtr hwnd, int idControl, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override void SlideWindow(IntPtr hwnd, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void StretchWindow(IntPtr hwnd, int w, int h)
        {
            throw new NotImplementedException();
        }

        public override bool CenterWindow(IntPtr hWndChild, IntPtr hWndParent)
        {
            throw new NotImplementedException();
        }

        public override void GetClientRectP(IntPtr hwnd, IBox2 rect)
        {
            throw new NotImplementedException();
        }

        public override void DrawIconButton(IntPtr hdc, Bitmap hBitmap, IBox2 wrect, IBox2 brect, bool in_)
        {
            throw new NotImplementedException();
        }

        public override int GetListHieght(IntPtr hList)
        {
            throw new NotImplementedException();
        }

        public override void ShadedVertLine(IntPtr hdc, int x, int y0, int y1, bool in_)
        {
            throw new NotImplementedException();
        }

        public override void ShadedHorizLine(IntPtr hdc, int y, int x0, int x1, bool in_)
        {
            throw new NotImplementedException();
        }

        public override void ShadedRect(IntPtr hdc, ref Rectangle rect)
        {
            throw new NotImplementedException();
        }

        public override void Rect3D(IntPtr hdc, ref Rectangle rect, bool in_)
        {
            throw new NotImplementedException();
        }

        public override void WhiteRect3D(IntPtr hdc, Rectangle rect, bool in_)
        {
            throw new NotImplementedException();
        }

        public override void DrawButton(IntPtr hdc, Rectangle rect, bool in_)
        {
            throw new NotImplementedException();
        }

        public override void DisplayStringWithEllipses(string displayString, IntPtr hWnd, int additionalSpace)
        {
            throw new NotImplementedException();
        }

        public override int UpdateComboBoxDropDownWidth(IntPtr hComboBox, bool vScroll)
        {
            throw new NotImplementedException();
        }

        public override void XORDottedRect(IntPtr hwnd, IIPoint2 p0, IIPoint2 p1, int solidToRight, bool bErase, bool bDelayUpdate)
        {
            throw new NotImplementedException();
        }

        public override void XORDottedCircle(IntPtr hwnd, IIPoint2 p0, IIPoint2 p1, int solidToRight, bool bErase, bool bDelayUpdate)
        {
            throw new NotImplementedException();
        }

        public override void XORDottedPolyline(IntPtr hwnd, int count, IIPoint2 pts, int solid, bool bErase, bool bDelayUpdate)
        {
            throw new NotImplementedException();
        }

        public override void XORRect(IntPtr hdc, ref Rectangle r, int border)
        {
            throw new NotImplementedException();
        }

        public override bool IsHovering(IntPtr hWnd)
        {
            throw new NotImplementedException();
        }

        public override bool IsHovering(IntPtr hWnd, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void MakeButton2State(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override void MakeButton3State(IntPtr hCtrl)
        {
            throw new NotImplementedException();
        }

        public override int GetCheckBox(IntPtr hw, int id)
        {
            throw new NotImplementedException();
        }

        public override void SetCheckBox(IntPtr hw, int id, bool b)
        {
            throw new NotImplementedException();
        }

        public override bool DoesFileExist(string file, bool allowDirectory)
        {
            throw new NotImplementedException();
        }

        public override bool DoesDirectoryExist(string dir)
        {
            throw new NotImplementedException();
        }

        public override void StripTrailingZeros(string buf)
        {
            throw new NotImplementedException();
        }

        public override float Dbl2Flt(double val, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override int Dbl2Int(double val, IntPtr valid)
        {
            throw new NotImplementedException();
        }

        public override IntPtr MaxMsgBox(IntPtr hWnd, string lpText, string lpCaption, uint type, uint exType, IntPtr exRet)
        {
            throw new NotImplementedException();
        }

        public override string GetListBoxItemText(IntPtr hDlg, int nIDDlgItem, int nListboxItem)
        {
            throw new NotImplementedException();
        }

        public override void GetListBoxItemText(IntPtr hDlg, int nIDDlgItem, int nListboxItem, ref string itemText)
        {
            throw new NotImplementedException();
        }

        public override string GetListBoxItemText(IntPtr hListBoxWnd, int nListboxItem)
        {
            throw new NotImplementedException();
        }

        public override void GetListBoxItemText(IntPtr hListBoxWnd, int nListboxItem, ref string itemText)
        {
            throw new NotImplementedException();
        }

        public override string GetComboBoxItemText(IntPtr hDlg, int nIDDlgItem, int nComboboxItem)
        {
            throw new NotImplementedException();
        }

        public override void GetComboBoxItemText(IntPtr hDlg, int nIDDlgItem, int nComboboxItem, ref string itemText)
        {
            throw new NotImplementedException();
        }

        public override string GetComboBoxItemText(IntPtr hComboBoxWnd, int nComboboxItem)
        {
            throw new NotImplementedException();
        }

        public override void GetComboBoxItemText(IntPtr hComboBoxWnd, int nComboboxItem, ref string itemText)
        {
            throw new NotImplementedException();
        }

        public override int Deflate(Iz_stream_s strm, int flush)
        {
            throw new NotImplementedException();
        }

        public override int DeflateEnd(Iz_stream_s strm)
        {
            throw new NotImplementedException();
        }

        public override int Inflate(Iz_stream_s strm, int flush)
        {
            throw new NotImplementedException();
        }

        public override int InflateEnd(Iz_stream_s strm)
        {
            throw new NotImplementedException();
        }

        public override int DeflateReset(Iz_stream_s strm)
        {
            throw new NotImplementedException();
        }

        public override int InflateSetDictionary(Iz_stream_s strm, IntPtr dictionary, uint dictLength)
        {
            throw new NotImplementedException();
        }

        public override int InflateSync(Iz_stream_s strm)
        {
            throw new NotImplementedException();
        }

        public override int InflateReset(Iz_stream_s strm)
        {
            throw new NotImplementedException();
        }

        public override int Compress(IntPtr dest, UIntPtr destLen, IntPtr source, UIntPtr sourceLen)
        {
            throw new NotImplementedException();
        }

        public override int Uncompress(IntPtr dest, UIntPtr destLen, IntPtr source, UIntPtr sourceLen)
        {
            throw new NotImplementedException();
        }

        public override int Gzread(IntPtr file, IntPtr buf, uint len)
        {
            throw new NotImplementedException();
        }

        public override int Gzflush(IntPtr file, int flush)
        {
            throw new NotImplementedException();
        }

        public override int Gzclose(IntPtr file)
        {
            throw new NotImplementedException();
        }

        public override string Gzerror(IntPtr file, IntPtr errnum)
        {
            throw new NotImplementedException();
        }

        public override uint Crc32(uint crc, IntPtr buf, uint len)
        {
            throw new NotImplementedException();
        }

        public override int DeflateInit_(Iz_stream_s strm, int level, string version, int stream_size)
        {
            throw new NotImplementedException();
        }

        public override int InflateInit_(Iz_stream_s strm, string version, int stream_size)
        {
            throw new NotImplementedException();
        }

        public override int DeflateInit2_(Iz_stream_s strm, int level, int method, int windowBits, int memLevel, int strategy, string version,
            int stream_size)
        {
            throw new NotImplementedException();
        }

        public override void UtilOutOfMemoryException()
        {
            throw new NotImplementedException();
        }

        public override void UtilDeallocateMemory(IntPtr param0)
        {
            throw new NotImplementedException();
        }

        public override IIBipMaster CreateNewBiped(float height, float angle, IPoint3 wpos, bool arms, bool triPelvis, int nnecklinks,
            int nspinelinks, int nleglinks, int ntaillinks, int npony1links, int npony2links, int numfingers, int nfinglinks,
            int numtoes, int ntoelinks, float ankleAttach, bool prop1exists, bool prop2exists, bool prop3exists,
            int forearmTwistLinks, int upperarmTwistLinks, int thighTwistLinks, int calfTwistLinks, int horseTwistLinks)
        {
            throw new NotImplementedException();
        }

        public override void SetMacroRecorderInterface(IMacroRecorder mri)
        {
            throw new NotImplementedException();
        }

        public override void SetMacroScriptInterface(IMacroDir msd)
        {
            throw new NotImplementedException();
        }

        public override int GetSystemSetting(int id)
        {
            throw new NotImplementedException();
        }

        public override int GetMotionCaptureINISetting(int ID)
        {
            throw new NotImplementedException();
        }

        public override void SetMotionCaptureINISetting(int ID, int val)
        {
            throw new NotImplementedException();
        }

        public override void RegisterCOREInterface(IFPInterface fpi)
        {
            throw new NotImplementedException();
        }

        public override IFPInterface GetCOREInterface(IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        public override IFPInterface GetCOREInterfaceAt(int i)
        {
            throw new NotImplementedException();
        }

        public override void UnregisterCOREInterface(IFPInterface fpi)
        {
            throw new NotImplementedException();
        }

        public override IFPInterface GetInterface(SClass_ID super, IClass_ID cls, IInterface_ID id)
        {
            throw new NotImplementedException();
        }

        public override IISpecularCompositeShader GetSpecularCompositeShader(IInterfaceServer s)
        {
            throw new NotImplementedException();
        }

        public override void ChooseSpecularMethod(IInterfaceServer s, int t, IRenderGlobalContext rgc)
        {
            throw new NotImplementedException();
        }

        public override void SetErrorCallBack(IIGameErrorCallBack proc)
        {
            throw new NotImplementedException();
        }

        public override void ResetError()
        {
            throw new NotImplementedException();
        }

        public override IPoint3 Multiply(IPoint3 V, IGMatrix A)
        {
            throw new NotImplementedException();
        }

        public override IILinkTMCtrl GetLinkTMInterface(IControl c)
        {
            throw new NotImplementedException();
        }

        public override IISubTargetCtrl GetSubTargetInterface(IControl c)
        {
            throw new NotImplementedException();
        }

        public override void UpdateMotionFlowGraph()
        {
            throw new NotImplementedException();
        }

        public override IISubMtlMap_BrowserFilter GetISubMtlMapBrowserFilter(IInterfaceServer iserver)
        {
            throw new NotImplementedException();
        }

        public override IIMtlRender_Compatibility_MtlBase GetIMtlRenderCompabilityMtlBase(IClassDesc mtlBaseClassDesc)
        {
            throw new NotImplementedException();
        }

        public override IIMtlRender_Compatibility_Renderer GetIMtlRenderCompatibilityRenderer(IClassDesc rendererClassDesc)
        {
            throw new NotImplementedException();
        }

        public override bool AreMtlAndRendererCompatible(IClassDesc mtlBaseClassDesc, IClassDesc rendererClassDesc)
        {
            throw new NotImplementedException();
        }

        public override IObject GetPFObject(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIParticleGroup ParticleGroupInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIParticleGroup ParticleGroupInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIParticleGroupExt ParticleGroupExtInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIParticleGroupExt ParticleGroupExtInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFAction PFActionInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFAction PFActionInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override bool IsPFActionActive(IINode actionNode)
        {
            throw new NotImplementedException();
        }

        public override bool IsUndefinedPFAction(IINode actionNode)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionExt PFActionExtInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionExt PFActionExtInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionList GetParentPFActionList(IINode actionNode)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionList PFActionListInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionList PFActionListInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionListMaterialHolder PFActionListMaterialHolderInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionListMaterialHolder PFActionListMaterialHolderInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionListSet PFActionListSetInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFActionListSet PFActionListSetInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFArrow PFArrowInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFArrow PFArrowInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override void ReleasePFIntegrator(IIPFIntegrator integrator)
        {
            throw new NotImplementedException();
        }

        public override IIPFOperator PFOperatorInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFOperator PFOperatorInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFOperatorPhysXWorld PFOperatorPhysXWorldInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFOperatorPhysXWorld PFOperatorPhysXWorldInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFRender PFRenderInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFRender PFRenderInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFSystem PFSystemInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFSystem PFSystemInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFTest PFTestInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFTest PFTestInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPFViewport PFViewportInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPFViewport PFViewportInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IIPViewItem PViewItemInterface(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override IIPViewItem PViewItemInterface(IINode node)
        {
            throw new NotImplementedException();
        }

        public override IINode CreatePFNode(IObject obj)
        {
            throw new NotImplementedException();
        }

        public override void DeletePFNode(IINode node)
        {
            throw new NotImplementedException();
        }

        public override bool AppendPFAction(IINode actionList, IINode action)
        {
            throw new NotImplementedException();
        }

        public override bool InsertPFAction(IINode actionList, IINode action, int indexAt)
        {
            throw new NotImplementedException();
        }

        public override bool RemovePFAction(IINode actionList, int index)
        {
            throw new NotImplementedException();
        }

        public override bool RemovePFAction(IINode actionList, IINode action)
        {
            throw new NotImplementedException();
        }

        public override int GetPViewVacantSpace(IINode excludeNode)
        {
            throw new NotImplementedException();
        }

        public override int GetPViewMaximumZOrderIndex(IINode excludeNode)
        {
            throw new NotImplementedException();
        }

        public override void RegisterParticleFlowNotification()
        {
            throw new NotImplementedException();
        }

        public override void SuspendParticleFlowNotification()
        {
            throw new NotImplementedException();
        }

        public override void ResumeParticleFlowNotification()
        {
            throw new NotImplementedException();
        }

        public override void ReleasePViewManager()
        {
            throw new NotImplementedException();
        }

        public override int GetPFInt(IIParamBlock2 pblock, short id, int t, int tabIndex)
        {
            throw new NotImplementedException();
        }

        public override float GetPFFloat(IIParamBlock2 pblock, short id, int t, int tabIndex)
        {
            throw new NotImplementedException();
        }

        public override int GetPFTimeValue(IIParamBlock2 pblock, short id, int t, int tabIndex)
        {
            throw new NotImplementedException();
        }

        public override void InitPFDefaultDisplay(int type)
        {
            throw new NotImplementedException();
        }

        public override void InitPFActionOrder(int order)
        {
            throw new NotImplementedException();
        }

        public override void InitPFUpdateType(int type)
        {
            throw new NotImplementedException();
        }

        public override void InitPFDynamicNames(int type)
        {
            throw new NotImplementedException();
        }

        public override void DisableParticleInvalidation()
        {
            throw new NotImplementedException();
        }

        public override void EnableParticleInvalidation()
        {
            throw new NotImplementedException();
        }

        public override void SetIgnoreEmitterTMChange()
        {
            throw new NotImplementedException();
        }

        public override void ClearIgnoreEmitterTMChange()
        {
            throw new NotImplementedException();
        }

        public override void SetIgnoreEmitterPropChange()
        {
            throw new NotImplementedException();
        }

        public override void ClearIgnoreEmitterPropChange()
        {
            throw new NotImplementedException();
        }

        public override void SetIgnoreRefNodeChange()
        {
            throw new NotImplementedException();
        }

        public override void ClearIgnoreRefNodeChange()
        {
            throw new NotImplementedException();
        }

        public override void SetPFProceedStatus()
        {
            throw new NotImplementedException();
        }

        public override void ClearPFProceedStatus()
        {
            throw new NotImplementedException();
        }

        public override IIShadeContextExtension8 GetIShadeContextExtension8(IShadeContext sc)
        {
            throw new NotImplementedException();
        }

        public override IITabDialogObject GetTabDialogObject(IInterfaceServer obj)
        {
            throw new NotImplementedException();
        }

        public override Ivector Multiply(float f, Ivector a)
        {
            throw new NotImplementedException();
        }

        public override IPoint4 VtoP4(Ivector v)
        {
            throw new NotImplementedException();
        }

        public override void NeedsRedrawSet()
        {
            throw new NotImplementedException();
        }

        public override void NeedsCompleteRedrawSet()
        {
            throw new NotImplementedException();
        }

        public override void NeedsRedrawClear()
        {
            throw new NotImplementedException();
        }

        public override void InitThreadLocals()
        {
            throw new NotImplementedException();
        }

        public override bool GetUsePhysicalScaleUVs(IAnimatable pAnim)
        {
            throw new NotImplementedException();
        }

        public override void SetUsePhysicalScaleUVs(IAnimatable pAnim, bool flag)
        {
            throw new NotImplementedException();
        }

        public override IMaxNetManager CreateManager()
        {
            throw new NotImplementedException();
        }

        public override void DestroyManager(IMaxNetManager mgr)
        {
            throw new NotImplementedException();
        }

        public override bool JobReadMAXProperties(string max_filename, IJob job, ICJobText jobText)
        {
            throw new NotImplementedException();
        }

        public override void JobSetJobDefaults(IJob job)
        {
            throw new NotImplementedException();
        }

        public override void NumberedFilename(string infile, string outfile, int number)
        {
            throw new NotImplementedException();
        }

        public override bool GetMacAddress(IntPtr addr)
        {
            throw new NotImplementedException();
        }

        public override bool MatchMacAddress(IntPtr addr1, IntPtr addr2)
        {
            throw new NotImplementedException();
        }

        public override void Mac2String(IntPtr addr, string string_)
        {
            throw new NotImplementedException();
        }

        public override void Mac2StringCondensed(IntPtr addr, string string_)
        {
            throw new NotImplementedException();
        }

        public override void StringCondensed2Mac(string string_, IntPtr addr)
        {
            throw new NotImplementedException();
        }

        public override void InitConfigurationInfo(IConfigurationBlock cb, char workdisk)
        {
            throw new NotImplementedException();
        }

        public override bool MatchServers(IHSERVER srv1, IHSERVER srv2)
        {
            throw new NotImplementedException();
        }

        public override bool Maz(string archivename, string file_list, IntPtr filesize)
        {
            throw new NotImplementedException();
        }

        public override bool UnMaz(string archivename, string output_path)
        {
            throw new NotImplementedException();
        }

        public override string ResString(int id, string buffer)
        {
            throw new NotImplementedException();
        }

        public override bool ConvertOldJobFile(string oldFile, string newFile)
        {
            throw new NotImplementedException();
        }

        public override IMaxNetManager CreateManager(int platform)
        {
            throw new NotImplementedException();
        }

        public override bool ConvertOldJobFile(string oldFile, string newFile, int platform)
        {
            throw new NotImplementedException();
        }

        public override IManager Manager { get; }
        public override IBezFontManager TheBezFontManager { get; }
        public override IBitmapManager TheManager { get; }
        public override ITempStore TmpStore { get; }
        public override IClass_ID DummyClassID { get; }
        public override IEventRouter DeleteRouter { get; }
        public override IEventRouter BackspaceRouter { get; }
        public override IEventRouter TabkeyRouter { get; }
        public override IFilterManager TheFilterManager { get; }
        public override IGammaMgr GammaMgr { get; }
        public override IClass_ID GenericShapeClassID { get; }
        public override IGUPManager GupManager { get; }
        public override IHold TheHold { get; }
        public override ISceneFileDropType SceneFileDropType { get; }
        public override IImageFileDropType ImageFileDropType { get; }
        public override IScriptFileDropType ScriptFileDropType { get; }
        public override IDropScriptFileDropType DropScriptFileDropType { get; }
        public override IDropScriptDropType DropScriptDropType { get; }
        public override IBitmapDropType BitmapDropType { get; }
        public override IMSZipPackageFileDropType MsZipPackageFileDropType { get; }
        public override IPathConfigDropType PathConfigDropType { get; }
        public override char[] TexmapCat2d { get; }
        public override char[] TexmapCat3d { get; }
        public override char[] TexmapCatComp { get; }
        public override char[] TexmapCatColmod { get; }
        public override char[] TexmapCatEnv { get; }
        public override bool CheckMaxscriptInterrupt { get; }
        public override int MAXScriptSignals { get; }
        public override IParamDimension DefaultDim { get; }
        public override IClass_ID LinearShapeClassID { get; }
        public override bool EndKeyboardInput { get; }
        public override bool StartKeyboardInput { get; }
        public override string KeyboardInput { get; }
        public override IValue KeyboardTerminator { get; }
        public override IArray KeyboardInputTerminators { get; }
        public override IMacroRecorder MacroRecorder { get; }
        public override IMAXSuperClass MaxwrapperClass { get; }
        public override IMAXSuperClass NonReftargMaxwrapperClass { get; }
        public override IMAXSuperClass ReferencetargetClass { get; }
        public override IMAXSuperClass ReferencemakerClass { get; }
        public override IMAXSuperClass NodeClass { get; }
        public override IMAXClass InodeObject { get; }
        public override IMAXClass RootnodeObject { get; }
        public override IMAXSuperClass GeomClass { get; }
        public override IMAXSuperClass Modifier { get; }
        public override IMAXSuperClass Shape { get; }
        public override IMAXSuperClass HelperObject { get; }
        public override IMAXSuperClass SpacewarpObject { get; }
        public override IMAXSuperClass SpacewarpModifier { get; }
        public override IMAXSuperClass FloatController { get; }
        public override IMAXSuperClass Point3Controller { get; }
        public override IMAXSuperClass PositionController { get; }
        public override IMAXSuperClass QuatController { get; }
        public override IMAXSuperClass RotationController { get; }
        public override IMAXSuperClass ScaleController { get; }
        public override IMAXSuperClass Matrix3Controller { get; }
        public override IMAXSuperClass MorphController { get; }
        public override IMAXSuperClass MasterBlockController { get; }
        public override IMAXSuperClass LightObject { get; }
        public override IMAXSuperClass CameraObject { get; }
        public override IMAXSuperClass MaterialClass { get; }
        public override IMAXSuperClass ShaderClass { get; }
        public override IMAXSuperClass TextureMap { get; }
        public override IMAXSuperClass SystemObject { get; }
        public override IMAXSuperClass UtilityPlugin { get; }
        public override IMAXSuperClass GupPlugin { get; }
        public override IMAXSuperClass AtmosObject { get; }
        public override IMAXSuperClass RenderEffect { get; }
        public override IMAXSuperClass ShadowtypeClass { get; }
        public override IMAXSuperClass CustAttribClass { get; }
        public override IMAXSuperClass RendererClass { get; }
        public override IMAXSuperClass RenderElementClass { get; }
        public override IMAXSuperClass BakeElementClass { get; }
        public override IMAXSuperClass RadiosityEffectClass { get; }
        public override IMAXSuperClass ToneOperatorClass { get; }
        public override IMAXSuperClass BitmapIoClass { get; }
        public override IMAXSuperClass IksolverClass { get; }
        public override IMAXSuperClass MpassCamEffectClass { get; }
        public override IMAXSuperClass TvUtilityClass { get; }
        public override IHashTable EnglishToLocal { get; }
        public override IHashTable LocalToEnglish { get; }
        public override bool NonEnglishNumerics { get; }
        public override IInterface MAXScriptInterface { get; }
        public override IInterface7 MAXScriptInterface7 { get; }
        public override IInterface8 MAXScriptInterface8 { get; }
        public override IInterface9 MAXScriptInterface9 { get; }
        public override IInterface11 MAXScriptInterface11 { get; }
        public override IInterface13 MAXScriptInterface13 { get; }
        public override IInterface14 MAXScriptInterface14 { get; }
        public override bool EscapeEnabled { get; }
        public override bool MAXScriptDetaching { get; }
        public override bool MAXScriptRunning { get; }
        public override IntPtr MainThreadWindow { get; }
        public override bool ProgressBarUp { get; }
        public override IIMXSDebugger TheMXSDebugger { get; }
        public override IHashTable Globals { get; }
        public override IHashTable Persistents { get; }
        public override IListener TheListener { get; }
        public override IntPtr TheListenerWindow { get; }
        public override IRandGenerator ClassIDRandGenerator { get; }
        public override IClass_ID DerivObjClassID { get; }
        public override IClass_ID WSMDerivObjClassID { get; }
        public override IIdentityTM IdTM { get; }
        public override IClass_ID DefObjectClassID { get; }
        public override IClass_ID MapObjectClassID { get; }
        public override uint[] ChMask { get; }
        public override IClass_ID PatchObjectClassID { get; }
        public override IClass_ID PolyObjectClassID { get; }
        public override IReadonlyTextFileStreamClass ReadonlyTextFileStreamClass { get; }
        public override IClass_ID SplineShapeClassID { get; }
        public override IThunkClass ThunkClass { get; }
        public override IClass_ID TriObjectClassID { get; }
        public override IUndefined Undefined { get; }
        public override bool DontThrowAccessorError { get; }
        public override IBoolean TrueValue { get; }
        public override IBoolean FalseValue { get; }
        public override IUndefined DontCollect { get; }
        public override IUndefined LoopExit { get; }
        public override IOk Ok { get; }
        public override IEmpty Empty { get; }
        public override IUnsupplied Unsupplied { get; }
        public override INoValue NoValue { get; }
        public override IMocapManager TheMocapManager { get; }
        public override IMixerManager TheMixerManager { get; }
        public override IMaxMixerManager TheMaxMixerManager { get; }
        public override int ThreadLocalsIndex { get; }
        public override IMXS_Editor_Interface TheMxsEditorInterface { get; }
        public override IParamDimension StdWorldDim { get; }
        public override IParamDimension StdAngleDim { get; }
        public override IParamDimension StdColorDim { get; }
        public override IParamDimension StdColor255Dim { get; }
        public override IParamDimension StdPercentDim { get; }
        public override IParamDimension StdNormalizedDim { get; }
        public override IParamDimension StdSegmentsDim { get; }
        public override IParamDimension StdTimeDim { get; }
        public override IFPInterfaceDesc GRealWorldMapSizeDesc { get; }
        public override IIBitmapProxyManager BitmapProxyManager { get; }
        public override IQuantizer BMMNewQuantizer { get; }
        public override IIBitmapPager IBitmapPager { get; }
        public override int Animating { get; }
        public override int AnimStart { get; set; }
        public override int AnimEnd { get; set; }
        public override IControl NewDefaultFloatController { get; }
        public override IControl NewDefaultPositionController { get; }
        public override IControl NewDefaultRotationController { get; }
        public override IControl NewDefaultScaleController { get; }
        public override IControl NewDefaultBoolController { get; }
        public override IControl NewDefaultColorController { get; }
        public override IControl NewDefaultFRGBAController { get; }
        public override bool SetKeyMode { get; set; }
        public override bool SetKeySuspended { get; }
        public override bool SetKeyModeStatus { get; }
        public override bool IsSetKeyModeFeatureEnabled { get; }
        public override IntPtr LTGrayBrush { get; }
        public override IntPtr DKGrayBrush { get; }
        public override IntPtr FixedFont { get; }
        public override IntPtr FixedFontLocalCharSet { get; }
        public override IntPtr FixedFontBold { get; }
        public override IntPtr FixedFontBoldLocalCharSet { get; }
        public override int FixedFontHeight { get; }
        public override int FixedFontHeightSmall { get; }
        public override uint FixedFontCharset { get; }
        public override string FixedFontFace { get; }
        public override IntPtr UIFont { get; }
        public override IntPtr UIFontLocalCharSet { get; }
        public override IntPtr UIFontBold { get; }
        public override IntPtr UIFontBoldLocalCharSet { get; }
        public override int UIFontHeight { get; }
        public override int UIFontHeightSmall { get; }
        public override uint UIFontCharset { get; }
        public override string UIFontFace { get; }
        public override IntPtr PanCursor { get; }
        public override ICUIFrameMgr CUIFrameMgr { get; }
        public override bool AllFloatersAreHidden { get; }
        public override bool SnapSpinner_ { get; set; }
        public override float SnapSpinValue_ { get; set; }
        public override int SpinnerPrecision_ { get; set; }
        public override int SpinnerWrap_ { get; set; }
        public override bool SliderDragNotify_ { get; set; }
        public override bool SpinDragNotify_ { get; set; }
        public override bool AcceleratorsEnabled { get; }
        public override bool SaveRequiredFlag { get; }
        public override bool IsSaveRequired { get; }
        public override bool IsAutoSaveRequired { get; }
        public override IClassDesc DummyObjDescriptor { get; }
        public override int MaximumGBufferLayerDepth_ { get; set; }
        public override IGBuffer NewDefaultGBuffer { get; }
        public override int AutoCross_ { get; set; }
        public override int AutoCrossDir_ { get; set; }
        public override IGPort2 GPort2 { get; }
        public override IGPort GPort { get; }
        public override IIPoint2 CPInitPos_ { get; set; }
        public override IColPick CurColPick { get; }
        public override IIAssemblyMgr AssemblyMgr { get; }
        public override IIBrowserMgr BrowserMgr { get; }
        public override IFPInterfaceDesc BrowserInterfaceDesc { get; }
        public override IICommandPanel ICommandPanel { get; }
        public override IIDragAndDropMgr DragAndDropMgr { get; }
        public override IMacroDir MacroScriptDir { get; }
        public override IIQuadMenuSettings QuadSettings { get; }
        public override IIMenuItem IMenuItem { get; }
        public override IIMenu IMenu { get; }
        public override IIQuadMenu IQuadMenu { get; }
        public override IimrLPE LPE { get; }
        public override IimrPreferences MRPreferences { get; }
        public override IIMSZipMgr MSZipMgr { get; }
        public override IIMtlEditInterface MtlEditInterface { get; }
        public override IISect NewISect { get; }
        public override IDADBitmapCarrier DADBitmapCarrier { get; }
        public override IClassDesc MtlLibCD { get; }
        public override IClassDesc MtlBaseLibCD { get; }
        public override IUVGen NewDefaultUVGen { get; }
        public override IXYZGen NewDefaultXYZGen { get; }
        public override ITextureOutput NewDefaultTextureOutput { get; }
        public override IIParamWireMgr ParamWireMgr { get; }
        public override IIRefHierarchy RefHierarchyInterface { get; }
        public override IIRollupSettings IRollupSettings { get; }
        public override IIObjXRefManager ObjXRefManager { get; }
        public override IClassDesc LinearShapeDescriptor { get; }
        public override bool IsTrialLicense { get; }
        public override bool IsNetworkLicense { get; }
        public override string MarketDefaultsWriteLocation { get; }
        public override bool DontRepeatRefMsg { get; }
        public override bool InvalidateTMOpt { get; }
        public override IntPtr IconManDefaultImageList { get; }
        public override IntPtr IconManSmallImageList { get; }
        public override IntPtr IconManLargeImageList { get; }
        public override int MxsRand { get; }
        public override bool ErrorTraceBackActive { get; set; }
        public override bool ErrorTraceBackDisabled { get; set; }
        public override int ErrorTraceBackLevel { get; set; }
        public override int UseVisEdge_ { get; set; }
        public override int UseVertexDots_ { get; set; }
        public override int VertexDotType_ { get; set; }
        public override int HandleBoxType_ { get; set; }
        public override int DisplayBackFaceVertices_ { get; set; }
        public override IVertexNormalsControl VertexNormalsControl { get; }
        public override bool MIDIManIsOpened { get; }
        public override bool MIDIManIsStarted { get; }
        public override bool InMouseAbort { get; }
        public override string DeletedObjErrMessage { get; }
        public override INoteTrack NewDefaultNoteTrack { get; }
        public override IShapeNamedVertSelClip ShapeNamedVertSelClip_ { get; set; }
        public override IShapeNamedSegSelClip ShapeNamedSegSelClip_ { get; set; }
        public override IShapeNamedPolySelClip ShapeNamedPolySelClip_ { get; set; }
        public override int HitType_ { get; set; }
        public override bool DoingXORDraw { get; }
        public override float PerspMouseSpeed { get; set; }
        public override int MoveModeType_ { get; set; }
        public override float RotationIncrement_ { get; set; }
        public override IQuantizer NewQuantizer { get; }
        public override IClassDesc PatchObjDescriptor { get; }
        public override IClassDesc PolyObjDescriptor { get; }
        public override IClassDesc EditPolyObjDesc { get; }
        public override IQuat IdentQuat { get; }
        public override uint SavingVersion { get; }
        public override IShadBufRenderer NewDefaultShadBufRenderer { get; }
        public override IShadowType NewDefaultShadowMapType { get; }
        public override IShadowType NewDefaultRayShadowType { get; }
        public override IClassDesc SimpleOSMToWSMModDesc { get; }
        public override IClassDesc SimpleOSMToWSMMod2Desc { get; }
        public override ISoundObj NewDefaultSoundObj { get; }
        public override IClassDesc SplineShapeDescriptor { get; }
        public override IStdMat2 NewDefaultStdMat { get; }
        public override IBitmapTex NewDefaultBitmapTex { get; }
        public override IMultiMtl NewDefaultMultiMtl { get; }
        public override IMultiMtl NewEmptyMultiMtl { get; }
        public override IMultiTex NewDefaultCompositeTex { get; }
        public override IMultiTex NewDefaultMixTex { get; }
        public override IGradTex NewDefaultGradTex { get; }
        public override IStdCubic NewDefaultStdCubic { get; }
        public override IStdMirror NewDefaultStdMirror { get; }
        public override IStdFog NewDefaultStdFog { get; }
        public override bool IsDebugging { get; }
        public override int NumberOfProcessors { get; }
        public override int ScreenWidth { get; }
        public override int ScreenHeight { get; }
        public override bool IsUsingProfileDirectories { get; }
        public override bool IsUsingRoamingProfiles { get; }
        public override bool IsSSE { get; }
        public override IInterface UtilGetCOREInterface { get; }
        public override IIPathConfigMgrEx UtilGetPathConfigMgr { get; }
        public override string GapVersion { get; }
        public override IClassDesc TriObjDescriptor { get; }
        public override IClassDesc EditTriObjDesc { get; }
        public override int UnitDisplayType { get; }
        public override int USDefaultUnit_ { get; set; }
        public override string FirstUnitName { get; }
        public override string NextUnitName { get; }
        public override string FirstMetricDisp { get; }
        public override string NextMetricDisp { get; }
        public override string FirstUSDisp { get; }
        public override string NextUSDisp { get; }
        public override string FirstFraction { get; }
        public override string NextFraction { get; }
        public override int FrameRate { get; set; }
        public override int TicksPerFrame { get; set; }
        public override TimeDisp TimeDisplayMode { get; set; }
        public override IntPtr ViewFileCreate { get; }
        public override IIVisualMSMgr VisualMSMgr { get; }
        public override bool IsVistaAeroEnabled { get; }
        public override bool IsThemeSupported { get; }
        public override int BitsPerPixel { get; }
        public override Color ComputeViewportXORDrawColor { get; }
        public override string ZlibVersion { get; }
        public override int BipGetTicksPerFrame { get; }
        public override int FSAddSide { get; set; }
        public override uint N3DSMAXVersion { get; }
        public override IInterface COREInterface { get; }
        public override IInterface7 COREInterface7 { get; }
        public override IInterface8 COREInterface8 { get; }
        public override IInterface9 COREInterface9 { get; }
        public override IInterface10 COREInterface10 { get; }
        public override IInterface11 COREInterface11 { get; }
        public override IInterface12 COREInterface12 { get; }
        public override IInterface13 COREInterface13 { get; }
        public override IInterface14 COREInterface14 { get; }
        public override IInterface15 COREInterface15 { get; }
        
        public override int NumCOREInterfaces { get; }
        public override IIAutodesk360 Autodesk360Interface { get; }
        public override IIBatchRenderManager BatchRenderManager { get; }
        public override IIBrushPresetMgr IBrushPresetMgr { get; }
        public override IIContainerManager ContainerManagerInterface { get; }
        public override IIContainerPreferences ContainerPreferences { get; }
        public override IIGameConversionManager ConversionManager { get; }
        public override IIGameScene IGameInterface { get; }
        public override float IGameVersion { get; }
        public override float Supported3DSVersion { get; }
        public override IGameError LastIGameError { get; }
        public override string LastIGameErrorText { get; }
        public override IIGameRenderedSurface IGameRenderedSurfaceInterface { get; }
        public override IIGlobalDXDisplayManager GlobalDXDisplayManager { get; }
        public override IIGlobalDXDisplayManager2 GlobalDXDisplayManager2 { get; }
        public override IIHeightManager HeightManagerInterface { get; }
        public override IIMtlBrowserFilter_Manager IMtlBrowserFilterManager { get; }
        public override IIParamPubMgr ParamPubMgr { get; }
        public override IIProjectionRenderMgr IProjectionRenderMgr { get; }
        public override IIPFActionListPool PFActionListPool { get; }
        public override IIPFIntegrator PFIntegrator { get; }
        public override IIPFSystemPool PFSystemPool { get; }
        public override IIPViewManager PViewManager { get; }
        public override bool CompactPViewZOrder { get; }
        public override bool IsParticleFlowNotificationSuspended { get; }
        public override bool ValidateParticleFlows { get; }
        public override int PFDefaultDisplay { get; set; }
        public override int PFActionOrder { get; set; }
        public override int PFUpdateType { get; set; }
        public override int PFDynamicNames { get; set; }
        public override bool IsAbleInvalidateParticles { get; }
        public override bool IsIgnoringEmitterTMChange { get; }
        public override bool IsIgnoringEmitterPropChange { get; }
        public override bool IsIgnoringRefNodeChange { get; }
        public override bool IsPFProceeding { get; }
        public override IIRenderMessageManager RenderMessageManager { get; }
        public override IISceneEventManager ISceneEventManager { get; }
        public override IISceneStateManager SceneStateManager { get; }
        public override IITabDialogManager TabDialogManager { get; }
        public override IIDXShaderManagerInterface DXShaderManager { get; }
        public override IIViewportShadingMgr IViewportShadingMgr { get; }
        public override IIViewportShadingMgr2 IViewportShadingMgr2 { get; }
        public override IIViewPanelManager ViewPanelManager { get; }
        public override II3DXIXRefManager I3DXIXRefManager { get; }
        public override bool PhysicalScaleUVsDisabled { get; set; }
        public override IIParserLoader ParserLoader { get; }
        public override IGlobalMFL_IOProcessor MFL_IOProcessor { get; }
        public override IGlobalManipHitList ManipHitList { get; }
        public override IGlobalIDataObject IDataObject { get; }
        public override IGlobalHardwareMaterial HardwareMaterial { get; }
        public override IGlobalParamBlock ParamBlock { get; }
        public override IGlobalIGeomImp IGeomImp { get; }
        public override IGlobalBaseNode BaseNode { get; }
        public override IGlobalIStorage IStorage { get; }
        public override IGlobalBMMInterface BMMInterface { get; }
        public override IGlobalLayerIterator LayerIterator { get; }
        public override IGlobalConstLayerIterator ConstLayerIterator { get; }
        public override IGlobalMoFlow MoFlow { get; }
        public override IGlobalLayer Layer { get; }
        public override IGlobalcrowd_script crowd_script { get; }
        public override IGlobalBipMaster BipMaster { get; }
        public override IGlobalanimal animal { get; }
        public override IGlobalmrShaderDesc mrShaderDesc { get; }
        public override IGlobalGFX_MESH GFX_MESH { get; }
        public override IGlobalImportExportInterface ImportExportInterface { get; }
        public override IGlobalIKSys IKSys { get; }
        public override IGlobalMaxSDK MaxSDK { get; }
        public override IGlobalNodeEventNamespace NodeEventNamespace { get; }
        public override IGlobalPF PF { get; }
        public override IGlobalUtilityInterface UtilityInterface { get; }
        public override IGlobalbmmHistoryList bmmHistoryList { get; }
        public override IGlobalimrAdvancedTranslation imrAdvancedTranslation { get; }
        public override IGlobalimrGeomShaderTranslation imrGeomShaderTranslation { get; }
        public override IGlobalimrLightTranslation imrLightTranslation { get; }
        public override IGlobalimrLPE imrLPE { get; }
        public override IGlobalimrMaterialCustAttrib imrMaterialCustAttrib { get; }
        public override IGlobalimrMaterialPhenomenonTranslation imrMaterialPhenomenonTranslation { get; }
        public override IGlobalimrPreferences imrPreferences { get; }
        public override IGlobalimrShader imrShader { get; }
        public override IGlobalimrShaderClassDesc imrShaderClassDesc { get; }
        public override IGlobalimrShaderCreation imrShaderCreation { get; }
        public override IGlobalimrShaderTranslation imrShaderTranslation { get; }
        public override IGlobalimrShaderTranslation_ClassInfo imrShaderTranslation_ClassInfo { get; }
        public override IGlobalimrTranslation imrTranslation { get; }
        public override IGlobalmrShaderButtonHandler mrShaderButtonHandler { get; }
        public override IGlobalmrShaderFilter mrShaderFilter { get; }
        public override IGlobalmsgdata msgdata { get; }
        public override IGlobalmxs_notify_ref_data mxs_notify_ref_data { get; }
        public override IGlobalpath_properties path_properties { get; }
        public override IGlobalpath_property path_property { get; }
        public override IGlobalsrc_info src_info { get; }
        public override IGlobaltooltabentry tooltabentry { get; }
        public override IGlobalvector vector { get; }
        public override IGlobalAccessorError AccessorError { get; }
        public override IGlobalActionCallback ActionCallback { get; }
        public override IGlobalActionContext ActionContext { get; }
        public override IGlobalActionItem ActionItem { get; }
        public override IGlobalActionTable ActionTable { get; }
        public override IGlobalActiveXLicensor ActiveXLicensor { get; }
        public override IGlobalAdjEdgeList AdjEdgeList { get; }
        public override IGlobalAdjFace AdjFace { get; }
        public override IGlobalAdjFaceList AdjFaceList { get; }
        public override IGlobalAngAxis AngAxis { get; }
        public override IGlobalAngAxisValue AngAxisValue { get; }
        public override IGlobalAnimatable Animatable { get; }
        public override IGlobalAnimateSuspend AnimateSuspend { get; }
        public override IGlobalAnimAppData AnimAppData { get; }
        public override IGlobalAnimEnum AnimEnum { get; }
        public override IGlobalAnimProperty AnimProperty { get; }
        public override IGlobalAnimPropertyList AnimPropertyList { get; }
        public override IGlobalAnyKey AnyKey { get; }
        public override IGlobalAppendGizmoRestore AppendGizmoRestore { get; }
        public override IGlobalAppDataChunk AppDataChunk { get; }
        public override IGlobalAppLoad AppLoad { get; }
        public override IGlobalAppSave AppSave { get; }
        public override IGlobalArcballCallback ArcballCallback { get; }
        public override IGlobalArcballDialog ArcballDialog { get; }
        public override IGlobalAreaShadowGenerator AreaShadowGenerator { get; }
        public override IGlobalAreaShadowSampler AreaShadowSampler { get; }
        public override IGlobalArgCountError ArgCountError { get; }
        public override IGlobalArray Array { get; }
        public override IGlobalAssetEnumCallback AssetEnumCallback { get; }
        public override IGlobalAssignControllerRestore AssignControllerRestore { get; }
        public override IGlobalAssignToConstError AssignToConstError { get; }
        public override IGlobalAtmospheric Atmospheric { get; }
        public override IGlobalAttachMatDlgUser AttachMatDlgUser { get; }
        public override IGlobalAvailableFont AvailableFont { get; }
        public override IGlobalAxisChangeCallback AxisChangeCallback { get; }
        public override IGlobalAColor AColor { get; }
        public override IGlobalATSClientInfo ATSClientInfo { get; }
        public override IGlobalATSExploreProviderParams ATSExploreProviderParams { get; }
        public override IGlobalATSFileEntry ATSFileEntry { get; }
        public override IGlobalATSFileList ATSFileList { get; }
        public override IGlobalATSNotification ATSNotification { get; }
        public override IGlobalATSNotifyParams ATSNotifyParams { get; }
        public override IGlobalATSUserEntry ATSUserEntry { get; }
        public override IGlobalATSUserList ATSUserList { get; }
        public override IGlobalBaseBehavior BaseBehavior { get; }
        public override IGlobalBaseInterface BaseInterface { get; }
        public override IGlobalBaseInterfaceServer BaseInterfaceServer { get; }
        public override IGlobalBaseObject BaseObject { get; }
        public override IGlobalBaseShader BaseShader { get; }
        public override IGlobalBasisFinder BasisFinder { get; }
        public override IGlobalBezierShape BezierShape { get; }
        public override IGlobalBezierShapeInterface_Ex41 BezierShapeInterface_Ex41 { get; }
        public override IGlobalBezierShapeTopology BezierShapeTopology { get; }
        public override IGlobalBezFont BezFont { get; }
        public override IGlobalBezFontDll BezFontDll { get; }
        public override IGlobalBezFontEnumProc BezFontEnumProc { get; }
        public override IGlobalBezFontEX BezFontEX { get; }
        public override IGlobalBezFontEX2 BezFontEX2 { get; }
        public override IGlobalBezFontInfo BezFontInfo { get; }
        public override IGlobalBezFontManager BezFontManager { get; }
        public override IGlobalBezFontMetrics BezFontMetrics { get; }
        public override IGlobalBezFontMgrEnumProc BezFontMgrEnumProc { get; }
        public override IGlobalBigMatrix BigMatrix { get; }
        public override IGlobalBitmap Bitmap { get; }
        public override IGlobalBitmapDither BitmapDither { get; }
        public override IGlobalBitmapDropType BitmapDropTypeNS { get; }
        public override IGlobalBitmapFileInputDialog BitmapFileInputDialog { get; }
        public override IGlobalBitmapFileOutputDialog BitmapFileOutputDialog { get; }
        public override IGlobalBitmapFilter BitmapFilter { get; }
        public override IGlobalBitmapInfo BitmapInfo { get; }
        public override IGlobalBitmapIO BitmapIO { get; }
        public override IGlobalBitmapIOLayer BitmapIOLayer { get; }
        public override IGlobalBitmapIOMetaData BitmapIOMetaData { get; }
        public override IGlobalBitmapLayerUtl BitmapLayerUtl { get; }
        public override IGlobalBitmapManager BitmapManager { get; }
        public override IGlobalBitmapNotify BitmapNotify { get; }
        public override IGlobalBitmapProxyTemporaryDisableGuard BitmapProxyTemporaryDisableGuard { get; }
        public override IGlobalBitmapStorage BitmapStorage { get; }
        public override IGlobalBitmapStorageHDR BitmapStorageHDR { get; }
        public override IGlobalBitmapStorageLDR BitmapStorageLDR { get; }
        public override IGlobalBitmapTex BitmapTex { get; }
        public override IGlobalBitArray BitArray { get; }
        public override IGlobalBitArrayCallback BitArrayCallback { get; }
        public override IGlobalBitArrayValue BitArrayValue { get; }
        public override IGlobalBoolean Boolean { get; }
        public override IGlobalBox2 Box2 { get; }
        public override IGlobalBox2D Box2D { get; }
        public override IGlobalBox2Value Box2Value { get; }
        public override IGlobalBox3 Box3 { get; }
        public override IGlobalBox3Value Box3Value { get; }
        public override IGlobalBoxGizmoObject BoxGizmoObject { get; }
        public override IGlobalBoxLineProc BoxLineProc { get; }
        public override IGlobalBMM_IOHandler BMM_IOHandler { get; }
        public override IGlobalBMM_IOList BMM_IOList { get; }
        public override IGlobalCacheClass CacheClass { get; }
        public override IGlobalCallbackScript CallbackScript { get; }
        public override IGlobalCallContext CallContext { get; }
        public override IGlobalCamera Camera { get; }
        public override IGlobalCameraObject CameraObjectNS { get; }
        public override IGlobalCandidate Candidate { get; }
        public override IGlobalCapFace CapFace { get; }
        public override IGlobalCapPatch CapPatch { get; }
        public override IGlobalCapVert CapVert { get; }
        public override IGlobalChangeForegroundCallback ChangeForegroundCallback { get; }
        public override IGlobalChangeFGObject ChangeFGObject { get; }
        public override IGlobalChangeHandler ChangeHandler { get; }
        public override IGlobalCharBinaryStream CharBinaryStream { get; }
        public override IGlobalCharStream CharStream { get; }
        public override IGlobalCheckAbortCallback CheckAbortCallback { get; }
        public override IGlobalClassDesc ClassDesc { get; }
        public override IGlobalClassDesc2 ClassDesc2 { get; }
        public override IGlobalClassDirectory ClassDirectory { get; }
        public override IGlobalClassEntry ClassEntry { get; }
        public override IGlobalClass_ID Class_ID { get; }
        public override IGlobalClearAnimFlagEnumProc ClearAnimFlagEnumProc { get; }
        public override IGlobalCodeBlock CodeBlock { get; }
        public override IGlobalCodeBlockLocalThunk CodeBlockLocalThunk { get; }
        public override IGlobalCodeTree CodeTree { get; }
        public override IGlobalCollectable Collectable { get; }
        public override IGlobalCollection Collection { get; }
        public override IGlobalCollisionMesh CollisionMesh { get; }
        public override IGlobalCollisionObject CollisionObject { get; }
        public override IGlobalCollisionOps CollisionOps { get; }
        public override IGlobalCollisionPlane CollisionPlane { get; }
        public override IGlobalCollisionSphere CollisionSphere { get; }
        public override IGlobalCollisionVNormal CollisionVNormal { get; }
        public override IGlobalColor Color { get; }
        public override IGlobalColorPacker ColorPacker { get; }
        public override IGlobalColorPicker ColorPicker { get; }
        public override IGlobalColorValue ColorValue { get; }
        public override IGlobalColPick ColPick { get; }
        public override IGlobalCommandMode CommandMode { get; }
        public override IGlobalCommandModeChangedCallback CommandModeChangedCallback { get; }
        public override IGlobalCompileError CompileError { get; }
        public override IGlobalConstColorValue ConstColorValue { get; }
        public override IGlobalConstGlobalThunk ConstGlobalThunk { get; }
        public override IGlobalConstObject ConstObject { get; }
        public override IGlobalConstPluginLocalThunk ConstPluginLocalThunk { get; }
        public override IGlobalConstPoint3Value ConstPoint3Value { get; }
        public override IGlobalConstRolloutLocalThunk ConstRolloutLocalThunk { get; }
        public override IGlobalContextThunk ContextThunk { get; }
        public override IGlobalControl Control { get; }
        public override IGlobalConversionError ConversionError { get; }
        public override IGlobalConvertToRestore ConvertToRestore { get; }
        public override IGlobalCreateInstanceCallParam CreateInstanceCallParam { get; }
        public override IGlobalCreateMouseCallBack CreateMouseCallBack { get; }
        public override IGlobalCreateRendImgSeqCallback CreateRendImgSeqCallback { get; }
        public override IGlobalCropCallback CropCallback { get; }
        public override IGlobalCtrlHitLog CtrlHitLog { get; }
        public override IGlobalCtrlHitRecord CtrlHitRecord { get; }
        public override IGlobalCurvePoint CurvePoint { get; }
        public override IGlobalCurSelObjectSet CurSelObjectSet { get; }
        public override IGlobalCustomParticleDisplay CustomParticleDisplay { get; }
        public override IGlobalCustAttrib CustAttrib { get; }
        public override IGlobalCylGizmoObject CylGizmoObject { get; }
        public override IGlobalCAssertCB CAssertCB { get; }
        public override IGlobalCExcepInfo CExcepInfo { get; }
        public override IGlobalCHRedrawViewsCallback CHRedrawViewsCallback { get; }
        public override IGlobalCJobText CJobText { get; }
        public override IGlobalCUIFrameMgr CUIFrameMgrNS { get; }
        public override IGlobalCUIFrameMsgHandler CUIFrameMsgHandler { get; }
        public override IGlobalCUIPosData CUIPosData { get; }
        public override IGlobalDataClassDesc DataClassDesc { get; }
        public override IGlobalDataEntryMouseProc DataEntryMouseProc { get; }
        public override IGlobalDebuggerRuntimeError DebuggerRuntimeError { get; }
        public override IGlobalDefaultActionSys DefaultActionSys { get; }
        public override IGlobalDefaultLight DefaultLight { get; }
        public override IGlobalDefaultRemapDir DefaultRemapDir { get; }
        public override IGlobalDeformer Deformer { get; }
        public override IGlobalDefNoteTrack DefNoteTrack { get; }
        public override IGlobalDelayedMatrix3 DelayedMatrix3 { get; }
        public override IGlobalDelayedNodeMat DelayedNodeMat { get; }
        public override IGlobalDeletedRestore DeletedRestore { get; }
        public override IGlobalDeleteGizmoRestore DeleteGizmoRestore { get; }
        public override IGlobalDependentEnumProc DependentEnumProc { get; }
        public override IGlobalDependentIterator DependentIterator { get; }
        public override IGlobalDerefThunk DerefThunk { get; }
        public override IGlobalDeviceRect DeviceRect { get; }
        public override IGlobalDialogItemSizeData DialogItemSizeData { get; }
        public override IGlobalDialogResizer DialogResizer { get; }
        public override IGlobalDisplayFilterCallback DisplayFilterCallback { get; }
        public override IGlobalDllData DllData { get; }
        public override IGlobalDllDesc DllDesc { get; }
        public override IGlobalDllDir DllDir { get; }
        public override IGlobalDotRunParser DotRunParser { get; }
        public override IGlobalDouble Double { get; }
        public override IGlobalDragAndDropHandler DragAndDropHandler { get; }
        public override IGlobalDrawLineProc DrawLineProc { get; }
        public override IGlobalDropClipFormat DropClipFormat { get; }
        public override IGlobalDropScriptClipFmt DropScriptClipFmt { get; }
        public override IGlobalDropScriptDropType DropScriptDropTypeNS { get; }
        public override IGlobalDropScriptFileDropType DropScriptFileDropTypeNS { get; }
        public override IGlobalDropType DropType { get; }
        public override IGlobalDummyObject DummyObject { get; }
        public override IGlobalDynamicMenu DynamicMenu { get; }
        public override IGlobalDynamicMenuCallback DynamicMenuCallback { get; }
        public override IGlobalDynamHelperObject DynamHelperObject { get; }
        public override IGlobalDynamModObject DynamModObject { get; }
        public override IGlobalDADBitmapCarrier DADBitmapCarrierNS { get; }
        public override IGlobalDADMgr DADMgr { get; }
        public override IGlobalDMatrix3 DMatrix3 { get; }
        public override IGlobalDOFParams DOFParams { get; }
        public override IGlobalDPoint3 DPoint3 { get; }
        public override IGlobalDRay DRay { get; }
        public override IGlobalDWORDTab DWORDTab { get; }
        public override IGlobalEaseCurveAnimProp EaseCurveAnimProp { get; }
        public override IGlobalEaseCurveList EaseCurveList { get; }
        public override IGlobalEdgeBondage EdgeBondage { get; }
        public override IGlobalEdgeClusterList EdgeClusterList { get; }
        public override IGlobalEditorStyleDef EditorStyleDef { get; }
        public override IGlobalEditor_Interface Editor_Interface { get; }
        public override IGlobalEditSSCB EditSSCB { get; }
        public override IGlobalEditSSMode EditSSMode { get; }
        public override IGlobalEffect Effect { get; }
        public override IGlobalEffect8 Effect8 { get; }
        public override IGlobalEffectDescriptor EffectDescriptor { get; }
        public override IGlobalEmpty EmptyNS { get; }
        public override IGlobalEulerAnglesValue EulerAnglesValue { get; }
        public override IGlobalEventRouter EventRouter { get; }
        public override IGlobalEventUser EventUser { get; }
        public override IGlobalExclList ExclList { get; }
        public override IGlobalExitMAXCallback ExitMAXCallback { get; }
        public override IGlobalExitMAXCallback2 ExitMAXCallback2 { get; }
        public override IGlobalExposureMaterialControl ExposureMaterialControl { get; }
        public override IGlobalExposureMaterialControlDesc ExposureMaterialControlDesc { get; }
        public override IGlobalExpr Expr { get; }
        public override IGlobalExprVar ExprVar { get; }
        public override IGlobalExpInterface ExpInterface { get; }
        public override IGlobalExtrudeData ExtrudeData { get; }
        public override IGlobalEPoly EPoly { get; }
        public override IGlobalEPoly13 EPoly13 { get; }
        public override IGlobalEPoly18 EPoly18 { get; }
        public override IGlobalEPolyMod EPolyMod { get; }
        public override IGlobalEPolyMod13 EPolyMod13 { get; }
        public override IGlobalEPolyMod18 EPolyMod18 { get; }
        public override IGlobalEP_BevelCMode EP_BevelCMode { get; }
        public override IGlobalEP_BevelMouseProc EP_BevelMouseProc { get; }
        public override IGlobalEP_BevelSelectionProcessor EP_BevelSelectionProcessor { get; }
        public override IGlobalEP_BindCMode EP_BindCMode { get; }
        public override IGlobalEP_BindMouseProc EP_BindMouseProc { get; }
        public override IGlobalEP_CopyTangentCMode EP_CopyTangentCMode { get; }
        public override IGlobalEP_CopyTangentMouseProc EP_CopyTangentMouseProc { get; }
        public override IGlobalEP_CreatePatchCMode EP_CreatePatchCMode { get; }
        public override IGlobalEP_CreatePatchMouseProc EP_CreatePatchMouseProc { get; }
        public override IGlobalEP_CreateVertCMode EP_CreateVertCMode { get; }
        public override IGlobalEP_CreateVertMouseProc EP_CreateVertMouseProc { get; }
        public override IGlobalEP_ExtrudeCMode EP_ExtrudeCMode { get; }
        public override IGlobalEP_ExtrudeMouseProc EP_ExtrudeMouseProc { get; }
        public override IGlobalEP_ExtrudeSelectionProcessor EP_ExtrudeSelectionProcessor { get; }
        public override IGlobalEP_NormalFlipCMode EP_NormalFlipCMode { get; }
        public override IGlobalEP_NormalFlipMouseProc EP_NormalFlipMouseProc { get; }
        public override IGlobalEP_PasteTangentCMode EP_PasteTangentCMode { get; }
        public override IGlobalEP_PasteTangentMouseProc EP_PasteTangentMouseProc { get; }
        public override IGlobalEP_VertWeldCMode EP_VertWeldCMode { get; }
        public override IGlobalEP_VertWeldMouseProc EP_VertWeldMouseProc { get; }
        public override IGlobalFace Face { get; }
        public override IGlobalFaceChange FaceChange { get; }
        public override IGlobalFaceClusterList FaceClusterList { get; }
        public override IGlobalFaceCreate FaceCreate { get; }
        public override IGlobalFaceDataFromPatch FaceDataFromPatch { get; }
        public override IGlobalFaceElementList FaceElementList { get; }
        public override IGlobalFaceEx FaceEx { get; }
        public override IGlobalFaceRemap FaceRemap { get; }
        public override IGlobalFaceSmooth FaceSmooth { get; }
        public override IGlobalFileDropType FileDropType { get; }
        public override IGlobalFileStream FileStream { get; }
        public override IGlobalFilterKernel FilterKernel { get; }
        public override IGlobalFilterList FilterList { get; }
        public override IGlobalFilterManager FilterManager { get; }
        public override IGlobalFindCustAttribOwnerDEP FindCustAttribOwnerDEP { get; }
        public override IGlobalFindMAXWrapperEnum FindMAXWrapperEnum { get; }
        public override IGlobalFlagUser FlagUser { get; }
        public override IGlobalFloat Float { get; }
        public override IGlobalFlyOffData FlyOffData { get; }
        public override IGlobalFnCallPropertyThunk FnCallPropertyThunk { get; }
        public override IGlobalFontMgrInterface FontMgrInterface { get; }
        public override IGlobalForceField ForceField { get; }
        public override IGlobalFrameRange FrameRange { get; }
        public override IGlobalFrameRendParams FrameRendParams { get; }
        public override IGlobalFreeThunk FreeThunk { get; }
        public override IGlobalFunctionReturn FunctionReturn { get; }
        public override IGlobalFLTInterface FLTInterface { get; }
        public override IGlobalFLT_FilterHandler FLT_FilterHandler { get; }
        public override IGlobalFLT_FilterList FLT_FilterList { get; }
        public override IGlobalFPActionDef FPActionDef { get; }
        public override IGlobalFPEnum FPEnum { get; }
        public override IGlobalFPFunctionDef FPFunctionDef { get; }
        public override IGlobalFPInterface FPInterface { get; }
        public override IGlobalFPInterfaceDesc FPInterfaceDesc { get; }
        public override IGlobalFPMacroEmitter FPMacroEmitter { get; }
        public override IGlobalFPMixinInterface FPMixinInterface { get; }
        public override IGlobalFPParams FPParams { get; }
        public override IGlobalFPParamDef FPParamDef { get; }
        public override IGlobalFPParamOptions FPParamOptions { get; }
        public override IGlobalFPPropDef FPPropDef { get; }
        public override IGlobalFPStaticInterface FPStaticInterface { get; }
        public override IGlobalFPValidator FPValidator { get; }
        public override IGlobalFPValue FPValue { get; }
        public override IGlobalGammaMgr GammaMgrNS { get; }
        public override IGlobalGamConvert16 GamConvert16 { get; }
        public override IGlobalGamConvert8 GamConvert8 { get; }
        public override IGlobalGenericCallback GenericCallback { get; }
        public override IGlobalGenericHierarchy GenericHierarchy { get; }
        public override IGlobalGenericNamedSelSetList GenericNamedSelSetList { get; }
        public override IGlobalGenBoxObject GenBoxObject { get; }
        public override IGlobalGenCamera GenCamera { get; }
        public override IGlobalGenControlSelectionProcessor GenControlSelectionProcessor { get; }
        public override IGlobalGenCylinder GenCylinder { get; }
        public override IGlobalGenLight GenLight { get; }
        public override IGlobalGenModSelectionProcessor GenModSelectionProcessor { get; }
        public override IGlobalGenSphere GenSphere { get; }
        public override IGlobalGenSubObjType GenSubObjType { get; }
        public override IGlobalGeomObject GeomObject { get; }
        public override IGlobalGeomPipelineEnumProc GeomPipelineEnumProc { get; }
        public override IGlobalGetParamDim GetParamDim { get; }
        public override IGlobalGetParamName GetParamName { get; }
        public override IGlobalGizmoClass GizmoClass { get; }
        public override IGlobalGizmoObject GizmoObject { get; }
        public override IGlobalGizmoShape GizmoShape { get; }
        public override IGlobalGlobalReferenceMaker GlobalReferenceMaker { get; }
        public override IGlobalGlobalThunk GlobalThunk { get; }
        public override IGlobalGradTex GradTex { get; }
        public override IGlobalGraphicsWindow GraphicsWindow { get; }
        public override IGlobalGripChangedCallback GripChangedCallback { get; }
        public override IGlobalGBuffer GBuffer { get; }
        public override IGlobalGBufReader GBufReader { get; }
        public override IGlobalGBufWriter GBufWriter { get; }
        public override IGlobalGMatrix GMatrix { get; }
        public override IGlobalGPort GPortNS { get; }
        public override IGlobalGPort2 GPort2NS { get; }
        public override IGlobalGUP GUP { get; }
        public override IGlobalGUPHandler GUPHandler { get; }
        public override IGlobalGUPInterface GUPInterface { get; }
        public override IGlobalGUPList GUPList { get; }
        public override IGlobalGUPManager GUPManager { get; }
        public override IGlobalGWinSetup GWinSetup { get; }
        public override IGlobalGWFace GWFace { get; }
        public override IGlobalHashTable HashTable { get; }
        public override IGlobalHashTabMapper HashTabMapper { get; }
        public override IGlobalHelperObject HelperObjectNS { get; }
        public override IGlobalHierarchyEntry HierarchyEntry { get; }
        public override IGlobalHitByNameDlgCallback HitByNameDlgCallback { get; }
        public override IGlobalHitData HitData { get; }
        public override IGlobalHitListWrapper HitListWrapper { get; }
        public override IGlobalHitLog HitLog { get; }
        public override IGlobalHitMesh HitMesh { get; }
        public override IGlobalHitRecord HitRecord { get; }
        public override IGlobalHitRegion HitRegion { get; }
        public override IGlobalHold Hold { get; }
        public override IGlobalHoldSuspend HoldSuspend { get; }
        public override IGlobalHookPoint HookPoint { get; }
        public override IGlobalHSVCallback HSVCallback { get; }
        public override IGlobalI3DXIXRefManager I3DXIXRefManagerNS { get; }
        public override IGlobalIdentityTM IdentityTM { get; }
        public override IGlobalIlluminateComponents IlluminateComponents { get; }
        public override IGlobalIllumParams IllumParams { get; }
        public override IGlobalImageFileDropType ImageFileDropTypeNS { get; }
        public override IGlobalImageFilter ImageFilter { get; }
        public override IGlobalImageFilterInfo ImageFilterInfo { get; }
        public override IGlobalImportFileDropType ImportFileDropType { get; }
        public override IGlobalImpInterface ImpInterface { get; }
        public override IGlobalImpNode ImpNode { get; }
        public override IGlobalIncompatibleTypes IncompatibleTypes { get; }
        public override IGlobalIndexThunk IndexThunk { get; }
        public override IGlobalIndirectFreeThunk IndirectFreeThunk { get; }
        public override IGlobalIndirectLocalThunk IndirectLocalThunk { get; }
        public override IGlobalInitJointData InitJointData { get; }
        public override IGlobalInitJointData2 InitJointData2 { get; }
        public override IGlobalInitJointData3 InitJointData3 { get; }
        public override IGlobalInst Inst { get; }
        public override IGlobalInteger Integer { get; }
        public override IGlobalInteger64 Integer64 { get; }
        public override IGlobalIntegerPtr IntegerPtr { get; }
        public override IGlobalInterface Interface { get; }
        public override IGlobalInterface10 Interface10 { get; }
        public override IGlobalInterface11 Interface11 { get; }
        public override IGlobalInterface12 Interface12 { get; }
        public override IGlobalInterface13 Interface13 { get; }
        public override IGlobalInterface14 Interface14 { get; }
        public override IGlobalInterface15 Interface15 { get; }
        public override IGlobalInterface16 Interface16 { get; }
        public override IGlobalInterface7 Interface7 { get; }
        public override IGlobalInterface8 Interface8 { get; }
        public override IGlobalInterface9 Interface9 { get; }
        public override IGlobalInterfaceMethod InterfaceMethod { get; }
        public override IGlobalInterfaceNotifyCallback InterfaceNotifyCallback { get; }
        public override IGlobalInterfaceServer InterfaceServer { get; }
        public override IGlobalInterface_ID Interface_ID { get; }
        public override IGlobalInterpCtrlUI InterpCtrlUI { get; }
        public override IGlobalInterpKeyInfo InterpKeyInfo { get; }
        public override IGlobalIntersectionCallback2D IntersectionCallback2D { get; }
        public override IGlobalIntersectionCallback3D IntersectionCallback3D { get; }
        public override IGlobalInterval Interval { get; }
        public override IGlobalItemID ItemID { get; }
        public override IGlobalIActionItemOverride IActionItemOverride { get; }
        public override IGlobalIActionItemOverrideManager IActionItemOverrideManager { get; }
        public override IGlobalIActionManager IActionManager { get; }
        public override IGlobalIActionManager10 IActionManager10 { get; }
        public override IGlobalIActionOptions IActionOptions { get; }
        public override IGlobalIAdjustMultipleTangents IAdjustMultipleTangents { get; }
        public override IGlobalIAnalyzer IAnalyzer { get; }
        public override IGlobalIAnimLayerControlManager IAnimLayerControlManager { get; }
        public override IGlobalIAnimTrack IAnimTrack { get; }
        public override IGlobalIAreaShadowType IAreaShadowType { get; }
        public override IGlobalIAssembly IAssembly { get; }
        public override IGlobalIAssemblyMgr IAssemblyMgr { get; }
        public override IGlobalIAssetAccessor IAssetAccessor { get; }
        public override IGlobalIAssignVertexColors IAssignVertexColors { get; }
        public override IGlobalIAssignVertexColors_R7 IAssignVertexColors_R7 { get; }
        public override IGlobalIAttachCtrl IAttachCtrl { get; }
        public override IGlobalIAutodesk360 IAutodesk360 { get; }
        public override IGlobalIAutoEParamDlg IAutoEParamDlg { get; }
        public override IGlobalIAutoMParamDlg IAutoMParamDlg { get; }
        public override IGlobalIAutoTangentMan IAutoTangentMan { get; }
        public override IGlobalIADTCategory IADTCategory { get; }
        public override IGlobalIADTObjMgr IADTObjMgr { get; }
        public override IGlobalIADTStyle IADTStyle { get; }
        public override IGlobalIATSClientAccess IATSClientAccess { get; }
        public override IGlobalIATSCustomDeps IATSCustomDeps { get; }
        public override IGlobalIATSMax IATSMax { get; }
        public override IGlobalIATSNotifyCallback IATSNotifyCallback { get; }
        public override IGlobalIATSProvider IATSProvider { get; }
        public override IGlobalIBaseGrip IBaseGrip { get; }
        public override IGlobalIBaseGrip2 IBaseGrip2 { get; }
        public override IGlobalIBaseScriptControl IBaseScriptControl { get; }
        public override IGlobalIBaseScriptControl8 IBaseScriptControl8 { get; }
        public override IGlobalIBaseWireControl IBaseWireControl { get; }
        public override IGlobalIBatchRenderManager IBatchRenderManager { get; }
        public override IGlobalIBatchRenderView IBatchRenderView { get; }
        public override IGlobalIBezFloatKey IBezFloatKey { get; }
        public override IGlobalIBezPoint2Key IBezPoint2Key { get; }
        public override IGlobalIBezPoint3Key IBezPoint3Key { get; }
        public override IGlobalIBezPoint4Key IBezPoint4Key { get; }
        public override IGlobalIBezQuatKey IBezQuatKey { get; }
        public override IGlobalIBezScaleKey IBezScaleKey { get; }
        public override IGlobalIBipedBodyKey IBipedBodyKey { get; }
        public override IGlobalIBipedCopy IBipedCopy { get; }
        public override IGlobalIBipedExport IBipedExport { get; }
        public override IGlobalIBipedFSKey IBipedFSKey { get; }
        public override IGlobalIBipedHeadKey IBipedHeadKey { get; }
        public override IGlobalIBipedHorzKey IBipedHorzKey { get; }
        public override IGlobalIBipedKey IBipedKey { get; }
        public override IGlobalIBipedPropKey IBipedPropKey { get; }
        public override IGlobalIBipedTurnKey IBipedTurnKey { get; }
        public override IGlobalIBipedVertKey IBipedVertKey { get; }
        public override IGlobalIBipFootStep IBipFootStep { get; }
        public override IGlobalIBipMaster IBipMasterNS { get; }
        public override IGlobalIBipMaster10 IBipMaster10 { get; }
        public override IGlobalIBipMaster11 IBipMaster11 { get; }
        public override IGlobalIBipMaster12 IBipMaster12 { get; }
        public override IGlobalIBipMaster8 IBipMaster8 { get; }
        public override IGlobalIBipMaster9 IBipMaster9 { get; }
        public override IGlobalIBitmapIO_Bmp IBitmapIO_Bmp { get; }
        public override IGlobalIBitmapIO_Jpeg IBitmapIO_Jpeg { get; }
        public override IGlobalIBitmapIO_Png IBitmapIO_Png { get; }
        public override IGlobalIBitmapIO_Rgb IBitmapIO_Rgb { get; }
        public override IGlobalIBitmapIO_RLA IBitmapIO_RLA { get; }
        public override IGlobalIBitmapIO_Tga IBitmapIO_Tga { get; }
        public override IGlobalIBitmapPager IBitmapPagerNS { get; }
        public override IGlobalIBitmapProxyManager IBitmapProxyManager { get; }
        public override IGlobalIBlobMesh IBlobMesh { get; }
        public override IGlobalIBlockMgr IBlockMgr { get; }
        public override IGlobalIBlockRefComponent IBlockRefComponent { get; }
        public override IGlobalIBoolCntrl IBoolCntrl { get; }
        public override IGlobalIBoolFloatKey IBoolFloatKey { get; }
        public override IGlobalIBoolObject IBoolObject { get; }
        public override IGlobalIBrowser IBrowser { get; }
        public override IGlobalIBrowserMgr IBrowserMgr { get; }
        public override IGlobalIBrushPreset IBrushPreset { get; }
        public override IGlobalIBrushPresetContext IBrushPresetContext { get; }
        public override IGlobalIBrushPresetMgr IBrushPresetMgrNS { get; }
        public override IGlobalIBrushPresetParams IBrushPresetParams { get; }
        public override IGlobalICatRegistry ICatRegistry { get; }
        public override IGlobalIChannelContainer IChannelContainer { get; }
        public override IGlobalIChkMtlAPI IChkMtlAPI { get; }
        public override IGlobalICollision ICollision { get; }
        public override IGlobalIColorCorrectionMgr IColorCorrectionMgr { get; }
        public override IGlobalIColorManager IColorManager { get; }
        public override IGlobalIColorSwatch IColorSwatch { get; }
        public override IGlobalIColorSwatchDestructorPolicy IColorSwatchDestructorPolicy { get; }
        public override IGlobalIColorSwatchRenamer IColorSwatchRenamer { get; }
        public override IGlobalICommandPanel ICommandPanelNS { get; }
        public override IGlobalIContainerManager IContainerManager { get; }
        public override IGlobalIContainerObject IContainerObject { get; }
        public override IGlobalIContainerObject13 IContainerObject13 { get; }
        public override IGlobalIContainerObject16 IContainerObject16 { get; }
        public override IGlobalIContainerPreferences IContainerPreferences { get; }
        public override IGlobalIContainerUpdateReplacedNode IContainerUpdateReplacedNode { get; }
        public override IGlobalICopyCollection ICopyCollection { get; }
        public override IGlobalICurve ICurve { get; }
        public override IGlobalICurveCtl ICurveCtl { get; }
        public override IGlobalICustomControl ICustomControl { get; }
        public override IGlobalICustomRenderPresets ICustomRenderPresets { get; }
        public override IGlobalICustAttribCollapseManager ICustAttribCollapseManager { get; }
        public override IGlobalICustAttribContainer ICustAttribContainer { get; }
        public override IGlobalICustButton ICustButton { get; }
        public override IGlobalICustButtonDestructorPolicy ICustButtonDestructorPolicy { get; }
        public override IGlobalICustEdit ICustEdit { get; }
        public override IGlobalICustEditDestructorPolicy ICustEditDestructorPolicy { get; }
        public override IGlobalICustImage ICustImage { get; }
        public override IGlobalICustImage2D ICustImage2D { get; }
        public override IGlobalICustImageDestructorPolicy ICustImageDestructorPolicy { get; }
        public override IGlobalICustSeparator ICustSeparator { get; }
        public override IGlobalICustSeparatorDestructorPolicy ICustSeparatorDestructorPolicy { get; }
        public override IGlobalICustStatus ICustStatus { get; }
        public override IGlobalICustStatusDestructorPolicy ICustStatusDestructorPolicy { get; }
        public override IGlobalICustStatusEdit ICustStatusEdit { get; }
        public override IGlobalICustStatusEditDestructorPolicy ICustStatusEditDestructorPolicy { get; }
        public override IGlobalICustToolbar ICustToolbar { get; }
        public override IGlobalICustToolbarDestructorPolicy ICustToolbarDestructorPolicy { get; }
        public override IGlobalICUIFrame ICUIFrame { get; }
        public override IGlobalICUIFrameDestructorPolicy ICUIFrameDestructorPolicy { get; }
        public override IGlobalID3D9GraphicsWindow ID3D9GraphicsWindow { get; }
        public override IGlobalID3DHWMeshCacheManager ID3DHWMeshCacheManager { get; }
        public override IGlobalIDataChannel IDataChannel { get; }
        public override IGlobalIDaylightControlledLightSystem IDaylightControlledLightSystem { get; }
        public override IGlobalIDaylightSystem IDaylightSystem { get; }
        public override IGlobalIDaylightSystem2 IDaylightSystem2 { get; }
        public override IGlobalIDaylightSystem3 IDaylightSystem3 { get; }
        public override IGlobalIDaylightSystemFactory IDaylightSystemFactory { get; }
        public override IGlobalIDaylightSystemFactory2 IDaylightSystemFactory2 { get; }
        public override IGlobalIDelegate IDelegate { get; }
        public override IGlobalIDerivedObject IDerivedObject { get; }
        public override IGlobalIDialogMonitor IDialogMonitor { get; }
        public override IGlobalIDialogMonitorNotification IDialogMonitorNotification { get; }
        public override IGlobalIDragAndDropMgr IDragAndDropMgr { get; }
        public override IGlobalIDropPackageClipFmt IDropPackageClipFmt { get; }
        public override IGlobalIDxMaterial IDxMaterial { get; }
        public override IGlobalIDxMaterial2 IDxMaterial2 { get; }
        public override IGlobalIDxMaterial3 IDxMaterial3 { get; }
        public override IGlobalIDxSceneManager IDxSceneManager { get; }
        public override IGlobalIDxSceneTransformManager IDxSceneTransformManager { get; }
        public override IGlobalIDADWindow IDADWindow { get; }
        public override IGlobalIDADWindowDestructorPolicy IDADWindowDestructorPolicy { get; }
        public override IGlobalIDX9DataBridge IDX9DataBridge { get; }
        public override IGlobalIDX9PixelShader IDX9PixelShader { get; }
        public override IGlobalIDX9VertexShader IDX9VertexShader { get; }
        public override IGlobalIDXDataBridge IDXDataBridge { get; }
        public override IGlobalIDXShaderManagerInterface IDXShaderManagerInterface { get; }
        public override IGlobalIEditNormalsMod IEditNormalsMod { get; }
        public override IGlobalIEffectFile IEffectFile { get; }
        public override IGlobalIEffectManager IEffectManager { get; }
        public override IGlobalIEffectParser IEffectParser { get; }
        public override IGlobalIEmissionColor IEmissionColor { get; }
        public override IGlobalIEnumAuxAssetsCallback IEnumAuxAssetsCallback { get; }
        public override IGlobalIEulerControl IEulerControl { get; }
        public override IGlobalIExportEntity IExportEntity { get; }
        public override IGlobalIFaceDataChannel IFaceDataChannel { get; }
        public override IGlobalIFaceDataChannelsEnumCallBack IFaceDataChannelsEnumCallBack { get; }
        public override IGlobalIFaceDataMgr IFaceDataMgr { get; }
        public override IGlobalIFileResolutionManager IFileResolutionManager { get; }
        public override IGlobalIFilter IFilter { get; }
        public override IGlobalIFixer IFixer { get; }
        public override IGlobalIFrameTagManager IFrameTagManager { get; }
        public override IGlobalIFPLayerManager IFPLayerManager { get; }
        public override IGlobalIGameBezierKey IGameBezierKey { get; }
        public override IGlobalIGameCamera IGameCamera { get; }
        public override IGlobalIGameConstraint IGameConstraint { get; }
        public override IGlobalIGameControl IGameControl { get; }
        public override IGlobalIGameConversionManager IGameConversionManager { get; }
        public override IGlobalIGameErrorCallBack IGameErrorCallBack { get; }
        public override IGlobalIGameFX IGameFX { get; }
        public override IGlobalIGameFXFunction IGameFXFunction { get; }
        public override IGlobalIGameFXPass IGameFXPass { get; }
        public override IGlobalIGameFXProperty IGameFXProperty { get; }
        public override IGlobalIGameFXTechnique IGameFXTechnique { get; }
        public override IGlobalIGameGenMod IGameGenMod { get; }
        public override IGlobalIGameGenObject IGameGenObject { get; }
        public override IGlobalIGameIKChain IGameIKChain { get; }
        public override IGlobalIGameKey IGameKey { get; }
        public override IGlobalIGameKnot IGameKnot { get; }
        public override IGlobalIGameLight IGameLight { get; }
        public override IGlobalIGameLinearKey IGameLinearKey { get; }
        public override IGlobalIGameMaterial IGameMaterial { get; }
        public override IGlobalIGameMesh IGameMesh { get; }
        public override IGlobalIGameModifier IGameModifier { get; }
        public override IGlobalIGameMorpher IGameMorpher { get; }
        public override IGlobalIGameNode IGameNode { get; }
        public override IGlobalIGameObject IGameObject { get; }
        public override IGlobalIGameProperty IGameProperty { get; }
        public override IGlobalIGameRenderedSurface IGameRenderedSurface { get; }
        public override IGlobalIGameSampleKey IGameSampleKey { get; }
        public override IGlobalIGameScene IGameScene { get; }
        public override IGlobalIGameSkin IGameSkin { get; }
        public override IGlobalIGameSpline IGameSpline { get; }
        public override IGlobalIGameSpline3D IGameSpline3D { get; }
        public override IGlobalIGameSupportObject IGameSupportObject { get; }
        public override IGlobalIGameTextureMap IGameTextureMap { get; }
        public override IGlobalIGameTCBKey IGameTCBKey { get; }
        public override IGlobalIGameUVGen IGameUVGen { get; }
        public override IGlobalIGameXRefObject IGameXRefObject { get; }
        public override IGlobalIGeometryChecker IGeometryChecker { get; }
        public override IGlobalIGeometryCheckerManager IGeometryCheckerManager { get; }
        public override IGlobalIGizmoBuffer IGizmoBuffer { get; }
        public override IGlobalIGizmoClass2 IGizmoClass2 { get; }
        public override IGlobalIGizmoClass3 IGizmoClass3 { get; }
        public override IGlobalIGlobalDXDisplayManager IGlobalDXDisplayManager { get; }
        public override IGlobalIGlobalDXDisplayManager2 IGlobalDXDisplayManager2 { get; }
        public override IGlobalIGraphNode IGraphNode { get; }
        public override IGlobalIGraphObjectManager IGraphObjectManager { get; }
        public override IGlobalIGraphRef IGraphRef { get; }
        public override IGlobalIGripManager IGripManager { get; }
        public override IGlobalIGuest IGuest { get; }
        public override IGlobalIHardwareMaterial IHardwareMaterialNS { get; }
        public override IGlobalIHardwareMaterial2 IHardwareMaterial2 { get; }
        public override IGlobalIHardwareMaterial3 IHardwareMaterial3 { get; }
        public override IGlobalIHardwareMesh IHardwareMesh { get; }
        public override IGlobalIHardwareMNMesh IHardwareMNMesh { get; }
        public override IGlobalIHardwareRenderer IHardwareRenderer { get; }
        public override IGlobalIHardwareRendererST IHardwareRendererST { get; }
        public override IGlobalIHardwareShader IHardwareShader { get; }
        public override IGlobalIHeightManager IHeightManager { get; }
        public override IGlobalIHost IHost { get; }
        public override IGlobalIIlluminationComponents IIlluminationComponents { get; }
        public override IGlobalIImageViewer IImageViewer { get; }
        public override IGlobalIIndirectReferenceMaker IIndirectReferenceMaker { get; }
        public override IGlobalIIndirectRefTargContainer IIndirectRefTargContainer { get; }
        public override IGlobalIInstanceMgr IInstanceMgr { get; }
        public override IGlobalIInteractiveRender IInteractiveRender { get; }
        public override IGlobalIICEFlowFileBirthSetup IICEFlowFileBirthSetup { get; }
        public override IGlobalIICEFlowParticleFactory IICEFlowParticleFactory { get; }
        public override IGlobalIICEFlowShapeControl IICEFlowShapeControl { get; }
        public override IGlobalIIKChainControl IIKChainControl { get; }
        public override IGlobalIIKControl IIKControl { get; }
        public override IGlobalIIKKeyProp IIKKeyProp { get; }
        public override IGlobalIIRenderMgr IIRenderMgr { get; }
        public override IGlobalIIRenderMgrSelector IIRenderMgrSelector { get; }
        public override IGlobalIJiggle IJiggle { get; }
        public override IGlobalIKey IKey { get; }
        public override IGlobalIKeyControl IKeyControl { get; }
        public override IGlobalIKeyControl2 IKeyControl2 { get; }
        public override IGlobalIKeyProperty IKeyProperty { get; }
        public override IGlobalIKChainActions IKChainActions { get; }
        public override IGlobalIKClipObject IKClipObject { get; }
        public override IGlobalIKCmdOps IKCmdOps { get; }
        public override IGlobalIKCmdOpsEx IKCmdOpsEx { get; }
        public override IGlobalIKDeriv IKDeriv { get; }
        public override IGlobalIKEnumCallback IKEnumCallback { get; }
        public override IGlobalIKMasterControl IKMasterControl { get; }
        public override IGlobalIKSlaveControl IKSlaveControl { get; }
        public override IGlobalIKSolver IKSolver { get; }
        public override IGlobalILagMod ILagMod { get; }
        public override IGlobalILayer ILayerNS { get; }
        public override IGlobalILayerControl ILayerControl { get; }
        public override IGlobalILayerDisplayProperties ILayerDisplayProperties { get; }
        public override IGlobalILayerEx ILayerEx { get; }
        public override IGlobalILayerManager ILayerManager { get; }
        public override IGlobalILayerManagerEx ILayerManagerEx { get; }
        public override IGlobalILayerProperties ILayerProperties { get; }
        public override IGlobalILightingData ILightingData { get; }
        public override IGlobalILightingUnits ILightingUnits { get; }
        public override IGlobalILightManager ILightManager { get; }
        public override IGlobalILimitControl ILimitControl { get; }
        public override IGlobalILinkCtrl ILinkCtrl { get; }
        public override IGlobalILinkTMCtrl ILinkTMCtrl { get; }
        public override IGlobalILinFloatKey ILinFloatKey { get; }
        public override IGlobalILinPoint3Key ILinPoint3Key { get; }
        public override IGlobalILinRotKey ILinRotKey { get; }
        public override IGlobalILinScaleKey ILinScaleKey { get; }
        public override IGlobalIListControl IListControl { get; }
        public override IGlobalILoad ILoad { get; }
        public override IGlobalILoadSaveAnimation ILoadSaveAnimation { get; }
        public override IGlobalILoadSaveAnimation10 ILoadSaveAnimation10 { get; }
        public override IGlobalILockedContainerUpdate ILockedContainerUpdate { get; }
        public override IGlobalILockedTrack ILockedTrack { get; }
        public override IGlobalILockedTracksMan ILockedTracksMan { get; }
        public override IGlobalILockedTrackClient ILockedTrackClient { get; }
        public override IGlobalILockedTrackImp ILockedTrackImp { get; }
        public override IGlobalILookatControl ILookatControl { get; }
        public override IGlobalILookatControl_Extension ILookatControl_Extension { get; }
        public override IGlobalILookAtConstRotation ILookAtConstRotation { get; }
        public override IGlobalILuminaire ILuminaire { get; }
        public override IGlobalIManipulatorMgr IManipulatorMgr { get; }
        public override IGlobalIMaterial IMaterialNS { get; }
        public override IGlobalIMaterialBrowserEntryInfo IMaterialBrowserEntryInfo { get; }
        public override IGlobalIMaterialViewportShading IMaterialViewportShading { get; }
        public override IGlobalIMaxBitmapViewer IMaxBitmapViewer { get; }
        public override IGlobalIMenu IMenuNS { get; }
        public override IGlobalIMenuBar IMenuBar { get; }
        public override IGlobalIMenuBarContext IMenuBarContext { get; }
        public override IGlobalIMenuContext IMenuContext { get; }
        public override IGlobalIMenuElement IMenuElement { get; }
        public override IGlobalIMenuGlobalContext IMenuGlobalContext { get; }
        public override IGlobalIMenuItem IMenuItemNS { get; }
        public override IGlobalIMenuItemExtension IMenuItemExtension { get; }
        public override IGlobalIMenuLocalContext IMenuLocalContext { get; }
        public override IGlobalIMenuManager IMenuManager { get; }
        public override IGlobalIMenuManagerExtension IMenuManagerExtension { get; }
        public override IGlobalIMenuSettings IMenuSettings { get; }
        public override IGlobalIMenuTimer IMenuTimer { get; }
        public override IGlobalIMergeManager IMergeManager { get; }
        public override IGlobalIMeshDeformPWMod IMeshDeformPWMod { get; }
        public override IGlobalIMeshSelect IMeshSelect { get; }
        public override IGlobalIMeshSelectData IMeshSelectData { get; }
        public override IGlobalIMeshWrapper IMeshWrapper { get; }
        public override IGlobalIMetaDataManager IMetaDataManager { get; }
        public override IGlobalIMixer IMixer { get; }
        public override IGlobalIMixer8 IMixer8 { get; }
        public override IGlobalIMixSlave IMixSlave { get; }
        public override IGlobalIMorphByBone IMorphByBone { get; }
        public override IGlobalIMoFlow IMoFlowNS { get; }
        public override IGlobalIMrSkyPortalLight IMrSkyPortalLight { get; }
        public override IGlobalIMtlBrowserFilter IMtlBrowserFilter { get; }
        public override IGlobalIMtlBrowserFilter_Manager IMtlBrowserFilter_Manager { get; }
        public override IGlobalIMtlEditInterface IMtlEditInterface { get; }
        public override IGlobalIMtlParams IMtlParams { get; }
        public override IGlobalIMtlRender_Compatibility_MtlBase IMtlRender_Compatibility_MtlBase { get; }
        public override IGlobalIMtlRender_Compatibility_Renderer IMtlRender_Compatibility_Renderer { get; }
        public override IGlobalIMultiMenu IMultiMenu { get; }
        public override IGlobalIMultiPassCameraEffect IMultiPassCameraEffect { get; }
        public override IGlobalIMBOps IMBOps { get; }
        public override IGlobalIMCapManager IMCapManager { get; }
        public override IGlobalIMCControl IMCControl { get; }
        public override IGlobalIMCParamDlg IMCParamDlg { get; }
        public override IGlobalIMNMeshUtilities10 IMNMeshUtilities10 { get; }
        public override IGlobalIMNMeshUtilities13 IMNMeshUtilities13 { get; }
        public override IGlobalIMNMeshUtilities8 IMNMeshUtilities8 { get; }
        public override IGlobalIMNTempData10 IMNTempData10 { get; }
        public override IGlobalIMRPhysicalSkyEnvironmentMap IMRPhysicalSkyEnvironmentMap { get; }
        public override IGlobalIMRPhysicalSkyEnvironmentMap2 IMRPhysicalSkyEnvironmentMap2 { get; }
        public override IGlobalIMRPhysicalSkyInterface IMRPhysicalSkyInterface { get; }
        public override IGlobalIMRPhysicalSkyInterface2 IMRPhysicalSkyInterface2 { get; }
        public override IGlobalIMRPhysicalSunLight IMRPhysicalSunLight { get; }
        public override IGlobalIMSZipMgr IMSZipMgr { get; }
        public override IGlobalIMXclip IMXclip { get; }
        public override IGlobalIMXclip8 IMXclip8 { get; }
        public override IGlobalIMXtrack IMXtrack { get; }
        public override IGlobalIMXtrack8 IMXtrack8 { get; }
        public override IGlobalIMXtrackgroup IMXtrackgroup { get; }
        public override IGlobalIMXtrackgroup8 IMXtrackgroup8 { get; }
        public override IGlobalIMXSDebugger IMXSDebugger { get; }
        public override IGlobalIMXSParticleContainer IMXSParticleContainer { get; }
        public override IGlobalINamedSelectionSetManager INamedSelectionSetManager { get; }
        public override IGlobalINaturalLightClass INaturalLightClass { get; }
        public override IGlobalINetCreateHelpers INetCreateHelpers { get; }
        public override IGlobalINewSubTexmapNotification INewSubTexmapNotification { get; }
        public override IGlobalINode INode { get; }
        public override IGlobalINodeBakeProjProperties INodeBakeProjProperties { get; }
        public override IGlobalINodeBakeProperties INodeBakeProperties { get; }
        public override IGlobalINodeDisplayControl INodeDisplayControl { get; }
        public override IGlobalINodeDisplayProperties INodeDisplayProperties { get; }
        public override IGlobalINodeEventCallback INodeEventCallback { get; }
        public override IGlobalINodeExposure INodeExposure { get; }
        public override IGlobalINodeGIProperties INodeGIProperties { get; }
        public override IGlobalINodeGIProperties2 INodeGIProperties2 { get; }
        public override IGlobalINodeLayerProperties INodeLayerProperties { get; }
        public override IGlobalINodeMentalRayProperties INodeMentalRayProperties { get; }
        public override IGlobalINodeMonitor INodeMonitor { get; }
        public override IGlobalINodeShadingProperties INodeShadingProperties { get; }
        public override IGlobalINodeTab INodeTabNS { get; }
        public override IGlobalINodeTransformed INodeTransformed { get; }
        public override IGlobalINodeTransformMonitor INodeTransformMonitor { get; }
        public override IGlobalINodeValidity INodeValidity { get; }
        public override IGlobalINoiseControl INoiseControl { get; }
        public override IGlobalIObject IObjectNS { get; }
        public override IGlobalIObjCreate IObjCreate { get; }
        public override IGlobalIObjParam IObjParam { get; }
        public override IGlobalIObjXRefManager IObjXRefManager { get; }
        public override IGlobalIObjXRefManager18 IObjXRefManager18 { get; }
        public override IGlobalIObjXRefManager8 IObjXRefManager8 { get; }
        public override IGlobalIObjXRefRecord IObjXRefRecord { get; }
        public override IGlobalIObjXRefRecord16 IObjXRefRecord16 { get; }
        public override IGlobalIOffScreenBuf IOffScreenBuf { get; }
        public override IGlobalIOrientConstRotation IOrientConstRotation { get; }
        public override IGlobalIOsnapManager IOsnapManager { get; }
        public override IGlobalIOsnapManager7 IOsnapManager7 { get; }
        public override IGlobalIOurBipExport IOurBipExport { get; }
        public override IGlobalIPainterCanvasInterface_V5 IPainterCanvasInterface_V5 { get; }
        public override IGlobalIPainterCanvasInterface_V5_1 IPainterCanvasInterface_V5_1 { get; }
        public override IGlobalIPainterCanvasInterface_V7 IPainterCanvasInterface_V7 { get; }
        public override IGlobalIPainterInterface_V14 IPainterInterface_V14 { get; }
        public override IGlobalIPainterInterface_V5 IPainterInterface_V5 { get; }
        public override IGlobalIPainterInterface_V7 IPainterInterface_V7 { get; }
        public override IGlobalIPainterRightClickHandler IPainterRightClickHandler { get; }
        public override IGlobalIParameterManager IParameterManager { get; }
        public override IGlobalIParamArray IParamArray { get; }
        public override IGlobalIParamBlock IParamBlockNS { get; }
        public override IGlobalIParamBlock2 IParamBlock2 { get; }
        public override IGlobalIParamBlock2PostLoadInfo IParamBlock2PostLoadInfo { get; }
        public override IGlobalIParamMap IParamMap { get; }
        public override IGlobalIParamMap2 IParamMap2 { get; }
        public override IGlobalIParamPubMgr IParamPubMgr { get; }
        public override IGlobalIParamWireMgr IParamWireMgr { get; }
        public override IGlobalIParserLoader IParserLoader { get; }
        public override IGlobalIParticleCache IParticleCache { get; }
        public override IGlobalIParticleChannel IParticleChannel { get; }
        public override IGlobalIParticleChannelAmountR IParticleChannelAmountR { get; }
        public override IGlobalIParticleChannelAmountW IParticleChannelAmountW { get; }
        public override IGlobalIParticleChannelAngAxisR IParticleChannelAngAxisR { get; }
        public override IGlobalIParticleChannelAngAxisW IParticleChannelAngAxisW { get; }
        public override IGlobalIParticleChannelBoolR IParticleChannelBoolR { get; }
        public override IGlobalIParticleChannelBoolW IParticleChannelBoolW { get; }
        public override IGlobalIParticleChannelExt IParticleChannelExt { get; }
        public override IGlobalIParticleChannelExt2 IParticleChannelExt2 { get; }
        public override IGlobalIParticleChannelFloatR IParticleChannelFloatR { get; }
        public override IGlobalIParticleChannelFloatW IParticleChannelFloatW { get; }
        public override IGlobalIParticleChannelIntR IParticleChannelIntR { get; }
        public override IGlobalIParticleChannelIntW IParticleChannelIntW { get; }
        public override IGlobalIParticleChannelIDR IParticleChannelIDR { get; }
        public override IGlobalIParticleChannelIDW IParticleChannelIDW { get; }
        public override IGlobalIParticleChannelINodeHandleR IParticleChannelINodeHandleR { get; }
        public override IGlobalIParticleChannelINodeHandleW IParticleChannelINodeHandleW { get; }
        public override IGlobalIParticleChannelINodeR IParticleChannelINodeR { get; }
        public override IGlobalIParticleChannelINodeW IParticleChannelINodeW { get; }
        public override IGlobalIParticleChannelMapR IParticleChannelMapR { get; }
        public override IGlobalIParticleChannelMapW IParticleChannelMapW { get; }
        public override IGlobalIParticleChannelMatrix3R IParticleChannelMatrix3R { get; }
        public override IGlobalIParticleChannelMatrix3W IParticleChannelMatrix3W { get; }
        public override IGlobalIParticleChannelMeshMapR IParticleChannelMeshMapR { get; }
        public override IGlobalIParticleChannelMeshMapW IParticleChannelMeshMapW { get; }
        public override IGlobalIParticleChannelMeshR IParticleChannelMeshR { get; }
        public override IGlobalIParticleChannelMeshW IParticleChannelMeshW { get; }
        public override IGlobalIParticleChannelNewR IParticleChannelNewR { get; }
        public override IGlobalIParticleChannelNewW IParticleChannelNewW { get; }
        public override IGlobalIParticleChannelPoint3R IParticleChannelPoint3R { get; }
        public override IGlobalIParticleChannelPoint3W IParticleChannelPoint3W { get; }
        public override IGlobalIParticleChannelPTVR IParticleChannelPTVR { get; }
        public override IGlobalIParticleChannelPTVW IParticleChannelPTVW { get; }
        public override IGlobalIParticleChannelQuatR IParticleChannelQuatR { get; }
        public override IGlobalIParticleChannelQuatW IParticleChannelQuatW { get; }
        public override IGlobalIParticleChannelTabTVFaceR IParticleChannelTabTVFaceR { get; }
        public override IGlobalIParticleChannelTabTVFaceW IParticleChannelTabTVFaceW { get; }
        public override IGlobalIParticleChannelTabUVVertR IParticleChannelTabUVVertR { get; }
        public override IGlobalIParticleChannelTabUVVertW IParticleChannelTabUVVertW { get; }
        public override IGlobalIParticleChannelTrueFalseIterator IParticleChannelTrueFalseIterator { get; }
        public override IGlobalIParticleChannelTrueFalseIterator2 IParticleChannelTrueFalseIterator2 { get; }
        public override IGlobalIParticleChannelVoidR IParticleChannelVoidR { get; }
        public override IGlobalIParticleChannelVoidW IParticleChannelVoidW { get; }
        public override IGlobalIParticleContainer IParticleContainer { get; }
        public override IGlobalIParticleGroup IParticleGroup { get; }
        public override IGlobalIParticleGroupExt IParticleGroupExt { get; }
        public override IGlobalIParticleObjectExt IParticleObjectExt { get; }
        public override IGlobalIPatchDeformPWMod IPatchDeformPWMod { get; }
        public override IGlobalIPatchOps IPatchOps { get; }
        public override IGlobalIPatchSelect IPatchSelect { get; }
        public override IGlobalIPatchSelectData IPatchSelectData { get; }
        public override IGlobalIPathConfigMgr IPathConfigMgr { get; }
        public override IGlobalIPathConfigMgrEx IPathConfigMgrEx { get; }
        public override IGlobalIPathPosition IPathPosition { get; }
        public override IGlobalIPhysiqueExport IPhysiqueExport { get; }
        public override IGlobalIPhysiqueImport IPhysiqueImport { get; }
        public override IGlobalIPhyBlendedRigidVertex IPhyBlendedRigidVertex { get; }
        public override IGlobalIPhyBlendedRigidVertexImport IPhyBlendedRigidVertexImport { get; }
        public override IGlobalIPhyContextExport IPhyContextExport { get; }
        public override IGlobalIPhyContextImport IPhyContextImport { get; }
        public override IGlobalIPhyDeformableOffsetVertex IPhyDeformableOffsetVertex { get; }
        public override IGlobalIPhyFloatingVertex IPhyFloatingVertex { get; }
        public override IGlobalIPhyRigidVertex IPhyRigidVertex { get; }
        public override IGlobalIPhyRigidVertexImport IPhyRigidVertexImport { get; }
        public override IGlobalIPhyVertexExport IPhyVertexExport { get; }
        public override IGlobalIPhyVertexImport IPhyVertexImport { get; }
        public override IGlobalIPipelineClient IPipelineClient { get; }
        public override IGlobalIPoint2 IPoint2NS { get; }
        public override IGlobalIPoint3 IPoint3NS { get; }
        public override IGlobalIPointCache IPointCache { get; }
        public override IGlobalIPointCacheWSM IPointCacheWSM { get; }
        public override IGlobalIPopupMenu IPopupMenu { get; }
        public override IGlobalIPosConstPosition IPosConstPosition { get; }
        public override IGlobalIProjectionIntersector IProjectionIntersector { get; }
        public override IGlobalIProjectionIntersectorMgr IProjectionIntersectorMgr { get; }
        public override IGlobalIProjectionMod IProjectionMod { get; }
        public override IGlobalIProjectionMod10 IProjectionMod10 { get; }
        public override IGlobalIProjectionModData IProjectionModData { get; }
        public override IGlobalIProjectionModType IProjectionModType { get; }
        public override IGlobalIProjectionRenderHandler IProjectionRenderHandler { get; }
        public override IGlobalIProjectionRenderMgr IProjectionRenderMgrNS { get; }
        public override IGlobalIProjection_WorkingModelInfo IProjection_WorkingModelInfo { get; }
        public override IGlobalIPropertyContainer IPropertyContainer { get; }
        public override IGlobalIPublishedCustAttrib IPublishedCustAttrib { get; }
        public override IGlobalIPFAction IPFAction { get; }
        public override IGlobalIPFActionExt IPFActionExt { get; }
        public override IGlobalIPFActionList IPFActionList { get; }
        public override IGlobalIPFActionListMaterialHolder IPFActionListMaterialHolder { get; }
        public override IGlobalIPFActionListPool IPFActionListPool { get; }
        public override IGlobalIPFActionListSet IPFActionListSet { get; }
        public override IGlobalIPFActionState IPFActionState { get; }
        public override IGlobalIPFArrow IPFArrow { get; }
        public override IGlobalIPFIntegrator IPFIntegrator { get; }
        public override IGlobalIPFOperator IPFOperator { get; }
        public override IGlobalIPFOperatorPhysXWorld IPFOperatorPhysXWorld { get; }
        public override IGlobalIPFRender IPFRender { get; }
        public override IGlobalIPFSystem IPFSystem { get; }
        public override IGlobalIPFSystemPool IPFSystemPool { get; }
        public override IGlobalIPFTest IPFTest { get; }
        public override IGlobalIPFViewport IPFViewport { get; }
        public override IGlobalIPFViewportExtension2 IPFViewportExtension2 { get; }
        public override IGlobalIPViewItem IPViewItem { get; }
        public override IGlobalIPViewItemCreator IPViewItemCreator { get; }
        public override IGlobalIPViewManager IPViewManager { get; }
        public override IGlobalIQuadMenu IQuadMenuNS { get; }
        public override IGlobalIQuadMenuContext IQuadMenuContext { get; }
        public override IGlobalIQuadMenuSettings IQuadMenuSettings { get; }
        public override IGlobalIRadiosityEffectExtension IRadiosityEffectExtension { get; }
        public override IGlobalIRadiosityPreferences IRadiosityPreferences { get; }
        public override IGlobalIRadiosityRenderParameters IRadiosityRenderParameters { get; }
        public override IGlobalIRayTexmap IRayTexmap { get; }
        public override IGlobalIRefHierarchy IRefHierarchy { get; }
        public override IGlobalIRefTargContainer IRefTargContainer { get; }
        public override IGlobalIRefTargMonitor IRefTargMonitor { get; }
        public override IGlobalIRefTargMonitorClass IRefTargMonitorClass { get; }
        public override IGlobalIRendererRequirements IRendererRequirements { get; }
        public override IGlobalIRenderElement IRenderElement { get; }
        public override IGlobalIRenderElementCompatible IRenderElementCompatible { get; }
        public override IGlobalIRenderElementMgr IRenderElementMgr { get; }
        public override IGlobalIRenderElementRequirements IRenderElementRequirements { get; }
        public override IGlobalIRenderMesh IRenderMesh { get; }
        public override IGlobalIRenderMeshCache IRenderMeshCache { get; }
        public override IGlobalIRenderMessageManager IRenderMessageManager { get; }
        public override IGlobalIRenderPresetsManager IRenderPresetsManager { get; }
        public override IGlobalIRenderProgressCallback IRenderProgressCallback { get; }
        public override IGlobalIRenderSSEControl IRenderSSEControl { get; }
        public override IGlobalIRendParams IRendParamsNS { get; }
        public override IGlobalIReshadeFragment IReshadeFragment { get; }
        public override IGlobalIReshading IReshading { get; }
        public override IGlobalIRollupCallback IRollupCallback { get; }
        public override IGlobalIRollupPanel IRollupPanel { get; }
        public override IGlobalIRollupRCMenuItem IRollupRCMenuItem { get; }
        public override IGlobalIRollupSettings IRollupSettingsNS { get; }
        public override IGlobalIRollupWindow IRollupWindow { get; }
        public override IGlobalIRollupWindowDestructorPolicy IRollupWindowDestructorPolicy { get; }
        public override IGlobalIRotWindup IRotWindup { get; }
        public override IGlobalIRTShaderManager IRTShaderManager { get; }
        public override IGlobalIRTShaderManager2 IRTShaderManager2 { get; }
        public override IGlobalIRTShaderNode IRTShaderNode { get; }
        public override IGlobalIRTShaderParameterBinding IRTShaderParameterBinding { get; }
        public override IGlobalISave ISave { get; }
        public override IGlobalIScanRenderer IScanRenderer { get; }
        public override IGlobalIScanRenderer2 IScanRenderer2 { get; }
        public override IGlobalIScene IScene { get; }
        public override IGlobalISceneCallbackPriority ISceneCallbackPriority { get; }
        public override IGlobalISceneEventCallback ISceneEventCallback { get; }
        public override IGlobalISceneEventManager ISceneEventManagerNS { get; }
        public override IGlobalISceneStateManager ISceneStateManager { get; }
        public override IGlobalISceneTraversal ISceneTraversal { get; }
        public override IGlobalIScriptCtrl IScriptCtrl { get; }
        public override IGlobalISectList ISectList { get; }
        public override IGlobalISetIKKeyProp ISetIKKeyProp { get; }
        public override IGlobalISetKey ISetKey { get; }
        public override IGlobalIShadeContextExtension8 IShadeContextExtension8 { get; }
        public override IGlobalIShadowLightData IShadowLightData { get; }
        public override IGlobalIShapeRectRenderParams IShapeRectRenderParams { get; }
        public override IGlobalISimpleFaceDataChannel ISimpleFaceDataChannel { get; }
        public override IGlobalISimpleFaceDataManager ISimpleFaceDataManager { get; }
        public override IGlobalISimpleManipulator ISimpleManipulatorNS { get; }
        public override IGlobalISkin ISkin { get; }
        public override IGlobalISkin2 ISkin2 { get; }
        public override IGlobalISkinContextData ISkinContextData { get; }
        public override IGlobalISkinImportData ISkinImportData { get; }
        public override IGlobalISkinPose ISkinPose { get; }
        public override IGlobalISkyLight ISkyLight { get; }
        public override IGlobalISliderControl ISliderControl { get; }
        public override IGlobalISliderControlDestructorPolicy ISliderControlDestructorPolicy { get; }
        public override IGlobalISoftSelect ISoftSelect { get; }
        public override IGlobalISpecularCompositeShader ISpecularCompositeShader { get; }
        public override IGlobalISpinnerControl ISpinnerControl { get; }
        public override IGlobalISpinnerControlDestructorPolicy ISpinnerControlDestructorPolicy { get; }
        public override IGlobalISplineIKControl ISplineIKControl { get; }
        public override IGlobalISplineIKControl2 ISplineIKControl2 { get; }
        public override IGlobalISplineOps ISplineOps { get; }
        public override IGlobalISplineSelect ISplineSelect { get; }
        public override IGlobalISplineSelectData ISplineSelectData { get; }
        public override IGlobalIStatusPanel IStatusPanel { get; }
        public override IGlobalIStdDualVS IStdDualVS { get; }
        public override IGlobalIStdDualVSCallback IStdDualVSCallback { get; }
        public override IGlobalISubMap ISubMap { get; }
        public override IGlobalISubMtlAPI ISubMtlAPI { get; }
        public override IGlobalISubMtlMap_BrowserFilter ISubMtlMap_BrowserFilter { get; }
        public override IGlobalISubObjType ISubObjType { get; }
        public override IGlobalISubTargetCtrl ISubTargetCtrl { get; }
        public override IGlobalISunLight ISunLight { get; }
        public override IGlobalISurfPosition ISurfPosition { get; }
        public override IGlobalISystemXRef ISystemXRef { get; }
        public override IGlobalITabbedDialog ITabbedDialog { get; }
        public override IGlobalITabDialogFilter ITabDialogFilter { get; }
        public override IGlobalITabDialogManager ITabDialogManager { get; }
        public override IGlobalITabDialogObject ITabDialogObject { get; }
        public override IGlobalITabDialogPluginTab ITabDialogPluginTab { get; }
        public override IGlobalITabDialogProc ITabDialogProc { get; }
        public override IGlobalITabPage ITabPage { get; }
        public override IGlobalITabPageProc ITabPageProc { get; }
        public override IGlobalITargetedIO ITargetedIO { get; }
        public override IGlobalITextObject ITextObject { get; }
        public override IGlobalITimeBasedConverter ITimeBasedConverter { get; }
        public override IGlobalITimeSlider ITimeSlider { get; }
        public override IGlobalIToneOperatorExtension IToneOperatorExtension { get; }
        public override IGlobalITrackBar ITrackBar { get; }
        public override IGlobalITrackBarFilterManager ITrackBarFilterManager { get; }
        public override IGlobalITrackViewArray ITrackViewArray { get; }
        public override IGlobalITrackViewNode ITrackViewNode { get; }
        public override IGlobalITreeEnumProc ITreeEnumProc { get; }
        public override IGlobalITreeView ITreeView { get; }
        public override IGlobalITreeViewOps ITreeViewOps { get; }
        public override IGlobalITreeViewUI ITreeViewUI { get; }
        public override IGlobalITCBFloatKey ITCBFloatKey { get; }
        public override IGlobalITCBKey ITCBKey { get; }
        public override IGlobalITCBPoint3Key ITCBPoint3Key { get; }
        public override IGlobalITCBPoint4Key ITCBPoint4Key { get; }
        public override IGlobalITCBRotKey ITCBRotKey { get; }
        public override IGlobalITCBScaleKey ITCBScaleKey { get; }
        public override IGlobalITVUtility ITVUtility { get; }
        public override IGlobalIUnwrapMod IUnwrapMod { get; }
        public override IGlobalIUnwrapMod2 IUnwrapMod2 { get; }
        public override IGlobalIUnwrapMod3 IUnwrapMod3 { get; }
        public override IGlobalIUnwrapMod4 IUnwrapMod4 { get; }
        public override IGlobalIUnReplaceableControl IUnReplaceableControl { get; }
        public override IGlobalIUtil IUtil { get; }
        public override IGlobalIUtilityPanel IUtilityPanel { get; }
        public override IGlobalIValidateNodeCallback IValidateNodeCallback { get; }
        public override IGlobalIValidityToken IValidityToken { get; }
        public override IGlobalIValidityTokenImp IValidityTokenImp { get; }
        public override IGlobalIVertexPaint IVertexPaint { get; }
        public override IGlobalIVertexPaint_R7 IVertexPaint_R7 { get; }
        public override IGlobalIVertexShader IVertexShader { get; }
        public override IGlobalIVertToolbar IVertToolbar { get; }
        public override IGlobalIVertToolbarDestructorPolicy IVertToolbarDestructorPolicy { get; }
        public override IGlobalIViewportButton IViewportButton { get; }
        public override IGlobalIViewportButtonManager IViewportButtonManager { get; }
        public override IGlobalIViewportShaderManager IViewportShaderManager { get; }
        public override IGlobalIViewportShaderManager2 IViewportShaderManager2 { get; }
        public override IGlobalIViewportShaderManager3 IViewportShaderManager3 { get; }
        public override IGlobalIViewportShadingMgr IViewportShadingMgrNS { get; }
        public override IGlobalIViewportShadingMgr2 IViewportShadingMgr2NS { get; }
        public override IGlobalIViewPanel IViewPanel { get; }
        public override IGlobalIViewPanelManager IViewPanelManager { get; }
        public override IGlobalIVisualMSCallback IVisualMSCallback { get; }
        public override IGlobalIVisualMSForm IVisualMSForm { get; }
        public override IGlobalIVisualMSItem IVisualMSItem { get; }
        public override IGlobalIVisualMSMgr IVisualMSMgr { get; }
        public override IGlobalIWavePaint IWavePaint { get; }
        public override IGlobalIWaveSound IWaveSound { get; }
        public override IGlobalIWorkingPivot IWorkingPivot { get; }
        public override IGlobalIWorkBench IWorkBench { get; }
        public override IGlobalIWorkBench2 IWorkBench2 { get; }
        public override IGlobalIXRefAtmospheric IXRefAtmospheric { get; }
        public override IGlobalIXRefCtrl IXRefCtrl { get; }
        public override IGlobalIXRefItem IXRefItem { get; }
        public override IGlobalIXRefMaterial IXRefMaterial { get; }
        public override IGlobalIXRefMaterial18 IXRefMaterial18 { get; }
        public override IGlobalIXRefObject IXRefObject { get; }
        public override IGlobalIXRefObject8 IXRefObject8 { get; }
        public override IGlobalIXRefProxy IXRefProxy { get; }
        public override IGlobalIXTCAccess IXTCAccess { get; }
        public override IGlobalJointDlgData JointDlgData { get; }
        public override IGlobalJointParams JointParams { get; }
        public override IGlobalJointParams2 JointParams2 { get; }
        public override IGlobalJPLimitsRestore JPLimitsRestore { get; }
        public override IGlobalKeyReduceStatus KeyReduceStatus { get; }
        public override IGlobalLagModData LagModData { get; }
        public override IGlobalLight Light { get; }
        public override IGlobalLightscapeLight LightscapeLight { get; }
        public override IGlobalLightscapeLight2 LightscapeLight2 { get; }
        public override IGlobalLightDesc LightDesc { get; }
        public override IGlobalLightObject LightObjectNS { get; }
        public override IGlobalLightRayTraversal LightRayTraversal { get; }
        public override IGlobalLinearShape LinearShape { get; }
        public override IGlobalLineBuffer LineBuffer { get; }
        public override IGlobalLinkedEntryT LinkedEntryT { get; }
        public override IGlobalListener Listener { get; }
        public override IGlobalListenerMessageData ListenerMessageData { get; }
        public override IGlobalListenerViewWindow ListenerViewWindow { get; }
        public override IGlobalLoadSaveRetargetData LoadSaveRetargetData { get; }
        public override IGlobalLocalModData LocalModData { get; }
        public override IGlobalLocalThunk LocalThunk { get; }
        public override IGlobalLockableControl LockableControl { get; }
        public override IGlobalLockableStdControl LockableStdControl { get; }
        public override IGlobalLogSys LogSys { get; }
        public override IGlobalLoopContinue LoopContinue { get; }
        public override IGlobalLoopExit LoopExitNS { get; }
        public override IGlobalMacroButtonData MacroButtonData { get; }
        public override IGlobalMacroDir MacroDir { get; }
        public override IGlobalMacroEntry MacroEntry { get; }
        public override IGlobalMacroRecorder MacroRecorderNS { get; }
        public override IGlobalMaker Maker { get; }
        public override IGlobalManipulator Manipulator { get; }
        public override IGlobalManipulatorGizmo ManipulatorGizmo { get; }
        public override IGlobalManipHitData ManipHitData { get; }
        public override IGlobalMapBitArray MapBitArray { get; }
        public override IGlobalMapDelta MapDelta { get; }
        public override IGlobalMapSampler MapSampler { get; }
        public override IGlobalMarketDefaults MarketDefaults { get; }
        public override IGlobalMarketDefaults13 MarketDefaults13 { get; }
        public override IGlobalMasterPointControl MasterPointControl { get; }
        public override IGlobalMaterial Material { get; }
        public override IGlobalMatrix2 Matrix2 { get; }
        public override IGlobalMatrix3 Matrix3 { get; }
        public override IGlobalMatrix3Indirect Matrix3Indirect { get; }
        public override IGlobalMatrix3Stack Matrix3Stack { get; }
        public override IGlobalMatrix3Value Matrix3Value { get; }
        public override IGlobalMaxBakeElement MaxBakeElement { get; }
        public override IGlobalMaxBakeElement10 MaxBakeElement10 { get; }
        public override IGlobalMaxBakeElement8 MaxBakeElement8 { get; }
        public override IGlobalMaxBmpFileIcon MaxBmpFileIcon { get; }
        public override IGlobalMaxIcon MaxIcon { get; }
        public override IGlobalMaxLocaleHandler MaxLocaleHandler { get; }
        public override IGlobalMaxMixerManager MaxMixerManager { get; }
        public override IGlobalMaxNet MaxNet { get; }
        public override IGlobalMaxNetworkInterface MaxNetworkInterface { get; }
        public override IGlobalMaxNetworkInterface2 MaxNetworkInterface2 { get; }
        public override IGlobalMaxNetCallBack MaxNetCallBack { get; }
        public override IGlobalMaxNetEngine MaxNetEngine { get; }
        public override IGlobalMaxNetFile MaxNetFile { get; }
        public override IGlobalMaxNetJob MaxNetJob { get; }
        public override IGlobalMaxNetManager MaxNetManager { get; }
        public override IGlobalMaxRenderElement MaxRenderElement { get; }
        public override IGlobalMenuColors MenuColors { get; }
        public override IGlobalMenuItem MenuItem { get; }
        public override IGlobalMergeable Mergeable { get; }
        public override IGlobalMesh Mesh { get; }
        public override IGlobalMeshAccess MeshAccess { get; }
        public override IGlobalMeshCapper MeshCapper { get; }
        public override IGlobalMeshCapInfo MeshCapInfo { get; }
        public override IGlobalMeshCapPoly MeshCapPoly { get; }
        public override IGlobalMeshCapVert MeshCapVert { get; }
        public override IGlobalMeshChamferData MeshChamferData { get; }
        public override IGlobalMeshData MeshData { get; }
        public override IGlobalMeshDelta MeshDelta { get; }
        public override IGlobalMeshDeltaUser MeshDeltaUser { get; }
        public override IGlobalMeshDeltaUserData MeshDeltaUserData { get; }
        public override IGlobalMeshFaceData MeshFaceData { get; }
        public override IGlobalMeshMap MeshMap { get; }
        public override IGlobalMeshNamedSelClip MeshNamedSelClip { get; }
        public override IGlobalMeshNormalFace MeshNormalFace { get; }
        public override IGlobalMeshNormalSpec MeshNormalSpec { get; }
        public override IGlobalMeshOpProgress MeshOpProgress { get; }
        public override IGlobalMeshRenderData MeshRenderData { get; }
        public override IGlobalMeshSelection MeshSelection { get; }
        public override IGlobalMeshSelectionConverter MeshSelectionConverter { get; }
        public override IGlobalMeshSubHitRec MeshSubHitRec { get; }
        public override IGlobalMeshTempData MeshTempData { get; }
        public override IGlobalMetaParticle MetaParticle { get; }
        public override IGlobalMixerManager MixerManager { get; }
        public override IGlobalMocapManager MocapManager { get; }
        public override IGlobalModifier ModifierNS { get; }
        public override IGlobalModContext ModContext { get; }
        public override IGlobalModContextEnumProc ModContextEnumProc { get; }
        public override IGlobalModContextList ModContextList { get; }
        public override IGlobalMorphControl MorphControl { get; }
        public override IGlobalMouseCallBack MouseCallBack { get; }
        public override IGlobalMouseManager MouseManager { get; }
        public override IGlobalMouseToolCallBack MouseToolCallBack { get; }
        public override IGlobalMouseToolCommandMode MouseToolCommandMode { get; }
        public override IGlobalMoveCtrlApparatus MoveCtrlApparatus { get; }
        public override IGlobalMoveCtrlApparatusCMode MoveCtrlApparatusCMode { get; }
        public override IGlobalMoveModBox MoveModBox { get; }
        public override IGlobalMoveModBoxCMode MoveModBoxCMode { get; }
        public override IGlobalMoveTransformer MoveTransformer { get; }
        public override IGlobalMsgFromMax MsgFromMax { get; }
        public override IGlobalMsgFromSrv MsgFromSrv { get; }
        public override IGlobalMtl Mtl { get; }
        public override IGlobalMtlBase MtlBase { get; }
        public override IGlobalMtlBaseLib MtlBaseLib { get; }
        public override IGlobalMtlBaseList MtlBaseList { get; }
        public override IGlobalMtlDADMgr MtlDADMgr { get; }
        public override IGlobalMtlLib MtlLib { get; }
        public override IGlobalMtlList MtlList { get; }
        public override IGlobalMtlMakerCallback MtlMakerCallback { get; }
        public override IGlobalMtlRemap MtlRemap { get; }
        public override IGlobalMultiMtl MultiMtl { get; }
        public override IGlobalMultiSelectCallback MultiSelectCallback { get; }
        public override IGlobalMultiTex MultiTex { get; }
        public override IGlobalMultCurveAnimProp MultCurveAnimProp { get; }
        public override IGlobalMultCurveList MultCurveList { get; }
        public override IGlobalMultFprintParams MultFprintParams { get; }
        public override IGlobalMAXClass MAXClass { get; }
        public override IGlobalMAXException MAXException { get; }
        public override IGlobalMAXFileOpenDialog MAXFileOpenDialog { get; }
        public override IGlobalMAXFileSaveDialog MAXFileSaveDialog { get; }
        public override IGlobalMAXScriptException MAXScriptException { get; }
        public override IGlobalMAXScriptPrefs MAXScriptPrefs { get; }
        public override IGlobalMAXSuperClass MAXSuperClass { get; }
        public override IGlobalMCDeviceBinding MCDeviceBinding { get; }
        public override IGlobalMCInputDevice MCInputDevice { get; }
        public override IGlobalMEdge MEdge { get; }
        public override IGlobalMNChamferData MNChamferData { get; }
        public override IGlobalMNChamferData10 MNChamferData10 { get; }
        public override IGlobalMNDiagonalHitData MNDiagonalHitData { get; }
        public override IGlobalMNEdge MNEdge { get; }
        public override IGlobalMNEdgeClusters MNEdgeClusters { get; }
        public override IGlobalMNFace MNFace { get; }
        public override IGlobalMNFaceClusters MNFaceClusters { get; }
        public override IGlobalMNFaceElement MNFaceElement { get; }
        public override IGlobalMNMap MNMap { get; }
        public override IGlobalMNMapFace MNMapFace { get; }
        public override IGlobalMNMapPreserveData MNMapPreserveData { get; }
        public override IGlobalMNMesh MNMesh { get; }
        public override IGlobalMNMeshBorder MNMeshBorder { get; }
        public override IGlobalMNMeshSelectionConverter MNMeshSelectionConverter { get; }
        public override IGlobalMNMeshUtilities MNMeshUtilities { get; }
        public override IGlobalMNNormalFace MNNormalFace { get; }
        public override IGlobalMNNormalSpec MNNormalSpec { get; }
        public override IGlobalMNTempData MNTempData { get; }
        public override IGlobalMNVert MNVert { get; }
        public override IGlobalMSAutoEParamDlg MSAutoEParamDlg { get; }
        public override IGlobalMSAutoMParamDlg MSAutoMParamDlg { get; }
        public override IGlobalMSClassFactory MSClassFactory { get; }
        public override IGlobalMSCustAttrib MSCustAttrib { get; }
        public override IGlobalMSCustAttribDef MSCustAttribDef { get; }
        public override IGlobalMSDisplayFilterCallback MSDisplayFilterCallback { get; }
        public override IGlobalMSInterval MSInterval { get; }
        public override IGlobalMSModifierXtnd MSModifierXtnd { get; }
        public override IGlobalMSMtlXtnd MSMtlXtnd { get; }
        public override IGlobalMSOLEObject MSOLEObject { get; }
        public override IGlobalMSPlugin MSPlugin { get; }
        public override IGlobalMSPluginAtmos MSPluginAtmos { get; }
        public override IGlobalMSPluginCamera MSPluginCamera { get; }
        public override IGlobalMSPluginDesc MSPluginDesc { get; }
        public override IGlobalMSPluginEffect MSPluginEffect { get; }
        public override IGlobalMSPluginGeomObject MSPluginGeomObject { get; }
        public override IGlobalMSPluginHelper MSPluginHelper { get; }
        public override IGlobalMSPluginLight MSPluginLight { get; }
        public override IGlobalMSPluginModifier MSPluginModifier { get; }
        public override IGlobalMSPluginMtl MSPluginMtl { get; }
        public override IGlobalMSPluginPBAccessor MSPluginPBAccessor { get; }
        public override IGlobalMSPluginShape MSPluginShape { get; }
        public override IGlobalMSPluginSimpleManipulator MSPluginSimpleManipulator { get; }
        public override IGlobalMSPluginSimpleMeshMod MSPluginSimpleMeshMod { get; }
        public override IGlobalMSPluginSimpleMod MSPluginSimpleMod { get; }
        public override IGlobalMSPluginSimpleObject MSPluginSimpleObject { get; }
        public override IGlobalMSPluginTexmap MSPluginTexmap { get; }
        public override IGlobalMSPluginTrackViewUtility MSPluginTrackViewUtility { get; }
        public override IGlobalMSPluginValueMigrator MSPluginValueMigrator { get; }
        public override IGlobalMSRightClickMenu MSRightClickMenu { get; }
        public override IGlobalMSSelectFilterCallback MSSelectFilterCallback { get; }
        public override IGlobalMSSimpleManipulatorXtnd MSSimpleManipulatorXtnd { get; }
        public override IGlobalMSSimpleModXtnd MSSimpleModXtnd { get; }
        public override IGlobalMSSimpleObjectXtnd MSSimpleObjectXtnd { get; }
        public override IGlobalMSTexmapXtnd MSTexmapXtnd { get; }
        public override IGlobalMSTime MSTime { get; }
        public override IGlobalMSZipPackage MSZipPackage { get; }
        public override IGlobalMSZipPackageFileDropType MSZipPackageFileDropType { get; }
        public override IGlobalMXSEditor_Interface MXSEditor_Interface { get; }
        public override IGlobalMXSEditor_Interface2 MXSEditor_Interface2 { get; }
        public override IGlobalMXS_Editor_Interface MXS_Editor_Interface { get; }
        public override IGlobalMZPExtraction MZPExtraction { get; }
        public override IGlobalName Name { get; }
        public override IGlobalNamedPolySelSetList NamedPolySelSetList { get; }
        public override IGlobalNamedSegSelSetList NamedSegSelSetList { get; }
        public override IGlobalNamedVertSelSetList NamedVertSelSetList { get; }
        public override IGlobalNameAccum NameAccum { get; }
        public override IGlobalNameMaker NameMaker { get; }
        public override IGlobalNameTab NameTab { get; }
        public override IGlobalNaturalLightClassBaseImp NaturalLightClassBaseImp { get; }
        public override IGlobalNodeAndAnims NodeAndAnims { get; }
        public override IGlobalNodeDisplayCallback NodeDisplayCallback { get; }
        public override IGlobalNodeDisplayCallbackEx NodeDisplayCallbackEx { get; }
        public override IGlobalNodeIterator NodeIterator { get; }
        public override IGlobalNodeTab NodeTab { get; }
        public override IGlobalNoteAnimProperty NoteAnimProperty { get; }
        public override IGlobalNoteKey NoteKey { get; }
        public override IGlobalNoteKeyClipObject NoteKeyClipObject { get; }
        public override IGlobalNoteKeyTab NoteKeyTab { get; }
        public override IGlobalNoteTrack NoteTrack { get; }
        public override IGlobalNotifyCollapseEnumProc NotifyCollapseEnumProc { get; }
        public override IGlobalNotifyCollapseMaintainCustAttribEnumProc NotifyCollapseMaintainCustAttribEnumProc
        {
            get;
        }

        public override IGlobalNotifyCollapseMaintainCustAttribEnumProc2 NotifyCollapseMaintainCustAttribEnumProc2
        {
            get;
        }

        public override IGlobalNoMethodError NoMethodError { get; }
        public override IGlobalNoValue NoValueNS { get; }
        public override IGlobalNumber Number { get; }
        public override IGlobalNumList NumList { get; }
        public override IGlobalNURBS1RailSweepSurface NURBS1RailSweepSurface { get; }
        public override IGlobalNURBS2RailSweepSurface NURBS2RailSweepSurface { get; }
        public override IGlobalNURBSBlendCurve NURBSBlendCurve { get; }
        public override IGlobalNURBSBlendSurface NURBSBlendSurface { get; }
        public override IGlobalNURBSCapSurface NURBSCapSurface { get; }
        public override IGlobalNURBSChamferCurve NURBSChamferCurve { get; }
        public override IGlobalNURBSControlVertex NURBSControlVertex { get; }
        public override IGlobalNURBSCurve NURBSCurve { get; }
        public override IGlobalNURBSCurveConstPoint NURBSCurveConstPoint { get; }
        public override IGlobalNURBSCurveCurveIntersectionPoint NURBSCurveCurveIntersectionPoint { get; }
        public override IGlobalNURBSCurveOnSurface NURBSCurveOnSurface { get; }
        public override IGlobalNURBSCurveSurfaceIntersectionPoint NURBSCurveSurfaceIntersectionPoint { get; }
        public override IGlobalNURBSCVCurve NURBSCVCurve { get; }
        public override IGlobalNURBSCVSurface NURBSCVSurface { get; }
        public override IGlobalNURBSDisplay NURBSDisplay { get; }
        public override IGlobalNURBSExtrudeSurface NURBSExtrudeSurface { get; }
        public override IGlobalNURBSFilletCurve NURBSFilletCurve { get; }
        public override IGlobalNURBSFilletSurface NURBSFilletSurface { get; }
        public override IGlobalNURBSFuseCurveCV NURBSFuseCurveCV { get; }
        public override IGlobalNURBSFuseSurfaceCV NURBSFuseSurfaceCV { get; }
        public override IGlobalNURBSIndependentPoint NURBSIndependentPoint { get; }
        public override IGlobalNURBSIsoCurve NURBSIsoCurve { get; }
        public override IGlobalNURBSLatheSurface NURBSLatheSurface { get; }
        public override IGlobalNURBSMirrorCurve NURBSMirrorCurve { get; }
        public override IGlobalNURBSMirrorSurface NURBSMirrorSurface { get; }
        public override IGlobalNURBSMultiCurveTrimSurface NURBSMultiCurveTrimSurface { get; }
        public override IGlobalNURBSNBlendSurface NURBSNBlendSurface { get; }
        public override IGlobalNURBSObject NURBSObject { get; }
        public override IGlobalNURBSOffsetCurve NURBSOffsetCurve { get; }
        public override IGlobalNURBSOffsetSurface NURBSOffsetSurface { get; }
        public override IGlobalNURBSPoint NURBSPoint { get; }
        public override IGlobalNURBSPointConstPoint NURBSPointConstPoint { get; }
        public override IGlobalNURBSPointCurve NURBSPointCurve { get; }
        public override IGlobalNURBSPointCurveOnSurface NURBSPointCurveOnSurface { get; }
        public override IGlobalNURBSPointSurface NURBSPointSurface { get; }
        public override IGlobalNURBSProceeduralCurve NURBSProceeduralCurve { get; }
        public override IGlobalNURBSProceeduralSurface NURBSProceeduralSurface { get; }
        public override IGlobalNURBSProjectNormalCurve NURBSProjectNormalCurve { get; }
        public override IGlobalNURBSProjectVectorCurve NURBSProjectVectorCurve { get; }
        public override IGlobalNURBSRuledSurface NURBSRuledSurface { get; }
        public override IGlobalNURBSSet NURBSSet { get; }
        public override IGlobalNURBSSurface NURBSSurface { get; }
        public override IGlobalNURBSSurfaceEdgeCurve NURBSSurfaceEdgeCurve { get; }
        public override IGlobalNURBSSurfaceNormalCurve NURBSSurfaceNormalCurve { get; }
        public override IGlobalNURBSSurfConstPoint NURBSSurfConstPoint { get; }
        public override IGlobalNURBSSurfSurfIntersectionCurve NURBSSurfSurfIntersectionCurve { get; }
        public override IGlobalNURBSTextureChannel NURBSTextureChannel { get; }
        public override IGlobalNURBSTextureChannelSet NURBSTextureChannelSet { get; }
        public override IGlobalNURBSTexturePoint NURBSTexturePoint { get; }
        public override IGlobalNURBSTextureSurface NURBSTextureSurface { get; }
        public override IGlobalNURBSTrimPoint NURBSTrimPoint { get; }
        public override IGlobalNURBSULoftSurface NURBSULoftSurface { get; }
        public override IGlobalNURBSUVLoftSurface NURBSUVLoftSurface { get; }
        public override IGlobalNURBSXFormCurve NURBSXFormCurve { get; }
        public override IGlobalNURBSXFormSurface NURBSXFormSurface { get; }
        public override IGlobalNUScaleCtrlApparatusCMode NUScaleCtrlApparatusCMode { get; }
        public override IGlobalNUScaleModBoxCMode NUScaleModBoxCMode { get; }
        public override IGlobalObject Object { get; }
        public override IGlobalObjectConverter ObjectConverter { get; }
        public override IGlobalObjectDataReaderCallback ObjectDataReaderCallback { get; }
        public override IGlobalObjectSet ObjectSet { get; }
        public override IGlobalObjectState ObjectState { get; }
        public override IGlobalObjectWrapper ObjectWrapper { get; }
        public override IGlobalObjLightDesc ObjLightDesc { get; }
        public override IGlobalOk OkNS { get; }
        public override IGlobalOneClickCreateCallBack OneClickCreateCallBack { get; }
        public override IGlobalOpenBezFont OpenBezFont { get; }
        public override IGlobalOpenSubdivParameters OpenSubdivParameters { get; }
        public override IGlobalOrbazTrueBlock OrbazTrueBlock { get; }
        public override IGlobalOrbazTrueBlockEnumerator OrbazTrueBlockEnumerator { get; }
        public override IGlobalOrbazTrueBlockIterator OrbazTrueBlockIterator { get; }
        public override IGlobalOrbazTrueEnumerator OrbazTrueEnumerator { get; }
        public override IGlobalOsnap Osnap { get; }
        public override IGlobalOsnapHit OsnapHit { get; }
        public override IGlobalOsnapMarker OsnapMarker { get; }
        public override IGlobalOwnerThunk OwnerThunk { get; }
        public override IGlobalOSnapDecorator OSnapDecorator { get; }
        public override IGlobalOSModifier OSModifier { get; }
        public override IGlobalParamBlock2PLCB ParamBlock2PLCB { get; }
        public override IGlobalParamBlockDesc ParamBlockDesc { get; }
        public override IGlobalParamBlockDesc2 ParamBlockDesc2 { get; }
        public override IGlobalParamBlockDescID ParamBlockDescID { get; }
        public override IGlobalParamBlockPLCB ParamBlockPLCB { get; }
        public override IGlobalParamDimension ParamDimension { get; }
        public override IGlobalParamDimensionBase ParamDimensionBase { get; }
        public override IGlobalParamDlg ParamDlg { get; }
        public override IGlobalParamMap2UserDlgProc ParamMap2UserDlgProc { get; }
        public override IGlobalParamMapUserDlgProc ParamMapUserDlgProc { get; }
        public override IGlobalParamRef ParamRef { get; }
        public override IGlobalParamUIDesc ParamUIDesc { get; }
        public override IGlobalParamVersionDesc ParamVersionDesc { get; }
        public override IGlobalParser Parser { get; }
        public override IGlobalParticleChannelMask ParticleChannelMask { get; }
        public override IGlobalParticleObject ParticleObject { get; }
        public override IGlobalParticleSys ParticleSys { get; }
        public override IGlobalPatch Patch { get; }
        public override IGlobalPatchCapper PatchCapper { get; }
        public override IGlobalPatchCapInfo PatchCapInfo { get; }
        public override IGlobalPatchCapPoly PatchCapPoly { get; }
        public override IGlobalPatchCapVec PatchCapVec { get; }
        public override IGlobalPatchCapVert PatchCapVert { get; }
        public override IGlobalPatchEdge PatchEdge { get; }
        public override IGlobalPatchHitData PatchHitData { get; }
        public override IGlobalPatchMesh PatchMesh { get; }
        public override IGlobalPatchNamedSelClip PatchNamedSelClip { get; }
        public override IGlobalPatchObject PatchObject { get; }
        public override IGlobalPatchObjectRestore PatchObjectRestore { get; }
        public override IGlobalPatchSubHitRec PatchSubHitRec { get; }
        public override IGlobalPatchTVert PatchTVert { get; }
        public override IGlobalPatchVec PatchVec { get; }
        public override IGlobalPatchVert PatchVert { get; }
        public override IGlobalPathConfigDropType PathConfigDropTypeNS { get; }
        public override IGlobalPathName PathName { get; }
        public override IGlobalPerData PerData { get; }
        public override IGlobalPickerControlFilter PickerControlFilter { get; }
        public override IGlobalPickerControlMode PickerControlMode { get; }
        public override IGlobalPickAnimatableCallback PickAnimatableCallback { get; }
        public override IGlobalPickClassCallback PickClassCallback { get; }
        public override IGlobalPickCommandMode PickCommandMode { get; }
        public override IGlobalPickModeCallback PickModeCallback { get; }
        public override IGlobalPickNodeCallback PickNodeCallback { get; }
        public override IGlobalPickObjectProc PickObjectProc { get; }
        public override IGlobalPipe Pipe { get; }
        public override IGlobalPixelBufT PixelBufT { get; }
        public override IGlobalPlane Plane { get; }
        public override IGlobalPluginClassDefPLCB1 PluginClassDefPLCB1 { get; }
        public override IGlobalPluginClassDefPLCB2 PluginClassDefPLCB2 { get; }
        public override IGlobalPluginLocalThunk PluginLocalThunk { get; }
        public override IGlobalPluginMethod PluginMethod { get; }
        public override IGlobalPluginParamThunk PluginParamThunk { get; }
        public override IGlobalPoint2 Point2 { get; }
        public override IGlobalPoint2Value Point2Value { get; }
        public override IGlobalPoint3 Point3 { get; }
        public override IGlobalPoint3Value Point3Value { get; }
        public override IGlobalPoint4 Point4 { get; }
        public override IGlobalPoint4Value Point4Value { get; }
        public override IGlobalPolyLine PolyLine { get; }
        public override IGlobalPolyLineProc PolyLineProc { get; }
        public override IGlobalPolyObject PolyObject { get; }
        public override IGlobalPolyPt PolyPt { get; }
        public override IGlobalPolyShape PolyShape { get; }
        public override IGlobalPostLoadCallback PostLoadCallback { get; }
        public override IGlobalPostPatchProc PostPatchProc { get; }
        public override IGlobalPreciseTimeValue PreciseTimeValue { get; }
        public override IGlobalPreviewParams PreviewParams { get; }
        public override IGlobalPrintManager PrintManager { get; }
        public override IGlobalPropertyEnum PropertyEnum { get; }
        public override IGlobalPropertyThunk PropertyThunk { get; }
        public override IGlobalPtrVector PtrVector { get; }
        public override IGlobalPB2Param PB2Param { get; }
        public override IGlobalPBAccessor PBAccessor { get; }
        public override IGlobalPBBitmap PBBitmap { get; }
        public override IGlobalPBRescaleParamAccessor PBRescaleParamAccessor { get; }
        public override IGlobalPBValidator PBValidator { get; }
        public override IGlobalPFActionStateDesc PFActionStateDesc { get; }
        public override IGlobalPFHitData PFHitData { get; }
        public override IGlobalPFSimpleAction PFSimpleAction { get; }
        public override IGlobalPFSimpleActionState PFSimpleActionState { get; }
        public override IGlobalPFSimpleOperator PFSimpleOperator { get; }
        public override IGlobalPFSimpleTest PFSimpleTest { get; }
        public override IGlobalPOModRecord POModRecord { get; }
        public override IGlobalPOPickPatchAttach POPickPatchAttach { get; }
        public override IGlobalPRVertex PRVertex { get; }
        public override IGlobalPStamp PStamp { get; }
        public override IGlobalQuantizer Quantizer { get; }
        public override IGlobalQuat Quat { get; }
        public override IGlobalQuatValue QuatValue { get; }
        public override IGlobalRadiosityEffect RadiosityEffect { get; }
        public override IGlobalRadiosityInterface RadiosityInterface { get; }
        public override IGlobalRadiosityMesh RadiosityMesh { get; }
        public override IGlobalRandom Random { get; }
        public override IGlobalRandGenerator RandGenerator { get; }
        public override IGlobalRandObjLinker RandObjLinker { get; }
        public override IGlobalRay Ray { get; }
        public override IGlobalRayValue RayValue { get; }
        public override IGlobalReadonlyTextFileStream ReadonlyTextFileStream { get; }
        public override IGlobalReadonlyTextFileStreamClass ReadonlyTextFileStreamClassNS { get; }
        public override IGlobalRealWorldMapSizeInterface RealWorldMapSizeInterface { get; }
        public override IGlobalRealWorldScaleRecord RealWorldScaleRecord { get; }
        public override IGlobalRedrawViewsCallback RedrawViewsCallback { get; }
        public override IGlobalReferenceMaker ReferenceMaker { get; }
        public override IGlobalReferenceSaveManager ReferenceSaveManager { get; }
        public override IGlobalReferenceTarget ReferenceTarget { get; }
        public override IGlobalRefEnumProc RefEnumProc { get; }
        public override IGlobalRefMgr RefMgr { get; }
        public override IGlobalRefMgrAddDeleteRestore RefMgrAddDeleteRestore { get; }
        public override IGlobalRefTarget RefTarget { get; }
        public override IGlobalRefTargMonitorRefMaker RefTargMonitorRefMaker { get; }
        public override IGlobalRemapDir RemapDir { get; }
        public override IGlobalRenderer Renderer { get; }
        public override IGlobalRenderData RenderData { get; }
        public override IGlobalRenderGlobalContext RenderGlobalContext { get; }
        public override IGlobalRenderInfo RenderInfo { get; }
        public override IGlobalRenderInstance RenderInstance { get; }
        public override IGlobalRenderMapsContext RenderMapsContext { get; }
        public override IGlobalRenderPresetsContext RenderPresetsContext { get; }
        public override IGlobalRendContext RendContext { get; }
        public override IGlobalRendParams RendParams { get; }
        public override IGlobalRendParamDlg RendParamDlg { get; }
        public override IGlobalRendPickProc RendPickProc { get; }
        public override IGlobalRendProgressCallback RendProgressCallback { get; }
        public override IGlobalRendProgressCallback2 RendProgressCallback2 { get; }
        public override IGlobalResourceMakerCallback ResourceMakerCallback { get; }
        public override IGlobalRestoreObj RestoreObj { get; }
        public override IGlobalRightClickMenu RightClickMenu { get; }
        public override IGlobalRightClickMenuManager RightClickMenuManager { get; }
        public override IGlobalRollout Rollout { get; }
        public override IGlobalRolloutChangeCallback RolloutChangeCallback { get; }
        public override IGlobalRolloutControlThunk RolloutControlThunk { get; }
        public override IGlobalRolloutLocalThunk RolloutLocalThunk { get; }
        public override IGlobalRotateCtrlApparatus RotateCtrlApparatus { get; }
        public override IGlobalRotateCtrlApparatusCMode RotateCtrlApparatusCMode { get; }
        public override IGlobalRotateModBox RotateModBox { get; }
        public override IGlobalRotateModBoxCMode RotateModBoxCMode { get; }
        public override IGlobalRotateTransformer RotateTransformer { get; }
        public override IGlobalRotationValue RotationValue { get; }
        public override IGlobalRuntimeError RuntimeError { get; }
        public override IGlobalRCMenu RCMenu { get; }
        public override IGlobalRCMenuItemThunk RCMenuItemThunk { get; }
        public override IGlobalRCMenuLocalThunk RCMenuLocalThunk { get; }
        public override IGlobalRCMData RCMData { get; }
        public override IGlobalRNormal RNormal { get; }
        public override IGlobalRVertex RVertex { get; }
        public override IGlobalSafeArrayWrapper SafeArrayWrapper { get; }
        public override IGlobalSampler Sampler { get; }
        public override IGlobalSamplingCallback SamplingCallback { get; }
        public override IGlobalSaveEnumProc SaveEnumProc { get; }
        public override IGlobalScaleCtrlApparatus ScaleCtrlApparatus { get; }
        public override IGlobalScaleModBox ScaleModBox { get; }
        public override IGlobalScaleTransformer ScaleTransformer { get; }
        public override IGlobalScaleValue ScaleValue { get; }
        public override IGlobalSceneExport SceneExport { get; }
        public override IGlobalSceneFileDropType SceneFileDropTypeNS { get; }
        public override IGlobalSceneImport SceneImport { get; }
        public override IGlobalSceneNodeByNameCache SceneNodeByNameCache { get; }
        public override IGlobalSchematicViewProperty SchematicViewProperty { get; }
        public override IGlobalScript Script { get; }
        public override IGlobalScriptEditor ScriptEditor { get; }
        public override IGlobalScriptFileDropType ScriptFileDropTypeNS { get; }
        public override IGlobalScriptItem ScriptItem { get; }
        public override IGlobalSealedReferenceMaker SealedReferenceMaker { get; }
        public override IGlobalSelectionIterator SelectionIterator { get; }
        public override IGlobalSelectionProcessor SelectionProcessor { get; }
        public override IGlobalSelectCtrlApparatus SelectCtrlApparatus { get; }
        public override IGlobalSelectCtrlApparatusCMode SelectCtrlApparatusCMode { get; }
        public override IGlobalSelectFilterCallback SelectFilterCallback { get; }
        public override IGlobalSelectModBox SelectModBox { get; }
        public override IGlobalSelectModBoxCMode SelectModBoxCMode { get; }
        public override IGlobalSetKeyModeCallback SetKeyModeCallback { get; }
        public override IGlobalSetKeyModeInterface SetKeyModeInterface { get; }
        public override IGlobalSetMorphTargetPacket SetMorphTargetPacket { get; }
        public override IGlobalSetXFormPacket SetXFormPacket { get; }
        public override IGlobalShader Shader { get; }
        public override IGlobalShaderParamDlg ShaderParamDlg { get; }
        public override IGlobalShadeContext ShadeContext { get; }
        public override IGlobalShadeOutput ShadeOutput { get; }
        public override IGlobalShadowGenerator ShadowGenerator { get; }
        public override IGlobalShadowParamDlg ShadowParamDlg { get; }
        public override IGlobalShadowType ShadowType { get; }
        public override IGlobalShadBufRenderer ShadBufRenderer { get; }
        public override IGlobalShapeContextCallback ShapeContextCallback { get; }
        public override IGlobalShapeHierarchy ShapeHierarchy { get; }
        public override IGlobalShapeHitData ShapeHitData { get; }
        public override IGlobalShapeNamedPolySelClip ShapeNamedPolySelClipNS { get; }
        public override IGlobalShapeNamedSegSelClip ShapeNamedSegSelClipNS { get; }
        public override IGlobalShapeNamedVertSelClip ShapeNamedVertSelClipNS { get; }
        public override IGlobalShapeObject ShapeObject { get; }
        public override IGlobalShapePSel ShapePSel { get; }
        public override IGlobalShapeSubHitRec ShapeSubHitRec { get; }
        public override IGlobalShapeSSel ShapeSSel { get; }
        public override IGlobalShapeVSel ShapeVSel { get; }
        public override IGlobalSignalException SignalException { get; }
        public override IGlobalSimpleManipulator SimpleManipulator { get; }
        public override IGlobalSimpleManipHitData SimpleManipHitData { get; }
        public override IGlobalSimpleMod SimpleMod { get; }
        public override IGlobalSimpleMod2 SimpleMod2 { get; }
        public override IGlobalSimpleObject SimpleObject { get; }
        public override IGlobalSimpleObject2 SimpleObject2 { get; }
        public override IGlobalSimpleOSMToWSMMod SimpleOSMToWSMMod { get; }
        public override IGlobalSimpleOSMToWSMMod2 SimpleOSMToWSMMod2 { get; }
        public override IGlobalSimpleOSMToWSMObject SimpleOSMToWSMObject { get; }
        public override IGlobalSimpleParticle SimpleParticle { get; }
        public override IGlobalSimpleRandom SimpleRandom { get; }
        public override IGlobalSimpleShape SimpleShape { get; }
        public override IGlobalSimpleSpline SimpleSpline { get; }
        public override IGlobalSimpleSplineDlgProc SimpleSplineDlgProc { get; }
        public override IGlobalSimpleWSMMod SimpleWSMMod { get; }
        public override IGlobalSimpleWSMMod2 SimpleWSMMod2 { get; }
        public override IGlobalSimpleWSMObject SimpleWSMObject { get; }
        public override IGlobalSimpleWSMObject2 SimpleWSMObject2 { get; }
        public override IGlobalSingleRefMaker SingleRefMaker { get; }
        public override IGlobalSingleRefMakerPatchMtl SingleRefMakerPatchMtl { get; }
        public override IGlobalSingleRefMakerPatchNode SingleRefMakerPatchNode { get; }
        public override IGlobalSingleRefMakerSplineMtl SingleRefMakerSplineMtl { get; }
        public override IGlobalSingleRefMakerSplineNode SingleRefMakerSplineNode { get; }
        public override IGlobalSkyLightEval SkyLightEval { get; }
        public override IGlobalSnippet Snippet { get; }
        public override IGlobalSoundObj SoundObj { get; }
        public override IGlobalSourceFileWrapper SourceFileWrapper { get; }
        public override IGlobalSourcePositionWrapper SourcePositionWrapper { get; }
        public override IGlobalSpaceArrayCallback SpaceArrayCallback { get; }
        public override IGlobalSpecialFX SpecialFX { get; }
        public override IGlobalSphereGizmoObject SphereGizmoObject { get; }
        public override IGlobalSpline3D Spline3D { get; }
        public override IGlobalSplineKnot SplineKnot { get; }
        public override IGlobalSplineKnotAssy SplineKnotAssy { get; }
        public override IGlobalSplinePoint SplinePoint { get; }
        public override IGlobalSplineShape SplineShape { get; }
        public override IGlobalSplineShapePointTab SplineShapePointTab { get; }
        public override IGlobalSplineShapeVertexDelta SplineShapeVertexDelta { get; }
        public override IGlobalSpringClass SpringClass { get; }
        public override IGlobalSpringSys SpringSys { get; }
        public override IGlobalSpringSysClient SpringSysClient { get; }
        public override IGlobalSquashCtrlApparatusCMode SquashCtrlApparatusCMode { get; }
        public override IGlobalSquashModBoxCMode SquashModBoxCMode { get; }
        public override IGlobalStaticInterfaceMethod StaticInterfaceMethod { get; }
        public override IGlobalStdControl StdControl { get; }
        public override IGlobalStdCubic StdCubic { get; }
        public override IGlobalStdFog StdFog { get; }
        public override IGlobalStdIKClipObject StdIKClipObject { get; }
        public override IGlobalStdMat StdMat { get; }
        public override IGlobalStdMat2 StdMat2 { get; }
        public override IGlobalStdMirror StdMirror { get; }
        public override IGlobalStdTexoutGen StdTexoutGen { get; }
        public override IGlobalStdUVGen StdUVGen { get; }
        public override IGlobalStdXYZGen StdXYZGen { get; }
        public override IGlobalString String { get; }
        public override IGlobalStringStream StringStream { get; }
        public override IGlobalStrip Strip { get; }
        public override IGlobalStripData StripData { get; }
        public override IGlobalStruct Struct { get; }
        public override IGlobalStructDef StructDef { get; }
        public override IGlobalStructMemberThunk StructMemberThunk { get; }
        public override IGlobalStructMethod StructMethod { get; }
        public override IGlobalSubClassList SubClassList { get; }
        public override IGlobalSubControlSelectionProcessor SubControlSelectionProcessor { get; }
        public override IGlobalSubModSelectionProcessor SubModSelectionProcessor { get; }
        public override IGlobalSubObjAxisCallback SubObjAxisCallback { get; }
        public override IGlobalSubObjHitList SubObjHitList { get; }
        public override IGlobalSubPatchHitList SubPatchHitList { get; }
        public override IGlobalSubShapeHitList SubShapeHitList { get; }
        public override IGlobalSuspendAll SuspendAll { get; }
        public override IGlobalSvGraphNodeReference SvGraphNodeReference { get; }
        public override IGlobalSyntaxError SyntaxError { get; }
        public override IGlobalSystemGlobalThunk SystemGlobalThunk { get; }
        public override IGlobalSClassUIInfo SClassUIInfo { get; }
        public override IGlobalSFXParamDlg SFXParamDlg { get; }
        public override IGlobalSMCallContext SMCallContext { get; }
        public override IGlobalSSBindCMode SSBindCMode { get; }
        public override IGlobalSSBindMouseProc SSBindMouseProc { get; }
        public override IGlobalSSBooleanCMode SSBooleanCMode { get; }
        public override IGlobalSSBooleanMouseProc SSBooleanMouseProc { get; }
        public override IGlobalSSChamferCMode SSChamferCMode { get; }
        public override IGlobalSSChamferMouseProc SSChamferMouseProc { get; }
        public override IGlobalSSChamferSelectionProcessor SSChamferSelectionProcessor { get; }
        public override IGlobalSSChamferTransformer SSChamferTransformer { get; }
        public override IGlobalSSConstraintPoint SSConstraintPoint { get; }
        public override IGlobalSSCopyTangentCMode SSCopyTangentCMode { get; }
        public override IGlobalSSCopyTangentMouseProc SSCopyTangentMouseProc { get; }
        public override IGlobalSSCreateLineCMode SSCreateLineCMode { get; }
        public override IGlobalSSCreateLineMouseProc SSCreateLineMouseProc { get; }
        public override IGlobalSSCrossInsertCMode SSCrossInsertCMode { get; }
        public override IGlobalSSCrossInsertMouseProc SSCrossInsertMouseProc { get; }
        public override IGlobalSSCrossSectionCMode SSCrossSectionCMode { get; }
        public override IGlobalSSCrossSectionMouseProc SSCrossSectionMouseProc { get; }
        public override IGlobalSSExtendCMode SSExtendCMode { get; }
        public override IGlobalSSExtendMouseProc SSExtendMouseProc { get; }
        public override IGlobalSSFilletCMode SSFilletCMode { get; }
        public override IGlobalSSFilletMouseProc SSFilletMouseProc { get; }
        public override IGlobalSSFilletSelectionProcessor SSFilletSelectionProcessor { get; }
        public override IGlobalSSFilletTransformer SSFilletTransformer { get; }
        public override IGlobalSSNamedSelSetList SSNamedSelSetList { get; }
        public override IGlobalSSOutlineCMode SSOutlineCMode { get; }
        public override IGlobalSSOutlineMouseProc SSOutlineMouseProc { get; }
        public override IGlobalSSOutlineSelectionProcessor SSOutlineSelectionProcessor { get; }
        public override IGlobalSSOutlineTransformer SSOutlineTransformer { get; }
        public override IGlobalSSParticle SSParticle { get; }
        public override IGlobalSSParticleCache SSParticleCache { get; }
        public override IGlobalSSPasteTangentCMode SSPasteTangentCMode { get; }
        public override IGlobalSSPasteTangentMouseProc SSPasteTangentMouseProc { get; }
        public override IGlobalSSPickSplineAttach SSPickSplineAttach { get; }
        public override IGlobalSSRefineConnectCMode SSRefineConnectCMode { get; }
        public override IGlobalSSRefineConnectMouseProc SSRefineConnectMouseProc { get; }
        public override IGlobalSSSegBreakCMode SSSegBreakCMode { get; }
        public override IGlobalSSSegBreakMouseProc SSSegBreakMouseProc { get; }
        public override IGlobalSSSegBreakTransformer SSSegBreakTransformer { get; }
        public override IGlobalSSSegRefineCMode SSSegRefineCMode { get; }
        public override IGlobalSSSegRefineMouseProc SSSegRefineMouseProc { get; }
        public override IGlobalSSSpring SSSpring { get; }
        public override IGlobalSSTrimCMode SSTrimCMode { get; }
        public override IGlobalSSTrimMouseProc SSTrimMouseProc { get; }
        public override IGlobalSSVertConnectCMode SSVertConnectCMode { get; }
        public override IGlobalSSVertConnectMouseProc SSVertConnectMouseProc { get; }
        public override IGlobalSSVertInsertCMode SSVertInsertCMode { get; }
        public override IGlobalSSVertInsertMouseProc SSVertInsertMouseProc { get; }
        public override IGlobalTab Tab { get; }
        public override IGlobalTabDialogPointer TabDialogPointer { get; }
        public override IGlobalTabHd TabHd { get; }
        public override IGlobalTabMZPExtraction TabMZPExtraction { get; }
        public override IGlobalTemplate Template { get; }
        public override IGlobalTemplate3D Template3D { get; }
        public override IGlobalTempBitmapManagerSilentMode TempBitmapManagerSilentMode { get; }
        public override IGlobalTempQuietMode TempQuietMode { get; }
        public override IGlobalTempStore TempStore { get; }
        public override IGlobalTessApprox TessApprox { get; }
        public override IGlobalTex3D Tex3D { get; }
        public override IGlobalTexmap Texmap { get; }
        public override IGlobalTexmapContainer TexmapContainer { get; }
        public override IGlobalTextureInfo TextureInfo { get; }
        public override IGlobalTextureOutput TextureOutput { get; }
        public override IGlobalTexDADMgr TexDADMgr { get; }
        public override IGlobalTexHandle TexHandle { get; }
        public override IGlobalTexHandleMaker TexHandleMaker { get; }
        public override IGlobalThunk Thunk { get; }
        public override IGlobalThunkClass ThunkClassNS { get; }
        public override IGlobalThunkReference ThunkReference { get; }
        public override IGlobalTimeChange TimeChange { get; }
        public override IGlobalTimeChangeCallback TimeChangeCallback { get; }
        public override IGlobalTimeMap TimeMap { get; }
        public override IGlobalToneOperator ToneOperator { get; }
        public override IGlobalToneOperator2 ToneOperator2 { get; }
        public override IGlobalToneOperatorInterface ToneOperatorInterface { get; }
        public override IGlobalToneOperatorInvertable ToneOperatorInvertable { get; }
        public override IGlobalToolButtonItem ToolButtonItem { get; }
        public override IGlobalToolImageItem ToolImageItem { get; }
        public override IGlobalToolItem ToolItem { get; }
        public override IGlobalToolLocalThunk ToolLocalThunk { get; }
        public override IGlobalToolMacroItem ToolMacroItem { get; }
        public override IGlobalToolOtherItem ToolOtherItem { get; }
        public override IGlobalToolSeparatorItem ToolSeparatorItem { get; }
        public override IGlobalToolStatusItem ToolStatusItem { get; }
        public override IGlobalToolTab ToolTab { get; }
        public override IGlobalToolTipExtender ToolTipExtender { get; }
        public override IGlobalTrackClipObject TrackClipObject { get; }
        public override IGlobalTrackHitRecord TrackHitRecord { get; }
        public override IGlobalTrackSelectionSetMgr TrackSelectionSetMgr { get; }
        public override IGlobalTrackViewActionCallback TrackViewActionCallback { get; }
        public override IGlobalTrackViewFilter TrackViewFilter { get; }
        public override IGlobalTrackViewPick TrackViewPick { get; }
        public override IGlobalTrackViewUtility TrackViewUtility { get; }
        public override IGlobalTransformer Transformer { get; }
        public override IGlobalTransformCtrlApparatus TransformCtrlApparatus { get; }
        public override IGlobalTransformModBox TransformModBox { get; }
        public override IGlobalTransition Transition { get; }
        public override IGlobalTranInfo TranInfo { get; }
        public override IGlobalTriObject TriObject { get; }
        public override IGlobalTriObjectNormalXTC TriObjectNormalXTC { get; }
        public override IGlobalTriStrip TriStrip { get; }
        public override IGlobalTypedHit TypedHit { get; }
        public override IGlobalTypeError TypeError { get; }
        public override IGlobalTCBGraphParams TCBGraphParams { get; }
        public override IGlobalTVFace TVFace { get; }
        public override IGlobalTVNodeNotify TVNodeNotify { get; }
        public override IGlobalTVPatch TVPatch { get; }
        public override IGlobalUndefined UndefinedNS { get; }
        public override IGlobalUndoNotify UndoNotify { get; }
        public override IGlobalUnknownSystemException UnknownSystemException { get; }
        public override IGlobalUnsupplied UnsuppliedNS { get; }
        public override IGlobalUserGeneric UserGeneric { get; }
        public override IGlobalUserProp UserProp { get; }
        public override IGlobalUserThrownError UserThrownError { get; }
        public override IGlobalUserType UserType { get; }
        public override IGlobalUtilityObj UtilityObj { get; }
        public override IGlobalURLTab URLTab { get; }
        public override IGlobalUScaleCtrlApparatusCMode UScaleCtrlApparatusCMode { get; }
        public override IGlobalUScaleModBoxCMode UScaleModBoxCMode { get; }
        public override IGlobalUTF8Str UTF8Str { get; }
        public override IGlobalUVGen UVGen { get; }
        public override IGlobalUVVertSet UVVertSet { get; }
        public override IGlobalUVWMapper UVWMapper { get; }
        public override IGlobalUVWMapperDesc UVWMapperDesc { get; }
        public override IGlobalValue Value { get; }
        public override IGlobalValueConverter ValueConverter { get; }
        public override IGlobalValueHolderMember ValueHolderMember { get; }
        public override IGlobalValueLoader ValueLoader { get; }
        public override IGlobalValueLoadCallback ValueLoadCallback { get; }
        public override IGlobalValueLoadPLCB ValueLoadPLCB { get; }
        public override IGlobalValueMapper ValueMapper { get; }
        public override IGlobalValueMetaClass ValueMetaClass { get; }
        public override IGlobalVertexBuffer VertexBuffer { get; }
        public override IGlobalVertexNormalsCallback VertexNormalsCallback { get; }
        public override IGlobalVertexNormalsControl VertexNormalsControlNS { get; }
        public override IGlobalVertexShaderCache VertexShaderCache { get; }
        public override IGlobalVertMove VertMove { get; }
        public override IGlobalView View { get; }
        public override IGlobalViewportDisplayCallback ViewportDisplayCallback { get; }
        public override IGlobalViewportTextButton ViewportTextButton { get; }
        public override IGlobalViewExp ViewExp { get; }
        public override IGlobalViewExp10 ViewExp10 { get; }
        public override IGlobalViewExp11 ViewExp11 { get; }
        public override IGlobalViewExp13 ViewExp13 { get; }
        public override IGlobalViewExp18 ViewExp18 { get; }
        public override IGlobalViewFile ViewFile { get; }
        public override IGlobalViewParams ViewParams { get; }
        public override IGlobalViewWindow ViewWindow { get; }
        public override IGlobalVDataDelta VDataDelta { get; }
        public override IGlobalVEdge VEdge { get; }
        public override IGlobalVIZableClipFmt VIZableClipFmt { get; }
        public override IGlobalWindowStream WindowStream { get; }
        public override IGlobalWireMeshData WireMeshData { get; }
        public override IGlobalWSModifier WSModifier { get; }
        public override IGlobalWSMObject WSMObject { get; }
        public override IGlobalXFormModes XFormModes { get; }
        public override IGlobalXMLAnimTreeEntry XMLAnimTreeEntry { get; }
        public override IGlobalXMLAnimTreeEntryList XMLAnimTreeEntryList { get; }
        public override IGlobalXTCContainer XTCContainer { get; }
        public override IGlobalXTCObject XTCObject { get; }
        public override IGlobalXYZGen XYZGen { get; }
        public override IGlobalbinding binding { get; }
        public override IGlobalbindShape bindShape { get; }
        public override IGlobalclass_key class_key { get; }
        public override IGlobalclass_table class_table { get; }
        public override IGlobaledit_window edit_window { get; }
        public override IGlobalfree_mem free_mem { get; }
        public override IGlobalgbuff_chan_code gbuff_chan_code { get; }
        public override IGloballayout_data layout_data { get; }
        public override IGlobalmbm_window mbm_window { get; }
        public override IGlobalmessage_box_data message_box_data { get; }
        public override IGlobalmxs_value_id_pair mxs_value_id_pair { get; }
        public override IGlobalnode_find node_find { get; }
        public override IGlobalnode_get node_get { get; }
        public override IGlobalnode_map node_map { get; }
        public override IGlobalparm_desc parm_desc { get; }
        public override IGlobalproperty_accessors property_accessors { get; }
        public override IGlobalrollout_control rollout_control { get; }
        public override IGlobalsecondary secondary { get; }
        public override IGlobalsuperclass_table superclass_table { get; }
        public override IGlobalz_stream_s z_stream_s { get; }
        public override IGlobalActionDescription ActionDescription { get; }
        public override IGlobalAffineParts AffineParts { get; }
        public override IGlobalAlertData AlertData { get; }
        public override IGlobalBMMBitmapList BMMBitmapList { get; }
        public override IGlobalBMMFilterList BMMFilterList { get; }
        public override IGlobalBMMGammaSettings BMMGammaSettings { get; }
        public override IGlobalBMMImageInfo BMMImageInfo { get; }
        public override IGlobalBMMStorageList BMMStorageList { get; }
        public override IGlobalBMMVfbPalette BMMVfbPalette { get; }
        public override IGlobalBMM_Color_24 BMM_Color_24 { get; }
        public override IGlobalBMM_Color_32 BMM_Color_32 { get; }
        public override IGlobalBMM_Color_48 BMM_Color_48 { get; }
        public override IGlobalBMM_Color_64 BMM_Color_64 { get; }
        public override IGlobalBMM_Color_fl BMM_Color_fl { get; }
        public override IGlobalBMM_Pyramid BMM_Pyramid { get; }
        public override IGlobalBMM_SAT BMM_SAT { get; }
        public override IGlobalCameraState CameraState { get; }
        public override IGlobalClassDescReplaced ClassDescReplaced { get; }
        public override IGlobalClientInfo ClientInfo { get; }
        public override IGlobalColor24 Color24 { get; }
        public override IGlobalColor48 Color48 { get; }
        public override IGlobalColor64 Color64 { get; }
        public override IGlobalCombustionJob CombustionJob { get; }
        public override IGlobalConfigurationBlock ConfigurationBlock { get; }
        public override IGlobalConstraintInOut ConstraintInOut { get; }
        public override IGlobalCIRCLE CIRCLE { get; }
        public override IGlobalDispInfo DispInfo { get; }
        public override IGlobalDumpValueData DumpValueData { get; }
        public override IGlobalDxGeneralFunctions DxGeneralFunctions { get; }
        public override IGlobalDX9VSConstant DX9VSConstant { get; }
        public override IGlobalEdge Edge { get; }
        public override IGlobalEditFileResult EditFileResult { get; }
        public override IGlobalFlectForces FlectForces { get; }
        public override IGlobalFBox2 FBox2 { get; }
        public override IGlobalGenEdge GenEdge { get; }
        public override IGlobalGenFace GenFace { get; }
        public override IGlobalGenSoftSelData GenSoftSelData { get; }
        public override IGlobalGenTri GenTri { get; }
        public override IGlobalGenTriPoints GenTriPoints { get; }
        public override IGlobalGetBoundBoxRequestData GetBoundBoxRequestData { get; }
        public override IGlobalGetParticleDataRequest GetParticleDataRequest { get; }
        public override IGlobalGetSubObjectRequestData GetSubObjectRequestData { get; }
        public override IGlobalGetTimeDataRequest GetTimeDataRequest { get; }
        public override IGlobalGBufData GBufData { get; }
        public override IGlobalHitTestRequestData HitTestRequestData { get; }
        public override IGlobalHSERVER HSERVER { get; }
        public override IGlobalISect ISect { get; }
        public override IGlobalJob Job { get; }
        public override IGlobalJobList JobList { get; }
        public override IGlobalJobRenderElement JobRenderElement { get; }
        public override IGlobalJobServer JobServer { get; }
        public override IGlobalJobText JobText { get; }
        public override IGlobalJOBFRAMES JOBFRAMES { get; }
        public override IGlobalLayerParentChange LayerParentChange { get; }
        public override IGlobalLightDispInfo LightDispInfo { get; }
        public override IGlobalLightState LightState { get; }
        public override IGlobalLoadSubAnimInfo LoadSubAnimInfo { get; }
        public override IGlobalLogLUV24Pixel LogLUV24Pixel { get; }
        public override IGlobalLogLUV32Pixel LogLUV32Pixel { get; }
        public override IGlobalManagerInfo ManagerInfo { get; }
        public override IGlobalMaxJob MaxJob { get; }
        public override IGlobalMaxJobRenderElements MaxJobRenderElements { get; }
        public override IGlobalMenuEvent MenuEvent { get; }
        public override IGlobalMAXScript_TLS MAXScript_TLS { get; }
        public override IGlobalNameChange NameChange { get; }
        public override IGlobalNetworkStatus NetworkStatus { get; }
        public override IGlobalNotifyCustomAttribute NotifyCustomAttribute { get; }
        public override IGlobalNotifyInfo NotifyInfo { get; }
        public override IGlobalNotifyPreEval_FrameInfo NotifyPreEval_FrameInfo { get; }
        public override IGlobalObjectDefinitionChangeNotificationParam ObjectDefinitionChangeNotificationParam { get; }
        public override IGlobalParamAlias ParamAlias { get; }
        public override IGlobalParamDef ParamDef { get; }
        public override IGlobalParticleID ParticleID { get; }
        public override IGlobalPerformOut PerformOut { get; }
        public override IGlobalPB2Value PB2Value { get; }
        public override IGlobalPFActiveActionDataRequest PFActiveActionDataRequest { get; }
        public override IGlobalRealPixel RealPixel { get; }
        public override IGlobalSaveSubAnimInfo SaveSubAnimInfo { get; }
        public override IGlobalSceneInfo SceneInfo { get; }
        public override IGlobalSchedule Schedule { get; }
        public override IGlobalServerInfo ServerInfo { get; }
        public override IGlobalServerList ServerList { get; }
        public override IGlobalSlot Slot { get; }
        public override IGlobalSnapInfo SnapInfo { get; }
        public override IGlobalSphereData SphereData { get; }
        public override IGlobalStatistics Statistics { get; }
        public override IGlobalSubRendParams SubRendParams { get; }
        public override IGlobalSurfTabEntry SurfTabEntry { get; }
        public override IGlobalTabHdr TabHdr { get; }
        public override IGlobalTangentBasis TangentBasis { get; }
        public override IGlobalTextBufferOutput TextBufferOutput { get; }
        public override IGlobalTABDLG_NMHDR TABDLG_NMHDR { get; }
        public override IGlobalTMComponentsArg TMComponentsArg { get; }
        public override IGlobalUserCoord UserCoord { get; }
        public override IGlobalUVTangentVectors UVTangentVectors { get; }
        public override IGlobalViewWindowMetaData ViewWindowMetaData { get; }
        public override IGlobalWeekSchedule WeekSchedule { get; }

        #endregion
    }
}
