using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domein;

namespace Presentation_Kleding
{
    public partial class Presentatie_Kleding : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            btnTest01.Visible = false;
            btnTest02.Visible = false;
        }
        Business _business = new Business();


        protected void btnHemd_Click(object sender, EventArgs e)
        {
            lblTest.Text = "hallooo jk dsj sdjxk dsbsjhbsfjb sjh bs bdsk di dg icccccccc";
            btnTest.Visible = true;
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            

            foreach (var gegeven in _business.getTest())
            {
                lstTest01.Items.Add(gegeven);
            }

            lblTest.Text = "hallooo jk dsj sdjxk dsbsjhbsfjb sjh bs bdsk di dg i";
            btnTest01.Visible = true;
            btnTest02.Visible = true;

            
            
        }
    }
}