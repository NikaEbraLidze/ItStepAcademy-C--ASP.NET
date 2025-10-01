using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        //დავალება 1
        //მომხმარებელს კლავიატურის გამოყენებით შეჰყავს ტექსტი. აპლიკაციამ თითოეული წინადადების
        //პირველი ასო, მაღალი რეგისტრის ასოთი უნდა ჩაანაცვლოს.
        //მაგალითად, თუ მომხმარებელმა შეიყვანა : «today is a good day for walking. i will try to walk near the 
        //sea».
        //აპლიკაციის შედეგი უნდა იყოს შემდეგი: «Today is a good day for walking. I will try to walk near the sea».


        // P.S არ ააწყოთ აპლიკაციის ლოგიკა მხოლოდ ამ მაგალითის მიხედვით, 
        // თქვენი კოდი უნდა მუშაობდეს ნებისმიერ წინადადებაზე.

        string text = EnterText(); // ტექსტის შეყვანა
        string[] parts = SplitText(text); // გამოყოფა 
        string[] corrected = CorrectText(parts); // პირველი ასოს დიდით შევცვლა
        JoinAndLogText(corrected, text); //დაბეჭვდვა
    }

    static string EnterText()
    {
        Console.Write("Enter your text: ");
        return Console.ReadLine() ?? string.Empty;
    }

    static string[] SplitText(string text)
    {
        string[] splitedText = text.Split('.');
        for (int i = 0; i < splitedText.Length; i++)
        {
            splitedText[i] = splitedText[i].Trim();
        }
        return splitedText;
    }

    static string CapitalizeFirstLetter(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return s;

        string firstLetter = s.Substring(0, 1).ToUpper();
        string rest = "";
        if (s.Length > 1)
            rest = s.Substring(1);

        return firstLetter + rest;
    }

    static string[] CorrectText(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = CapitalizeFirstLetter(arr[i]);

        return arr;
    }

    static void JoinAndLogText(string[] arr, string originalText)
    {
        bool endsWithDot = !string.IsNullOrWhiteSpace(originalText) && originalText.TrimEnd().EndsWith(".");
        string joined = string.Join(". ", arr);
        if (endsWithDot)
            joined += ".";
        Console.WriteLine(joined);
    }
}


