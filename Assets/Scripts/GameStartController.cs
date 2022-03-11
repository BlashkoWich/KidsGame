using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStartController : MonoBehaviour
{
    [SerializeField]
    private GlobalTouchController _globalTouchController;

    [SerializeField]
    private TextMeshProUGUI[] _gameStartTexts;

    [SerializeField]
    private GameObject _scoreCount;

    private void OnEnable()
    {
        GlobalTouchController.StartGame += OnStartGame;
    }
    private void OnDisable()
    {
        GlobalTouchController.StartGame -= OnStartGame;
    }

    private void OnStartGame(bool isActivate)
    {
        if(isActivate == true)
        {
            foreach (var text in _gameStartTexts)
            {
                UIAnimations.TextVisible(text);
            }
        }
    }
}
