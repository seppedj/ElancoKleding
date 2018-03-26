using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domein;

namespace Presentation_Kleding
{
    public partial class TestGrid : System.Web.UI.Page
    {
        Business _business = new Business();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvTest.DataSource = _business.getKraag();
            gvTest.DataBind();
        }
    }
}