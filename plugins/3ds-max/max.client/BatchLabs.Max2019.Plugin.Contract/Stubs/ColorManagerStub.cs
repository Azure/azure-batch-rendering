
using System;
using System.Drawing;

using Autodesk.Max;
using Autodesk.Max.BaseInterface;
using Autodesk.Max.IColorManager;

namespace BatchLabs.Max2019.Plugin.Contract.Stubs
{
    /// <summary>
    /// Override functionality from the Max SDK for when we are running in local debug mode. 
    /// </summary>
    public class ColorManagerStub : IIColorManager
    {
        public Color GetColor(GuiColors kind, State state)
        {
            switch (kind)
            {
                case GuiColors.Background:
                    return Color.DarkBlue;
                case GuiColors.Text:
                    return ColorTranslator.FromHtml("#FFC8C8C8");
                case GuiColors.ActiveCommand:
                    return ColorTranslator.FromHtml("#FFDC823C");
                case GuiColors.Hilight:
                    return ColorTranslator.FromHtml("#FF383838");
                case GuiColors.Shadow:
                    return ColorTranslator.FromHtml("#FF0B0B0B");
                case GuiColors.Window:
                    return ColorTranslator.FromHtml("#FF565656");
                case GuiColors.ActiveCaption:
                    return ColorTranslator.FromHtml("#FF382F22");
                case GuiColors.ToolTipBackground:
                    return ColorTranslator.FromHtml("#FF55CCEE");
                case GuiColors.ToolTipText:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.HilightText:
                    return ColorTranslator.FromHtml("#FFB2B2B2");
                case GuiColors.WindowText:
                    return ColorTranslator.FromHtml("#FFDCDCDC");
                case GuiColors.ItemHilight:
                    return ColorTranslator.FromHtml("#FFDC6E1E");
                case GuiColors.SubObjectColor:
                    return ColorTranslator.FromHtml("#FFDC823C");
                case GuiColors.N3dDarkShadow:
                    return ColorTranslator.FromHtml("#FF0B0B0B");
                case GuiColors.N3dLight:
                    return ColorTranslator.FromHtml("#FF333333");
                case GuiColors.AppWorkspace:
                    return ColorTranslator.FromHtml("#FFAAAAAA");
                case GuiColors.TrackbarBg:
                    return ColorTranslator.FromHtml("#FF2A2A2A");
                case GuiColors.TrackbarBgSel:
                    return ColorTranslator.FromHtml("#FF574635");
                case GuiColors.TrackbarText:
                    return ColorTranslator.FromHtml("#FFBCBCBC");
                case GuiColors.TrackbarTicks:
                    return ColorTranslator.FromHtml("#FF646464");
                case GuiColors.TrackbarKeys:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackbarSelKeys:
                    return ColorTranslator.FromHtml("#FFFFFFFF");
                case GuiColors.TrackbarCursor:
                    return ColorTranslator.FromHtml("#FF12EAFD");
                case GuiColors.PressedButton:
                    return ColorTranslator.FromHtml("#FFDC823C");
                case GuiColors.TimeSliderBg:
                    return ColorTranslator.FromHtml("#FF444444");
                case GuiColors.ViewportBorder:
                    return ColorTranslator.FromHtml("#FF323232");
                case GuiColors.ActiveViewportBorder:
                    return ColorTranslator.FromHtml("#FF2C6A7C");
                case GuiColors.RollupTitleFace:
                    return ColorTranslator.FromHtml("#FF3E3E3E");
                case GuiColors.RollupTitleText:
                    return ColorTranslator.FromHtml("#FFEBEBEB");
                case GuiColors.RollupTitleHilight:
                    return ColorTranslator.FromHtml("#FF646464");
                case GuiColors.RollupTitleShadow:
                    return ColorTranslator.FromHtml("#FF646464");
                case GuiColors.SelectionRubberBand:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.StackViewSelection:
                    return ColorTranslator.FromHtml("#FF444444");
                case GuiColors.ImageViewerBackground:
                    return ColorTranslator.FromHtml("#FF464646");
                case GuiColors.IRenderProgressHoriz:
                    return ColorTranslator.FromHtml("#FF0202CE");
                case GuiColors.IRenderProgressVert:
                    return ColorTranslator.FromHtml("#FF02A415");
                case GuiColors.PressedHierarchyButton:
                    return ColorTranslator.FromHtml("#FFDC823C");
                case GuiColors.TrackViewBackground:
                    return ColorTranslator.FromHtml("#FF3F3F3F");
                case GuiColors.TrackViewInactiveBackground:
                    return ColorTranslator.FromHtml("#FF383838");
                case GuiColors.ManipulatorsActive:
                    return ColorTranslator.FromHtml("#FF00E100");
                case GuiColors.ManipulatorsSelected:
                    return ColorTranslator.FromHtml("#FF0000FF");
                case GuiColors.ManipulatorsInactive:
                    return ColorTranslator.FromHtml("#FF00E1FF");
                case GuiColors.FunctionCurveX:
                    return ColorTranslator.FromHtml("#FF3434B6");
                case GuiColors.FunctionCurveY:
                    return ColorTranslator.FromHtml("#FF319431");
                case GuiColors.FunctionCurveZ:
                    return ColorTranslator.FromHtml("#FFFF5741");
                case GuiColors.FunctionCurveW:
                    return ColorTranslator.FromHtml("#FF00C8C8");
                case GuiColors.FunctionCurveFloat:
                    return ColorTranslator.FromHtml("#FFC8C632");
                case GuiColors.FunctionCurveSelected:
                    return ColorTranslator.FromHtml("#FFFFFFFF");
                case GuiColors.TrackViewTrackText:
                    return ColorTranslator.FromHtml("#FFDCDCDC");
                case GuiColors.TrackViewSelInstantTime:
                    return ColorTranslator.FromHtml("#FF798E8F");
                case GuiColors.TrackViewKeyCursor:
                    return ColorTranslator.FromHtml("#FF00FFFF");
                case GuiColors.TrackViewSelectedBackground:
                    return ColorTranslator.FromHtml("#FF535353");
                case GuiColors.TrackViewDisabledTrack1:
                    return ColorTranslator.FromHtml("#FF434343");
                case GuiColors.TrackViewDisabledTrack2:
                    return ColorTranslator.FromHtml("#FF464646");
                case GuiColors.TrackViewEnabledTrack1:
                    return ColorTranslator.FromHtml("#FF171717");
                case GuiColors.TrackViewEnabledTrack2:
                    return ColorTranslator.FromHtml("#FF8F8F8F");
                case GuiColors.TrackViewTimeCursor:
                    return ColorTranslator.FromHtml("#FF23B4CA");
                case GuiColors.TrackViewGrid:
                    return ColorTranslator.FromHtml("#FF343434");
                case GuiColors.TrackViewUnSelectedKeys:
                    return ColorTranslator.FromHtml("#FF808080");
                case GuiColors.TrackViewSelectedKeys:
                    return ColorTranslator.FromHtml("#FFFAFEFF");
                case GuiColors.TrackViewKeyOutline:
                    return ColorTranslator.FromHtml("#FF2A2A2A");
                case GuiColors.TrackViewKeyOutlineOnTop:
                    return ColorTranslator.FromHtml("#FFAFAFAF");
                case GuiColors.ViewportShowDependencies:
                    return ColorTranslator.FromHtml("#FF9C00F5");
                case GuiColors.TrackViewSoundTrackRight:
                    return ColorTranslator.FromHtml("#FF779500");
                case GuiColors.TrackViewSoundTrackLeft:
                    return ColorTranslator.FromHtml("#FF41259C");
                case GuiColors.AssemblyOutline:
                    return ColorTranslator.FromHtml("#FF0000FF");
                case GuiColors.TrackViewKeyPosition:
                    return ColorTranslator.FromHtml("#FF000081");
                case GuiColors.TrackViewKeyRotation:
                    return ColorTranslator.FromHtml("#FF007A00");
                case GuiColors.TrackViewKeyScale:
                    return ColorTranslator.FromHtml("#FFBC3737");
                case GuiColors.TrackViewKeyTransform:
                    return ColorTranslator.FromHtml("#FF808080");
                case GuiColors.TrackViewKeyObject:
                    return ColorTranslator.FromHtml("#FF808080");
                case GuiColors.TrackViewKeyMaterial:
                    return ColorTranslator.FromHtml("#FF808080");
                case GuiColors.TrackViewTangentHandle:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackViewAutoTangentHandle:
                    return ColorTranslator.FromHtml("#FFFF6F6F");
                case GuiColors.TrackViewKeyMixed:
                    return ColorTranslator.FromHtml("#FF595959");
                case GuiColors.TrackViewKeyFake:
                    return ColorTranslator.FromHtml("#FFC3C3C3");
                case GuiColors.TrackbarKeyPosition:
                    return ColorTranslator.FromHtml("#FF0000A3");
                case GuiColors.TrackbarKeyRotation:
                    return ColorTranslator.FromHtml("#FF007A00");
                case GuiColors.TrackbarKeyScale:
                    return ColorTranslator.FromHtml("#FFC90000");
                case GuiColors.TrackbarKeyTransform:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackbarKeyObject:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackbarKeyMaterial:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackbarKeyMixed:
                    return ColorTranslator.FromHtml("#FF000000");
                case GuiColors.TrackViewScaleOriginLine:
                    return ColorTranslator.FromHtml("#FF3267B6");
                case GuiColors.TrackViewKeyFCurveSelected:
                    return ColorTranslator.FromHtml("#FFFFFFFF");
                case GuiColors.TrackViewKeyFCurveUnSelected:
                    return ColorTranslator.FromHtml("#FF797979");
                case GuiColors.OutOfRangeLow:
                    return ColorTranslator.FromHtml("#FFFF0000");
                case GuiColors.OutOfRangeHigh:
                    return ColorTranslator.FromHtml("#FF0000FF");
                case GuiColors.TrackViewRangeIgnored:
                    return ColorTranslator.FromHtml("#FFB79FA0");
                case GuiColors.TrackViewRangeIgnoredSel:
                    return ColorTranslator.FromHtml("#FFE7D2D3");
                case GuiColors.AdaptiveDegActive:
                    return ColorTranslator.FromHtml("#FFFFFF33");
                default:
                    return Color.DeepPink;
            }
        }

