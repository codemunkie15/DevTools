using System.Data;

namespace Codemunkie.DevTools
{
    public static class DataTableParser
    {
        public static bool AssumeHeaders(string text)
        {
            return text.Contains('\t');
        }

        public static DataTable Parse(string text, bool hasHeaders)
        {
            var lines = text.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);

            var isTabSeparated = lines[0].Contains('\t');

            if (isTabSeparated)
            {
                return CreateTabDelimitedDataTable(lines, hasHeaders);
            }
            else
            {
                return CreateSingleColumnDataTable(lines);
            }
        }

        private static DataTable CreateTabDelimitedDataTable(string[] lines, bool hasHeaders)
        {
            var dataTable = new DataTable();

            var headers = lines[0].Split('\t');
            for (int i = 0; i < headers.Length; i++)
            {
                var columnName = $"Column{i + 1}"; // Default
                var headerName = headers[i].Trim();

                if (hasHeaders && !string.IsNullOrEmpty(headerName))
                {
                    columnName = headerName;
                }

                dataTable.Columns.Add(columnName);
            }

            var contentStartIndex = hasHeaders ? 1 : 0;

            for (int i = contentStartIndex; i < lines.Length; i++)
            {
                var values = lines[i].Split('\t');
                var row = dataTable.NewRow();

                for (int j = 0; j < Math.Min(values.Length, dataTable.Columns.Count); j++)
                {
                    row[j] = values[j].Trim();
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private static DataTable CreateSingleColumnDataTable(string[] lines)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Column1");

            foreach (var line in lines)
            {
                var row = dataTable.NewRow();
                row[0] = line.Trim();
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
