using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSqure : MonoBehaviour
{
    private MoveSinusoid _moveSinusoid;
    private DestroyOnFinish _destroyOnFinish;
    private void Start()
    {
        _moveSinusoid = GetComponent<MoveSinusoid>();
        _destroyOnFinish = GetComponent<DestroyOnFinish>();
    }

    public void Initialize(DirectionOfMovement direction, Vector2 startPositon, Vector2 finishPosition)
    {
        _moveSinusoid.Initialize(startPositon, finishPosition);
        _destroyOnFinish.Initialize(finishPosition, direction);
    }
}
