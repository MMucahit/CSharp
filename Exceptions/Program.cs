using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryException();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }


            HandleException(() =>
            {
                Find();
            } );


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Mücahit", "Osman", "Suat"};

            if (!students.Contains("Müslüm"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }

            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void TryException()
        {
            try
            {
                string[] students = new string[3] {"Engin", "Derin", "Salih"};
                students[3] = "Mücahit";
            }

            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Hata Nedeni: {0}", exception.Message);
            }
        }
    }
}
