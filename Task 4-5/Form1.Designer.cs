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
            panel1.Location = new Point(0 , 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(800 , 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0 , 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800 , 32);
            panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 32);
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
            splitContainer1.Size = new Size(800 , 380);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 2;
            // 
            // IsShowOnScreen
            // 
            IsShowOnScreen.AutoSize = true;
            IsShowOnScreen.Checked = true;
            IsShowOnScreen.CheckState = CheckState.Checked;
            IsShowOnScreen.Location = new Point(25 , 256);
            IsShowOnScreen.Name = "IsShowOnScreen";
            IsShowOnScreen.Size = new Size(154 , 24);
            IsShowOnScreen.TabIndex = 8;
            IsShowOnScreen.Text = "Вывести на экран";
            IsShowOnScreen.UseVisualStyleBackColor = true;
            // 
            // IsSaveinFile
            // 
            IsSaveinFile.AutoSize = true;
            IsSaveinFile.Location = new Point(25 , 226);
            IsSaveinFile.Name = "IsSaveinFile";
            IsSaveinFile.Size = new Size(156 , 24);
            IsSaveinFile.TabIndex = 7;
            IsSaveinFile.Text = "Сохранить в файл";
            IsSaveinFile.UseVisualStyleBackColor = true;
            // 
            // ShowReportBtn
            // 
            ShowReportBtn.Location = new Point(25 , 307);
            ShowReportBtn.Name = "ShowReportBtn";
            ShowReportBtn.Size = new Size(221 , 29);
            ShowReportBtn.TabIndex = 1;
            ShowReportBtn.Text = "Показать отчет";
            ShowReportBtn.UseVisualStyleBackColor = true;
            ShowReportBtn.Click += ShowReportBtn_Click;
            // 
            // DestinationTxtBox
            // 
            DestinationTxtBox.Location = new Point(25 , 179);
            DestinationTxtBox.Name = "DestinationTxtBox";
            DestinationTxtBox.ReadOnly = true;
            DestinationTxtBox.Size = new Size(221 , 27);
            DestinationTxtBox.TabIndex = 6;
            // 
            // SourceTxtBox
            // 
            SourceTxtBox.Location = new Point(25 , 63);
            SourceTxtBox.Name = "SourceTxtBox";
            SourceTxtBox.ReadOnly = true;
            SourceTxtBox.Size = new Size(221 , 27);
            SourceTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25 , 136);
            label2.Name = "label2";
            label2.Size = new Size(122 , 20);
            label2.TabIndex = 4;
            label2.Text = "Конечная папка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29 , 23);
            label1.Name = "label1";
            label1.Size = new Size(120 , 20);
            label1.TabIndex = 3;
            label1.Text = "Папка источник";
            // 
            // DestinationBtn
            // 
            DestinationBtn.Location = new Point(148 , 132);
            DestinationBtn.Name = "DestinationBtn";
            DestinationBtn.Size = new Size(94 , 29);
            DestinationBtn.TabIndex = 2;
            DestinationBtn.Text = "Открыть";
            DestinationBtn.UseVisualStyleBackColor = true;
            DestinationBtn.Click += DestinationBtn_Click;
            // 
            // sourceBtn
            // 
            sourceBtn.Location = new Point(152 , 19);
            sourceBtn.Name = "sourceBtn";
            sourceBtn.Size = new Size(94 , 29);
            sourceBtn.TabIndex = 1;
            sourceBtn.Text = " Открыть";
            sourceBtn.UseVisualStyleBackColor = true;
            sourceBtn.Click += sourceBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0 , 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530 , 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Отчет";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3 , 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(524 , 354);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
    }
}
