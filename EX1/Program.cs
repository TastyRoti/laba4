using System;
using System.Collections.Generic;

namespace Lab_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Cinema florencia = new Cinema("07.03.2012", 100, 5);
            Console.WriteLine(florencia);

            Console.WriteLine("Built: " + florencia.Date);

            Console.WriteLine("Ticket price: " + florencia.Price(100, 3));   
            
            Console.WriteLine("Сapacity: " + florencia.capacity());

            ////////////////////////////////////////////////////////////////////

            Hotel California = new Hotel("21.08.2004", 310, 8);

            Console.WriteLine(California);

            Console.WriteLine("Built: " + California.Date);

            Console.WriteLine("Rent price: " + California.Rent(100, 3, 10));

            Console.WriteLine("Сapacity: " + California.capacity());

            ////////////////////////////////////////////////////////////////////

            PublicBuilding publickbuilding1 = new PublicBuilding("23.08.1923", 200, 4);

            Console.WriteLine(publickbuilding1);

            Console.WriteLine("Built: " + publickbuilding1.Date);

            Console.WriteLine("Ticket price: " + publickbuilding1.Price(50, 34));

            Console.WriteLine("Сapacity: " + publickbuilding1.capacity());

            /////////////////////////////////////////////////////////////////////

            ResidentialBuilding house = new ResidentialBuilding("01.01.2012", 150, 20);

            Console.WriteLine(house);

            Console.WriteLine("Built: " + house.Date);

            Console.WriteLine("Rent price: " + house.Rent(150, 50, 30));

            Console.WriteLine("Сapacity: " + house.capacity());

            /////////////////////////////////////////////////////////////////////


            
        }
    }
}
