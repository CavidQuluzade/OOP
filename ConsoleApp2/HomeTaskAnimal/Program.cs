namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main()
        {
            Cat cat = new Cat("Max", 5, "kedi", "white");
            Dog dog = new Dog("Jack", 7, "rrr", "white");
            cat.GetDetail();
            cat.MakeVoice();
            dog.GetDetail(); 
            dog.MakeVoice();

        }
    }
}