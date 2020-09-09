using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Width = 300;
            form.Height = 200;
            form.MouseDown += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldwidth = form.Width;
            int oldheight = form.Height;
            if(e.Button == MouseButtons.Left)
            {
                if(oldwidth < oldheight)
                {
                    form.Width = oldheight;
                    form.Height = oldwidth;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (oldheight < oldwidth)
                {
                    form.Width = oldheight;
                    form.Height = oldwidth;                  
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                    if (oldwidth < oldheight)
                    {
                        form.Width = oldheight;
                        form.Height = oldwidth;
                    }
                    else if (oldheight < oldwidth)
                    {
                        form.Width = oldheight;
                        form.Height = oldwidth;
                    }                
            }
            Console.WriteLine($"Width : {form.Width} Height : {form.Height}");
        }
    }
}
