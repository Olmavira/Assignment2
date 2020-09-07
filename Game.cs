using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace Assignment2
{

    public class Game<T> where T : IPlayer
    {
        private List<T> _players;

        public Game(List<T> players)
        {
            _players = players;
        }

        public T[] GetTop10Players()
        {
            T[] topPlayers = new T[10];
            Console.WriteLine("Top Players:");
            //topPlayers[0]= slayer;
            _players.Sort();
            int j = 0;
            for (int i = _players.Count - 1; j < 10; j++, i--)
            {
                topPlayers[j] = _players[i];
            }

            foreach (T player in topPlayers)
            {
                Console.WriteLine(player.Score);
            }
            return topPlayers;
        }
    }
}

