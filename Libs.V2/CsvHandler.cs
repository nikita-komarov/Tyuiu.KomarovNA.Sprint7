using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class CsvHandler
{
    public static DataTable ReadCsv(string filePath)
    {
        DataTable table = new DataTable();
        try
        {
            using (var reader = new StreamReader(filePath))
            {
                // Read headers
                string[] headers = reader.ReadLine()?.Split(',');
                if (headers == null) throw new Exception("Файл пустой или поврежден.");
                foreach (var header in headers)
                    table.Columns.Add(header);

                // Read rows
                while (!reader.EndOfStream)
                {
                    string[] row = reader.ReadLine()?.Split(',');
                    if (row != null) table.Rows.Add(row);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return table;
    }
}