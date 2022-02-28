using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leaderCard : MonoBehaviour
{
    public Text numBronzeContainers;
    public Text numSilverContainers;
    public Text numGoldContainers;

    public AudioSource chestObtained;

    void Start()
    {
        chestObtained = GetComponent<AudioSource>();
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
    }
}
