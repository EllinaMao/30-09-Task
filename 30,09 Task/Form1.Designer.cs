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
            button1 = new Button();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            ShowToolStripMenuItem = new ToolStripMenuItem();
            AmountSentensesToolStripMenuItem = new ToolStripMenuItem();
            AmountSimbolsToolStripMenuItem = new ToolStripMenuItem();
            AmountWordsToolStripMenuItem = new ToolStripMenuItem();
            AmountQuestionSentencesToolStripMenuItem = new ToolStripMenuItem();
            AmountExclamationSentencesToolStripMenuItem = new ToolStripMenuItem();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
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
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0 , 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(800 , 41);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(687 , 4);
            button1.Name = "button1";
            button1.Size = new Size(94 , 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(800 , 381);
            splitContainer1.SplitterDistance = 434;
            splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0 , 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434 , 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3 , 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(428 , 355);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0 , 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362 , 381);
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
            dataGridView1.Size = new Size(356 , 355);
            dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20 , 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem , ShowToolStripMenuItem });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800 , 28);
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
            // ShowToolStripMenuItem
            // 
            ShowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AmountSentensesToolStripMenuItem , AmountSimbolsToolStripMenuItem , AmountWordsToolStripMenuItem , AmountQuestionSentencesToolStripMenuItem , AmountExclamationSentencesToolStripMenuItem });
            ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            ShowToolStripMenuItem.Size = new Size(87 , 24);
            ShowToolStripMenuItem.Text = "Показать";
            // 
            // AmountSentensesToolStripMenuItem
            // 
            AmountSentensesToolStripMenuItem.CheckOnClick = true;
            AmountSentensesToolStripMenuItem.Name = "AmountSentensesToolStripMenuItem";
            AmountSentensesToolStripMenuItem.Size = new Size(400 , 26);
            AmountSentensesToolStripMenuItem.Text = "Количество предложений";
            // 
            // AmountSimbolsToolStripMenuItem
            // 
            AmountSimbolsToolStripMenuItem.CheckOnClick = true;
            AmountSimbolsToolStripMenuItem.Name = "AmountSimbolsToolStripMenuItem";
            AmountSimbolsToolStripMenuItem.Size = new Size(400 , 26);
            AmountSimbolsToolStripMenuItem.Text = "Количество символов";
            // 
            // AmountWordsToolStripMenuItem
            // 
            AmountWordsToolStripMenuItem.CheckOnClick = true;
            AmountWordsToolStripMenuItem.Name = "AmountWordsToolStripMenuItem";
            AmountWordsToolStripMenuItem.Size = new Size(400 , 26);
            AmountWordsToolStripMenuItem.Text = "Количество слов";
            AmountWordsToolStripMenuItem.Click += количествоToolStripMenuItem_Click;
            // 
            // AmountQuestionSentencesToolStripMenuItem
            // 
            AmountQuestionSentencesToolStripMenuItem.CheckOnClick = true;
            AmountQuestionSentencesToolStripMenuItem.Name = "AmountQuestionSentencesToolStripMenuItem";
            AmountQuestionSentencesToolStripMenuItem.Size = new Size(400 , 26);
            AmountQuestionSentencesToolStripMenuItem.Text = "Количество вопросительных предложений";
            // 
            // AmountExclamationSentencesToolStripMenuItem
            // 
            AmountExclamationSentencesToolStripMenuItem.CheckOnClick = true;
            AmountExclamationSentencesToolStripMenuItem.Name = "AmountExclamationSentencesToolStripMenuItem";
            AmountExclamationSentencesToolStripMenuItem.Size = new Size(400 , 26);
            AmountExclamationSentencesToolStripMenuItem.Text = "Количество восклицательных предложений";
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            saveToFileToolStripMenuItem.Size = new Size(224 , 26);
            saveToFileToolStripMenuItem.Text = "Сохранить в файл";
            saveToFileToolStripMenuItem.Click += saveToFileToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ShowToolStripMenuItem;
        private ToolStripMenuItem AmountSentensesToolStripMenuItem;
        private ToolStripMenuItem AmountSimbolsToolStripMenuItem;
        private ToolStripMenuItem AmountWordsToolStripMenuItem;
        private ToolStripMenuItem AmountQuestionSentencesToolStripMenuItem;
        private ToolStripMenuItem AmountExclamationSentencesToolStripMenuItem;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
    }
}
