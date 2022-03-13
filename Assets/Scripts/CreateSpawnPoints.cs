using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpawnPoints : MonoBehaviour
{
    private Vector2 bottomLeft;
    public Vector2 BottomLeft => bottomLeft;
    private Vector2 bottomRight;
    public Vector2 BottomRight => bottomRight;
    private Vector2 topLeft;
    public Vector2 TopLeft => topLeft;
    private Vector2 topRight;
    public Vector2 TopRight => topRight;

    private void Start()
    {
        CalculateScreenBorder();
    }
    private void CalculateScreenBorder()
    {
        Camera camera = Camera.main;
        float width = camera.pixelWidth;
        float height = camera.pixelHeight;

        bottomLeft = camera.ScreenToWorldPoint(new Vector2 (0, 0));
        bottomLeft -= new Vector2(0, -3);
        bottomRight = camera.ScreenToWorldPoint(new Vector2 (width, 0));
        bottomRight -= new Vector2(0, -3);
        topLeft = camera.ScreenToWorldPoint(new Vector2 (0, height));
        topRight = camera.ScreenToWorldPoint(new Vector2 (width, height));

    }
}
