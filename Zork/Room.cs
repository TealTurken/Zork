namespace Zork
// Room class accessed via object-oriented programming
{

    public class Room
    {
        public string Name { get; } // allows outside programs to read this data

        public string Description { get; set; } // set allows outside program to write to this data. Assign name.

        /* public Room pulls the room names and descriptions from Program.cs
            and assigns them to each room and description here. 
            */
        public Room(string name, string description = "") // a Constructor. This process is run when you call on it in Program.cs
                                                          // supplying description with a value or NULL here makes the description optional.
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name; // ensure you don't get Room.Zork when calling currentRoom in Program.cs
    }
}