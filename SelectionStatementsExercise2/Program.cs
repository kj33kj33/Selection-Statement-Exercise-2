using static System.Formats.Asn1.AsnWriter;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "physics":
                    Console.WriteLine("Physics is the study of movement");
                    break;
                case "english":
                    Console.WriteLine("English is a language");
                    break;
                case "chemistry":
                    Console.WriteLine("Chemistry involves elements");
                    break;
                case "gym":
                    Console.WriteLine("Gym class is fun");
                    break;
                case "art":
                    Console.WriteLine("Art class involves creativity");
                    break;
                default:
                    Console.WriteLine($"{answer} is a lovely class!");
                    break;
            }
        }
    }
}