namespace Codemunkie.DevTools
{
    public partial class TextToolOptionsForm : Form
    {
        public TextOptions? Options { get; internal set; }

        public TextToolOptionsForm()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Options = new TextOptions(
                ItemPrefix: GetPrefixOrSuffix(),
                ItemSuffix: GetPrefixOrSuffix(),
                CslSeperator: cboAddLineBreaks.Checked ? Environment.NewLine : "");
        }

        private string GetPrefixOrSuffix()
        {
            if (rdoAddSingleQuotes.Checked)
            {
                return "'";
            }

            if (rdoAddDoubleQuotes.Checked)
            {
                return "\"";
            }

            return "";
        }
    }
}
