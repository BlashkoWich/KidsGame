using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LocalTouchChecker))]
public class AfterClick : MonoBehaviour
{
    private LocalTouchChecker _localTouchChecker;
    
    [SerializeField] private Color _finishColor;
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
        _localTouchChecker = GetComponent<LocalTouchChecker>();
    }
    
    private void IsClick()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(UIAnimations.SpriteColorChange(spriteRenderer, spriteRenderer.color, _finishColor, 1));
        DestroyGameObject();
    }

    private void DestroyGameObject()
    {
        Destroy(gameObject, 1);
    }
}
