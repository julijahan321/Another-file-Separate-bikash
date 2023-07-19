class program
{
        public static void Main()
        {
            while (true)
            {
                Bikash bikash = new Bikash();
                
                string inputNumber1 = Convert.ToString(Console.ReadLine());
                bikash.BikashSystem(inputNumber1);

                Recharge recharge = new Recharge();

                recharge.RechergeMoney();
            }
        }
    }
