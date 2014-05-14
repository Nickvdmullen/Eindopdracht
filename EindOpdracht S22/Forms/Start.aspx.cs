namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Data;
    using System.Web.UI.WebControls;
    using System.Data.OleDb;
   

    public partial class Start : System.Web.UI.Page
    {

        Classes.DBControl database = new Classes.DBControl();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> builds = database.GetBuilds();
            ddlBuilds.DataSource = builds;
        }

        protected void btnStartNew_Click(object sender, EventArgs e)
        {
           Response.Redirect("http://localhost:5667/Forms/Builder.aspx");
           
        }
    }
}