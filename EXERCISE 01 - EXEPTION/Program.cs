using System;
namespace EXERCISE_01___EXEPTION {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resut = n1 / n2;
                Console.WriteLine(resut);
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Format error! " +e.Message);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
