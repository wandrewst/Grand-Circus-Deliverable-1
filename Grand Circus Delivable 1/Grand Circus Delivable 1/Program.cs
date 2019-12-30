using System;

namespace Grand_Circus_Delivable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            Console.WriteLine(" What trip type interest you today: musical, tropical, or adventurous? ");
            vacationType = Console.ReadLine();

            Console.WriteLine(" How many are in you group? ");
            int groupSize = int.Parse(Console.ReadLine());
        
        if (vacationType == "musical" && groupSize <=2)
            {
                string result = (" Alrighty, as a group of "  +   groupSize  +  " looking for a "  +  vacationType  +  " vacation, your group should take a first class trip to New Orleans ");
                Console.WriteLine(result);
            }
            else if (vacationType == "musical" && groupSize <=5)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a helicopter to New Orleans ");
                Console.WriteLine(result);
            }
            if (vacationType == "musical" && groupSize >=6)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a charter flight to New Orleans " );
                Console.WriteLine(result);
            }
        if (vacationType == "tropical" && groupSize <=2)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a first class trip to a beach vacation in Mexico ");
                Console.WriteLine(result);
            }
            else if (vacationType == "tropical" && groupSize <=5)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a helicopter to a beach vacation in Mexico ");
                Console.WriteLine(result);
            }
            if(vacationType == "tropical" && groupSize >=6)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should charter a flight to a beach vacation in Mexico ");
                Console.WriteLine(result);
            }
        if (vacationType == "adventurous" && groupSize <=2)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a first class trip whitewater rafting in the Grand Canyon ");
                Console.WriteLine(result);
            }
            else if (vacationType == "adventurous" && groupSize <=5)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a helicopter to go whitewater rafting in the Grand Canyon ");
                Console.WriteLine(result);
            }
            if (vacationType == "adventurous" && groupSize >=6)
            {
                string result = (" Alrighty, as a group of " + groupSize + " looking for a " + vacationType + " vacation, your group should take a charter flight to go whitewater rafting in the Grand Canyon ");
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }
    }
}
