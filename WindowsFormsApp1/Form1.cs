using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             var button = (Button) sender; //If can't convert will throw an error
            var button2 = sender as Button;//If can't convert will set button2 to null

            if(button2 != null)
            {
                MessageBox.Show(button.Height.ToString());
            }

            if(sender is Button)//Validate the type before converting sender to Button type
            {
                var button3 = (Button)sender;

            }

            MessageBox.Show("Hello world");
        }
    }
}
