using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Static {

    public static int score = 0;

    public static int highscore = 0;

    public static void SetHighscore(int score)
    {
        highscore = score;
    }

    public static int GetHighscore()
    {
        return highscore;
    }
}
