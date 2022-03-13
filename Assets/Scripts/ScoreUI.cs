using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreCountTxt;
    private void OnEnable()
    {
        ScoreController.ScoreChangedEvent += UpdateScoreCount;
    }
    private void OnDisable()
    {
        ScoreController.ScoreChangedEvent -= UpdateScoreCount;
    }

    private void UpdateScoreCount(int newScore)
    {
        _scoreCountTxt.text = newScore.ToString();
    }
}
