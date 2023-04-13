
namespace BatchLabs.Plugin.Common.Code
{
    public class AssetSearchFlags
    {
        /// <summary>
        /// Enumerate inactive files. Inactive files are those that aren't being used currently.
        /// For instance, a texture map file that is present, but not activated in the materials
        /// editor user interface, is considered inactive.
        /// </summary>
        public const int FileEnumInactive = (1 << 0);

        /// <summary>
        /// Enumerate video post files.
        /// </summary>
        public const int FileEnumVp = (1 << 1);

        /// <summary>
        /// Enumerate render files.
        /// </summary>
        public const int FileEnumRender = (1 << 2);

        /// <summary>
        /// Enumerate ALL files.
        /// </summary>
        public const int FileEnumAll = (FileEnumInactive | FileEnumVp | FileEnumRender);

        /// <summary>
        /// Enumerate references to be saved to scene files.
        /// </summary>
        public const int FileEnumFileSave = (1 << 3);

        /// <summary>
        /// Enumerate missing files only.
        /// </summary>
        public const int FileEnumMissingOnly = (1 << 8);

        /// <summary>
        /// Just enumerate 1st missing sub file, for example frame files specified by IFL and point
        /// cache .xml, if enumerating missing files. Trying to resolve missing files can be slow. If
        /// all that is really cared about is whether any sub files are missing, specify this option.
        /// </summary>
        public const int FileEnumFirstSubMissing = (1 << 9);

        /// <summary>
        /// Do not enumerate references.
        /// </summary>
        public const int FileEnumDontRecurse = (1 << 10);

        /// <summary>
        /// Do not enumerate things with flag A_WORK1 set.
        /// </summary>
        public const int FileEnumCheckAwork1 = (1 << 11);

        /// <summary>
        /// Do not enumerate custom attributes.
        /// </summary>
        public const int FileEnumDontcheckCustattr = (1 << 12);

        /// <summary>
        /// Do not enumerate files needed only for viewport rendering. If the flag is set, then any
        /// files that are needed only for viewport display (not for rendering) will be excluded from
        /// the enumeration. This is useful in render slave mode, when you do not want to consider a render
        /// a failure just because some viewport-only files are missing.
        /// </summary>
        public const int FileEnumSkipVprenderOnly = (1 << 13);

        /// <summary>
        /// The callback object passed through is an IEnumAuxAssetsCallback derived object.
        /// </summary>
        public const int FileEnumAccessorInterface = (1 << 14);

        /// <summary>
        /// FILE_ENUM_RESERVED_1 was marked as internal use only, was used to skip IFL sub files.
        /// </summary>
        public const int FileEnumReserved = (1 << 15);

        /// <summary>
        /// Do not enumerate sub files, for example frame files specified by IFL and point cache .xml.
        /// </summary>
        public const int FileEnumSkipSubFiles = FileEnumReserved;

        /// <summary>
        /// Enumerate all active but missing files.
        /// </summary>
        public const int FileEnumMissingActive = (FileEnumVp | FileEnumRender | FileEnumMissingOnly);

        /// <summary>
        /// Enumerate all active but missing files. But only enumerate first sub file pointed to by an
        /// IFL (Image File List) or other asset with sub files
        /// </summary>
        public const int FileEnumMissingActive1 = (FileEnumMissingActive | FileEnumFirstSubMissing);
    }
}
