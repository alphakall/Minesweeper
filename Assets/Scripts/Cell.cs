using UnityEngine;

public struct Cell
{
    public enum Type
    {   Invalid,                //should be 1st so by dfalt its invalid
        Empty,
        Mine,
        Number,
    }
    public Vector3Int position;
    public Type type;
    public int number;
    public bool revealed;
    public bool flagged;
    public bool exploded;
}
