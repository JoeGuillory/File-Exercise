using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;



namespace File_Exercises
{
    struct Contact
    {
        public string name;
        public string email;
        public int id;
       
        

        public Contact(string name, string email,int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
            
        }
        public void Print()
        {
            Console.WriteLine(name + " | " + email + " | " + id);

        }
        public void Serialize(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        writer.WriteLine(name);
                        writer.WriteLine(email);
                        writer.WriteLine(id);
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }

            }


        }
        public void DeSerialize(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    
                    name = reader.ReadLine();
                    email = reader.ReadLine();
                    Int32.TryParse(reader.ReadLine(), out id);
                    



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }

    internal class SerializeIO
    {
        
        public void Run()
        {
            // Make 3 contacts
            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Bob", "fred@email.com", 2345);
            Contact jane = new Contact("Bob", "jane@email.com", 3456);


            // Write each contact to a file
            bob.Serialize(@"bob.txt");
            fred.Serialize(@"fred.txt");
            jane.Serialize(@"jane.txt");

            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane = new Contact();

            // Load from file
            bob.DeSerialize(@"bob.txt");
            fred.DeSerialize(@"fred.txt");
            jane.DeSerialize(@"jane.txt");

            //Print contacts
            bob.Print();
            fred.Print();
            jane.Print();

        }

    }
}
