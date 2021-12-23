using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDeserializationLib
{
    [Serializable]
    public class PlayerData
    {
        public string playerName;
        public int stage;
        public int coin;

        public PlayerData() { }

        public PlayerData(string playerName, int stage, int coin)
        {
            this.playerName = playerName;
            this.stage = stage;
            this.coin = coin;
        }

        public void InputData()
        {
            Console.Write("Enter player name: ");
            playerName = Console.ReadLine();
            Console.Write("Enter player stage: ");
            stage = int.Parse(Console.ReadLine());
            Console.Write("Enter player coin: ");
            coin = int.Parse(Console.ReadLine());
        }

        public void ShowData()
        {
            Console.WriteLine(playerName);
            Console.WriteLine(stage);
            Console.WriteLine(coin);
        }
    }
}
