using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLearning
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (GridViewRow row in  GridView1.Rows)
                {
                    HyperLink h = (HyperLink)row.FindControl("lnkEdit");

                    h.NavigateUrl += "/Naveed/" + row.Cells[0].Text; ;
                    
                }
            }
        }
    }
}