using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questButtonRight : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPosition;
    private Vector3 targetPosition;
    float timeToMove = 0.2f;

    public questLeaderCard questlc;
    public questButtonDown questbd;
    public questButtonLeft questbl;
    public questButtonUp questup;

    void OnMouseDown()
    {

        if (!isMoving)
        {
            moveRightArrow();
            questlc.moveLeaderRight();
            questup.moveUpArrowRight();
            questbd.moveDownArrowRight();
            questbl.moveLeftArrowRight();
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

    public void moveRightArrow()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }
    public void moveRightArrowUp()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }
    public void moveRightArrowDown()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }
    public void moveRightArrowLeft()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }
}
