using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class initalPos : MonoBehaviour
{
    public GameObject playerCont;
    public Transform movePoint;
    public Text numBronzeContainers;
    public Text numSilverContainers;
    public Text numGoldContainers;

    public string mapcheck;

    public static int numContain;

    // Start is called before the first frame update
    void Start()
    {
        mapcheck = SceneManager.GetActiveScene().name;
        if (!mapcheck.Equals(player.currentQuestMap))
        {
            player.numBronzeContainers = 0;
            player.numSilverContainers = 0;
            player.numGoldContainers = 0;
            player.currentQuestMap = SceneManager.GetActiveScene().name;
            player.mapInProgress = false;
            player.questPosX = 0;
            player.questPosY = 0;
            player.cont1found = false;
            player.cont2found = false;
            player.cont3found = false;
            player.cont4found = false;
            player.cont5found = false;
            player.cont6found = false;
            player.cont7found = false;
            player.cont8found = false;
            player.cont9found = false;
            player.cont10found = false;
            player.cont11found = false;
            player.cont12found = false;
        }

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
