// შექმენი პროგრამა, რომელიც წარმოაჩენს სხვადასხვა ცხოველის ხმას მემკვიდრეობისა და პოლიმორფიზმის გამოყენებით.

// მოთხოვნები:
//     1. შექმენი აბსტრაქტული კლასი Animal შემდეგი ელემენტებით:
//         o Property: public string Name { get; set; }
//         o კონსტრუქტორი, რომელიც იღებს name-ს.
//         o აბსტრაქტული მეთოდი: public abstract void MakeSound();

//     2. შექმენი ორი შვილობილი კლასი:
//         o Dog – override მეთოდში გამოიტანე "Dog barks: Woof!".
//         o Cat – override მეთოდში გამოიტანე "Cat meows: Meow!".

//     3. Main მეთოდში:
//         o შექმენი Animal[] მასივი და დაამატე Dog და Cat ობიექტები.
//         o გაიარე foreach-ით და გამოიძახე MakeSound() ყველა ცხოველზე.
//         o დაამატე Exception Handling, რომ თუ ცხოველს არ აქვს სახელი, ჩააგდოს ArgumentException

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Animal must have a name!");

        Name = name;
    }

    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow!");
    }
}