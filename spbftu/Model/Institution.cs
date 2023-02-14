using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spbftu.Model
{
    public class Institution
    {
        public String Name { get; private set; }
        public String Abbreviation { get; private set; }
        public String DirectoryName { get; private set; }
        public String PhoneNumber { get; private set; }
        public String Email { get; private set; }
        public String PathImage { get; private set; }

        public Institution(string name, string abbreviation, string directoryName, string phoneNumber, string email, string pathImage)
        {
            Name = name;
            Abbreviation = abbreviation;
            DirectoryName = directoryName;
            PhoneNumber = phoneNumber;
            Email = email;
            PathImage = pathImage;  
        }
    }
}
