namespace Task_4_5
{
    partial class Form1
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
            panel1 = new Panel();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            IsShowOnScreen = new CheckBox();
            IsSaveinFile = new CheckBox();
            ShowReportBtn = new Button();
            DestinationTxtBox = new TextBox();
            SourceTxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DestinationBtn = new Button();
            sourceBtn = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            FileNameClmn = new DataGridViewTextBoxColumn();
            FileSourcePathClmn = new DataGridViewTextBoxColumn();
            FileDestinationClmn = new DataGridViewTextBoxColumn();
            FileTypeClmn = new DataGridViewTextBoxColumn();
            FileStatusClmn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 310);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 28);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1148, 24);
            panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(IsShowOnScreen);
            splitContainer1.Panel1.Controls.Add(IsSaveinFile);
            splitContainer1.Panel1.Controls.Add(ShowReportBtn);
            splitContainer1.Panel1.Controls.Add(DestinationTxtBox);
            splitContainer1.Panel1.Controls.Add(SourceTxtBox);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(DestinationBtn);
            splitContainer1.Panel1.Controls.Add(sourceBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1148, 286);
            splitContainer1.SplitterDistance = 381;
            splitContainer1.TabIndex = 2;
            // 
            // IsShowOnScreen
            // 
            IsShowOnScreen.AutoSize = true;
            IsShowOnScreen.Checked = true;
            IsShowOnScreen.CheckState = CheckState.Checked;
            IsShowOnScreen.Location = new Point(22, 192);
            IsShowOnScreen.Margin = new Padding(3, 2, 3, 2);
            IsShowOnScreen.Name = "IsShowOnScreen";
            IsShowOnScreen.Size = new Size(123, 19);
            IsShowOnScreen.TabIndex = 8;
            IsShowOnScreen.Text = "Вывести на экран";
            IsShowOnScreen.UseVisualStyleBackColor = true;
            // 
            // IsSaveinFile
            // 
            IsSaveinFile.AutoSize = true;
            IsSaveinFile.Location = new Point(22, 170);
            IsSaveinFile.Margin = new Padding(3, 2, 3, 2);
            IsSaveinFile.Name = "IsSaveinFile";
            IsSaveinFile.Size = new Size(126, 19);
            IsSaveinFile.TabIndex = 7;
            IsSaveinFile.Text = "Сохранить в файл";
            IsSaveinFile.UseVisualStyleBackColor = true;
            // 
            // ShowReportBtn
            // 
            ShowReportBtn.Location = new Point(22, 230);
            ShowReportBtn.Margin = new Padding(3, 2, 3, 2);
            ShowReportBtn.Name = "ShowReportBtn";
            ShowReportBtn.Size = new Size(193, 22);
            ShowReportBtn.TabIndex = 1;
            ShowReportBtn.Text = "Показать отчет";
            ShowReportBtn.UseVisualStyleBackColor = true;
            ShowReportBtn.Click += ShowReportBtn_Click;
            // 
            // DestinationTxtBox
            // 
            DestinationTxtBox.Location = new Point(22, 134);
            DestinationTxtBox.Margin = new Padding(3, 2, 3, 2);
            DestinationTxtBox.Name = "DestinationTxtBox";
            DestinationTxtBox.ReadOnly = true;
            DestinationTxtBox.Size = new Size(194, 23);
            DestinationTxtBox.TabIndex = 6;
            // 
            // SourceTxtBox
            // 
            SourceTxtBox.Location = new Point(22, 47);
            SourceTxtBox.Margin = new Padding(3, 2, 3, 2);
            SourceTxtBox.Name = "SourceTxtBox";
            SourceTxtBox.ReadOnly = true;
            SourceTxtBox.Size = new Size(194, 23);
            SourceTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Конечная папка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Папка источник";
            // 
            // DestinationBtn
            // 
            DestinationBtn.Location = new Point(130, 99);
            DestinationBtn.Margin = new Padding(3, 2, 3, 2);
            DestinationBtn.Name = "DestinationBtn";
            DestinationBtn.Size = new Size(82, 22);
            DestinationBtn.TabIndex = 2;
            DestinationBtn.Text = "Открыть";
            DestinationBtn.UseVisualStyleBackColor = true;
            DestinationBtn.Click += DestinationBtn_Click;
            // 
            // sourceBtn
            // 
            sourceBtn.Location = new Point(133, 14);
            sourceBtn.Margin = new Padding(3, 2, 3, 2);
            sourceBtn.Name = "sourceBtn";
            sourceBtn.Size = new Size(82, 22);
            sourceBtn.TabIndex = 1;
            sourceBtn.Text = " Открыть";
            sourceBtn.UseVisualStyleBackColor = true;
            sourceBtn.Click += sourceBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(763, 286);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Отчет";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FileNameClmn, FileSourcePathClmn, FileDestinationClmn, FileTypeClmn, FileStatusClmn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 18);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 266);
            dataGridView1.TabIndex = 0;
            // 
            // FileNameClmn
            // 
            FileNameClmn.HeaderText = "Название Файла";
            FileNameClmn.Name = "FileNameClmn";
            FileNameClmn.ReadOnly = true;
            // 
            // FileSourcePathClmn
            // 
            FileSourcePathClmn.HeaderText = "Источник";
            FileSourcePathClmn.Name = "FileSourcePathClmn";
            FileSourcePathClmn.ReadOnly = true;
            FileSourcePathClmn.Width = 200;
            // 
            // FileDestinationClmn
            // 
            FileDestinationClmn.HeaderText = "Конечный путь";
            FileDestinationClmn.Name = "FileDestinationClmn";
            FileDestinationClmn.ReadOnly = true;
            FileDestinationClmn.Width = 200;
            // 
            // FileTypeClmn
            // 
            FileTypeClmn.HeaderText = "Тип файла";
            FileTypeClmn.Name = "FileTypeClmn";
            FileTypeClmn.ReadOnly = true;
            // 
            // FileStatusClmn
            // 
            FileStatusClmn.HeaderText = "Статус";
            FileStatusClmn.Name = "FileStatusClmn";
            FileStatusClmn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 338);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private Button DestinationBtn;
        private Button sourceBtn;
        private DataGridView dataGridView1;
        private Button ShowReportBtn;
        private TextBox DestinationTxtBox;
        private TextBox SourceTxtBox;
        private GroupBox groupBox1;
        private CheckBox IsShowOnScreen;
        private CheckBox IsSaveinFile;
        private DataGridViewTextBoxColumn FileNameClmn;
        private DataGridViewTextBoxColumn FileSourcePathClmn;
        private DataGridViewTextBoxColumn FileDestinationClmn;
        private DataGridViewTextBoxColumn FileTypeClmn;
        private DataGridViewTextBoxColumn FileStatusClmn;
    }
}
