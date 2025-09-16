


using Task2;
string a = Console.ReadLine();
string b = Console.ReadLine();
User user = new User(a, b);
string c = Console.ReadLine();
string d = Console.ReadLine();
user.Regist(c,d);
string e = Console.ReadLine();
string f = Console.ReadLine();
user.Login(e, f);
System.Console.WriteLine(user.GetFullInfo());
string x = Console.ReadLine();
string z = Console.ReadLine();
user.ChangePassword(x, z);
System.Console.WriteLine(user.GetAccountAgeInDays());