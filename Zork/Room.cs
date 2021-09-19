namespace Zork
// Room class accessed via object-oriented programming
{

    public class Room
    {
        public string Name { get; }

        public string Description { get; set; }

        /* public Room pulls the room names and descriptions from Program.cs
            and assigns them to each room and description here. 
            */
        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name; // ensure you don't get Room.Zork when calling currentRoom in Program.cs
    }
}