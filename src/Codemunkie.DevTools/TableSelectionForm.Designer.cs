namespace Codemunkie.DevTools
{
    partial class TableSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSelectionForm));
            label1 = new Label();
            dgvContent = new DoubleBufferedDataGridView();
            groupBox1 = new GroupBox();
            rdoNone = new RadioButton();
            rdoAddDoubleQuotes = new RadioButton();
            rdoAddSingleQuotes = new RadioButton();
            groupBox2 = new GroupBox();
            cboAddLineBreaks = new CheckBox();
            btnContinue = new Button();
            cboHeaders = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvContent).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a column...";
            // 
            // dgvContent
            // 
            dgvContent.AllowUserToAddRows = false;
            dgvContent.AllowUserToDeleteRows = false;
            dgvContent.AllowUserToResizeColumns = false;
            dgvContent.AllowUserToResizeRows = false;
            dgvContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContent.Location = new Point(12, 31);
            dgvContent.MultiSelect = false;
            dgvContent.Name = "dgvContent";
            dgvContent.ReadOnly = true;
            dgvContent.RowHeadersVisible = false;
            dgvContent.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvContent.Size = new Size(707, 277);
            dgvContent.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(rdoNone);
            groupBox1.Controls.Add(rdoAddDoubleQuotes);
            groupBox1.Controls.Add(rdoAddSingleQuotes);
            groupBox1.Location = new Point(12, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 107);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item wrapping";
            // 
            // rdoNone
            // 
            rdoNone.AutoSize = true;
            rdoNone.Checked = true;
            rdoNone.Location = new Point(10, 25);
            rdoNone.Name = "rdoNone";
            rdoNone.Size = new Size(54, 19);
            rdoNone.TabIndex = 4;
            rdoNone.TabStop = true;
            rdoNone.Text = "None";
            rdoNone.UseVisualStyleBackColor = true;
            // 
            // rdoAddDoubleQuotes
            // 
            rdoAddDoubleQuotes.AutoSize = true;
            rdoAddDoubleQuotes.Location = new Point(10, 75);
            rdoAddDoubleQuotes.Name = "rdoAddDoubleQuotes";
            rdoAddDoubleQuotes.Size = new Size(126, 19);
            rdoAddDoubleQuotes.TabIndex = 3;
            rdoAddDoubleQuotes.Text = "Add double quotes";
            rdoAddDoubleQuotes.UseVisualStyleBackColor = true;
            // 
            // rdoAddSingleQuotes
            // 
            rdoAddSingleQuotes.AutoSize = true;
            rdoAddSingleQuotes.Location = new Point(10, 50);
            rdoAddSingleQuotes.Name = "rdoAddSingleQuotes";
            rdoAddSingleQuotes.Size = new Size(120, 19);
            rdoAddSingleQuotes.TabIndex = 0;
            rdoAddSingleQuotes.Text = "Add single quotes";
            rdoAddSingleQuotes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(cboAddLineBreaks);
            groupBox2.Location = new Point(168, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(157, 53);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Misc";
            // 
            // cboAddLineBreaks
            // 
            cboAddLineBreaks.AutoSize = true;
            cboAddLineBreaks.Location = new Point(10, 25);
            cboAddLineBreaks.Name = "cboAddLineBreaks";
            cboAddLineBreaks.Size = new Size(107, 19);
            cboAddLineBreaks.TabIndex = 3;
            cboAddLineBreaks.Text = "Add line breaks";
            cboAddLineBreaks.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnContinue.DialogResult = DialogResult.OK;
            btnContinue.Location = new Point(644, 399);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // cboHeaders
            // 
            cboHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboHeaders.AutoSize = true;
            cboHeaders.Location = new Point(647, 8);
            cboHeaders.Name = "cboHeaders";
            cboHeaders.Size = new Size(74, 19);
            cboHeaders.TabIndex = 7;
            cboHeaders.Text = "Headers?";
            cboHeaders.UseVisualStyleBackColor = true;
            // 
            // TableSelectionForm
            // 
            AcceptButton = btnContinue;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 434);
            Controls.Add(cboHeaders);
            Controls.Add(btnContinue);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvContent);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TableSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text options";
            TopMost = true;
            Load += TableSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DoubleBufferedDataGridView dgvContent;
        private GroupBox groupBox1;
        private RadioButton rdoAddDoubleQuotes;
        private RadioButton rdoAddSingleQuotes;
        private RadioButton rdoNone;
        private GroupBox groupBox2;
        private CheckBox cboAddLineBreaks;
        private Button btnContinue;
        private CheckBox cboHeaders;
    }
}