namespace Task_4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sourceBtn_Click(object sender , EventArgs e)
        {
            OpenFile("Выберите папку источник" , SourceTxtBox);
        }
        private void DestinationBtn_Click(object sender , EventArgs e)
        {
            OpenFile("Выберите конечную папку" , DestinationTxtBox);
        }

        private void OpenFile(string text , TextBox tb)
        {
            using var openFileDialog = new FolderBrowserDialog()
            {
                Description = text ,
                SelectedPath = tb.Text
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb.Text = openFileDialog.SelectedPath;
            }
        }

        private void ShowReportBtn_Click(object sender , EventArgs e)
        {
            if (!IsSaveinFile.Checked && !IsShowOnScreen.Checked)
            {
                MessageBox.Show("Выберите действие: показать на экране или сохранить в файл" , "Внимание" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }






            if (IsSaveinFile.Checked)
            {
                //somelogic
            }
            if (IsShowOnScreen.Checked)
            {
                //somelogic
            }

            

        }


        private void FormReport(object sender , EventArgs e)
        {
            //
        }





    }
}
