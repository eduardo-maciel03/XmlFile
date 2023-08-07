using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFile
{
    public class Users
    {
        public Users() 
        {
            Address = new Address();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; }
    }
}
