﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace algorithm_1;

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }

    static void GreetUser(User user)
    {
        Console.WriteLine($"Привет, {user.Name}!");

        if (!user.IsPremium)
        {
            ShowAds();
        }
    }

    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "Иван", IsPremium = true },
            new User { Login = "user2", Name = "Анна", IsPremium = false },
            new User { Login = "user3", Name = "Дмитрий", IsPremium = false }
        };

        foreach (var user in users)
        {
            GreetUser(user);
        }
    }
}
