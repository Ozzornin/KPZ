using Factory.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class WebSite : ISubscriptionFactory
    {
        public Subscription CurrentSub { get; set; }
        public Subscription Subscribe()
        {
            Console.Write("You decided to select a new sub plan on a web site.");
            Console.WriteLine("Select a subscription type:");
            Console.WriteLine("1. DomesticSubscription");
            Console.WriteLine("2. EducationalSubscription");
            Console.WriteLine("3. PremiumSubscription");
            Console.Write("Enter the number of your choice: ");

            string choice = Console.ReadLine();
            int period = 12;

            switch (choice)
            {
                case "1":

                    Console.WriteLine("Thank you for selecting Domestic subscription!");
                    return new DomesticSubscription(period);

                    break;
                case "2":
                    Console.WriteLine("You choosed Educational subscription");
                    return new EducationalSubscription(period);

                    break;
                case "3":
                    Console.WriteLine("Subscribed on Premium");
                    return new PremiumSubscription(period);

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return null;
                    break;
            }
        }             
    }
}


