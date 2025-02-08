using System;

namespace Program {
class Coworker {
    public string Name { get; set; }
    public string BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public string Duties { get; set; }

    public Coworker( string name, string birthday, string phone, string email, string position, string duties){
        Name = name;
        BirthDate = birthday;
        Phone = phone;
        Email = email;
        Position = position;
        Duties = duties;
    }
    public Coworker() {
        Name = " ";
        BirthDate = " ";
        Phone = " ";
        Email = " ";
        Position = " ";
        Duties = " ";
        }
        public void InputData() {   
            Console.WriteLine("Enter name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter birthday:");
            BirthDate = Console.ReadLine();
            Console.WriteLine("Enter phone:");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter email:");
            Email = Console.ReadLine();
            Console.WriteLine("Enter position:");
            Position = Console.ReadLine();
            Console.WriteLine("Enter duties:");
            Duties = Console.ReadLine();
            }
            public void OutputData() {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Birthday: {BirthDate}");
                Console.WriteLine($"Phone: {Phone}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Position: {Position}");
                Console.WriteLine($"Duties: {Duties}");
                }
                }

                class Program {
                    static void Main(string[] data) {
                        Coworker coworker = new Coworker();
                        coworker.InputData();
                        coworker.OutputData();
                        Console.ReadLine();
                        }
                        }
}
