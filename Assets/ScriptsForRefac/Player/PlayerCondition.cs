using System.Collections.Generic;

public class PlayerCondition
{
    public Dictionary<string, int> conditions = new ();

    public PlayerCondition()
    {
        conditions =  new Dictionary<string, int>();
    }

    public void SetStat(string key, int value)
    {
        if (conditions.ContainsKey(key)) conditions[key] = value;
        else conditions.Add(key, value);
    }
}

