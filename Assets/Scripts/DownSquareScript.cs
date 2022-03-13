using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DownSquareScript : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private ParticleSystem _particleSystem;

    [SerializeField]
    private Color _purpleColor;
    [SerializeField]
    private Color _greenColor;

    private int scoresOnClick;
    public int ScoresOnClick => scoresOnClick;

    private ScoreController _scoreController;

    private bool isActivate;

    private void OnEnable()
    {
        GlobalTouchController.StartGame += OnStartGame;
    }
    private void OnDisable()
    {
        GlobalTouchController.StartGame -= OnStartGame;
    }

    private void Start()
    {
        _scoreController = FindObjectOfType<ScoreController>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = _purpleColor;
    }

    private void OnStartGame(bool isActivate)
    {
        if(isActivate)
        {
            StartCoroutine(ActivateSquare());
        }
        else
        {
            StopAllCoroutines();
            DisactivateSquare(out float time);
        }
    }

    private IEnumerator ActivateSquare()
    {
        float time = Random.Range(4f, 7f);
        StartCoroutine(UIAnimations.SpriteColorChange(_spriteRenderer, _purpleColor, _greenColor, time));
        yield return new WaitForSeconds(time);
        isActivate = true;
        _particleSystem.Play();
        StartCoroutine(LifeSquare());
    }
    private IEnumerator LifeSquare()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(DisactivateTimer());
    }
    private IEnumerator DisactivateTimer()
    {
       DisactivateSquare(out float time);
        yield return new WaitForSeconds(time);
        StartCoroutine(ActivateSquare());
    }
    private void DisactivateSquare(out float time)
    {
        isActivate = false;
        _particleSystem.Stop();
        time = 0.5f;
        StartCoroutine(UIAnimations.SpriteColorChange(_spriteRenderer, _purpleColor, _greenColor, time));
    }

    private void OnMouseDown()
    {
        if(isActivate == true)
        {
            _scoreController.ScoreChange(100);
            StopAllCoroutines();
            StartCoroutine(DisactivateTimer());
        }
    }
}
