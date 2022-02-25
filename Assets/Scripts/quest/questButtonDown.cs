using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questButtonDown : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPosition;
    private Vector3 targetPosition;
    float timeToMove = 0.2f;

    public questLeaderCard questlc;
    public questButtonRight questbr;
    public questButtonLeft questbl;
    public questButtonUp questup;

    void OnMouseDown()
    {

        if (!isMoving)
        {
            moveDownArrow();
            questlc.moveLeaderDown();
            questup.moveUpArrowDown();
            questbr.moveRightArrowDown();
            questbl.moveLeftArrowDown();
        }
    }

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

    public void moveDownArrow()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }
    public void moveDownArrowUp()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }
    public void moveDownArrowRight()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }
    public void moveDownArrowLeft()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }
}
