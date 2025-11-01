using System;
using System.Security.Cryptography.X509Certificates;
using static CustomerProcessor;

class Program
{
    static void Main()
    {
        string filePath = @"../../../Customers.csv";
        // გიგზავნით csv ფაილს სადაც მოცემულია ინფორმაცია ბანკის მომხმარებლების შესახებ, 
        // თქვენი დავალებაა რომ ააწყოთ ამ მომხმარებლების მენეჯმენტ სისტემა. 
        // რომლის საშუალებითაც შესაძლებელი იქნება მომხმარებლის შესახებ სრული ინფორმაციის წამოღება, 
        // ასევე კონკრეტული მომხმარებლის მიღება, ფაილში ახალი მომხმარებლის დამატება რედაქტირება და წაშლა.

        // დავალების შესასრულებლად უნდა შეასრულოთ ყველა ის ეტაპი რომელიც ლექციის განმავლობაში გავიარეთ.
        // მეთოდების სტრუქტურა არის შემდეგი:

        // 1.   List<Customer> GetAllCustomers(); აბრუნებს ყველა მომხმარებელს ფაილიდან

        // Customer[] customersArr = GetAllCustomers(filePath);
        // LogArr(customersArr);


        // 2.   Customer GetSingleCustomer(int customerId); აბრუნებს კონკრეტულად იმ მომხმარებელს რომლის customerId _ იც ემთხვევა ფაილში არსებულ მომხმარებელს

        // Customer singleCustomer = GetSingleCustomer(customersArr, 2);
        // singleCustomer?.Log();


        // 3.   int AddCustomer(Customer model); ფაილში ამატებს ახალ მომხმარებელს (სასურველია კონსოლიდან) ისე რომ არ დაირღვეს ფაილის მთლიანობა

        // Customer[] customers = GetAllCustomers(filePath);
        // Customer newCustomer = Input.CreateCustomer(customers);
        // newCustomer.Log();


        // 4.   int UpdateCustomer(Customer model);  ფაილში ანახლებს მომხმარებელს (სასურველია კონსოლიდან) ისე რომ არ დაირღვეს ფაილის მთლიანობა
        // Customer[] customers = GetAllCustomers(filePath);
        // Input.UpdateCustomer(customers, filePath);

        // 5.   int DeleteCustomer(int customerId); ფაილში შლის იმ მომხმარებელს რომლის customerId - იც ემთხვევა ფაილში არსებულ მომხმარებელს

        // Customer[] customers = GetAllCustomers(filePath);
        // Input.DeleteCustomer(customers, 2, filePath);
    }
}
