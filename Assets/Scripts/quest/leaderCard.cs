using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderCard : MonoBehaviour
{
    public Text numBronzeContainers;
    public Text numSilverContainers;
    public Text numGoldContainers;
    public GameObject goalPoint;

    public AudioSource chestObtained;

    void Start()
    {
        chestObtained = GetComponent<AudioSource>();
        goalPoint.transform.localScale = Vector2.zero;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bronzeContainer")
        {
            chestObtained.Play();
            LeanTween.alpha(col.gameObject, 0f, 1f).setDelay(0.5f);
            LeanTween.rotateAround(col.gameObject, Vector3.up, 90f, 1.5f);
            player.numBronzeContainers += 1;
            numBronzeContainers.text = player.numBronzeContainers.ToString();
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());

        }
        if (col.gameObject.tag == "silverContainer")
        {
            chestObtained.Play();
            LeanTween.alpha(col.gameObject, 0f, 1f).setDelay(0.5f);
            LeanTween.rotateAround(col.gameObject, Vector3.up, 90f, 1.5f);
            player.numSilverContainers += 1;
            numSilverContainers.text = player.numSilverContainers.ToString();
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
        }
        if (col.gameObject.tag == "goldContainer")
        {
            chestObtained.Play();
            LeanTween.alpha(col.gameObject, 0f, 1f).setDelay(0.5f);
            LeanTween.rotateAround(col.gameObject, Vector3.up, 90f, 1.5f);
            player.numGoldContainers += 1;
            numGoldContainers.text = player.numGoldContainers.ToString();
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
        }
        if (col.gameObject.tag == "endPoint")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            goalPoint.transform.LeanScale(Vector2.one, 0.9f).setEaseOutQuart();
        }
        if (col.gameObject.tag == "questSpawn1")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont1found = true;
        }
        if (col.gameObject.tag == "questSpawn2")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont2found = true;
        }
        if (col.gameObject.tag == "questSpawn3")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont3found = true;
        }
        if (col.gameObject.tag == "questSpawn4")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont4found = true;
        }
        if (col.gameObject.tag == "questSpawn5")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont5found = true;
        }
        if (col.gameObject.tag == "questSpawn6")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont6found = true;
        }
        if (col.gameObject.tag == "questSpawn7")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont7found = true;
        }
        if (col.gameObject.tag == "questSpawn8")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont8found = true;
        }
        if (col.gameObject.tag == "questSpawn9")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont9found = true;
        }
        if (col.gameObject.tag == "questSpawn10")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont10found = true;
        }
        if (col.gameObject.tag == "questSpawn11")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont11found = true;
        }
        if (col.gameObject.tag == "questSpawn12")
        {
            Destroy(col.gameObject.GetComponent<BoxCollider2D>());
            player.cont12found = true;
        }
    }
}
