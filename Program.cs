using System;

namespace laba2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Puppy puppy = new Puppy("Fred", "gav", "prug", "top", "kus");
        }
    }
    class Puppy: Dog
    {
        public Puppy (string _name,string _voice, string _jump, string _run, string _bite) : base(_name, _voice, _jump, _run, _bite)
        {
            Console.WriteLine("I create");
        }
    }
    class Animal
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public Animal (string _name, string _voice)
        {
            Name = _name;
            Voice = _voice;
            Console.WriteLine("Animal created");
        }
    }
    class Dog: Animal
    {
        public string Jump { get; set; }
        public string Run { get; set; }
        public string Bite { get; set; }
        public Dog(string _name, string _voice, string _jump, string _run,string _bite) : base(_name, _voice)
        {
            Jump = _jump;
            Run = _run;
            Bite = _bite;
            Console.WriteLine("Dog created");
        }
    }
}
