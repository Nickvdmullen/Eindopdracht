namespace EindOpdracht_S22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Class
    {
        public string Name { get; private set; }
        public string Tooltip { get; private set; }
        public string imgURL { get; private set; }
        public List<Specialization> PossibleSpecs { get; private set; }

        public Class(string name)
        {
            //Get info from Database
        }


    }
}