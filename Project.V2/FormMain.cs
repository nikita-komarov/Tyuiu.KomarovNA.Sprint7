using System.Data;
using System.Windows.Forms;

namespace Project.V2;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();

    }
    private int currentId = 1;
    string currentPage = "";
    private string openFilePath = "";



    private void toHome_Click_KNA(object sender, EventArgs e)
    {
        this.currentPage = "Главная";
        handleChangePage();
    }

    private void toOwner_KNA_Click(object sender, EventArgs e)
    {
        this.currentPage = "Владельцы";
        handleChangePage();
    }

    private void toProvider_KNA_Click(object sender, EventArgs e)
    {
        this.currentPage = "Поставщики";
        handleChangePage();
    }

    private void toShop_KNA_Click(object sender, EventArgs e)
    {
        this.currentPage = "Магазины";
        handleChangePage();
    }
    private void changeTitle()
    {
        this.pageTitle_KNA.Text = this.currentPage;
    }
    private void loadCSV()
    {
        string projectRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\");
        string databasePath = Path.Combine(projectRoot, "database");
        string filePath = currentPage switch
        {
            "Владельцы" => Path.Combine(databasePath, "owners.csv"),
            "Магазины" => Path.Combine(databasePath, "stores.csv"),
            "Поставщики" => Path.Combine(databasePath, "suppliers.csv"),
            _ => null
        };

        if (filePath == null || !File.Exists(filePath))
        {
            output_KNA.DataSource = null;
            return;
        }

        DataTable table = CsvHandler.ReadCsv(filePath);

        output_KNA.DataSource = table;



        // change currentId
        DataTable dataTable = (DataTable)output_KNA.DataSource;
        if (dataTable != null && dataTable.Rows.Count > 0)
        {
            var ids = dataTable.AsEnumerable()
                               .Select(row => int.TryParse(row["ID"]?.ToString(), out int idValue) ? idValue : 0);

            this.currentId = ids.Max() + 1;
        }
        else
        {
            this.currentId = 1;
        }
    }

    private void handleChangePage()
    {
        changeTitle();
        if (this.currentPage != "Главная")
        {
            loadCSV();
        }
        else
        {
            output_KNA.DataSource = null;
        }
    }





    private void openButton_KNA_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "CSV Files (*.csv)|*.csv",
            Title = "Выберите файл"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            DataTable ownersTable = CsvHandler.ReadCsv(filePath);

            output_KNA.DataSource = ownersTable;
        }
    }

    private void addButton_KNA_Click(object sender, EventArgs e)
    {
        if (this.currentPage == "Владельцы")
        {
            FormOwnerDetails form = new FormOwnerDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)output_KNA.DataSource;

                if (dataTable == null)
                {
                    dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Name", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    dataTable.Columns.Add("Phone", typeof(string));
                    dataTable.Columns.Add("Capital", typeof(decimal));
                    output_KNA.DataSource = dataTable;
                }

                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = currentId++;
                newRow["Name"] = form.Name;
                newRow["Address"] = form.Address;
                newRow["Phone"] = form.Phone;
                newRow["Capital"] = form.Capital;
                dataTable.Rows.Add(newRow);
            }
        }

        if (this.currentPage == "Магазины")
        {
            FormStoreDetails form = new FormStoreDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)output_KNA.DataSource;

                if (dataTable == null)
                {
                    dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Name", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    dataTable.Columns.Add("Phone", typeof(string));
                    output_KNA.DataSource = dataTable;
                }

                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = currentId++;
                newRow["Name"] = form.Name;
                newRow["Address"] = form.Address;
                newRow["Phone"] = form.Phone;
                dataTable.Rows.Add(newRow);
            }
        }

        if (this.currentPage == "Поставщики")
        {
            FormSuppliersDetails form = new FormSuppliersDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)output_KNA.DataSource;

                if (dataTable == null)
                {
                    dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Name", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    dataTable.Columns.Add("Phone", typeof(string));
                    dataTable.Columns.Add("Capital", typeof(decimal));
                    output_KNA.DataSource = dataTable;
                }

                DataRow newRow = dataTable.NewRow();
                newRow["ID"] = currentId++;
                newRow["Name"] = form.Name;
                newRow["Address"] = form.Address;
                newRow["Phone"] = form.Phone;
                newRow["SupplyCost"] = form.Capital;
                dataTable.Rows.Add(newRow);
            }
        }

    }

    private void editButton_KNA_Click(object sender, EventArgs e)
    {
        if (output_KNA.CurrentRow == null)
        {
            MessageBox.Show("Выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int selectedRowIndex = output_KNA.CurrentRow.Index;

        DataRow row = ((DataTable)output_KNA.DataSource).Rows[selectedRowIndex];

        if (this.currentPage == "Владельцы")
        {
            FormOwnerDetails formOwner = new FormOwnerDetails
            {
                Name = row["Name"].ToString(),
                Address = row["Address"].ToString(),
                Phone = row["Phone"].ToString(),
                Capital = Convert.ToDecimal(row["Capital"])
            };

            if (formOwner.ShowDialog() == DialogResult.OK)
            {
                row["Name"] = formOwner.Name;
                row["Address"] = formOwner.Address;
                row["Phone"] = formOwner.Phone;
                row["Capital"] = formOwner.Capital;
            }
        }

        if (this.currentPage == "Магазины")
        {
            FormStoreDetails formOwner = new FormStoreDetails
            {
                Name = row["Name"].ToString(),
                Address = row["Address"].ToString(),
                Phone = row["Phone"].ToString(),
            };

            if (formOwner.ShowDialog() == DialogResult.OK)
            {
                row["Name"] = formOwner.Name;
                row["Address"] = formOwner.Address;
                row["Phone"] = formOwner.Phone;
            }
        }

        if (this.currentPage == "Поставщики")
        {
            FormSuppliersDetails formOwner = new FormSuppliersDetails
            {
                Name = row["Name"].ToString(),
                Address = row["Address"].ToString(),
                Phone = row["Phone"].ToString(),
                Capital = Convert.ToDecimal(row["SupplyCost"])
            };

            if (formOwner.ShowDialog() == DialogResult.OK)
            {
                row["Name"] = formOwner.Name;
                row["Address"] = formOwner.Address;
                row["Phone"] = formOwner.Phone;
                row["SupplyCost"] = formOwner.Capital;
            }
        }

    }

    private void saveButton_KNA_Click(object sender, EventArgs e)
    {
        string projectRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\");
        string databasePath = Path.Combine(projectRoot, "database");
        string filePath = currentPage switch
        {
            "Владельцы" => Path.Combine(databasePath, "owners.csv"),
            "Магазины" => Path.Combine(databasePath, "stores.csv"),
            "Поставщики" => Path.Combine(databasePath, "suppliers.csv"),
            _ => null
        };

        try
        {
            DataTable dataTable = (DataTable)output_KNA.DataSource;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string[] headers = dataTable.Columns.Cast<DataColumn>()
                                                 .Select(col => col.ColumnName)
                                                 .ToArray();
                    writer.WriteLine(string.Join(",", headers));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string[] rowValues = row.ItemArray.Select(field => field.ToString()).ToArray();
                        writer.WriteLine(string.Join(",", rowValues));
                    }
                }

                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FAQButton_KNA_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new FormAbout();
        formAbout.ShowDialog();
    }

    private void deleteButton_KNA_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dataTable = (DataTable)output_KNA.DataSource;

            if (output_KNA.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = output_KNA.CurrentRow.Index;
            DataRow row = ((DataTable)output_KNA.DataSource).Rows[selectedRowIndex];

            dataTable.Rows.RemoveAt(selectedRowIndex);
            MessageBox.Show("Запись успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}




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