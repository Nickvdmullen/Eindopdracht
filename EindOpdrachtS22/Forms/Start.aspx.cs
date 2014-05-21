namespace EindOpdrachtS22.Forms
{
    using EindopdrachtS22.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Start : System.Web.UI.Page
    {
        DBControl database = new DBControl();
        List<string> results = new List<string>();
        Build myBuild = new Build();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> resources = database.GetBuilds();
            foreach (string build in resources)
            {
                if(build != "0")
                {
                    dllBuilds.Items.Add(build);
                }
            }
        }

        protected void btnStartNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:2780/Forms/FormCreate.aspx");
        }

        protected void btnStartLoad_Click(object sender, EventArgs e)
        {
            //myBuild = database.GetBuild(dllBuilds.SelectedItem.ToString());
            Build myBuild = new Build();
            Response.Redirect("http://localhost:2780/Forms/FormCreate.aspx");
        }

        private void Check()
        {
            myBuild = new Build();
            foreach (string item in results)
            {
                if(myBuild.SelectedClass == null)
                {
                    myBuild.AddClass(item);
                }
                else if(myBuild.SelectedSpec == null)
                {
                    myBuild.AddSpec(item);
                }
                else if(myBuild.SelectedSpells.Count < 7)
                {
                    myBuild.AddSpell(item);
                }
            }

            Session.Add("Build", myBuild);
        }
    }
}