using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;


namespace DataAccessLayer
{
    public class ScoreAccessor
    {
        public bool SaveHighScore(int amount)
        {
            bool result = false;
            string dataPath = AppData.DataPath + "\\" + "highscore.txt";
            FileStream scoreFile = null;
            StreamWriter writer = null;

            try
            {
                scoreFile = new FileStream(dataPath, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(scoreFile);
                string line = amount.ToString();
                writer.WriteLine(line);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
            }
            return result;
        }

        public int RestoreHighScore()
        {

            int score = 0;
            string dataPath = AppData.DataPath + "\\" + "highscore.txt";
            FileStream scoreFile = null;
            StreamReader reader = null;

            try
            {
                scoreFile = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(scoreFile);
                string line = reader.ReadLine();
                line = line.Trim();
                score = int.Parse(line);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }

            return score;
        }
    }
}
