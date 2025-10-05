using _30_09_Task.AnalyzerClass;

namespace _30_09_Task
{
    public partial class Form1 : Form
    {
        private TextReport report;
        private string? _text;
        private CancellationTokenSource? _cancellation;
        private Task? _analyzeTask;
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

        private void button1_Click(object sender, EventArgs e)
        {
            report = null;

            if (_analyzeTask != null && !_analyzeTask.IsCompleted)
            {
                MessageBox.Show("Анализ уже выполняется. Остановите его, прежде чем запускать новый.");
                return;
            }
            //_text = richTextBox1.Text;

            _text = "Если верить слухам, Ксин Жао не проиграл ни одного поединка, однако вся его жизнь – нелегкая борьба. В ранней юности он был юнгой на \"Потрошителе\", ионийском рыболовецком судне, ходившем у берегов Райккона. Ксин Жао беспрекословно выполнял любые приказы: драил грязную палубу, чинил спутавшиеся сети... и наслаждался мирной жизнью, пока однажды суденышко случайно не зашло в чужие воды.\r\n\r\nЗа маленьким судном погналась пара каперских кораблей из Ноксуса. Они захватили \"Потрошителя\" и его экипаж \"во славу империи\" и объявили их ноксианской собственностью. Команда в основном состояла из пожилых рыбаков, которые не годились для военной службы, однако их все равно увезли в Ноксус.\r\n\r\nПосле трудного путешествия по морю Ксин Жао оказался в чужой стране. Здешние воды не отличались красотой, а в деревьях не было магии. Вдоль улиц тянулись прочные каменные стены с монументальными воротами, каких Ксин Жао в жизни не видел, и везде было полно народу – яблоку упасть негде. Он узнал, что попал в столицу Ноксуса и что именно отсюда некий Дарквилл правил огромной империей. Ксин Жао, разлученный со своими товарищами с \"Потрошителя\" и не имеющий возможности вернуться домой, поступил на службу к человеку, который взял его в плен.\r\n\r\nМастерское владение копьем не осталось незамеченным, и вскоре ему предложили демонстрировать боевое искусство в обмен на лучшие условия и еду. В Ноксусе уважали силу, а хозяин Ксина Жао считал его сильным воином.\r\n\r\nТерять юноше было нечего, и он согласился. Сменив свои лохмотья на грубые доспехи, он вышел на арену уравнителей.\r\n\r\nЭто было развлечение особого толка. Могучие воины, известные под громкими именами, сражались на глазах у возбужденной толпы, которой равно нравились и блестящие боевые приемы, и пролитая кровь. Ксин Жао взял себе псевдоним \"Потрошитель\" и быстро завоевал любовь зрителей. Очень скоро поединки с его участием начали собирать целые арены, а в карманы его спонсоров рекой полилось золото. Всего за несколько лет Потрошитель прославился – зрители его обожали, а другие уравнители боялись.\r\n\r\nНо все хорошее быстро заканчивается.\r\n\r\nВ Ноксусе настали тяжелые времена. На территорию империи вторглись вражеские войска, на границе вспыхнули восстания. Ходили слухи, что Дарквилл и его советники тайно заплатили целое состояние за освобождение узников, уравнителей и наемников, чтобы те пополнили ряды имперской армии. Без лишнего шума Ксина Жао с товарищами выкупили и погрузили на транспортное судно, направлявшееся на запад.\r\n\r\nЗдесь, в прибрежной крепости Калстед, имена и репутация даже самых известных гладиаторов ничего не значили. Их отправили в бой против элитных войск Джарвана III, короля Демасии, который был полон решимости сдержать растущее влияние Ноксуса на Валоран… и Ксин Жао быстро понял, что война совсем не похожа на гладиаторские бои!\r\n\r\nМногие бывшие уравнители испугались неизбежного поражения и бежали, но Ксин Жао не сдавался и обагрил копье кровью сотен противников. Его мастерство произвело впечатление на многих солдат из королевского Бесстрашного авангарда. Когда же они наконец окружили его, он отказался бежать. Гордо подняв голову, Ксин Жао ожидал казни!\r\n\r\nОднако у Джарвана были совсем другие планы. В отличие от зрителей арены, король Демасии не любил бессмысленные убийства. Он освободил побежденных ноксианцев, взяв с них клятву мирно покинуть Калстед. Потрясенный великодушием короля, Ксин Жао представил, что ждет его в Ноксусе. Он оказался перед выбором: вернуться туда, где был нужен только пока приносил золото... или сражаться за народ, который воплощал собой добродетели, к которым стремился он сам?\r\n\r\nКсин Жао выбрал честь. Он преклонил колени перед Джарваном III и принес королю клятву верности.\r\n\r\nЗа прошедшие с тех пор десятилетия Ксин Жао не раз доказывал свою преданность королю. Он стал придворным сенешалем, а также телохранителем и советником не только для своего друга и повелителя, но и для его сына – юного наследного принца Джарвана.\r\n\r\nХотя Ксин Жао стал демасийцем весьма необычным путем, он был всей душой предан королевству и его идеалам – не из чувства долга, а по велению души.";
            if (string.IsNullOrWhiteSpace(_text))
            {
                MessageBox.Show("Введите текст!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            _cancellation = new CancellationTokenSource();
            var token = _cancellation.Token;
            try
            {

                _analyzeTask = new Task(BuildText, (token, _text), token);
                _analyzeTask.Start();
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Анализ прерван.");
            }
            finally
            {
                _cancellation?.Dispose();
                _cancellation = null;

            }

        }

        private void BuildText(object? args)
        {
            var (token, text) = ((CancellationToken, string))args!;
            token.ThrowIfCancellationRequested();
            var builder = new BuilderTextAnalyzer(
                text,
                AmountSentensesToolStripMenuItem.Checked ? new SentenceAnalyzer() : null,
                AmountSimbolsToolStripMenuItem.Checked ? new SymbolsAnalyzer() : null,
                AmountWordsToolStripMenuItem.Checked ? new WordsAnalyzer() : null,
                AmountQuestionSentencesToolStripMenuItem.Checked ? new QuestionAnalyzer() : null,
                AmountExclamationSentencesToolStripMenuItem.Checked ? new ExclamationsAnalyzer() : null
                );

            report = builder.Build();
            Invoke(() => ShowReport(report!));

        }

        private void ShowReport(TextReport report)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("metric", "Метрика");
            dataGridView1.Columns.Add("value", "Значение");

            var metrics = GetSelectedMetrics(report);
            _cancellation = new CancellationTokenSource();
            var token = _cancellation.Token;

            try
            {

                Task.Run(() =>
                {
                    try
                    {
                        foreach (var (name, value) in metrics)
                        {
                            token.ThrowIfCancellationRequested();
                            _pauseEvent.Wait();

                            if (value != null)
                            {
                                Invoke(() =>
                                {
                                    dataGridView1.Rows.Add(name, value);
                                });
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        // Можно добавить уведомление или очистку UI
                        Invoke(() => MessageBox.Show("Анализ остановлен."));
                    }
                }, token);
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                _cancellation.Dispose();
                _cancellation = null;

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

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (report == null)
            {
                return;
            }
            BuilderFileManager.SaveInFileJson(report);
        }

        private void PauseBtn_Click(object sender, EventArgs e)
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

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (_analyzeTask != null && !_analyzeTask.IsCompleted && _cancellation != null)
            {
                _cancellation.Cancel();
                _pauseEvent.Set();
            }
            else
            {
                MessageBox.Show("Нет выполняющегося анализа для остановки.");
            }
        }
    }
}