using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EventHandlingExample
{
    public delegate void DelEventHandler();
    class Program : Form
    {
        public event DelEventHandler add;

        public Program()
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Click Me";
            btn.Location = new Point(100, 100);

            btn.Click += new EventHandler(onClick);
            add += new DelEventHandler(Initiate);
            add();
        }

        public void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }

        public void onClick(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
            Console.ReadLine();
        }
    }
}