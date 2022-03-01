using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questCompleteUI : MonoBehaviour
{
    public Text bronzeContainer;
    public Text silverContainer;
    public Text goldContainer;

    public GameObject[] itemSlots;
    public Sprite[] crateSpriteList;

    // Start is called before the first frame update
    void Start()
    {
        player.numBronzeContainers = 3;
        player.numSilverContainers = 2;
        player.numGoldContainers = 1;
        bronzeContainer.text = player.numBronzeContainers.ToString();
        silverContainer.text = player.numSilverContainers.ToString();
        goldContainer.text = player.numGoldContainers.ToString();
        print(itemSlots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        updateItems();
    }

    void updateItems()
    {
        int totalnumContainers = player.numBronzeContainers + player.numSilverContainers + player.numGoldContainers - 1;
        print(totalnumContainers);
        //Initaiate Panels
        for (int i = 0; i <= itemSlots.Length; i++)
        {
            if (i <= totalnumContainers)
            {
                itemSlots[i].gameObject.SetActive(true);
            }
        }

        //Display Reward Data
        for(int i = 0; i <= totalnumContainers; i++)
        {
            if (i <= player.numBronzeContainers - 1)
            {
                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[0];
                //Set item1 Sprite
                //Set Item1 Name
                itemSlots[i].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "Hello There";
                print(i + "Bronze");
            }
            if (i > player.numBronzeContainers - 1 && i <= player.numBronzeContainers - 1 + player.numSilverContainers)
            {
                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[1];
                print(i + "Silver");
            }
            if (i > player.numBronzeContainers - 1 + player.numSilverContainers)
            {
                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[2];
                print(i + "Gold");
            }
        }   
    }
}
