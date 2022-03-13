using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[RequireComponent(typeof(SelectSquareType))]
public class LocalTouchChecker : MonoBehaviour
{
    public event Action IsClick;

    public void OnMouseDown()
    {
        IsClick?.Invoke();
    }
}
