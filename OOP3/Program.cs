// See https://aka.ms/new-console-template for more information

using OOP3;

Console.WriteLine("Hello, World!");


IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new DatabaseLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();

List<ILoggerService> loggerServices = new List<ILoggerService>(){new DatabaseLoggerService(),new FileLoggerService()};

basvuruManager.BasvuruYap(tasitKrediManager,loggerServices);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

  
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);



