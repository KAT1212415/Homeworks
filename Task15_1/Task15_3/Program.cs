using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Subscribers = new HashSet<string>();
            Subscribers.Add("alice@example.com");
            Subscribers.Add("bob@example.com");
            Subscribers.Add("charlie@example.com");
            bool duplicate= Subscribers.Add("charlie@example.com");
            Console.WriteLine(duplicate);
            Console.WriteLine($"Есть ли пользователь charlie@example.com в Subscribers?-{Subscribers.Contains("charlie@example.com")}");

            HashSet<string> newSubscribers = new HashSet<string>();
            newSubscribers.Add("alice@example.com");
            newSubscribers.Add("dave@example.com");
            newSubscribers.Add("eve@example.com");
            HashSet<string> allSubscribers = new HashSet<string>(newSubscribers);
            allSubscribers.UnionWith(Subscribers);
            Console.WriteLine($"allSubscribers:");
            foreach (string subscriber in allSubscribers) {Console.WriteLine(subscriber);};
           HashSet<string> commonSubscribers = new HashSet<string>(Subscribers);
            commonSubscribers.IntersectWith(newSubscribers);
            foreach(string subscriber in commonSubscribers) {Console.WriteLine($"Общий подписчик -{subscriber}");};
            newSubscribers.Remove("eve@example.com");
            HashSet<string> subset = new HashSet<string>{ "a@example.com" , "alice@example.com" };
            Console.WriteLine($"Есть ли \"a@example.com\" , \"alice@example.com\" в newSubscribers-{newSubscribers.IsSubsetOf(subset)}");

            
            
        }
    }
}
