using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFinish : MonoBehaviour
{
    private float finishPosition;
    private DirectionOfMovement direction;
    public void Initialize(Vector3 finish, DirectionOfMovement directionOfMovement)
    {
        finishPosition = finish.x;
        direction = directionOfMovement;
    }

    private void Update()
    {
        DestroyGameOnject();
    }
    private void DestroyGameOnject()
    {
        if(direction == DirectionOfMovement.LeftToRight && transform.position.x >= finishPosition + 3)
        {
            Destroy(gameObject);
        }
        else if(direction == DirectionOfMovement.RightToLeft && transform.position.x <= finishPosition - 3)
        {
            Destroy(gameObject);
        }
    }
}
