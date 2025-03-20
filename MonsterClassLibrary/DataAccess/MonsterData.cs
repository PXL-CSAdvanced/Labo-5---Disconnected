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
        private static DataSet _monsterDataSet = new DataSet();
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
            throw new NotImplementedException();
        }

        private static void CreateTierDataTable()
        {
            throw new NotImplementedException();
        }
        
        private static void FillTierDataTable()
        {
            string[] tiers = { "Baby", "Battle", "Adult", "Ancient", "Astral", "Godlike", "Transcendental", "Meta Infinite" };
            double[] modifiers = { 1, 1.2, 1.5, 2, 3, 10, 20, 1000 };
            throw new NotImplementedException();
            // TODO voeg een moster toe aan de DataTable
        }

        public static void AddRandomMonster() 
        {
            Monster randomMonster = MonsterGenerateRandomMonster();
            // TODO: Voeg het willekeurige monster toe aan _monsterDataTable

        }

        public static void ClearAllMonsters()
        {
            // TODO: alle monsters verwijderen
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
            throw new NotImplementedException();
        }

        public static void ExportToXML(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
