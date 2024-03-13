namespace Week4Task
{
    internal class Task3
    {
        public static void Task3Solution(List<string> states)
        {

            var stateCategory = new List<StateCategory>();

            foreach (var state in states)
            {
                stateCategory.Add(new StateCategory { Name = state, GroupId = state[0] });
            }

            var groupList = new List<Group>()
            {
                new() { GroupId = 'A', GroupName = "Group A"},
                new() { GroupId = 'B', GroupName = "Group B"},
                new() { GroupId = 'C', GroupName = "Group C"},
                new() { GroupId = 'D', GroupName = "Group D"},
                new() { GroupId = 'E', GroupName = "Group E"},
                new() { GroupId = 'G', GroupName = "Group G"},
                new() { GroupId = 'I', GroupName = "Group I"},
                new() { GroupId = 'J', GroupName = "Group J" },
                new() { GroupId = 'K', GroupName = "Group K" },
                new() { GroupId = 'L', GroupName = "Group L" },
                new() { GroupId = 'N', GroupName = "Group N" },
                new() { GroupId = 'O', GroupName = "Group O" },
                new() { GroupId = 'P', GroupName = "Group P" },
                new() { GroupId = 'R', GroupName = "Group R" },
                new() { GroupId = 'S', GroupName = "Group S" },
                new() { GroupId = 'T', GroupName = "Group T" },
                new() { GroupId = 'Y', GroupName = "Group Y" },
                new() { GroupId = 'Z', GroupName = "Group Z" }
            };



            var groupJoin = groupList.GroupJoin(stateCategory,
                                    g => g.GroupId,
                                    s => s.GroupId,
                                    (g, stateGroup) => new
                                    {
                                        StateCategory = string.Join(", ", stateGroup.Select(state => state.Name)),
                                        GroupId = g.GroupName,
                                        GroupCount = stateGroup.Count()
                                    });


            foreach (var item in groupJoin)
            {
                Console.WriteLine($"{item.GroupId} - {item.GroupCount}");

                Console.WriteLine(item.StateCategory);

                Console.WriteLine();
            }
        }
    }
}


/*var groupJoinn = groupList.GroupJoin(stateCategory,
                        g => g.GroupId,
                        s => s.GroupId,
                        (g, stateGroup) => new
                        {
                            //StateCategory = string.Join(", ", stateGroup.Select(state => state.Name)),
                            states = stateGroup,
                            GroupId = g.GroupName,
                            GroupCount = stateGroup.Count()
                        });


foreach (var item in groupJoinn)
{
    Console.WriteLine($"{item.GroupId} - {item.GroupCount}");
    var statesCount = item.states.Count();
    foreach (var state in item.states)
    {
        Console.Write(state.Name);
        if (statesCount > 1)
        {
            Console.Write(", ");
            statesCount--;
        }
    }
    Console.WriteLine();
}*/