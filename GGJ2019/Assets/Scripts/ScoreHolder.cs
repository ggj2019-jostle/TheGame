using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    public int no1 = 0;
    public int no2 = 0;
    public int no3 = 0;
    public int thisRound;

    public void SetScore(int score)
    {
        thisRound = score;
        if (score > no3)
        {
            if (score > no2)
            {
                if (score > no1)
                {
                    no3 = no2;
                    no2 = no1;
                    no1 = score;
                }
                else
                {
                    no3 = no2;
                    no2 = score;
                }
            }
            else
            {
                no3 = score;
            }
        }

    }

    public int GetThisRoundScore()
    {
        return thisRound;
    }

    public int GetNo1Score()
    {
        return no1;
    }

    public int GetNo2Score()
    {
        return no2;
    }

    public int GetNo3Score()
    {
        return no3;
    }
}
