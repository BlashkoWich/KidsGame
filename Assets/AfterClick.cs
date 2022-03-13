using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LocalTouchChecker))]
public class AfterClick : MonoBehaviour
{
    [SerializeField]
    private LocalTouchChecker _localTouchChecker;
    
    [SerializeField] private Color _finishColor;

    private BoxCollider2D collider2D;

    private int _scoresOnClick;

    private SelectSquareType _selectSquareType;
    private ScoreController _scoreController;
    private SpriteRenderer _spriteRenderer;
    private void OnEnable()
    {
        _localTouchChecker.IsClick += IsClick;
    }
    private void OnDisable()
    {
        _localTouchChecker.IsClick -= IsClick;
    }
    private void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _scoreController = FindObjectOfType<ScoreController>();
        _selectSquareType = GetComponent<SelectSquareType>();
        _scoresOnClick = _selectSquareType.ScoresOnClick;
    }
    
    private void IsClick()
    {
        collider2D.enabled = false;
        _scoreController.ScoreChange(_scoresOnClick);
        StartCoroutine(UIAnimations.SpriteColorChange(_spriteRenderer, _spriteRenderer.color, _finishColor, 1));
        DestroyGameObject();
    }

    private void DestroyGameObject()
    {
        Destroy(gameObject, 1);
    }
}
