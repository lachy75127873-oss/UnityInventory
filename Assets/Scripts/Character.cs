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

    private int atk;
    private int def;
    private int hp;
    private int mp;
    private int speed;
    
    public string Name { get => name; set => name = value; }
    public string Rank { get => rank; set => rank = value; }
    public string Description { get => description; set => description = value; }
    public int Level { get => level; set => level = value; }
    public int Exp { get => exp; set => exp = value; }
    public int Gold { get => gold; set => gold = value; }
    
    public int Atk { get => atk; set => atk = value; }
    public int Def { get => def; set => def = value; }
    public int HP { get => hp; set => hp = value; }
    public int MP { get => mp; set => mp = value; }
    public int Speed { get => speed; set => speed = value; }
    
}
