using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoInsurance02

//POCO
//plane old C# Object
{

    public class Developer
    {
        public string DevName { get; set; }

        public int DevID { get; set; }

        public bool Exudus { get; set; }

        public Developer(string devName, int devID, bool exudus)
        {
            DevName = devName;
            DevID = devID;
            Exudus = exudus;
        }

    }
}
