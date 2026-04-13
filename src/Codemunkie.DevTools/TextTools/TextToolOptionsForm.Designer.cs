namespace Codemunkie.DevTools
{
    partial class TextToolOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToolOptionsForm));
            btnContinue = new Button();
            groupBox1 = new GroupBox();
            rdoAddDoubleQuotes = new RadioButton();
            rdoAddSingleQuotes = new RadioButton();
            cboAddLineBreaks = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnContinue.DialogResult = DialogResult.OK;
            btnContinue.Location = new Point(230, 138);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoAddDoubleQuotes);
            groupBox1.Controls.Add(rdoAddSingleQuotes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 54);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item wrapping";
            // 
            // rdoAddDoubleQuotes
            // 
            rdoAddDoubleQuotes.AutoSize = true;
            rdoAddDoubleQuotes.Location = new Point(144, 22);
            rdoAddDoubleQuotes.Name = "rdoAddDoubleQuotes";
            rdoAddDoubleQuotes.Size = new Size(126, 19);
            rdoAddDoubleQuotes.TabIndex = 3;
            rdoAddDoubleQuotes.TabStop = true;
            rdoAddDoubleQuotes.Text = "Add double quotes";
            rdoAddDoubleQuotes.UseVisualStyleBackColor = true;
            // 
            // rdoAddSingleQuotes
            // 
            rdoAddSingleQuotes.AutoSize = true;
            rdoAddSingleQuotes.Location = new Point(10, 22);
            rdoAddSingleQuotes.Name = "rdoAddSingleQuotes";
            rdoAddSingleQuotes.Size = new Size(120, 19);
            rdoAddSingleQuotes.TabIndex = 0;
            rdoAddSingleQuotes.TabStop = true;
            rdoAddSingleQuotes.Text = "Add single quotes";
            rdoAddSingleQuotes.UseVisualStyleBackColor = true;
            // 
            // cboAddLineBreaks
            // 
            cboAddLineBreaks.AutoSize = true;
            cboAddLineBreaks.Checked = true;
            cboAddLineBreaks.CheckState = CheckState.Checked;
            cboAddLineBreaks.Location = new Point(10, 25);
            cboAddLineBreaks.Name = "cboAddLineBreaks";
            cboAddLineBreaks.Size = new Size(107, 19);
            cboAddLineBreaks.TabIndex = 3;
            cboAddLineBreaks.Text = "Add line breaks";
            cboAddLineBreaks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboAddLineBreaks);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 53);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Misc";
            // 
            // TextToolOptionsForm
            // 
            AcceptButton = btnContinue;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 173);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnContinue);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TextToolOptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text options";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnContinue;
        private GroupBox groupBox1;
        private RadioButton rdoAddDoubleQuotes;
        private RadioButton rdoAddSingleQuotes;
        private CheckBox cboAddLineBreaks;
        private GroupBox groupBox2;
    }
}