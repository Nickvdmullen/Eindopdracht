namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Build
    {
        public string BuildName { get; set; }
        public string Author { get; set; }
        public Class SelectedClass { get; set; }
        public Class SelectedSpec { get; set; }
        public List<Spell> SelectedSpells { get; private set; }

        public Build()
        {

        }

        public void SaveBuild()
        {
            // Send insert to database.
        }

    }
}