namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Spell
    {
        public string Name { get; private set; }
        public string Tooltip { get; private set; }
        public string imgURL { get; private set; }

        public Spell()
        {
            //Get data from database
        }
    }
}