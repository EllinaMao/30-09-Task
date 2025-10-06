using _30_09_Task.AnalyzerClass;

namespace _30_09_Task
{
    public partial class Form1 : Form
    {
        private TextReport report;
        private string? _text;
        private CancellationTokenSource? _cancellation;
        private Task? _analyzeTask;
        private Task? _showTask;
        private ManualResetEventSlim _pauseEvent = new(true); // сразу разрешено
        private bool _resume;
        /*Створіть віконний додаток, що використовує механізм завдань (клас Task). Користувач вводить у текстове поле деякий текст. Після натискання на кнопку додаток має проаналізувати текст і вивести звіт. Звіт містить інформацію про:
Кількість речень.
Кількість символів.
Кількість слів.
Кількість питальних речень.
Кількість речень оклику.
Звіт залежно від вибору користувача відображається на екрані або зберігається у файл.
        
Завдвння 2     
  Додайте до першого завдання можливість зупинки та повторного запуску аналізу тексту.
Завдання 3 +
Додайте до першого завдання можливість вибору типу інформації, що поміщається у звіт. Наприклад, користувач може вибрати, що його цікавить тільки кількість речень і слів.
        
         
         */
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender , EventArgs e)
        {
            report = null;

            if (_analyzeTask != null && !_analyzeTask.IsCompleted)
            {
                MessageBox.Show("Анализ уже выполняется. Остановите его, прежде чем запускать новый.");
                return;
            }
            _text = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(_text))
            {
                MessageBox.Show("Введите текст!" , "Ошибка" , MessageBoxButtons.OK);
                return;
            }
            _cancellation = new CancellationTokenSource();
            var token = _cancellation.Token;
            try
            {
                _analyzeTask = Task
                    .Run(() => BuildText((token, _text)) , token)
                    .ContinueWith(
                        t => ShowReport(report) ,
                        token ,
                        TaskContinuationOptions.OnlyOnRanToCompletion ,
                        TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Работа остановлена.");
            }


        }

        private void BuildText(object? args)
        {
            var (token, text) = ((CancellationToken, string))args!;
            token.ThrowIfCancellationRequested();
            _pauseEvent.Wait();
            var builder = new BuilderTextAnalyzer(
                text ,
                AmountSentensesToolStripMenuItem.Checked ? new SentenceAnalyzer() : null ,
                AmountSimbolsToolStripMenuItem.Checked ? new SymbolsAnalyzer() : null ,
                AmountWordsToolStripMenuItem.Checked ? new WordsAnalyzer() : null ,
                AmountQuestionSentencesToolStripMenuItem.Checked ? new QuestionAnalyzer() : null ,
                AmountExclamationSentencesToolStripMenuItem.Checked ? new ExclamationsAnalyzer() : null
                );

            report = builder.Build();

        }

        private void ShowReport(TextReport report)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("metric" , "Метрика");
            dataGridView1.Columns.Add("value" , "Значение");

            var metrics = GetSelectedMetrics(report);
            var token = _cancellation?.Token ?? CancellationToken.None;

            try
            {

                Task.Run(() =>
                {
                    try
                    {
                        foreach (var (name, value) in metrics)
                        {
                            _pauseEvent.Wait();
                            token.ThrowIfCancellationRequested();

                            if (value != null)
                            {
                                Invoke(() =>
                                {
                                    dataGridView1.Rows.Add(name , value);
                                });
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    catch (OperationCanceledException ex)
                    {
                        throw;
                    }
                } , token);
            }
            catch (OperationCanceledException ex)
            {
                Invoke(() => MessageBox.Show("Анализ остановлен."));
            }





        }

        private List<(string Name, int? Value)> GetSelectedMetrics(TextReport report)
        {
            return new List<(string Name, int? Value)>
            {
                (AmountSentensesToolStripMenuItem.Text ?? string.Empty, AmountSentensesToolStripMenuItem.Checked ? report.SentenceCount : null),
                (AmountSimbolsToolStripMenuItem.Text ?? string.Empty, AmountSimbolsToolStripMenuItem.Checked ? report.SymbolsCount : null),
                (AmountWordsToolStripMenuItem.Text ?? string.Empty, AmountWordsToolStripMenuItem.Checked ? report.WordCount : null),
                (AmountQuestionSentencesToolStripMenuItem.Text ?? string.Empty, AmountQuestionSentencesToolStripMenuItem.Checked ? report.QuestionSentenceCount : null),
                (AmountExclamationSentencesToolStripMenuItem.Text ?? string.Empty, AmountExclamationSentencesToolStripMenuItem.Checked ? report.ExclamationSentenceCount : null)
            };
        }

        private void saveToFileToolStripMenuItem_Click(object sender , EventArgs e)
        {
            if (report == null)
            {
                return;
            }
            BuilderFileManager.SaveInFileJson(report);
        }

        private void PauseBtn_Click(object sender , EventArgs e)
        {
            if (!_resume)
            {
                _pauseEvent.Reset();
                _resume = true;
            }
            else
            {
                _pauseEvent.Set();   // продолжение
            }
        }

        private void StopBtn_Click(object sender , EventArgs e)
        {
            if (_cancellation != null)
            {
                _cancellation.Cancel();
                _pauseEvent.Set();

                MessageBox.Show("Анализ и отображение отчёта остановлены.");
            }
            else
            {
                MessageBox.Show("Нет выполняющегося анализа для остановки.");
            }
        }

        private void Form1_FormClosed(object sender , FormClosedEventArgs e)
        {
            _cancellation?.Cancel();
            _cancellation?.Dispose();
        }
    }
}