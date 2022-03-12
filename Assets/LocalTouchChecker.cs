using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[RequireComponent(typeof(SelectSquareType))]
public class LocalTouchChecker : MonoBehaviour
{
    public event Action IsClick;

    private SelectSquareType _selectSquareType;
    private int _scoresOnClick;

    private ScoreController _scoreController;

    private void Start()
    {
        _selectSquareType = GetComponent<SelectSquareType>();
        _scoresOnClick = _selectSquareType.ScoresOnClick;
    }
    public void OnMouseDown()
    {
        _scoreController.ScoreChange(100);
        StopAllCoroutines();
    }
}