        public Color CustSysColor(GuiColors which)
        {
            return GetColor(which, State.Normal);
        }

        #region Unused Properties and Overrides

        public bool RegisterColor(uint id, string pName, string pCategory, Color defaultValue, Color defaultValueDisabled, Color defaultValueHover)
        {
            throw new NotImplementedException();
        }

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

        public bool LoadColorFile(string pFileName)
        {
            throw new NotImplementedException();
        }

        public bool SaveColorFile(string pFileName)
        {
            throw new NotImplementedException();
        }

        public bool SetColor(GuiColors id, Color color, State state)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetColorAsPoint3(GuiColors id, State state)
        {
            throw new NotImplementedException();
        }

        public IntPtr GetBrush(GuiColors id, State state)
        {
            throw new NotImplementedException();
        }

        public string GetName(GuiColors id)
        {
            throw new NotImplementedException();
        }

        public string GetCategory(GuiColors id)
        {
            throw new NotImplementedException();
        }

        public IntPtr CustSysColorBrush(GuiColors which)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetOldUIColor(GuiColors which)
        {
            throw new NotImplementedException();
        }

        public void SetOldUIColor(GuiColors which, IPoint3 clr)
        {
            throw new NotImplementedException();
        }

        public IPoint3 GetOldDefaultUIColor(GuiColors which)
        {
            throw new NotImplementedException();
        }

        public float GetIconColorScale(IconType type, IconColorScale which)
        {
            throw new NotImplementedException();
        }

        public void SetIconColorScale(IconType type, IconColorScale which, float value)
        {
            throw new NotImplementedException();
        }

        public bool GetIconColorInvert(IconType type)
        {
            throw new NotImplementedException();
        }

        public void SetIconColorInvert(IconType type, bool value)
        {
            throw new NotImplementedException();
        }

        public Color GetDefaultColor(GuiColors id, State state)
        {
            throw new NotImplementedException();
        }

        public Color GetOldUIColorCOLORREF(GuiColors which)
        {
            throw new NotImplementedException();
        }

        public void RepaintUI(RepaintType type)
        {
            throw new NotImplementedException();
        }

        public bool SetIconFolder(string pFolder)
        {
            throw new NotImplementedException();
        }

        public void ReInitIcons()
        {
            throw new NotImplementedException();
        }

        public bool ResolveIconFolder(string pFilename, ref string path)
        {
            throw new NotImplementedException();
        }

        public string ColorFile { get; }

        public AppFrameColorTheme AppFrameColorTheme { get; set; }

        public string FileName { get; }

        public string IconFolder { get; }

        #endregion
    }
}
