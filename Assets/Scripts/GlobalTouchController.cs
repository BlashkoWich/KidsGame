using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalTouchController : MonoBehaviour
{
    public static event Action<bool> StartGame;

    [SerializeField]
    private TextMeshProUGUI _touchScreenTxt;
    [SerializeField]
    private Image _startPanel;

    private bool isStart;

    private void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButtonDown(0) && isStart == false)
        {
            GlobalTouch();
        }
    }
    private void GlobalTouch()
    {
        isStart = true;
        StartGame?.Invoke(true);
        
        StartCoroutine(UIAnimations.TextInvisible(_touchScreenTxt));
        _startPanel.color = new Color(_startPanel.color.r, _startPanel.color.g, _startPanel.color.b, 0);
    }
}
