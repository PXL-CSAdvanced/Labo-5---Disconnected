using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MonsterClassLibrary.Entities;

namespace MonsterClassLibrary.DataAccess
{
    public static class MonsterData
    {
        private static DataSet _monsterDataSet = new DataSet("Labo-5");
        private static DataTable _monsterDataTable;
        public static DataTable MonsterDataTable { get { return _monsterDataTable; } }
        private static DataTable _tierDataTable;

        private static Random _randomizer = new Random();

        static MonsterData()
        {
            CreateMonsterDataTable();
            CreateTierDataTable();
            FillTierDataTable();

            _monsterDataSet.Tables.Add(_monsterDataTable);
            _monsterDataSet.Tables.Add(_tierDataTable);
        }


        private static void CreateMonsterDataTable()
        {
            // throw new NotImplementedException();
            
            _monsterDataTable = new DataTable("Monsters");
            DataColumn dcId = new DataColumn("Id", typeof(int));
            _monsterDataTable.Columns.Add(dcId);
            _monsterDataTable.Columns.Add("Name", typeof(string));
            _monsterDataTable.Columns.Add("Tier", typeof(string));
            _monsterDataTable.Columns.Add("BaseHealth", typeof(int));
            _monsterDataTable.Columns.Add("BasePower", typeof(int));

            UniqueConstraint unique = new UniqueConstraint(dcId);
            _monsterDataTable.Constraints.Add(unique);
            _monsterDataTable.PrimaryKey = new DataColumn[] { dcId };
        }

        private static void CreateTierDataTable()
        {
            // throw new NotImplementedException();

            _tierDataTable = new DataTable("Tiers");
            DataColumn dcName = new DataColumn("Name", typeof(string));
            _tierDataTable.Columns.Add(dcName);
            _tierDataTable.Columns.Add("Modifier", typeof(double));
            
            _tierDataTable.PrimaryKey = new DataColumn[] {dcName};
        }
        
        private static void FillTierDataTable()
        {
            string[] tiers = { "Baby", "Battle", "Adult", "Ancient", "Astral", "Godlike", "Transcendental", "Meta Infinite" };
            double[] modifiers = { 1, 1.2, 1.5, 2, 3, 10, 20, 1000 };

            for (int i = 0; i < tiers.Length; i++)
            {
                _tierDataTable.Rows.Add(tiers[i], modifiers[i]);
            }
        }

        public static void AddRandomMonster() 
        {
            Monster randomMonster = MonsterGenerateRandomMonster();
            // TODO: Voeg het willekeurige monster toe aan _monsterDataTable

            _monsterDataTable.Rows.Add(randomMonster.Id, randomMonster.Name, randomMonster.Tier,
                randomMonster.BaseHealth, randomMonster.BasePower);
        }

        public static void ClearAllMonsters()
        {
            _monsterDataTable.Rows.Clear();
        }

        private static Monster MonsterGenerateRandomMonster()
        {
            string[] names = { "Vampire", "Werewolf", "Zombie", "Dragon", "Goblin", "Troll", "Demon", "Couatl" };
            List<Tier> tiers = _tierDataTable.AsEnumerable().Select(x => new Tier(x)).ToList();
            Monster randomMonster = new Monster(
                _monsterDataTable.Rows.Count + 1,
                names[_randomizer.Next(names.Length)],
                tiers[_randomizer.Next(tiers.Count)].Name,
                _randomizer.Next(10, 100),
                _randomizer.Next(10, 100));
            return randomMonster;
        }

        public static void ImportFromXML(string fileName)
        {
            _monsterDataSet.Clear();
            _monsterDataSet.ReadXml(fileName);
        }

        public static void ExportToXML(string fileName)
        {
            _monsterDataSet.WriteXml(fileName);
        }
    }
}
