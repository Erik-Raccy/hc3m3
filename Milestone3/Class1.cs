using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    public class FileReader
    {
        List<List<string>> game = new List<List<string>>();

        public List<List<string>> getGameInfo(String gameName)
        {   string line;
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
            return game;
        }

    }
}
