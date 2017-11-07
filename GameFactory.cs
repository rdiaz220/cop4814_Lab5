using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        const string GAME_FILENAME = @"..\..\games.xml";
        List<Game> list = new List<Game>();

        public void CreateGameList()
        {
            //Game g = new Game("1", "2", 3, 4);
            //gameList.Add(g);

            Game g = new Game("Hornets", "Bulldogs", 10, 20);
            gameList.Add(g);
            g = new Game("Red", "Blue", 15, 5);
            gameList.Add(g);
            g = new Game("Disney", "Warners", 40, 35);
            gameList.Add(g);
            g = new Game("Mario", "Sonic", 50, 30);
            gameList.Add(g);

            serial = new XmlSerializer(gameList.GetType());
            serial.Serialize(sw, gameList);
            sw.Close();

            gameList = new List<Game>();
            StreamReader sr = new StreamReader(GAME_FILENAME);
            serial = new XmlSerializer(gameList.GetType());
            gameList = (List<Game>)serial.Deserialize(sr);
            sr.Close();
        }

        public List<Game> ReadGameList(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(GAME_FILENAME);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "success";
                return gameList;
            }
            catch(Exception ex)
            {
                resultMessage = "Exception thrown: " + ex.Message;
                return null;
            }
        }
    }
}
