using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SquareType
{
    public static void SquareProperty(SquareTypes squareTypes, out int scoresOnClick, out Color32 color)
    {
        scoresOnClick = 0;
        color = new Color32(254, 1, 1, 255);
        switch (squareTypes)
        {
            case SquareTypes.LightGreen:
                color = new Color32(254, 83, 255, 255);
                scoresOnClick = 100;
                break;
            case SquareTypes.Orange:
                color = new Color32(254, 209, 1, 255);
                scoresOnClick = 200;
                break;
            case SquareTypes.Red:
                color = new Color32(254, 1, 1, 255);
                scoresOnClick = -300;
                break;
        }
    }
}
public enum SquareTypes
{
    LightGreen,
    Orange,
    Red
}
