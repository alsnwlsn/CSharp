using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "클릭";
            button.Left = 100;
            button.Top = 50;
            int c = 0;
            button.Click += (object sender, EventArgs e) =>
            {
                c++;
                MessageBox.Show(c+"번 클릭");
            };
            Program form = new Program();
            form.Text = "Form & Control";
            form.Height = 150;
            form.Controls.Add(button);
            Application.Run(form);
        }
    }
}
