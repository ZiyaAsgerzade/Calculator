namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Total();
            //Total(5, 15);
            //Total(20,30,40);
            //Total(2.5,3.1);



            //Bolme(100,200,5);

            Calculator(100,10,"/");
            
        }
        

        //static void Total()
        //{
        //    Console.WriteLine("Ziya");
        //}
      
        //static void Total(int price1, int price2)
        //{
        //    Console.WriteLine(price1 + price2);
        //}

        //static void Total(int price1, int price2, int price3)
        //{
        //    Console.WriteLine(price1+price2+price3);
        //}
        //static void Total(double price1, double price2)
        //{
        //    Console.WriteLine("Cemi=" + (price1+price2));
        //}
        //static void Bolme(int start,int end,int bolen)
        //{
        //    Console.WriteLine(bolen + "-a bolunenler");
        //    for (int i= start; i <= end; i++)
        //    {
        //        if (i % bolen == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }

        //}

        static void Calculator(int number1, int number2,string operation)
        {   
            
            switch (operation)
            {
                case "+": 
                    Console.WriteLine(number1+number2);
                    break;
                case "-":
                    Console.WriteLine(number1-number2);
                    break;
                case "*":
                    Console.WriteLine(number1*number2);
                    break;
                case "/":        
                    Console.WriteLine(number1/number2);
                    break;
                   
                  
            }







        }
















    }
}