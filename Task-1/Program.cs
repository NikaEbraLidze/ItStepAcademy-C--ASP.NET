using System;
using System.Security.Cryptography.X509Certificates;
using static VehicleProcessor;

class Program
{
    static void Main()
    {

        // string[] data = File.ReadAllLines(@"../../../vehicles.csv");
        string filePath = @"../../../vehicles.csv";

        //    1. უნდა შექმნათ მანქანის კლასი
        //    2. უნდა დაწეროთ მეთოდი რომელიც ერთ string line - ს გარდაქმნის მანქანის ობიექტად
        //    ("Dodge,Charger,4,2.2,Front-Wheel Drive,Manual 5-spd,23,27,33") => 
        //    new Car(){Dodge,Charger,4,2.2,Front-Wheel Drive,Manual 5-spd,23,27,33}
        //    3. ფაილიდან უნდა წაიკითხოთ თითოეული line
        //    4.თითოეული line გარდაქმენით მანქანის ობიექტად, გარდაქმნილი მანქანები დაიმახსოვრეთ მასივში ან ლისტში
        Vehicle[] vehiclesList = ReadAllData(filePath);



        //      1. მოძებნეთ ყველა მერსედესი
        Vehicle[] filteredCars = SearchCarByModel(vehiclesList, "Mercedes-Benz");
        LogArr(filteredCars);
        //      2. მოძებნეთ 10 ყველაზე ეკონომიური მანქანა
        // Vehicle[] economicCars = FindEconomicCars(vehiclesList, 10);
        // LogArr(economicCars);
    }
}