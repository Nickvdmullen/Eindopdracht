namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Viewer : System.Web.UI.Page
    {
        List<int> Build = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Build"] != null)
            {
                foreach (int Choice in Build)
                {
                    
                    switch (Choice)
                    {
                            //Classes
                        case 1: break;
                        case 2: break;
                        case 3: break;
                        case 4: break;
                        case 5: break;
                        case 6: break;
                        case 7: break;
                        case 8: break;
                        case 9: break;
                        case 10: break;
                        case 11: break;
                            //Specialization
                        case 12: break;
                        case 13: break;
                        case 14: break;
                            //15
                        case 15: break;
                        case 16: break;
                        case 17: break;
                            //30
                        case 18: break;
                        case 19: break;
                        case 20: break;
                            //45
                        case 21: break;
                        case 22: break;
                        case 23: break;
                            //60
                        case 24: break;
                        case 25: break;
                        case 26: break;
                            //75
                        case 27: break;
                        case 28: break;
                        case 29: break;
                            //90
                        case 30: break;
                        case 31: break;
                        case 32: break;
                    }
                }
            }
        }
    }
}