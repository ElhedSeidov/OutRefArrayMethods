namespace ConsoleApp6
{


    public class Example
    {


        public static bool CustomTryParse(string a, out int result)
        {

            string[] strings = a.Split('1','2','3','4','5','6','7','8','9','0');
            string str = String.Join(null,strings);
            //Console.WriteLine(str.Length);
            //foreach (string s in strings) 
            //{ 
            //    Console.WriteLine(s);
            //}

            

            if (str.Length > 0) 
            {
                result = 0;
                return false;
               
                
            }
            result=int.Parse(a);
            return true;    

        }


        public static void Main()
        {

            Console.WriteLine(CustomTryParse("67",out int result));
            Console.WriteLine(result);
            Console.WriteLine(result*2);



        }
    }

}
    
 
