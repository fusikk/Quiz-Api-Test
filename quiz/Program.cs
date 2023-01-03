namespace quiz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Form1 Form;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Form = new();
            Application.Run(Form);
        }
    }
}