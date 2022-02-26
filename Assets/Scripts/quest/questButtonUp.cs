using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questButtonUp : MonoBehaviour
{
    //UI
    public Text EP;
    public Text XP;

    private bool isMoving;
    private Vector3 origPosition;
    private Vector3 targetPosition;
    float timeToMove = 0.2f;

    public questLeaderCard questlc;
    public questButtonDown questbd;
    public questButtonLeft questbl;
    public questButtonRight questbr;

    void OnMouseDown()
    {

        if(!isMoving)
        {
            moveUpArrow();
            questlc.moveLeaderUp();
            questbr.moveRightArrowUp();
            questbd.moveDownArrowUp();
            questbl.moveLeftArrowUp();
        }
    }

    public IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedTime = 0;

        origPosition = transform.position;
        targetPosition = origPosition + direction;

        while(elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPosition, targetPosition, (elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            EP.gameObject.SetActive(true);
            XP.gameObject.SetActive(true);
            yield return null;
        }
        transform.position = targetPosition;
        isMoving = false;
        EP.gameObject.SetActive(false);
        XP.gameObject.SetActive(false);
    }

    public void moveUpArrow()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }
    public void moveUpArrowRight()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }
    public void moveUpArrowDown()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }
    public void moveUpArrowLeft()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }

}
