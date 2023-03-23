using Factory.Factories;
using Factory.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Provider
    {
        private Subscription CurrentSub { get; set; }
        public ISubscriptionFactory Manager = new ManagerCall();
        public ISubscriptionFactory Mobile = new MobileApp();
        public ISubscriptionFactory Web = new WebSite();

        public void SelectPlan()
        {
            Console.WriteLine("You decided that you want to change your subscription plan on TV.");
            Console.WriteLine("Which way you want to do that?");
            Console.WriteLine("1. Manager Call");
            Console.WriteLine("2. Mobile App");
            Console.WriteLine("3. Website");
            int choice = int.Parse(Console.ReadLine());

            ISubscriptionFactory subscriptionFactory;

            switch (choice)
            {
                case 1:
                    CurrentSub = Manager.Subscribe();
                    break;
                case 2:
                    CurrentSub = Mobile.Subscribe();
                    break;
                case 3:
                    CurrentSub = Web.Subscribe();
                    break;
                default:
                    Console.WriteLine("You cant do that in other way!");
                    return;
            }
        }

        public void GetCurrentPlan()
        {
            if(CurrentSub != null)
            {
                Console.WriteLine(CurrentSub.GetInfo());
            }
            
        }
    }
}
