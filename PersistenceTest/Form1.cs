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

namespace PersistenceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Domein.Business _business = new Business();

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblUitvoer.Text = _business.getTest().ToString();
        }
    }
}
