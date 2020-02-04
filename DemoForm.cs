using DevExpress.XtraEditors;

using RichTextBoxExDemo.ViewModels;

namespace RichTextBoxExDemo
{
    public partial class DemoForm : XtraForm
    {
        #region Constructors
        public DemoForm()
        {
            InitializeComponent();

            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        #endregion

        #region Methods
        private void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<DemoFormViewModel>();

            fluent.SetBinding(spinEditMaxLength, p => p.EditValue, vm => vm.MaxLength);

            fluent.SetBinding(richTextBoxControl, p => p.RtfText, vm => vm.RtfText);
            fluent.SetBinding(richTextBoxControl, p => p.MaxLength, vm => vm.MaxLength);
        }
        #endregion
    }
}