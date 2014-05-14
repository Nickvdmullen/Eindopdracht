namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Specialization
    {
        public string Name { get; private set; }
        public string Tooltip { get; private set; }
        public string imgURL { get; private set; }
        public List<Spell> PossibleSpells { get; private set; }

        public Specialization()
        {
            //Get info from Database
        }
    }
}