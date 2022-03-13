using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSinusoid : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public void Initialize(DirectionOfMovement directionOfMovement)
    {
        rigidbody = GetComponent<Rigidbody2D>();
        float time = Random.Range(4, 7);
        StartCoroutine(WaveLerp(directionOfMovement));
        StartCoroutine(AddForce(time));
    }
    private IEnumerator WaveLerp(DirectionOfMovement directionOfMovement)
    {
        if(directionOfMovement == DirectionOfMovement.LeftToRight)
        {
            rigidbody.AddForce(Vector2.right * 50);
        }
        else if(directionOfMovement == DirectionOfMovement.RightToLeft)
        {
            rigidbody.AddForce(Vector2.left * 50);
        }
        yield return new WaitForSeconds(1);
    }
    private IEnumerator AddForce(float time)
    {;
        rigidbody.AddForce( new Vector2(0, Random.Range(-20, 20)));
        yield return new WaitForSeconds (1);
        StartCoroutine(AddForce(time));
    }
}
