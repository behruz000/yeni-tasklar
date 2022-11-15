namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var count=0;
            int  [] test = {1,2,3,4,5,6,7,8,9};
            

            for (int i = 0; i < test.Length ; i++)
            {
                if (test[i] % 2 == 1) 
                {
                  
                    count++;    


                
                }
            }
            Console.WriteLine("tek ededlerin sayi :"+count);   
           






        } 

    }
}