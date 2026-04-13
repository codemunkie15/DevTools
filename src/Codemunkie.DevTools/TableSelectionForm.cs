using System.ComponentModel;

namespace Codemunkie.DevTools
{
    public partial class TableSelectionForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? TextData { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<string>? SelectedData { get; internal set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TextOptions? Options { get; internal set; }

        public TableSelectionForm()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            dgvContent.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dgvContent.DataSource = DataTableParser.Parse(TextData, cboHeaders.Checked);

            foreach (DataGridViewColumn column in dgvContent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvContent.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvContent.Columns[0].Selected = true;
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

        private void TableSelectionForm_Load(object? sender, EventArgs e)
        {
            cboHeaders.Checked = DataTableParser.AssumeHeaders(TextData);

            LoadTable();

            cboHeaders.CheckedChanged += cboHeaders_CheckedChanged;
        }

        private void cboHeaders_CheckedChanged(object? sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SelectedData = dgvContent.SelectedCells
                .Cast<DataGridViewCell>()
                .Select(cell => cell.Value?.ToString() ?? "")
                .ToList();

            Options = new TextOptions(
                ItemPrefix: GetPrefixOrSuffix(),
                ItemSuffix: GetPrefixOrSuffix(),
                CslSeperator: cboAddLineBreaks.Checked ? Environment.NewLine : "");
        }
    }
}
