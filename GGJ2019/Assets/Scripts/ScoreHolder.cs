using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreHolder 
{
    public static float no1 = 0;
    public static float no2 = 0;
    public static float no3 = 0;
    public static float thisRound;

    public static string endingMsg = "";


    public static void SetScore(float score)
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

    public static string GetThisRoundScore()
    {
        return thisRound.ToString();
    }

    public static float GetNo1Score()
    {
        return no1;
    }

    public static float GetNo2Score()
    {
        return no2;
    }

    public static float GetNo3Score()
    {
        return no3;
    }

    public static void SetEndingMsg(string msg)
    {
        endingMsg = msg;
    }

    public static string GetEndingMsg()
    {
        return endingMsg;
    }
}
