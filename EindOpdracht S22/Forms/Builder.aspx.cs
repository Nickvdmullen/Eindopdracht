﻿namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Drawing;

    public partial class Builder : System.Web.UI.Page
    {
        Build myBuild = new Build();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ibtnDeathKnight_Click(object sender, ImageClickEventArgs e)
        {
            Class DeathKnight = new Class("1");
            SetToolTips(DeathKnight.PossibleSpecs);
            ibtnDeathKnight.ToolTip = DeathKnight.Tooltip;
            myBuild.AddClass(DeathKnight.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnDruid_Click(object sender, ImageClickEventArgs e)
        {
            Class Druid = new Class("2");
            SetToolTips(Druid.PossibleSpecs);
            ibtnDruid.ToolTip = Druid.Tooltip;
            myBuild.AddClass(Druid.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnMage_Click(object sender, ImageClickEventArgs e)
        {
            Class Mage = new Class("3");
            SetToolTips(Mage.PossibleSpecs);
            ibtnMage.ToolTip = Mage.Tooltip;
            myBuild.AddClass(Mage.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnMonk_Click(object sender, ImageClickEventArgs e)
        {
            Class Monk = new Class("4");
            SetToolTips(Monk.PossibleSpecs);
            ibtnMonk.ToolTip = Monk.Tooltip;
            myBuild.AddClass(Monk.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnPaladin_Click(object sender, ImageClickEventArgs e)
        {
            Class Paladin = new Class("5");
            SetToolTips(Paladin.PossibleSpecs);
            ibtnPaladin.ToolTip = Paladin.Tooltip;
            myBuild.AddClass(Paladin.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnPriest_Click(object sender, ImageClickEventArgs e)
        {
            Class Priest = new Class("6");
            SetToolTips(Priest.PossibleSpecs);
            ibtnPriest.ToolTip = Priest.Tooltip;
            myBuild.AddClass(Priest.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnHunter_Click(object sender, ImageClickEventArgs e)
        {
            Class Hunter = new Class("7");
            SetToolTips(Hunter.PossibleSpecs);
            ibtnHunter.ToolTip = Hunter.Tooltip;
            myBuild.AddClass(Hunter.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnShaman_Click(object sender, ImageClickEventArgs e)
        {
            Class Shaman = new Class("8");
            SetToolTips(Shaman.PossibleSpecs);
            ibtnShaman.ToolTip = Shaman.Tooltip;
            myBuild.AddClass(Shaman.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnRogue_Click(object sender, ImageClickEventArgs e)
        {
            Class Rogue = new Class("9");
            SetToolTips(Rogue.PossibleSpecs);
            ibtnRogue.ToolTip = Rogue.Tooltip;
            myBuild.AddClass(Rogue.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnWarrior_Click(object sender, ImageClickEventArgs e)
        {
            Class Warrior = new Class("10");
            SetToolTips(Warrior.PossibleSpecs);
            ibtnWarrior.ToolTip = Warrior.Tooltip;
            myBuild.AddClass(Warrior.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnWarlock_Click(object sender, ImageClickEventArgs e)
        {
            Class Warlock = new Class("11");
            SetToolTips(Warlock.PossibleSpecs);
            ibtnWarlock.ToolTip = Warlock.Tooltip;
            myBuild.AddClass(Warlock.Name);
            Session.Add("Build", myBuild.UpdateBuild());;
            FillPage();
        }

        protected void ibtnSpec1_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("12");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpec2_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("13");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpec3_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpec("14");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell2_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("15");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell3_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("16");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell1_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("17");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell4_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("18");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell5_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("19");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell6_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("20");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell7_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("21");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell8_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("22");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell9_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("23");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell10_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("24");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell11_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("25");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell12_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("26");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell13_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("27");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell14_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("28");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell15_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("29");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell16_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("30");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell17_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("31");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        protected void ibtnSpell18_Click(object sender, ImageClickEventArgs e)
        {
            Check();
            myBuild.AddSpell("32");
            Session.Add("Build", myBuild.UpdateBuild()); ;
            FillPage();
        }

        private void SetToolTips(string[] specs)
        {
            ibtnSpec1.ToolTip = specs[0];
            ibtnSpec2.ToolTip = specs[1];
            ibtnSpec3.ToolTip = specs[2];
        }

        private void Check()
        {
            if (Session["Build"] != null)
            {
                List<string>Choices = (List<string>)Session["Build"];

                foreach (string item in Choices)
                {
                    if (myBuild.SelectedClass == null)
                    {
                        myBuild.AddClass(item);
                    }
                    else if (myBuild.SelectedSpec == null)
                    {
                        myBuild.AddSpec(item);
                    }
                    else if (myBuild.SelectedSpells.Count < 7)
                    {
                        myBuild.AddSpell(item);
                    }

                }
            }
        }

        private void FillPage()
        {

            List<string> Build = (List<string>)Session["Build"];

            if (Session["Build"] != null)
            {
                ibtnDeathKnight.BorderColor = Color.Black;
                ibtnDruid.BorderColor = Color.Black;
                ibtnRogue.BorderColor = Color.Black;
                ibtnMage.BorderColor = Color.Black;
                ibtnMonk.BorderColor = Color.Black;
                ibtnPriest.BorderColor = Color.Black;
                ibtnHunter.BorderColor = Color.Black;
                ibtnShaman.BorderColor = Color.Black;
                ibtnWarlock.BorderColor = Color.Black;
                ibtnWarrior.BorderColor = Color.Black;
                ibtnPaladin.BorderColor = Color.Black;

                ibtnSpec1.BorderColor = Color.Black;
                ibtnSpec2.BorderColor = Color.Black;
                ibtnSpec3.BorderColor = Color.Black;

                ibtnSpell1.BorderColor = Color.Black;
                ibtnSpell2.BorderColor = Color.Black;
                ibtnSpell3.BorderColor = Color.Black;

                ibtnSpell4.BorderColor = Color.Black;
                ibtnSpell5.BorderColor = Color.Black;
                ibtnSpell6.BorderColor = Color.Black;

                ibtnSpell7.BorderColor = Color.Black;
                ibtnSpell8.BorderColor = Color.Black;
                ibtnSpell9.BorderColor = Color.Black;

                ibtnSpell10.BorderColor = Color.Black;
                ibtnSpell11.BorderColor = Color.Black;
                ibtnSpell12.BorderColor = Color.Black;

                ibtnSpell13.BorderColor = Color.Black;
                ibtnSpell14.BorderColor = Color.Black;
                ibtnSpell15.BorderColor = Color.Black;

                ibtnSpell16.BorderColor = Color.Black;
                ibtnSpell17.BorderColor = Color.Black;
                ibtnSpell18.BorderColor = Color.Black;

                foreach (string choice in Build)
                {
                    if (choice == null)
                    {
                        return;
                    }
                    int Choice = Convert.ToInt32(choice);

                    switch (Choice)
                    {
                        //Classes
                        case 1: ibtnDeathKnight.BorderColor = Color.Lime;
                            break;
                        case 2: ibtnDruid.BorderColor = Color.Lime;
                            break;
                        case 3: ibtnMage.BorderColor = Color.Lime;
                            break;
                        case 4: ibtnMonk.BorderColor = Color.Lime;
                            break;
                        case 5: ibtnPaladin.BorderColor = Color.Lime;
                            break;
                        case 6: ibtnPriest.BorderColor = Color.Lime;
                            break;
                        case 7: ibtnHunter.BorderColor = Color.Lime;
                            break;
                        case 8: ibtnShaman.BorderColor = Color.Lime;
                            break;
                        case 9: ibtnRogue.BorderColor = Color.Lime;
                            break;
                        case 10: ibtnWarrior.BorderColor = Color.Lime;
                            break;
                        case 11: ibtnWarlock.BorderColor = Color.Lime;
                            break;
                        //Specialization
                        case 12: ibtnSpec1.BorderColor = Color.Lime;
                            break;
                        case 13: ibtnSpec2.BorderColor = Color.Lime;
                            break;
                        case 14: ibtnSpec3.BorderColor = Color.Lime;
                            break;
                        //15
                        case 15: ibtnSpell1.BorderColor = Color.Lime;
                            break;
                        case 16: ibtnSpell2.BorderColor = Color.Lime;
                            break;
                        case 17: ibtnSpell3.BorderColor = Color.Lime;
                            break;
                        //30
                        case 18: ibtnSpell4.BorderColor = Color.Lime;
                            break;
                        case 19: ibtnSpell5.BorderColor = Color.Lime;
                            break;
                        case 20: ibtnSpell6.BorderColor = Color.Lime;
                            break;
                        //45
                        case 21: ibtnSpell7.BorderColor = Color.Lime;
                            break;
                        case 22: ibtnSpell8.BorderColor = Color.Lime;
                            break;
                        case 23: ibtnSpell9.BorderColor = Color.Lime;
                            break;
                        //60
                        case 24: ibtnSpell10.BorderColor = Color.Lime;
                            break;
                        case 25: ibtnSpell11.BorderColor = Color.Lime;
                            break;
                        case 26: ibtnSpell12.BorderColor = Color.Lime;
                            break;
                        //75
                        case 27: ibtnSpell13.BorderColor = Color.Lime;
                            break;
                        case 28: ibtnSpell14.BorderColor = Color.Lime;
                            break;
                        case 29: ibtnSpell15.BorderColor = Color.Lime;
                            break;
                        //90
                        case 30: ibtnSpell16.BorderColor = Color.Lime;
                            break;
                        case 31: ibtnSpell17.BorderColor = Color.Lime;
                            break;
                        case 32: ibtnSpell18.BorderColor = Color.Lime;
                            break;
                        //empty

                    }
                }
            }
        }

        
    }
}