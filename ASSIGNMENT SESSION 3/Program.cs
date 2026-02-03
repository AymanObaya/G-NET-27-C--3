using System.Reflection;
using System.Reflection.PortableExecutable;

namespace ASSIGNMENT_SESSION_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region QUESTION 1
            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            //output : 9
            ////Explicit castin from double to int truncates the decimal part 

            #endregion

            #region QUESTION 2
            //int n = 5;
            //double d2 = n / 2.00; // FIX => (2 ==> 2.00) 
            //Console.WriteLine(d2); 
            #endregion

            #region QUESTION 3
            //Console.WriteLine("int age : ");
            //int age = int.Parse(Console.ReadLine()); 
            #endregion

            #region QUESTION 4
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            // Runtime Exception  :  FormatException
            // "12a" is invalid integer  correction is "12" 
            #endregion

            #region QUESTION 5
            //string s = "12a";
            //if (int.TryParse(s, out int x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //} 
            #endregion

            #region QUESTION 6
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1); //Output 11
            //Explane : 10 is boxed as object  (int)  
            #endregion

            #region QUESTION 7
            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x); // EXCEPTION : System.InvalidCastException

            //HANDEL EXCEPTION : CONVERT LONG TO INT32
            //object o = 10;
            //long x = Convert.ToInt32(o);
            //Console.WriteLine(x); // NO EXCEPTION AND RESULT : 10
            #endregion

            #region QUESTION 8
            //object o = 10;
            //long x = o; 
            //Console.WriteLine(x);

            //handel :

            //try
            //{
            //    object o = 10;
            //    long x = Convert.ToInt64(o);
            //    Console.WriteLine(x);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("-1");
            //}


            #endregion

            #region QUESTION 9
            //string? name = null;  
            //Console.WriteLine(name?.Length); // output : empty line
            //null-conditional When name is null, name?.Length evaluates to null instead of throwing a NullReferenceException.


            #endregion

            #region QUESTION 10

            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);  // OUTPUT : 0

            //The null - conditional operator (?.) returns null because name2 is null.
            //The null - coalescing operator (??) then assigns 0 as the default,
            //so length becomes 0 and is printed. 
            #endregion

            #region QUESTION 11
            //string? s = null;
            //int x = int.Parse(s ?? "0");
            //Console.WriteLine(x);


            //which can throw a FormatException if the string is not a valid integer.
            //so we should use int.TryParse instead to safely attempt the conversion.
            //string? s = null;
            //int x;
            //int.TryParse(s ?? "0", out x);
            //Console.WriteLine(x); 
            #endregion

            #region QUESTION 12

            //string? s = null;
            //Console.WriteLine(s!.Length);

            //Here a NullReferenceException will be thrown at runtime.
            //To handle , we can check if 's' is null before accessing its Length property.
            // use try-catch block to catch the exception.

            //try
            //{
            //    string? s = null;
            //    Console.WriteLine(s!.Length);
            //}
            //catch (NullReferenceException)
            //{

            //    Console.WriteLine("String is null");
            //} 
            #endregion

            #region QUESTION 13

            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);  
            // OUTPUT 0  BECOUSE IN CONVERT TO INT32 WHEN VALUE IS NULL NOT THROW EXCEPTION , IT RETYRN 0

            #endregion

            #region QUESTION 14

            // string? s = null;

            //A
            // int a = int.Parse(s);

            // B
            // int b = Convert.ToInt32(s);
            // Console.WriteLine(b);
            // A :  THROW EXCEPTION ArgumentNullException IN RUNTIME
            //BECOUSE INT.PARSE DOES NOT ACCEP NULL VALUE AS VALID

            // B :  PRINT 0 BECOUSE CONVERT.TOINT32 HANDLES NULL VALUE BY RETURN 0

            #endregion
            
            #region QUESTION 15
            //string? user = null;
            //Console.WriteLine((user ?? "Guest").ToUpper()); 
            #endregion

        }
    }
}
