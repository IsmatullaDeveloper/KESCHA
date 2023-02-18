namespace KESCHA.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }
    
        public Animal(string name,int animalAge)
        {
            Name = name;
            Age = animalAge;
        }

        public virtual void Greet(string userName)
        {
            if(userName=="")
            {
                userName="Unknown Person";
            }
            Console.WriteLine($"Qoyil! {userName} biz endi sizning ismingizni bilamiz!");
        }



        public void PrintAgeDifference()
        {
            Console.WriteLine($"{Name} to'tiqushi va  sizning yoshingiz o'rtasidagi farq {AgeDifference} yoshni tashkil qiladi");
        }

        public void CompareAges(int userAge)
        {
            string message =
            userAge <= Age
                ? "You are younger or same age!"
                : "You are older!";
                
            Console.WriteLine(message);
        }

        public void KommissionAges()
        {
            string messageNum1 =
            !(AgeDifference < 0)
                ? "Age difference positive"
                : "Age difference negative";

        Console.WriteLine(messageNum1);
        }

        public void TellAbautFriend(string userName,int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Valya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge };
            string[] adress = { "Rio", "Malasia", "Uzbekistan" };

            
            foreach( string friendName in friendsName)
            {
                System.Console.WriteLine(friendName);
            }
            

            for (int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} years old! {adress[iteration]}");
            }
        }

        
        public void CalculateAgeDifferenceNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }
       
    }
}