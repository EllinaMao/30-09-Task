namespace Task_4_5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        /*Завдання 4
Створіть віконний додаток, що використовує механізм завдань (клас Task). Користувач вводить шлях до директорії джерела і директорії приймача. Додаток перевіряє джерело на наявність файлів двійників. Усі оригінальні файли переносяться в приймач.
Завдання 5
Додайте до четвертого завдання можливість генерації звіту про виконані дії.*/
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}