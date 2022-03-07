using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text EP;
    public Text XP;
    public Text creditsLabel;

    public AudioSource playerMove;
    public questCredits credits;

    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask whatStopsMovement;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        playerMove = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveClassic();
    }

    public void moveClassic()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }

    IEnumerator textAppear(Text go, float delay)
    {
        go.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.gameObject.SetActive(false);
    }

    public void upButton()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, 1f, 0f), .2f, whatStopsMovement))
            {
                playerMove.Play();
                movePoint.position += new Vector3(0f, 1f, 0f);
                StartCoroutine(textAppear(EP, 0.2f));
                StartCoroutine(textAppear(XP, 0.2f));
                float creditValue = credits.creditsMaps1();
                creditsLabel.text = "+" + Mathf.Round(creditValue).ToString();
                player.credits += (int)creditValue;
                StartCoroutine(textAppear(creditsLabel, 0.2f));
                player.mapInProgress = true;
            }

        }
    }
    public void downButton()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, -1f, 0f), .2f, whatStopsMovement))
            {
                playerMove.Play();
                movePoint.position += new Vector3(0f, -1f, 0f);
                StartCoroutine(textAppear(EP, 0.2f));
                StartCoroutine(textAppear(XP, 0.2f));
                //float creditValue = randomInt(35, 78);
                //creditsLabel.text = "+" + Mathf.Round(creditValue).ToString();
                //player.credits += (int)creditValue;
                StartCoroutine(textAppear(creditsLabel, 0.2f));
                player.mapInProgress = true;
            }

        }
    }
    public void leftButton()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1f, 0f, 0f), .2f, whatStopsMovement))
            {
                playerMove.Play();
                movePoint.position += new Vector3(-1f, 0f, 0f);
                StartCoroutine(textAppear(EP, 0.2f));
                StartCoroutine(textAppear(XP, 0.2f));
                //float creditValue = randomInt(35, 78);
                //creditsLabel.text = "+" + Mathf.Round(creditValue).ToString();
                //player.credits += (int)creditValue;
                StartCoroutine(textAppear(creditsLabel, 0.2f));
                player.mapInProgress = true;
            }

        }
    }

    public void rightButton()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(1f, 0f, 0f), .2f, whatStopsMovement))
            {
                playerMove.Play();
                movePoint.position += new Vector3(1f, 0f, 0f);
                StartCoroutine(textAppear(EP, 0.2f));
                StartCoroutine(textAppear(XP, 0.2f));
                ///float creditValue = randomInt(35, 78);
               // creditsLabel.text = "+" + Mathf.Round(creditValue).ToString();
                //player.credits += (int)creditValue;
                StartCoroutine(textAppear(creditsLabel, 0.2f));
                player.mapInProgress = true;
            }
        }
    }
}
