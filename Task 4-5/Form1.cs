using System.Collections.Generic;

namespace Task_4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sourceBtn_Click(object sender, EventArgs e)
        {
            OpenFile("Выберите папку источник", SourceTxtBox);
        }
        private void DestinationBtn_Click(object sender, EventArgs e)
        {
            OpenFile("Выберите конечную папку", DestinationTxtBox);
        }

        private void OpenFile(string text, TextBox tb)
        {
            using var openFileDialog = new FolderBrowserDialog()
            {
                Description = text,
                SelectedPath = tb.Text
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb.Text = openFileDialog.SelectedPath;
            }
        }

        private void ShowReportBtn_Click(object sender, EventArgs e)
        {
            if (!IsSaveinFile.Checked && !IsShowOnScreen.Checked)
            {
                MessageBox.Show("Выберите действие: показать на экране или сохранить в файл", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SourceTxtBox.Text == string.Empty || DestinationTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Выберите файлы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var task = Task.Run(() =>
                FileTransfer.TransferFiles(SourceTxtBox.Text, DestinationTxtBox.Text)
                );
                task.Wait();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (IsSaveinFile.Checked)
            {
                try
                {

                    var task = Task.Run(() =>
                    FileSaveManager.SaveInJson(FileTransfer.GetReport()));
                    task.Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (IsShowOnScreen.Checked)
            {

                ShowReport(FileTransfer.GetReport());
            }



        }

        private void ShowReport(List<FileReportItem> report)
        {

            if (report.Count == 0)
            {
                MessageBox.Show("Отчет пуст", "Ошибка отчета", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Clear();

            Task.Run(() =>
            {
                foreach (var item in report)
                {
                    // Добавляем строку в UI-потоке
                    dataGridView1.Invoke((Action)(() =>
                    {
                        dataGridView1.Rows.Add(item.Name, item.SourcePath, item.DestinationPath, item.Type, item.Status);
                    }));

                    Thread.Sleep(100);
                }
            });

        }
    }
}

