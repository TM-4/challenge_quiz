using quizPpfcha;
using System;
using System.Windows.Forms;

namespace quiz_ppfcha
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new PpfQuiz());
        }
    }
}