// Jacob Ivey
// Lab1 Maze
// ITSE 1430
//
// Concept for the maze borrowed from Star Wars freighter 
// MY MAP - https://i.gyazo.com/6ab2e5290089cd389ea02717d9023176.png
// ORIGINAL FREIGHTER MAP - https://vignette.wikia.nocookie.net/starwars/images/d/d5/Dynamic-class.png/revision/latest?cb=20080330025657

using System;

namespace Itse1430.Maze
{
    class Program
    {
        private static int currentDirection;
        static void Main ( string[] args )
        {
            currentDirection = 2;
            Console.WriteLine ("You are a starship pilot. You have been given emergency instruction to fire up an unfamiliar freight ship and leave immediately. Start at the ship's ramp and find your way to the cockpit.");
            Console.WriteLine ("");

            Ramp ();
        }

        enum Command
        {
            Quit = 1,
            MoveForward = 2,
            MoveBackward = 3,
            MoveLeft = 4,
            MoveRight = 5,
        }

        enum Direction
        {
            North = 0,
            East = 1,
            South = 2,
            West = 3,
        }

        static Direction MoveDirection ( Command command )
        {
            switch (command)
            {
                case Command.MoveForward:
                return (Direction)currentDirection;
                case Command.MoveBackward:
                return (Direction)((currentDirection + 2 + 4) % 4);
                case Command.MoveLeft:
                return (Direction)((currentDirection - 1 + 4) % 4);
                case Command.MoveRight:
                return (Direction)((currentDirection + 1 + 4) % 4);
                default:
                Console.WriteLine ("You somehow broke it.");
                break;
            }
            return (Direction)currentDirection;
        }

        static void DisplayDirection ()
        {
            Console.WriteLine ("You are facing " + (Direction)currentDirection + ".");
        }

        static Command CommandHandler ()
        {
            while (true)
            {
                Console.WriteLine ("What will you do? ");
                string command = CommandValidation ();
                switch (command)
                {
                    case "quit":
                    {
                        if (BoolValidation ("Are you sure you want to quit? "))
                            return Command.Quit;
                        else
                            continue;
                    }
                    case "move forward":
                    return Command.MoveForward;
                    case "move backward":
                    return Command.MoveBackward;
                    case "move left":
                    return Command.MoveLeft;
                    case "move right":
                    return Command.MoveRight;

                    case "turn left":
                    currentDirection = (currentDirection - 1 + 4) % 4;
                    DisplayDirection ();
                    break;
                    case "turn right":
                    currentDirection = (currentDirection + 1 + 4) % 4;
                    DisplayDirection ();
                    break;
                    case "turn around":
                    currentDirection = (currentDirection + 2 + 4) % 4;
                    DisplayDirection ();
                    break;

                    default:
                    {
                        Console.WriteLine ("Invalid Command. Try again.");
                        continue;
                    }

                }
            }
        }

        static string CommandValidation ()
        {
            while (true)
            {
                string input = Console.ReadLine ();

                if (String.IsNullOrEmpty (input))
                    continue;

                input = input.Trim ();
                input = input.ToLower ();

                return input;
            }
        }

        static bool BoolValidation ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);

