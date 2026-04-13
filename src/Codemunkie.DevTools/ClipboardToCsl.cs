using Codemunkie.DevTools.TextTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemunkie.DevTools
{
    public static class ClipboardToCsl
    {
        public static void Handle()
        {
            if (Clipboard.ContainsText())
            {
                var tableSelectionForm = new TableSelectionForm
                {
                    TextData = Clipboard.GetText()
                };
                var dialogResult = tableSelectionForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    var options = tableSelectionForm.Options!;

                    var newText = tableSelectionForm.SelectedData!.ToCsl(options.CslSeperator, options.ItemPrefix, options.ItemSuffix);

                    Clipboard.SetText(newText);
                    ToastHelper.Show("Converted to CSL.");
                }
            }
            else
            {
                MessageBox.Show("Clipboard content can't be converted.", "Warning");
            }
        }
    }
}
