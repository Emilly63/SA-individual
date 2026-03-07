using System;
using System.Windows.Forms;

namespace SA_INDIVIDUAL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Esta linha abaixo é a que faz a mágica de abrir o seu formulário
            Application.Run(new Form1()); 
        }
    }
}