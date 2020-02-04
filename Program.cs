using DevExpress.XtraSpellChecker.Native;

using System;
using System.Windows.Forms;

namespace RichTextBoxExDemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Is this appropriate here?
            SpellCheckTextControllersManager.Default.RegisterClass(typeof(RichTextBoxEx), typeof(RichTextBoxTextController));
            SpellCheckTextBoxBaseFinderManager.Default.RegisterClass(typeof(RichTextBoxEx), typeof(RTFTextBoxFinder));

            Application.Run(new DemoForm());
        }
    }
}