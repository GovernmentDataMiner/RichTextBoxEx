using DevExpress.LookAndFeel;
using DevExpress.Skins;

using System.Drawing;

namespace RichTextBoxExDemo.Helpers
{
    internal static class ColorHelper
    {
        #region Properties
        internal static Color BorderColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default)[CommonSkins.SkinTextBorder].Border.All; }
        }

        internal static Color CriticalColor
        {
            get { return CommonColors.GetCriticalColor(UserLookAndFeel.Default); }
        }

        internal static Color DisabledTextColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor(CommonColors.DisabledText); }
        }

        internal static Color HyperlinkTextColor
        {
            get { return EditorsSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel).Colors.GetColor(EditorsSkins.SkinHyperlinkTextColor, Color.Blue); }
        }

        internal static Color InformationColor
        {
            get { return CommonColors.GetInformationColor(UserLookAndFeel.Default); }
        }

        internal static Color QuestionColor
        {
            get { return CommonColors.GetQuestionColor(UserLookAndFeel.Default); }
        }

        internal static Color TextColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor(CommonColors.ControlText); }
        }

        internal static Color TooltipColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).TranslateColor(SystemColors.Highlight); }
        }

        internal static Color TooltipTextColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).TranslateColor(SystemColors.HighlightText); }
        }

        internal static Color WarningColor
        {
            get { return CommonColors.GetWarningColor(UserLookAndFeel.Default); }
        }

        internal static Color WindowColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor(CommonColors.Window); }
        }

        internal static Color WindowTextColor
        {
            get { return CommonSkins.GetSkin(UserLookAndFeel.Default).Colors.GetColor(CommonColors.WindowText); }
        }
        #endregion
    }
}