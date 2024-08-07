using System;

using System.Collections.Generic;

namespace JAMK.IT
{
    public interface ICanMakeNote
    {
        string MakeNote(string note);
    }

    public class Computer
    {
        //propertise
        public string Name { get; set; }
        public string CPU { get; set; }
        //methods
    }
    //classes which can make notes
    public class Laptop : Computer, ICanMakeNote
    {
        public string MakeNote(string note)
        {
            return $"Your note {note} has been written to the harddisc successfully.";
        }
    }
    public class MobilePhone : Computer, ICanMakeNote
    {
        public string MakeNote(string note)
        {
            return $"Your note {note} has been written to the harddisc successfully.";
        }
    }
    public class pen : ICanMakeNote
    {
        public string MakeNote(string note)
        {
            return "Some nice scratching...";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a laptoop
            Laptop lappari = new Laptop();
            lappari.Name = "HP";
            lappari.CPU = "i7";
            //ask from end-user a note to make
            Console.WriteLine("Please, give your note to save: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Your laptop {"lappari.Name"} says {lappari.MakeNote(input)}");
            //create a Mobilephone
            MobilePhone nokia = new MobilePhone() { Name = "Nokia 7plus", CPU = "i dont know" };
            Console.WriteLine($"With my {nokia.Name} it goes like this {nokia.MakeNote(input)}");
            //a pen
            pen pen = new pen();
            string sound = pen.MakeNote(input);
            //Console.WriteLine(sound);
            //let's use a method
            MakeANote(pen, input);
            MakeANote(nokia, input);
            MakeANote(lappari, input);
            //devices to the list
            List<ICanMakeNote> devices = new List<ICanMakeNote>();
            devices.Add(nokia);
            devices.Add(pen);
            devices.Add(lappari);
            GoThroughList(devices, input);
        }
        private static void MakeANote(ICanMakeNote device, string msg)
        {
            Console.WriteLine(device.MakeNote(msg));
        }
    
        private static void GoThroughList(List<ICanMakeNote> listOfDevices, string msg)
        {
            foreach (var device in listOfDevices)
            {
                Console.WriteLine(device.MakeNote("Yes, this is working! here is your note {msg}"));
                Console.ReadLine();
            }
        }
    }
}
