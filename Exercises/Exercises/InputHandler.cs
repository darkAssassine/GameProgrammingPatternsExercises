namespace CommandPattern
{
    internal class InputHandler
    {
        Actor actor = new Actor();
        List<Command> commands = new List<Command>();
        int index = -1;
        public void Update()
        {
            Command newCommand = HandleInput();
            if (newCommand != null)
            {
                newCommand.Execute();
                UpdateCommandsList();
                commands.Add(newCommand);
                index++;
                Console.WriteLine($"{actor.x} , {actor.y}");
            }
        }

        public void UpdateCommandsList()
        {
            for (int i = index; i < commands.Count; i++)
            {
                if (i > 0 && i < commands.Count - 1)
                {
                    commands.RemoveAt(i);
                }
            }
        }

        public Command HandleInput()
        {
            string line = Console.ReadKey(true).KeyChar.ToString();
            if (line == "A" || line == "a")
            {
                return new MoveCommand(actor, -1, 0);
            }
            if (line == "D" || line == "d")
            {
                return new MoveCommand(actor, 1, 0);
            }
            if (line == "W" || line == "w")
            {
                return new MoveCommand(actor, 0, 1);
            }
            if (line == "S" || line == "s")
            {
                return new MoveCommand(actor, 0, -1);
            }
            if (line == "Q" || line == "q")
            {
                index--;
                if (index < 0)
                {
                    index = 0;
                }
                else
                {
                    commands[index].Undo();
                    Console.WriteLine($"{actor.x} , {actor.y}");
                }
            }

            if (line == "E" || line == "e")
            {
                index++;
                if (index >= commands.Count - 1)
                {
                    index = commands.Count - 1;
                }
                else
                {
                    commands[index].Execute();
                    Console.WriteLine($"{actor.x} , {actor.y}");
                }
            }
            return null;
        }

        // had long delays
        public bool IsKeyDown(ConsoleKey key)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey pressedKey = Console.ReadKey(true).Key;

                if (key == pressedKey)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
