namespace MonsterClassLibrary.Entities
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tier { get; set; }
        public int BaseHealth { get; set; }
        public int BasePower { get; set; }

        public Monster(int id, string name, string tier, int baseHealth, int basePower)
        {
            Id = id;
            Name = name;
            Tier = tier;
            BaseHealth = baseHealth;
            BasePower = basePower;
        }
    }
}
