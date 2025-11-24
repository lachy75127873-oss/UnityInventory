using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string name;
    private string rank;
    private string description;
    private int level;
    private int exp;
    private int gold;
    
    public string Name { get => name; set => name = value; }
    public string Rank { get => rank; set => rank = value; }
    public string Description { get => description; set => description = value; }
    public int Level { get => level; set => level = value; }
    public int Exp { get => exp; set => exp = value; }
    public int Gold { get => gold; set => gold = value; }
    
}
