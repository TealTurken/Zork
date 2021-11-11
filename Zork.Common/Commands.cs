namespace Zork.Common
{
    public enum Commands
    {
        HELP,
        SCORE,
        REWARD,
        QUIT,
        LOOK,
        UNKNOWN,
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public enum Directions
    {
        NORTH = Commands.NORTH,
        SOUTH = Commands.SOUTH,
        EAST = Commands.EAST,
        WEST = Commands.WEST
    }
}