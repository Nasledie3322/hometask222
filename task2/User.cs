
using System;

namespace Task2;

public class User
{
 string FisrtName;
    string LastName;
    string PasswordHash;
    bool IsLoggedIn;
    string userName;
    DateTime CreatAt;
    public User(string name, string surname)
    {
        FisrtName = name;
        LastName = surname;
    }
    public void Regist(string user, string pass)
    {
        userName = user;
        PasswordHash = pass;
        System.Console.WriteLine("Вы зарегистрировались успешно!");
        System.Console.WriteLine("А теперь введите юсер и имя пользователя повторно \n чтоб войоти в систему!");
        CreatAt = DateTime.Now;
    }
    public void Login(string user, string pass)
    {
        if (userName == user && PasswordHash == pass)
        {
            System.Console.WriteLine("Вы вошли в систему");
            IsLoggedIn = true;

        }
        else if (PasswordHash == pass)
        {
            System.Console.WriteLine("Нерпаивльное имя пользователя или пароль!");
            IsLoggedIn = false;
        }
    }
    public void Logout()
    {
        System.Console.WriteLine("Вы вишли из системы!");
        IsLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{FisrtName} {LastName} | Логин: {userName} | Онлайн: {IsLoggedIn}";
    }
    public void ChangePassword(string old, string neww)
    {
        if (old == PasswordHash)
        {
            System.Console.WriteLine("Ваш пароль изменён успешно!");
            PasswordHash = neww;
        }
        else if (old != PasswordHash)
        {
            System.Console.WriteLine("Вы ввели неправильынй пароль, пожалуйста исправьте ошибки!");
        }
    }
    public int GetAccountAgeInDays()
{
    TimeSpan age = DateTime.Now - CreatAt;
    return age.Days;
}
}