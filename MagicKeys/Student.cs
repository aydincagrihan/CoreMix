using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicKeys
{
    [DebuggerDisplay("")]
    public class Student
    {
        public string FirstName { get; set; } = "Çağrıhan Aydın";
        public string LastName { get; set; } = "Tarım";
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
