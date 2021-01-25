using System;
using System.Collections.Generic;

namespace CS133MIDTERMPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();


            myRestaurant.AddPeopleIntoTheQueue("First Client ");
            myRestaurant.AddPeopleIntoTheQueue("Second Client ");
            myRestaurant.AddPeopleIntoTheQueue("Third Client ");
            myRestaurant.AddPeopleIntoTheQueue("Fourth Client ");
            myRestaurant.AddPeopleIntoTheQueue("Fifth Client ");

            

            myRestaurant.ClientsArrive();

            myRestaurant.ClientsLeave();

            myRestaurant.WaiterPickUpPlates();

            myRestaurant.CleanDishes();

            myRestaurant.ShowMeTheActualClients();
        }
    }
}
public class Restaurant
{
    private Queue<string> waitinQueue = new Queue<string>();

    public void AddPeopleIntoTheQueue(string parameter)
    {
        waitinQueue.Enqueue(parameter);
    }

    public void ShowMeHowManyClientsIHave()
    {
        Console.WriteLine(" I have these many Clients: " +
                          waitinQueue.Count +
                          " Clients ");
    }

    public void ShowMeTheActualClients()
    {
        foreach (var item in waitinQueue)
        {
            Console.WriteLine("Client: " + item);
        }
    }

    public void ClientsArrive()
    {
        waitinQueue.Dequeue();
    }

    public void WaiterPickUpPlates()
    {
        foreach (var item in waitinQueue)
        {
            Console.WriteLine("Table: " + item);
        }
    }
    public void ClientsLeave()
    {
        waitinQueue.Dequeue();
    }

    public void CleanDishes()
    {
        foreach (var item in waitinQueue)
        {
            Console.WriteLine("Dishes: " + item);
        }
    }
}