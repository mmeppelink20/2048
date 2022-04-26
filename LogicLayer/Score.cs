using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataObjects;

namespace LogicLayer
{
    public class Score
    {

        private ScoreAccessor _scoreAccessor = new ScoreAccessor();
        private GameBoardData _gameBoardData = new GameBoardData();

        public bool SavePlayerScore(int Score)
        {
            bool result = false; // change to true if successful


            if (Score > RestoreSavedScore())
            {
                try
                {
                    result = _scoreAccessor.SaveHighScore(Score);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("There was a problem saving your game.", ex);
                }
            }
            else
            {
                result = true;
            }

            // invoke ScoreAccesor 

            return result;
        }


        public bool SetScoreZero(int Score, int one)
        {
            bool result = false; // change to true if successful

            try
            {
                result = _scoreAccessor.SaveHighScore(Score);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was a problem saving your game.", ex);
            }

            // invoke ScoreAccesor 

            return result;
        }

        public int RestoreSavedScore()
        {
            int amount = 500; // what to use if restore fails

            try
            {
                amount = _scoreAccessor.RestoreHighScore();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was a problem restoring your game.", ex);
            }

            // invoke ScoreAccesor 

            return amount;
        }
    }
}
