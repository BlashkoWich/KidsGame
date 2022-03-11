using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSinusoid : MonoBehaviour
{
    private Vector2 WaveLerp(Vector2 a, Vector2 b)
    {
        float time = Random.Range(3f, 6f);
        float smooth = 0.5f;
        float freq = 1f;
        float waveScale = 1f;
 
        if (time <= smooth)
        {
            waveScale *= time / smooth;
        }
        else if (time > 1f - smooth)
        {
            waveScale *= (1f - time) / smooth;
        }
 
 
        Vector2 result = Vector2.Lerp(a, b, time);
 
        Vector2 dir = (b - a).normalized;
        Vector2 leftNormal = result + new Vector2(-dir.y, dir.x) * waveScale;
 
        result = Vector2.LerpUnclamped(result, leftNormal, Mathf.Sin(time * freq));
 
        return result;
    }
}
