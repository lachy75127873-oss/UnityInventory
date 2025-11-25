
[System.Serializable]
public class PlayerData
{
    public PlayerData(string _name, string _rank, string _description, int _level , int _exp, int _gold)
    {
         name = _name;
         rank = _rank;
         description = _description;
         level = _level;
         exp = _exp;
         gold = _gold;
    }

    public string name;
    public string rank;
    public string description;
    public int level;
    public int exp;
    public int gold;
}
