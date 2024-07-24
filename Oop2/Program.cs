// See https://aka.ms/new-console-template for more information

using Oop2;

Console.WriteLine("Hello, World!");


CoorporateCustomer customer1 = new CoorporateCustomer();

IndividualCustomer customer2 = new IndividualCustomer();

Customer customer3 = new CoorporateCustomer();

Customer customer4 = new IndividualCustomer();

CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);
