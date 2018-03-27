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
            
        }
        Business _business = new Business();


        protected void btnHemd_Click(object sender, EventArgs e)
        {
            lblTest.Text = "hallooo jk dsj sdjxk dsbsjhbsfjb sjh bs bdsk di dg icccccccc";
            btnTest.Visible = true;
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            foreach(var gegeven in _business.getKraag())
            {
                imgbtnTEST.ImageUrl = gegeven.ToString();
            }
        }

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

		protected void btnHemd_Click1(object sender, EventArgs e)
		{
            lstUitvoer.Items.Clear();
            foreach(var geg in _business.getDesign())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }

            
		}

		protected void btnKraag_Click(object sender, EventArgs e)
		{
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getKraag())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

		protected void btnBortszak_Click(object sender, EventArgs e)
		{
            lstUitvoer.Items.Clear();
            foreach(var geg in _business.getBorstzak())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
		}

        protected void btnKnoopsluiting_Click(object sender, EventArgs e)
        {
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getKnoopsluiting())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnEpaulet_Click(object sender, EventArgs e)
        {
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getSchouder())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void btnMouw_Click(object sender, EventArgs e)
        {
            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getLangeMouw())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }

            
            foreach (var geg in _business.getKorteMouw())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }

            
            foreach (var geg in _business.getMouwsplit())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }

            lstUitvoer.Items.Clear();
            foreach (var geg in _business.getPolsboord())
            {
                lstUitvoer.Items.Add(geg.ToString());
            }
        }

        protected void imgbtnTEST_Click(object sender, ImageClickEventArgs e)
        {
            
        }
    }
}