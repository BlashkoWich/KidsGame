using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static event Action<int> ScoreChangedEvent;

    private int _currentScore;

    private void Start()
    {
        ScoreChangedEvent?.Invoke(0);
    }
    public void ScoreChange(int newScore)
    {
        _currentScore += newScore;
        if(_currentScore < 0)
        {
            _currentScore = 0;
        }
        ScoreChangedEvent?.Invoke(_currentScore);
    }
}
