namespace Week4Task
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var states = new List<string>() { "Abia", "Adamawa", "Akwa Ibom", "Anambra",
                                  "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River",
                                  "Delta", "Ebonyi", "Edo", "Ekiti", "Enugu", "Gombe", "Imo",
                                  "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Kogi", "Kwara",
                                  "Lagos", "Nasarawa", "Niger", "Ogun", "Ondo", "Osun", "Oyo",
                                  "Plateau", "Rivers", "Sokoto", "Taraba","Yobe", "Zamfara" };

            Task1.Task1Solution(states);
            Task2.Task2Solution();
            Task3.Task3Solution(states);

        }
    }
}
