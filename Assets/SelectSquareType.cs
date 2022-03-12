using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSquareType : MonoBehaviour
{
    private SquareTypes _currentSquareType;
    private int scoresOnClick;
    public int ScoresOnClick => scoresOnClick;
    private Color32 color;
    private void Start()
    {
        int selectSquareType = Random.Range(0, 3);
        _currentSquareType = (SquareTypes)selectSquareType;
        SquareType.SquareProperty(_currentSquareType, out scoresOnClick, out color);
    }
}
