namespace Project.V2
{
    partial class FormOwnerDetails
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
            TextBox textBoxName = new TextBox { Name = "textBoxName", Location = new Point(10, 30), Width = 200 };
            TextBox textBoxAddress = new TextBox { Name = "textBoxAddress", Location = new Point(10, 90), Width = 200 };
            TextBox textBoxPhone = new TextBox { Name = "textBoxPhone", Location = new Point(10, 150), Width = 200 };
            NumericUpDown numericCapital = new NumericUpDown { Name = "numericCapital", Location = new Point(10, 210), Width = 200 };

            Button buttonSave = new Button { Text = "Сохранить", Location = new Point(10, 235) };
            buttonSave.Click += (sender, e) =>
            {
                Name = textBoxName.Text;
                Address = textBoxAddress.Text;
                Phone = textBoxPhone.Text;
                Capital = numericCapital.Value;
                DialogResult = DialogResult.OK;
            };

            Controls.Add(new Label { Text = "Имя:", Location = new Point(10, 0), BackColor=Color.Transparent });
            Controls.Add(textBoxName);
            Controls.Add(new Label { Text = "Адрес:", Location = new Point(10, 60), BackColor = Color.Transparent });
            Controls.Add(textBoxAddress);
            Controls.Add(new Label { Text = "Телефон:", Location = new Point(10, 120), BackColor = Color.Transparent });
            Controls.Add(textBoxPhone);
            Controls.Add(new Label { Text = "Капитал:", Location = new Point(10, 180), BackColor = Color.Transparent });
            Controls.Add(numericCapital);
            Controls.Add(buttonSave);
        }

        #endregion
    }
}