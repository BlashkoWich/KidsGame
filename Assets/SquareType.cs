using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SquareType
{
    public static void SquareProperty(SquareTypes squareTypes, out int scoresOnClick, out Color color)
    {
        scoresOnClick = 0;
        color = new Color(254, 1, 1, 255);
        switch (squareTypes)
        {
            case SquareTypes.LightGreen:
                color = new Color(0.003921569f, 0.9960784f, 0.3254902f, 1);
                scoresOnClick = 100;
                break;
            case SquareTypes.Orange:
                color = new Color(0.9960784f, 0.5630357f, 0.003921567f, 1);
                scoresOnClick = 200;
                break;
            case SquareTypes.Red:
                color = new Color(0.9960784f, 0.003921569f, 0.003921569f, 1);
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
public enum DirectionOfMovement
{
    LeftToRight,
    RightToLeft
}
