using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("123 St 987 Blvd", "Mount Virginia", "UT", "US");
        Address address2 = new Address("321 St 789 Blvd", "Escalade", "MT", "US");
        Address address3 = new Address("132 St 798 Blvd", "Castle", "MI", "US");

        Lecture lecture = new Lecture("Lecture", "Speech by Profesor Greg", "Professor Greg will be coming to campus to speak to us about the power of scripture study in the family. Come prepared ot learn essential Gospel truths to strangthen your family.", "Jun 14th, 2024", "2pm", address1, "Professor Greg", "100");
        Reception reception = new Reception("Reception", "Chuck & Sarah", "A reception for the Bartowskis will be held this weekend for the family and friends of this beloved couple. All are invited to attend.", "Feb 23, 2024", "3pm", address2, "sarahtimely@hotmail.com");
        Outdoor outdoor = new Outdoor("Outdoor", "Ward Campout", "The 2nd Ward is hosting a family campout for all who would like to join us! Food will be included. Bring your own camping gear.", "July 10th, 2024", "10am", address3, "Partly Cloudy, High of 80 degrees most days.");
    
        Console.WriteLine("");
        Console.WriteLine("Standard Details");
        lecture.GenerateStandardDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details");
        lecture.GetFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description");
        lecture.GenerateShortDescription();
        Console.WriteLine("-----------------------");

        Console.WriteLine("");
        Console.WriteLine("Standard Details");
        reception.GenerateStandardDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details");
        reception.GetFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description");
        reception.GenerateShortDescription();
        Console.WriteLine("-----------------------");

        Console.WriteLine("");
        Console.WriteLine("Standard Details");
        outdoor.GenerateStandardDetails();
        Console.WriteLine("");
        Console.WriteLine("Full Details");
        outdoor.GetFullDetails();
        Console.WriteLine("");
        Console.WriteLine("Short Description");
        outdoor.GenerateShortDescription();
        Console.WriteLine("-----------------------");

    }
}