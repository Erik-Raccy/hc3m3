using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    public class FileReader
    {
        List<string> gamelist = new List<string>();
        public FileReader()
        {
            getGames();
            getGameInfo("LoL");
        }
        public List<string> getGames()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("games.txt");
            while ((line = file.ReadLine()) != null)
            {
                gamelist.Add(line);
                //Console.WriteLine(line);
            }
            file.Close();
            return gamelist;
        }

        public List<string> getGamesList()
        {
        return gamelist;
        }

        public void setGameList(List <string> game)
        {
            gamelist=game;
        }

        
        public List<List<string>> getGameInfo(String gameName)
        {
            List<List<string>> game = new List<List<string>>();
            string line;
            game.Add(new List<string>());//initial line for the name
            game[0].Add(gameName); //saves the game name
            int category=0;

            System.IO.StreamReader file = new System.IO.StreamReader(gameName+".txt");
            while ((line=file.ReadLine()) != null)
            {//name,description,specs,play history, 
                if(line!="~")//squiggly will seperate each category
                {
                    game[category].Add(line);//adds info to name
                }
                else//squiggly means category is done
                {
                    category++;//next category
                    game.Add(new List<string>());//extends array
                }
                
            }

           // for (int i = 0; game.Count() > i; i++)
           // {
             //   for (int j = 0; game[i].Count() > j; j++)
              //  {
              //      Console.WriteLine(game[i][j]);
              //  }
             //   Console.WriteLine("Property " + i + " done");
         //   }
                return game;
        }

    }
}
