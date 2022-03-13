using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSqure : MonoBehaviour
{
    [SerializeField]
    private MoveSinusoid _moveSinusoid;
    [SerializeField]
    private DestroyOnFinish _destroyOnFinish;

    public void Initialize(DirectionOfMovement direction, Vector2 startPositon, Vector2 finishPosition)
    {
        _moveSinusoid.Initialize(direction);
        _destroyOnFinish.Initialize(finishPosition, direction);
    }
}
