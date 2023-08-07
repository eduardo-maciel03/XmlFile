using System.Xml.Serialization;

namespace XmlFile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Test\Users.xml";
            
            var list = new List<Users> 
            {
                new Users()
                {
                    Id = 1,
                    Name = "Eduardo",
                    Address = { Number = 100, Street = "Avenue", City = "PatoBranco", State = "Parana" }
                },

                new Users()
                {
                    Id = 2,
                    Name = "Luiz",
                    Address = { Number = 200, Street = "Center", City = "PatoBranco", State = "Parana" }
                }
            };

            Serializing(path, list);
            Deserializing(path);

        }

        private static void Serializing(string file, List<Users> list)
        {
            using (StreamWriter stream = new StreamWriter(file))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Users>));
                xmlSerializer.Serialize(stream, list); //serialize receives a file and some object
            }
        }

        private static void Deserializing(string file)
        {
            var list = new List<Users>();

            using (StreamReader stream = new StreamReader(file)) 
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Users>));
                list = (List<Users>)xmlDeserializer.Deserialize(stream);  //deserializing a list
            }

            foreach (var item in list) //print items from my list
            {
                Console.WriteLine($"Id: {item.Id}\nName: {item.Name}"
                                 +$"\nADDRESS\nNumber: {item.Address.Number}\nStreet: {item.Address.Street}\nCity: {item.Address.City}\nState: {item.Address.State}");
            }

        }
    }
}
