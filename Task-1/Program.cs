using System;
using System.Security.Cryptography.X509Certificates;

using static ListUtils;
using static Algorithms;
// დელეგატების გამოყენებით დაწერეთ შემდეგი მეთოდები

//    · Reverse აბრუნებს გადაცემული მასივის შეტრიალებულ ვარიანტს
//    · Sort აბრუნებს გადაცემული მასივის დალაგებულ ვარიანტს
//    · Any აბრუნებს true თუ მასივის რომელიმე ელემენტი ემთხვევა მოსაძებნად გადაცემულ ელემენტებს
//    · All აბრუნებს true თუ მასივის ყველა ელემენტი ემთხვევა მოსაძებნად გადაცემულ ელემენტებს
//    · FirstOrDefault მასივში მოძებნის გადაცემული რიცხვის პირველივე მნიშვნელობას თუ არ მოიძებნა დააბრუნებს default - ს
//    · LastOrDefault მასივში მოძებნის გადაცემული რიცხვის ბოლო მნიშვნელობას თუ არ მოიძებნა დააბრუნებს default - ს
//    · FindAll მოძებნის და დააბრუნებს მასივის ყველა იმ ელემენტს რომელიც გადაცემულია მოსაძებნად
//    · FindIndex მასივში მოძებნის გადაცემული რიცხვის პირველივე მნიშვნელობის ინდექსს თუ არ მოიძებნა დააბრუნებს -1
//    · FindLastIndex მასივში მოძებნის გადაცემული რიცხვის ბოლო მნიშვნელობის ინდექსს თუ არ მოიძებნა დააბრუნებს -1
//    · Sum შეკრებს მასივის ყველა ელემენტს.

class Program
{
    static void Main()
    {
        List<int> intItems = new() { 1, 2, 3, 4, 5 };

        List<int> reversedIntItems = DelegateExecutor(intItems, Reverse);
        List<int> sortedIntItems = DelegateExecutor(intItems, Sort);

        bool isExist = CompareEmelemts(intItems, Any);
        bool isExistList = CompareEmelemts(intItems, All);

        int FirstNum = CompareEmelemts(intItems, FirstOrDefault);
        int LasrNum = CompareEmelemts(intItems, LastOrDefault);



        int FirstIndex = CompareEmelemts(intItems, FindIndex);
        int LastIndex = CompareEmelemts(intItems, FindLastIndex);

        int sumElements = CompareEmelemts(intItems, SumAllElements);
    }
}