using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questLeaderCard : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPosition;
    private Vector3 targetPosition;
    float timeToMove = 0.2f;

    public IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedTime = 0;

        origPosition = transform.position;
        targetPosition = origPosition + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPosition, targetPosition, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false;
    }

    public void moveLeaderUp()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }
    public void moveLeaderDown()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }
    public void moveLeaderLeft()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }
    public void moveLeaderRight()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }
}
