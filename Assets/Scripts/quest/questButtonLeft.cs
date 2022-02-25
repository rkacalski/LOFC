using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questButtonLeft : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPosition;
    private Vector3 targetPosition;
    float timeToMove = 0.2f;

    public questLeaderCard questlc;
    public questButtonDown questbd;
    public questButtonRight questbr;
    public questButtonUp questup;

    void OnMouseDown()
    {

        if (!isMoving)
        {
            moveLeftArrow();
            questlc.moveLeaderLeft();
            questup.moveUpArrowLeft();
            questbd.moveDownArrowLeft();
            questbr.moveRightArrowLeft();
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

    public void moveLeftArrow()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }
    public void moveLeftArrowUp()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }
    public void moveLeftArrowDown()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }
    public void moveLeftArrowRight()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }
}
