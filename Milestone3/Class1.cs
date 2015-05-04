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
        List<string> genrelist = new List<String>();

        public FileReader()
        {
            getGames();
            getGenres();
        }

        public List<string> getGames()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("games.txt");
            while ((line = file.ReadLine()) != null)
            {
                gamelist.Add(line);
            }
            file.Close();
            return gamelist;
        }

        public List<string> getGenres()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("genres.txt");
            while ((line = file.ReadLine()) != null)
            {
                genrelist.Add(line);
            }
            file.Close();
            return genrelist;
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
            file.Close();
            return game;
        }

        public List<string> getGenreList()
        {
            return genrelist;
        }

        public void setGenre(String gameName, String newGenre)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(gameName+".txt");
            writer.WriteLine(newGenre);
            writer.Close();
            if (gameName != "")
            {
                System.Windows.Forms.MessageBox.Show("Genre has been changed!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please Enter a Game to change!");
            }
        }

        public String getGamesGenre(String gameName)
        {
            string line;
           try
           {
                System.IO.StreamReader file = new System.IO.StreamReader(gameName + ".txt");
                line = file.ReadLine();
                file.Close();
                return line;
            }
            catch (System.IO.FileNotFoundException)
            {
                return null;
            }
        }

        public void addGame(String gameName)
        {
            if (System.IO.File.Exists(gameName + ".txt") && gameName != "")
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("games.txt", true);
                writer.WriteLine(gameName);
                writer.Close();
                System.Windows.Forms.MessageBox.Show("Success!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: Cannot find file. Did you name it correctly?");
            }
        }

    }
}