                string input = Console.ReadLine ();
                bool result;

                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            }
        }

        static void Ramp ()
        {
            string roomName = "Ramp";
            string roomDescription = "Up the ramp is the ship's only point of entry for a pilot. at the top of the ramp, there is a door leading to the rest of the ship.";
            //string south = "Hallway";

            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("The ramp has already closed. There's no going back now.");
                        break;
                        case Direction.South:
                        Hallway ();
                        return;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }

                }
            }
        }

        static void Hallway ()
        {
            string roomName = "Hallway";
            string roomDescription = "This is the hallway. there are three doors. One is the ramp, where you came from. the other two are not marked.";

            //north = "Ramp";
            //east = "Starboard Dorm";
            //south = "Garage";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Ramp ();
                        return;
                        case Direction.South:
                        Garage ();
                        return;
                        case Direction.East:
                        StarboardDorm ();
                        return;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }

                }
            }
        }
        static void StarboardDorm ()
        {
            string roomName = "Starboard Dorm";
            string roomDescription = "This is the Starboard Dormitory. This ship is supposed to have a crew. There are three beds and a few closets, but no other doors except for the way you came in. It's a dead end.";
            //string west = "Hallway";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        Hallway ();
                        return;
                    }

                }
            }
        }
        static void Garage ()
        {
            string roomName = "Garage";
            string roomDescription = "This is the garage. there are a couple of land vehicles in here, covered by tarps. There is a door marked \"Turret Access\", and the hallway leading out to the ramp. ";

            //string north = "Hallway";
            //string west = "Turret Access";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Hallway ();
                        return;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        TurretAccess ();
                        return;
                    }

                }
            }
        }
        static void TurretAccess ()
        {
            string roomName = "Turret Access";
            string roomDescription = "This is a small junction with everywhere to go. Up and down are locked latches, marked with a \'1\' and a \'2\'. " +
                "Besides that, there is an open way to the main area, a door leading to the Medical Bay, a door leading to the garage, and a door leading to the engine room.";

            //string north = "Main Hold";
            //string west = "Medical Bay";
            //string east = "Garage";
            //string south = "Engine Room";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        MainHold ();
                        return;
                        case Direction.South:
                        EngineRoom ();
                        return;
                        case Direction.East:
                        Garage ();
                        return;
                        case Direction.West:
                        MedicalBay ();
                        return;
                    }

                }
            }
        }
        static void EngineRoom ()
        {
            string roomName = "Engine Room";
            string roomDescription = "This is the engine room. it's a room with a big engine in it. dead end.";
            //string north = "Turret Access";

            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        TurretAccess ();
                        return;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }

                }
            }
        }
        static void MedicalBay ()
        {
            string roomName = "Medical Bay";
            string roomDescription = "This looks like it used to be a coat closet. it's small, and it has a single bed and a cabinet. dead end.";
            //string east = "Turret Access";

            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        TurretAccess ();
                        return;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }

                }
            }
        }
        static void MainHold ()
        {
            string roomName = "Main Hold";
            string roomDescription = "This is the Main Hold, there is a big planning table, some chairs, and a couch. There are two hallways, a door marked \"Storage\", and a door marked \"Turret Access\".";

            //string north = "Hallway 3";
            //string west = "Hallway 2";
            //string east = "Storage";
            //string south = "Turret Access";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        HallwayThree ();
                        return;
                        case Direction.South:
                        HallwayTwo ();
                        return;
                        case Direction.East:
                        Storage ();
                        return;
                        case Direction.West:
                        Storage ();
                        return;
                    }

                }
            }
        }
        static void HallwayTwo ()
        {
            string roomName = "Hallway 2";
            string roomDescription = "This is a hallway. there is an open way to the main area, and two unmarked doors";

            //string north = "Port Dorm";
            //string west = "Cargo Hold";
            //string east = "Main Hold";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();


            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        PortDorm ();
                        return;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        MainHold ();
                        return;
                        case Direction.West:
                        CargoHold ();
                        return;
                    }

                }
            }

        }
        static void CargoHold ()
        {
            string roomName = "Cargo Hold";
            string roomDescription = "This is a big room full of boxes. dead end.";

            //string east = "Hallway 2";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();

            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        HallwayTwo ();
                        return;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }

                }
            }
        }
        static void PortDorm ()
        {
            string roomName = "Port Dorm";
            string roomDescription = "This is the Port Dorm. it has three beds and a few closets. dead end.";

            //string south = "Hallway 2";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();
            
            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        HallwayTwo ();
                        return;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }
                }
            }
        }
        static void Storage ()
        {
            string roomName = "Storage";
            string roomDescription = "this is a storage closet. you've got some coats, some brooms, cleaning supplies, and that's about it. dead end.";

            //string west = "Main Hold";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();

            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        MainHold ();
                        return;
                    }
                }
            }
        }
        static void HallwayThree ()
        {
            string roomName = "Hallway 3";
            string roomDescription = "this is a hallway. there is an open way to the main hold, and two unmarked doors.";

            //string north = "Cockpit";
            //string east = "Communications";
            //string south = "Main Hold";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();

            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Cockpit ();
                        return;
                        case Direction.South:
                        MainHold ();
                        return;
                        case Direction.East:
                        Communications ();
                        return;
                        case Direction.West:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                    }
                }
            }
        }
        static void Communications ()
        {
            string roomName = "Communications";
            string roomDescription = "this is the comms room.there are a couple of computers with chairs, some fancy-looking radio equipment, and a mini-fridge. dead end.";
            //west = hallway 3

            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);
            DisplayDirection ();

            while (true)
            {
                Command command = CommandHandler ();
                Direction direction;
                if (command == Command.Quit)
                    return;
                else
                {
                    direction = MoveDirection (command);
                    switch (direction)
                    {
                        case Direction.North:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.South:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.East:
                        Console.WriteLine ("That is a wall. you cant walk into a wall.");
                        break;
                        case Direction.West:
                        HallwayThree ();
                        return;
                    }
                }
            }
        }

        static void Cockpit ()
        {
            string roomName = "Cockpit";
            string roomDescription = "This is the Cockpit. The Bridge. The Pilot's Station. there are four chairs, one of them clearly a pilot's chair." +
                " Directly ahead of you is the blackness of space. You sit down and fire up the controls. its lucky you got there in time.";
            //string south = "Hallway 3";
            Console.WriteLine ("------------------------" + roomName + "-----------------------");
            Console.WriteLine (roomDescription);

            Console.WriteLine ("");
            Console.WriteLine ("YOU WIN. GAME OVER");
            return;
        }
    }
}
