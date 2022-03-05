using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initalPos : MonoBehaviour
{
    public GameObject playerCont;
    public Transform movePoint;
    public Text numBronzeContainers;
    public Text numSilverContainers;
    public Text numGoldContainers;

    public static int numContain;

    // Start is called before the first frame update
    void Start()
    {
        playerCont.transform.position = new Vector3(player.questPosX, player.questPosY, 0);
        movePoint.position = new Vector3(player.questPosX, player.questPosY, 0);
        numBronzeContainers.text = player.numBronzeContainers.ToString();
        numSilverContainers.text = player.numSilverContainers.ToString();
        numGoldContainers.text = player.numGoldContainers.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
