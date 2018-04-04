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
            btnLangeMouw.Visible = false;
            btnKorteMouw.Visible = false;
            btnMouwsplit.Visible = false;
            btnPolsboord.Visible = false;
            lstUitvoer.Visible = false;
        }
        Business _business = new Business();


        protected void btnHemd_Click(object sender, EventArgs e)
        {
            lblTest.Text = "hallooo jk dsj sdjxk dsbsjhbsfjb sjh bs bdsk di dg icccccccc";
            btnTest.Visible = true;
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            
        }

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

		protected void btnHemd_Click1(object sender, EventArgs e)
		{
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach(var geg in _business.getSnit())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }

            
		}

		protected void btnKraag_Click(object sender, EventArgs e)
		{
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getKraag())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

		protected void btnBortszak_Click(object sender, EventArgs e)
		{

            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach(var geg in _business.getBorstzak())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
		}

        protected void btnKnoopsluiting_Click(object sender, EventArgs e)
        {
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getKnoopsluiting())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnEpaulet_Click(object sender, EventArgs e)
        {
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getSchouder())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnMouw_Click(object sender, EventArgs e)
        {
            btnPolsboord.Visible = true;
            btnMouwsplit.Visible = true;
            btnLangeMouw.Visible = true;
            btnKorteMouw.Visible = true;
        }

        protected void imgbtnTEST_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void btnKorteMouw_Click(object sender, EventArgs e)
        {
            btnLangeMouw.Visible = true;
            btnKorteMouw.Visible = true;
            btnMouwsplit.Visible = true;
            btnPolsboord.Visible = false;
            lstUitvoer.Visible = true;
            foreach (var geg in _business.getKorteMouw())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnLangeMouw_Click(object sender, EventArgs e)
        {
            btnLangeMouw.Visible = true;
            btnKorteMouw.Visible = true;
            btnMouwsplit.Visible = true;
            btnPolsboord.Visible = true;
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getLangeMouw())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnMouwsplit_Click(object sender, EventArgs e)
        {
            btnLangeMouw.Visible = true;
            btnKorteMouw.Visible = true;
            btnMouwsplit.Visible = true;
            btnPolsboord.Visible = true;
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getMouwsplit())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnPolsboord_Click(object sender, EventArgs e)
        {
            btnLangeMouw.Visible = true;
            btnKorteMouw.Visible = true;
            btnMouwsplit.Visible = true;
            btnPolsboord.Visible = true;
            lstUitvoer.Visible = true;
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getPolsboord())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }
    }
}