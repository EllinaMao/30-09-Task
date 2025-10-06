namespace _30_09_Task
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
            PauseBtn = new Button();
            StopBtn = new Button();
            StartBtn = new Button();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
            ShowToolStripMenuItem = new ToolStripMenuItem();
            AmountSentensesToolStripMenuItem = new ToolStripMenuItem();
            AmountSimbolsToolStripMenuItem = new ToolStripMenuItem();
            AmountWordsToolStripMenuItem = new ToolStripMenuItem();
            AmountQuestionSentencesToolStripMenuItem = new ToolStripMenuItem();
            AmountExclamationSentencesToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PauseBtn);
            panel1.Controls.Add(StopBtn);
            panel1.Controls.Add(StartBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0 , 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(800 , 41);
            panel1.TabIndex = 2;
            // 
            // PauseBtn
            // 
            PauseBtn.Location = new Point(600 , 4);
            PauseBtn.Margin = new Padding(3 , 4 , 3 , 4);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(86 , 31);
            PauseBtn.TabIndex = 3;
            PauseBtn.Text = "⏯";
            PauseBtn.UseVisualStyleBackColor = true;
            PauseBtn.Click += PauseBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(701 , 3);
            StopBtn.Margin = new Padding(3 , 4 , 3 , 4);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(86 , 31);
            StopBtn.TabIndex = 2;
            StopBtn.Text = "⏹";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(12 , 5);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(94 , 29);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "▶";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += button1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 30);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(800 , 380);
            splitContainer1.SplitterDistance = 433;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0 , 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433 , 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3 , 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(427 , 354);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0 , 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362 , 380);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3 , 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(356 , 354);
            dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20 , 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem , ShowToolStripMenuItem });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6 , 3 , 0 , 3);
            menuStrip1.Size = new Size(800 , 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToFileToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59 , 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            saveToFileToolStripMenuItem.Size = new Size(217 , 26);
            saveToFileToolStripMenuItem.Text = "Сохранить в файл";
            saveToFileToolStripMenuItem.Click += saveToFileToolStripMenuItem_Click;
            // 
            // ShowToolStripMenuItem
            // 
            ShowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AmountSentensesToolStripMenuItem , AmountSimbolsToolStripMenuItem , AmountWordsToolStripMenuItem , AmountQuestionSentencesToolStripMenuItem , AmountExclamationSentencesToolStripMenuItem });
            ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            ShowToolStripMenuItem.Size = new Size(87 , 24);
            ShowToolStripMenuItem.Text = "Показать";
            // 
            // AmountSentensesToolStripMenuItem
            // 
            AmountSentensesToolStripMenuItem.Checked = true;
            AmountSentensesToolStripMenuItem.CheckOnClick = true;
            AmountSentensesToolStripMenuItem.CheckState = CheckState.Checked;
            AmountSentensesToolStripMenuItem.Name = "AmountSentensesToolStripMenuItem";
            AmountSentensesToolStripMenuItem.Size = new Size(400 , 26);
            AmountSentensesToolStripMenuItem.Text = "Количество предложений";
            // 
            // AmountSimbolsToolStripMenuItem
            // 
            AmountSimbolsToolStripMenuItem.Checked = true;
            AmountSimbolsToolStripMenuItem.CheckOnClick = true;
            AmountSimbolsToolStripMenuItem.CheckState = CheckState.Checked;
            AmountSimbolsToolStripMenuItem.Name = "AmountSimbolsToolStripMenuItem";
            AmountSimbolsToolStripMenuItem.Size = new Size(400 , 26);
            AmountSimbolsToolStripMenuItem.Text = "Количество символов";
            // 
            // AmountWordsToolStripMenuItem
            // 
            AmountWordsToolStripMenuItem.Checked = true;
            AmountWordsToolStripMenuItem.CheckOnClick = true;
            AmountWordsToolStripMenuItem.CheckState = CheckState.Checked;
            AmountWordsToolStripMenuItem.Name = "AmountWordsToolStripMenuItem";
            AmountWordsToolStripMenuItem.Size = new Size(400 , 26);
            AmountWordsToolStripMenuItem.Text = "Количество слов";
            // 
            // AmountQuestionSentencesToolStripMenuItem
            // 
            AmountQuestionSentencesToolStripMenuItem.Checked = true;
            AmountQuestionSentencesToolStripMenuItem.CheckOnClick = true;
            AmountQuestionSentencesToolStripMenuItem.CheckState = CheckState.Checked;
            AmountQuestionSentencesToolStripMenuItem.Name = "AmountQuestionSentencesToolStripMenuItem";
            AmountQuestionSentencesToolStripMenuItem.Size = new Size(400 , 26);
            AmountQuestionSentencesToolStripMenuItem.Text = "Количество вопросительных предложений";
            // 
            // AmountExclamationSentencesToolStripMenuItem
            // 
            AmountExclamationSentencesToolStripMenuItem.Checked = true;
            AmountExclamationSentencesToolStripMenuItem.CheckOnClick = true;
            AmountExclamationSentencesToolStripMenuItem.CheckState = CheckState.Checked;
            AmountExclamationSentencesToolStripMenuItem.Name = "AmountExclamationSentencesToolStripMenuItem";
            AmountExclamationSentencesToolStripMenuItem.Size = new Size(400 , 26);
            AmountExclamationSentencesToolStripMenuItem.Text = "Количество восклицательных предложений";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 451);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button StartBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ShowToolStripMenuItem;
        private ToolStripMenuItem AmountSentensesToolStripMenuItem;
        private ToolStripMenuItem AmountSimbolsToolStripMenuItem;
        private ToolStripMenuItem AmountWordsToolStripMenuItem;
        private ToolStripMenuItem AmountQuestionSentencesToolStripMenuItem;
        private ToolStripMenuItem AmountExclamationSentencesToolStripMenuItem;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
        private Button PauseBtn;
        private Button StopBtn;
    }
}
