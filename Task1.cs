namespace Week4Task
{
    internal class Task1
    {
        public static void Task1Solution(List<string> states)
        {

            var statesWithId = new List<State>();

            int counter = 1;
            int groupCount = 0;
            foreach (var state in states)
            {
                statesWithId.Add(new State { Id = counter, Name = state });
                groupCount++;

                if (groupCount == 3)
                {
                    counter = (counter % 12) + 1;
                    groupCount = 0;
                }
            }


            var groupedStates = statesWithId.GroupBy(s => s.Id);

            Console.WriteLine("A Group of states in set of 3:");
            Console.WriteLine("_".PadRight(41, '_'));

            foreach (var stateGroup in groupedStates)
            {
                string state = string.Join(", ", stateGroup.Select(state => state.Name));
                Console.WriteLine(state);
                Console.WriteLine("_".PadRight(41, '_'));
            }


        }
    }
}
