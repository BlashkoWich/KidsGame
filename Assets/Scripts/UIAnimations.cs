using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class UIAnimations
{
    public static IEnumerator TextInvisible(TextMeshProUGUI textMesh) 
    {
        Color prozr = textMesh.faceColor;
        for (float f = 1f; f >= 0; f -= 0.001f) 
        {
            prozr.a = f;
            textMesh.faceColor = prozr;
            yield return new WaitForEndOfFrame();
        }
    }  
    public static IEnumerator TextVisible(TextMeshProUGUI textMesh) 
    {
        Color prozr = textMesh.faceColor;
        for (float f = 0f; f <= 1; f += 0.001f) 
        {
            prozr.a = f;
            textMesh.faceColor = prozr;
            yield return new WaitForEndOfFrame();
        }
    }

    public static IEnumerator SpriteColorChange(SpriteRenderer spriteRenderer, Color startColor, Color finishColor, float time)
    {
        spriteRenderer.color = startColor;
        for (float i = 0; i < time; i += 0.02f)
        {
            spriteRenderer.color = Color.Lerp(startColor, finishColor, i/time);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
