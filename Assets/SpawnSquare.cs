using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CreateSpawnPoints))]
public class SpawnSquare : MonoBehaviour
{
    private CreateSpawnPoints _createSpawnPoints;
    [SerializeField]
    private GameObject _squarePrefab;

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
        _createSpawnPoints = GetComponent<CreateSpawnPoints>();
    }

    private void OnStartGame(bool isActivate)
    {
        if(isActivate == true)
        {
            
        }
    }
    private IEnumerator Spawn()
    {
        float yPos = default;
        float xPos = default;


        int randomBorder = Random.Range(0, 2);
        DirectionOfMovement moveDirection = (DirectionOfMovement)randomBorder;
        if(moveDirection == DirectionOfMovement.LeftToRight)
        {
           yPos = Random.Range(_createSpawnPoints.TopLeft.y, _createSpawnPoints.BottomLeft.y);
           xPos = _createSpawnPoints.BottomLeft.x - 1;
        }
        else if(moveDirection == DirectionOfMovement.RightToLeft)
        {
            yPos = Random.Range(_createSpawnPoints.TopRight.y, _createSpawnPoints.BottomRight.y);
            xPos = _createSpawnPoints.BottomRight.x + 1;
        }
        Instantiate(_squarePrefab, new Vector2(xPos, yPos), Quaternion.identity);

        yield return new WaitForSeconds(3);
    }
}
