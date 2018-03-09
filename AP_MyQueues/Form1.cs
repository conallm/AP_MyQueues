using AP_MyQueues.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_MyQueues
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mine = from b in books where b.Author == "me" select b;
        }
    }
}
