using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem;
public class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        Console.WriteLine("Hello, welcome to the random activity selector!");
        bool cont = true;
        Console.WriteLine();        
        Console.WriteLine("We are going to need your information first! What is your name?: ");        
        string userName = Console.ReadLine();       
        Console.WriteLine();
        Console.WriteLine("What is your age?: ");        
        int userAge = int.Parse(Console.ReadLine());        
        Console.WriteLine();
        bool seeList;
        Console.WriteLine("Would you like to see the current list of activities before we choose one for you? Yes/No thanks (y/n): ");
        if (Console.ReadLine() == "y")
            seeList = true;
        else
            seeList = false;
        if (seeList)
        {
            foreach (string activity in activities)
            {
                Console.WriteLine($"{activity} ");
                Thread.Sleep(250);
            }

            Console.WriteLine();
            bool addToList;

            Console.WriteLine("Would you like to add any activities before we choose one? yes/no (y/n): ");
            if (Console.ReadLine() == "y")
                addToList = true;
            else 
                addToList = false;
            Console.WriteLine();
            while (addToList)
            {
                Console.WriteLine("What would you like to add?: ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);
                foreach (string activity in activities)
                {
                    Console.WriteLine($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: (y/n)");
                if (Console.ReadLine() == "y")
                    addToList = true;
                else
                    addToList = false;
            }
        }        
        while (cont)        
        {        
            Console.WriteLine("Connecting to the database");        
            for (int i = 0; i < 10; i++)        
            {            
                Console.WriteLine(". ");            
                Thread.Sleep(500);        
            }            
            Console.WriteLine();                
            Console.WriteLine("Choosing your random activity");        
            for (int i = 0; i < 9; i++)            
            {            
                Console.WriteLine(". ");            
                Thread.Sleep(500);        
            }
            Console.WriteLine();            
            int randomNumber = rng.Next(activities.Count);
            string randomActivity = activities[randomNumber];                
            if (userAge < 21 && randomActivity == "Wine Tasting")          
            {            
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");            
                Console.WriteLine("Picking something else!");            
                randomNumber = rng.Next(activities.Count);            
                randomActivity = activities[randomNumber];        
            }            
            Console.WriteLine($"Ah got it! {userName}, your random activity is: {randomActivity}!\nIs this ok or do you want to grab another activity? Keep/Redo: (k/r)");            
            Console.WriteLine();
            if (Console.ReadLine() == "r")
                cont = true;
            else
                cont = false;
        }    
    }
}
