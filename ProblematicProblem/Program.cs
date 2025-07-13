using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem;
public class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        //bool cont = true;

        List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        Console.WriteLine("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
             
        bool cont = bool.Parse(Console.ReadLine());
   
        Console.WriteLine();
        
        Console.WriteLine("We are going to need your information first! What is your name? ");
        
        string userName = Console.ReadLine();
       
        Console.WriteLine();
        
        Console.WriteLine("What is your age? ");
        
        int userAge = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine("Would you like to see the current list of activities? Sure/No thanks: ");
        
        bool seeList = bool.Parse(Console.ReadLine());
    
        if (seeList)       
        {            
            foreach (string activity in activities)         
            {        
                Console.WriteLine($"{activity} ");        
                Thread.Sleep(250);    
            }   
            
            Console.WriteLine();    
            Console.WriteLine("Would you like to add any activities before we generate one? yes/no: ");    
            bool addToList = bool.Parse(Console.ReadLine());    
            Console.WriteLine();    
            while (addToList)   
            
            {            
                Console.WriteLine("What would you like to add? ");            
                string userAddition = Console.ReadLine();            
                activities.Add(userAddition);            
                foreach (string activity in activities)            
                {                
                    Console.WriteLine($"{activity} ");                
                    Thread.Sleep(250);           
                }            
                Console.WriteLine();            
                Console.WriteLine("Would you like to add more? yes/no: ");            
                addToList = bool.Parse(Console.ReadLine());    
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
                Console.WriteLine("Pick something else!");            
                activities.Remove(randomActivity);            
                randomNumber = rng.Next(activities.Count);            
                randomActivity = activities[randomNumber];        
            }            
            Console.WriteLine($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");            
            Console.WriteLine();            
            cont = bool.Parse(Console.ReadLine());        
        }    
    }
}
