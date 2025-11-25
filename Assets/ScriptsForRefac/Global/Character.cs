using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; protected set; }
    public string Rank { get; protected set; }
    public string Description { get; protected set; }
    public int Level { get; protected set; }
    public int Exp { get; protected set; }
    public int Gold { get; protected set; }

    public int Atk { get; protected set; }
    public int Def { get; protected set; }
    public int HP { get; protected set; }
    public int MP { get; protected set; }
    public int Speed { get; protected set; }
}