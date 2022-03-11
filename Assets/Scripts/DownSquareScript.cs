using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DownSquareScript : MonoBehaviour
{
    private SpriteRenderer _goSprite;
    [SerializeField]
    private ParticleSystem _particleSystem;

    [SerializeField]
    private Color _purpleColor;
    [SerializeField]
    private Color _greenColor;

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
        _goSprite = GetComponent<SpriteRenderer>();
        _goSprite.color = _purpleColor;
    }

    private void OnStartGame(bool isActivate)
    {
        if(isActivate)
        {
            Debug.Log("OnStart");
            StartCoroutine(ActivateSquare());
        }
    }

    private IEnumerator ActivateSquare()
    {
        float time = Random.Range(4f, 7f);
        StartCoroutine(UIAnimations.SpriteColorChange(_goSprite, _purpleColor, _greenColor, time));
        yield return new WaitForSeconds(time);
        isActivate = true;
        _particleSystem.Play();
        StartCoroutine(LifeSquare());
    }
    private IEnumerator LifeSquare()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(DisactivateSquare());
    }
    private IEnumerator DisactivateSquare()
    {
        isActivate = false;
        _particleSystem.Stop();
        float time = 0.5f;
        StartCoroutine(UIAnimations.SpriteColorChange(_goSprite, _purpleColor, _greenColor, time));
        yield return new WaitForSeconds(time);
        StartCoroutine(ActivateSquare());
    }

    public void OnMouseDown()
    {
        if(isActivate == true)
        {
            _scoreController.ScoreChange(100);
            StopAllCoroutines();
            StartCoroutine(DisactivateSquare());
        }
    }
}
