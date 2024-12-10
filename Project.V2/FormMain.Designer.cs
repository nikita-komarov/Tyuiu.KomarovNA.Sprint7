namespace Project.V2;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        toolTip = new ToolTip(components);
        openFileDialogTask = new OpenFileDialog();
        openButton_KNA = new Button();
        FAQButton_KNA = new Button();
        editButton_KNA = new Button();
        saveButton_KNA = new Button();
        splitContainer1 = new SplitContainer();
        addButton_KNA = new Button();
        toShop_KNA = new Label();
        toProvider_KNA = new Label();
        toOwner_KNA = new Label();
        toHome_KNA = new Label();
        output_KNA = new DataGridView();
        pageTitle_KNA = new Label();
        deleteButton_KNA = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)output_KNA).BeginInit();
        SuspendLayout();
        // 
        // toolTip
        // 
        toolTip.ToolTipIcon = ToolTipIcon.Info;
        toolTip.ToolTipTitle = "Подсказка";
        // 
        // openButton_KNA
        // 
        openButton_KNA.BackColor = Color.GreenYellow;
        openButton_KNA.FlatStyle = FlatStyle.Flat;
        openButton_KNA.Location = new Point(184, 12);
        openButton_KNA.Name = "openButton_KNA";
        openButton_KNA.Size = new Size(78, 44);
        openButton_KNA.TabIndex = 34;
        openButton_KNA.Text = "Импорт";
        openButton_KNA.UseVisualStyleBackColor = false;
        openButton_KNA.Click += openButton_KNA_Click;
        // 
        // FAQButton_KNA
        // 
        FAQButton_KNA.BackColor = Color.Gold;
        FAQButton_KNA.FlatStyle = FlatStyle.Flat;
        FAQButton_KNA.Location = new Point(1000, 12);
        FAQButton_KNA.Name = "FAQButton_KNA";
        FAQButton_KNA.Size = new Size(63, 44);
        FAQButton_KNA.TabIndex = 33;
        FAQButton_KNA.Text = "Справка";
        FAQButton_KNA.UseVisualStyleBackColor = false;
        FAQButton_KNA.Click += FAQButton_KNA_Click;
        // 
        // editButton_KNA
        // 
        editButton_KNA.BackColor = Color.CornflowerBlue;
        editButton_KNA.FlatStyle = FlatStyle.Flat;
        editButton_KNA.Location = new Point(10, 438);
        editButton_KNA.Name = "editButton_KNA";
        editButton_KNA.Size = new Size(141, 31);
        editButton_KNA.TabIndex = 32;
        editButton_KNA.Text = "Редактировать";
        editButton_KNA.UseVisualStyleBackColor = false;
        editButton_KNA.Click += editButton_KNA_Click;
        // 
        // saveButton_KNA
        // 
        saveButton_KNA.BackColor = Color.Yellow;
        saveButton_KNA.FlatStyle = FlatStyle.Flat;
        saveButton_KNA.Location = new Point(268, 12);
        saveButton_KNA.Name = "saveButton_KNA";
        saveButton_KNA.Size = new Size(78, 44);
        saveButton_KNA.TabIndex = 35;
        saveButton_KNA.Text = "Сохранить";
        saveButton_KNA.UseVisualStyleBackColor = false;
        saveButton_KNA.Click += saveButton_KNA_Click;
        // 
        // splitContainer1
        // 
        splitContainer1.BorderStyle = BorderStyle.FixedSingle;
        splitContainer1.Location = new Point(12, 62);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(deleteButton_KNA);
        splitContainer1.Panel1.Controls.Add(addButton_KNA);
        splitContainer1.Panel1.Controls.Add(toShop_KNA);
        splitContainer1.Panel1.Controls.Add(toProvider_KNA);
        splitContainer1.Panel1.Controls.Add(toOwner_KNA);
        splitContainer1.Panel1.Controls.Add(editButton_KNA);
        splitContainer1.Panel1.Controls.Add(toHome_KNA);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(output_KNA);
        splitContainer1.Panel2.Controls.Add(pageTitle_KNA);
        splitContainer1.Size = new Size(1051, 518);
        splitContainer1.SplitterDistance = 167;
        splitContainer1.TabIndex = 36;
        // 
        // addButton_KNA
        // 
        addButton_KNA.BackColor = Color.CornflowerBlue;
        addButton_KNA.FlatStyle = FlatStyle.Flat;
        addButton_KNA.Location = new Point(10, 398);
        addButton_KNA.Name = "addButton_KNA";
        addButton_KNA.Size = new Size(141, 34);
        addButton_KNA.TabIndex = 37;
        addButton_KNA.Text = "Добавить";
        addButton_KNA.UseVisualStyleBackColor = false;
        addButton_KNA.Click += addButton_KNA_Click;
        // 
        // toShop_KNA
        // 
        toShop_KNA.AutoSize = true;
        toShop_KNA.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        toShop_KNA.Location = new Point(3, 157);
        toShop_KNA.Name = "toShop_KNA";
        toShop_KNA.Size = new Size(135, 30);
        toShop_KNA.TabIndex = 3;
        toShop_KNA.Text = "Магазины";
        toShop_KNA.Click += toShop_KNA_Click;
        // 
        // toProvider_KNA
        // 
        toProvider_KNA.AutoSize = true;
        toProvider_KNA.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        toProvider_KNA.Location = new Point(3, 110);
        toProvider_KNA.Name = "toProvider_KNA";
        toProvider_KNA.Size = new Size(161, 30);
        toProvider_KNA.TabIndex = 2;
        toProvider_KNA.Text = "Поставщики";
        toProvider_KNA.Click += toProvider_KNA_Click;
        // 
        // toOwner_KNA
        // 
        toOwner_KNA.AutoSize = true;
        toOwner_KNA.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        toOwner_KNA.Location = new Point(3, 64);
        toOwner_KNA.Name = "toOwner_KNA";
        toOwner_KNA.Size = new Size(148, 30);
        toOwner_KNA.TabIndex = 1;
        toOwner_KNA.Text = "Владельцы";
        toOwner_KNA.Click += toOwner_KNA_Click;
        // 
        // toHome_KNA
        // 
        toHome_KNA.AutoSize = true;
        toHome_KNA.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        toHome_KNA.Location = new Point(3, 19);
        toHome_KNA.Name = "toHome_KNA";
        toHome_KNA.Size = new Size(111, 30);
        toHome_KNA.TabIndex = 0;
        toHome_KNA.Text = "Главная";
        toHome_KNA.Click += toHome_Click_KNA;
        // 
        // output_KNA
        // 
        output_KNA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        output_KNA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        output_KNA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        output_KNA.Location = new Point(39, 43);
        output_KNA.Name = "output_KNA";
        output_KNA.RowHeadersVisible = false;
        output_KNA.RowHeadersWidth = 40;
        output_KNA.Size = new Size(799, 448);
        output_KNA.TabIndex = 5;
        // 
        // pageTitle_KNA
        // 
        pageTitle_KNA.AutoSize = true;
        pageTitle_KNA.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        pageTitle_KNA.Location = new Point(361, 10);
        pageTitle_KNA.Name = "pageTitle_KNA";
        pageTitle_KNA.Size = new Size(111, 30);
        pageTitle_KNA.TabIndex = 4;
        pageTitle_KNA.Text = "Главная";
        // 
        // deleteButton_KNA
        // 
        deleteButton_KNA.BackColor = Color.Crimson;
        deleteButton_KNA.FlatStyle = FlatStyle.Flat;
        deleteButton_KNA.Location = new Point(10, 475);
        deleteButton_KNA.Name = "deleteButton_KNA";
        deleteButton_KNA.Size = new Size(141, 31);
        deleteButton_KNA.TabIndex = 38;
        deleteButton_KNA.Text = "Удалить";
        deleteButton_KNA.UseVisualStyleBackColor = false;
        deleteButton_KNA.Click += deleteButton_KNA_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1075, 589);
        Controls.Add(splitContainer1);
        Controls.Add(saveButton_KNA);
        Controls.Add(openButton_KNA);
        Controls.Add(FAQButton_KNA);
        Name = "FormMain";
        Text = "Сеть Магазинов";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)output_KNA).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolTip toolTip;
    private OpenFileDialog openFileDialogTask;
    private Button openButton_KNA;
    private Button FAQButton_KNA;
    private Button editButton_KNA;
    private Button saveButton_KNA;
    private SplitContainer splitContainer1;
    private Label toHome_KNA;
    private Label toShop_KNA;
    private Label toProvider_KNA;
    private Label toOwner_KNA;
    private Label pageTitle_KNA;
    private DataGridView output_KNA;
    private Button addButton_KNA;
    private Button deleteButton_KNA;
}
