using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EindopdrachtS22.Classes;

namespace EindOpdrachtS22.Forms
{
    public partial class View : System.Web.UI.Page
    {
        DBControl database = new DBControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = database.GetDataSource();
            GridView1.DataBind();
        }

        protected void pnlViewBuild_PreRender(object sender,EventArgs e)
        {
            GridView1.DataSource = database.GetDataSource();
            GridView1.DataBind();
        }
    }
}