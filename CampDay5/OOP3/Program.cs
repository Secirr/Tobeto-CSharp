using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();

BasvuruManager basvuruManager=new BasvuruManager();

List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

