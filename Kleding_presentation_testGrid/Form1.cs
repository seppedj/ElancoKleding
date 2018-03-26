using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domein;

namespace Kleding_presentation_testGrid
{
    public partial class Form1 : Form
    {
        Business _business = new Business();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gdvKleding01.DataSource = _business.getKraag();
            gdvKleding01.DataBindings.ToString();
        }
    }
}
