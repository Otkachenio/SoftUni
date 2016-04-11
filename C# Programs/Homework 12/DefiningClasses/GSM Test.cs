using System;

namespace DefiningClasses
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] GSMTest = new GSM[3];

            GSM firstGSM = new GSM("Nokia Lumia 820", "Nokia", 200, "Aleksandar Aleksandrov");
            GSMTest[0] = firstGSM;
            GSM secondGSM = new GSM("Microsoft Lumia 950", "Microsoft", 600, "Pazaruvaj.com");
            GSMTest[1] = secondGSM;
            GSM thirdGSM = new GSM("iPhone 6 Plus", "Apple", 800, "Ebay.com");
            GSMTest[2] = thirdGSM;

            for (int i = 0; i < GSMTest.Length; i++)
            {
                GSMTest[i].ToString();
            }

            GSM.IPhone4S.ToString();

            //Call Test
            GSM fourthGSM = new GSM("Nokia Lumia 1020", "Nokia", 300, "Velizar Simov");

            fourthGSM.AddCalls(DateTime.Now, "0892774895", 600);
            fourthGSM.AddCalls(DateTime.Now, "0892774895", 180);
            fourthGSM.AddCalls(DateTime.Now, "0892774895", 145);
            fourthGSM.PrintCalls();

            fourthGSM.CallPrice(0.37);

            fourthGSM.DeleteCalls(600);
            fourthGSM.PrintCalls();

            fourthGSM.CallPrice(0.37);

            fourthGSM.ClearCalls();
            fourthGSM.PrintCalls();
        }
    }
}
