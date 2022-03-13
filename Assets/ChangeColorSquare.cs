using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorSquare : MonoBehaviour
{
    private SelectSquareType _selectSquareType;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _selectSquareType = GetComponent<SelectSquareType>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeColor(_selectSquareType.FinishColor);
    }

    private void ChangeColor(Color finishColor)
    {
        _spriteRenderer.color = finishColor;
    }
}
