namespace Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            fileSystemWatcher1 = new FileSystemWatcher();
            buttonOK_KNA = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonOK_KNA
            // 
            buttonOK_KNA.Location = new Point(12, 629);
            buttonOK_KNA.Name = "buttonOK_KNA";
            buttonOK_KNA.Size = new Size(104, 29);
            buttonOK_KNA.TabIndex = 8;
            buttonOK_KNA.Text = "OK";
            buttonOK_KNA.UseVisualStyleBackColor = true;
            buttonOK_KNA.Click += buttonOK_KNA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1045, 615);
            label1.TabIndex = 7;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 664);
            Controls.Add(buttonOK_KNA);
            Controls.Add(label1);
            Name = "FormAbout";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button buttonOK_KNA;
        private Label label1;
    }
}