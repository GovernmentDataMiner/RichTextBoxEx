using DevExpress.XtraRichEdit;

namespace RichTextBoxExDemo.ViewModels
{
    public class DemoFormViewModel
    {
        #region Fields
        private string plainText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam egestas mattis justo, at interdum dolor ultrices eu. Curabitur tincidunt tincidunt justo, fermentum egestas mi aliquet in. Duis accumsan erat dui, eget facilisis justo sodales tempus.";
        #endregion

        #region Properties
        public virtual int MaxLength { get; set; }

        public virtual string RtfText { get; set; }
        #endregion

        #region Constructors
        public DemoFormViewModel()
        {
            using (var richEditDocumentServer = new RichEditDocumentServer())
            {
                richEditDocumentServer.Text = plainText;

                richEditDocumentServer.Document.DefaultCharacterProperties.FontName = "Tahoma";
                richEditDocumentServer.Document.DefaultCharacterProperties.FontSize = 8F;

                RtfText = richEditDocumentServer.RtfText;
            }

            MaxLength = plainText.Length * 2;
        }
        #endregion
    }
}