using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Tour
    {
        public string Name { get; }
        public readonly int Code;
        public List<string> Plan;
        public TransportType Transport;
        public int Duration;
        public double Price { get; }
        public DateTime Start;
        public string Description;
        public DateTime End 
        { get
            {
                return Start.AddDays(Duration);
            } 
        }

        public Tour(string name, int code, List<string> plan, TransportType transport, int duration)
        {
            Name = name;
            Code = code;
            Plan = plan;
            Transport = transport;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Name} {Code}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Date: {Start} - {End} ({Duration} days)");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine(Description);
            Console.WriteLine("You will wisit such places as:");
            foreach (string i in Plan)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"You will use such transport as {Transport}");
            


        }
    }
}
