using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questCompleteUI : MonoBehaviour
{
    public crateRewards CrateRewards;

    public Text bronzeContainer;
    public Text silverContainer;
    public Text goldContainer;

    public GameObject[] itemSlots;
    public Sprite[] crateSpriteList;
    public Sprite[] rewardSpriteList;

    // Start is called before the first frame update
    void Start()
    {
        //player.numBronzeContainers = player.numBronzeContainers;
        //player.numSilverContainers = player.numSilverContainers;
        //player.numGoldContainers = player.numGoldContainers;
        bronzeContainer.text = player.numBronzeContainers.ToString();
        silverContainer.text = player.numSilverContainers.ToString();
        goldContainer.text = player.numGoldContainers.ToString();

        updateItems();
    }

    // Update is called once per frame
    void Update()
    {
        
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
                //Initaiate Rewards
                string[,] rewards = CrateRewards.rewards("bronzeContainer");

                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[0];

                //Set Item1 Quantity and Name
                itemSlots[i].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = rewards[0,1] + " " + rewards[0,0];

                //Set item1 Sprite
                if(rewards[0, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[0, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[0, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[0, 0].Equals("1 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[3];
                }
                if (rewards[0, 0].Equals("1 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[4];
                }
                if (rewards[0, 0].Equals("1 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[5];
                }

                //Item 2
                //Set Item2 Quantity and Name
                itemSlots[i].transform.GetChild(3).GetChild(0).GetComponent<Text>().text = rewards[1, 1] + " " + rewards[1, 0];

                //Set item2 Sprite
                if (rewards[1, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[1, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[1, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[1, 0].Equals("1 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[3];
                }
                if (rewards[1, 0].Equals("1 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[4];
                }
                if (rewards[1, 0].Equals("1 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[5];
                }

                //Item 3
                //Set Item3 Quantity and Name
                itemSlots[i].transform.GetChild(4).GetChild(0).GetComponent<Text>().text = rewards[2, 1] + " " + rewards[2, 0];

                //Set item3 Sprite
                if (rewards[2, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[2, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[2, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[2, 0].Equals("1 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[3];
                }
                if (rewards[2, 0].Equals("1 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[4];
                }
                if (rewards[2, 0].Equals("1 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[5];
                }

                //Item4
                float value = randomInt(0, 1);
                if (value <= 0.2)
                {
                    //Set Item4 Quantity and Name
                    itemSlots[i].transform.GetChild(5).GetChild(0).GetComponent<Text>().text = rewards[3, 1] + " " + rewards[3, 0];

                    //Set item4 Sprite
                    if (rewards[3, 0].Equals("Credits"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[0];
                    }
                    if (rewards[3, 0].Equals("AP"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[1];
                    }
                    if (rewards[3, 0].Equals("Crystals"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[2];
                    }
                    if (rewards[3, 0].Equals("1 Star Jedi Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[3];
                    }
                    if (rewards[3, 0].Equals("1 Star Sith Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[4];
                    }
                    if (rewards[3, 0].Equals("1 Star Great Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[5];
                    }
                }
                else
                {
                    itemSlots[i].transform.GetChild(5).GetChild(0).gameObject.SetActive(false);
                    itemSlots[i].transform.GetChild(5).gameObject.SetActive(false);
                }

            }

            if (i > player.numBronzeContainers - 1 && i <= player.numBronzeContainers - 1 + player.numSilverContainers)
            {
                //Initaiate Rewards
                string[,] rewards = CrateRewards.rewards("silverContainer");

                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[1];

                //Set Item1 Quantity and Name
                itemSlots[i].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = rewards[0, 1] + " " + rewards[0, 0];

                //Set item1 Sprite
                if (rewards[0, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[0, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[0, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[0, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[0, 0].Equals("Silver Card Pack"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[16];
                }
                if (rewards[0, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[0, 0].Equals("2 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[6];
                }
                if (rewards[0, 0].Equals("2 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[7];
                }
                if (rewards[0, 0].Equals("2 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[8];
                }
                if (rewards[0, 0].Equals("3 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[9];
                }
                if (rewards[0, 0].Equals("3 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[10];
                }
                if (rewards[0, 0].Equals("3 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[11];
                }

                //Set Item2 Quantity and Name
                itemSlots[i].transform.GetChild(3).GetChild(0).GetComponent<Text>().text = rewards[1, 1] + " " + rewards[1, 0];

                //Set item2 Sprite
                if (rewards[1, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[1, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[1, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[1, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[1, 0].Equals("Silver Card Pack"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[16];
                }
                if (rewards[1, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[1, 0].Equals("2 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[6];
                }
                if (rewards[1, 0].Equals("2 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[7];
                }
                if (rewards[1, 0].Equals("2 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[8];
                }
                if (rewards[1, 0].Equals("3 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[9];
                }
                if (rewards[1, 0].Equals("3 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[10];
                }
                if (rewards[1, 0].Equals("3 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[11];
                }

                //Set Item3 Quantity and Name
                itemSlots[i].transform.GetChild(4).GetChild(0).GetComponent<Text>().text = rewards[2, 1] + " " + rewards[2, 0];

                //Set item3 Sprite
                if (rewards[2, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[2, 0].Equals("AP"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[1];
                }
                if (rewards[2, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[2, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[2, 0].Equals("Silver Card Pack"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[16];
                }
                if (rewards[2, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[2, 0].Equals("2 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[6];
                }
                if (rewards[2, 0].Equals("2 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[7];
                }
                if (rewards[2, 0].Equals("2 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[8];
                }
                if (rewards[2, 0].Equals("3 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[9];
                }
                if (rewards[2, 0].Equals("3 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[10];
                }
                if (rewards[2, 0].Equals("3 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[11];
                }

                //Item4
                float value = randomInt(0, 1);
                if (value <= 0.2)
                {
                    //Set Item4 Quantity and Name
                    itemSlots[i].transform.GetChild(5).GetChild(0).GetComponent<Text>().text = rewards[3, 1] + " " + rewards[3, 0];

                    //Set item4 Sprite
                    if (rewards[3, 0].Equals("Credits"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[0];
                    }
                    if (rewards[3, 0].Equals("AP"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[1];
                    }
                    if (rewards[3, 0].Equals("Crystals"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[2];
                    }
                    if (rewards[3, 0].Equals("Training Remotes"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[15];
                    }
                    if (rewards[3, 0].Equals("Silver Card Pack"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[16];
                    }
                    if (rewards[3, 0].Equals("Vehicle Blue Print"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[2];
                    }
                    if (rewards[3, 0].Equals("2 Star Jedi Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[6];
                    }
                    if (rewards[3, 0].Equals("2 Star Sith Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[7];
                    }
                    if (rewards[3, 0].Equals("2 Star Great Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[8];
                    }
                    if (rewards[3, 0].Equals("3 Star Jedi Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[9];
                    }
                    if (rewards[3, 0].Equals("3 Star Sith Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[10];
                    }
                    if (rewards[3, 0].Equals("3 Star Great Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[11];
                    }
                }
                else
                {
                    itemSlots[i].transform.GetChild(5).GetChild(0).gameObject.SetActive(false);
                    itemSlots[i].transform.GetChild(5).gameObject.SetActive(false);
                }
            }

            if (i > player.numBronzeContainers - 1 + player.numSilverContainers)
            {
                //Initaiate Rewards
                string[,] rewards = CrateRewards.rewards("goldContainer");

                itemSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = crateSpriteList[2];

                //Set Item1 Quantity and Name
                itemSlots[i].transform.GetChild(2).GetChild(0).GetComponent<Text>().text = rewards[0, 1] + " " + rewards[0, 0];

                //Set item1 Sprite
                if (rewards[0, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[0, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[0, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[0, 0].Equals("Gold Card Pack"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[17];
                }
                if (rewards[0, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[0, 0].Equals("4 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[12];
                }
                if (rewards[0, 0].Equals("4 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[13];
                }
                if (rewards[0, 0].Equals("4 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(2).GetComponent<Image>().sprite = rewardSpriteList[14];
                }

                //Set Item2 Quantity and Name
                itemSlots[i].transform.GetChild(3).GetChild(0).GetComponent<Text>().text = rewards[1, 1] + " " + rewards[1, 0];

                //Set item2 Sprite
                if (rewards[1, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[1, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[1, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[1, 0].Equals("Gold Card Pack"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[17];
                }
                if (rewards[1, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[1, 0].Equals("4 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[12];
                }
                if (rewards[1, 0].Equals("4 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[13];
                }
                if (rewards[1, 0].Equals("4 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(3).GetComponent<Image>().sprite = rewardSpriteList[14];
                }

                //Set Item3 Quantity and Name
                itemSlots[i].transform.GetChild(4).GetChild(0).GetComponent<Text>().text = rewards[2, 1] + " " + rewards[2, 0];

                //Set item3 Sprite
                if (rewards[2, 0].Equals("Credits"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[0];
                }
                if (rewards[2, 0].Equals("Crystals"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[2, 0].Equals("Training Remotes"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[15];
                }
                if (rewards[2, 0].Equals("Gold Card Pack"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[17];
                }
                if (rewards[2, 0].Equals("Vehicle Blue Print"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[2];
                }
                if (rewards[2, 0].Equals("4 Star Jedi Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[12];
                }
                if (rewards[2, 0].Equals("4 Star Sith Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[13];
                }
                if (rewards[2, 0].Equals("4 Star Great Holocron"))
                {
                    itemSlots[i].transform.GetChild(4).GetComponent<Image>().sprite = rewardSpriteList[14];
                }

                //Item4
                float value = randomInt(0, 1);
                if (value <= 0.2)
                {
                    //Set Item4 Quantity and Name
                    itemSlots[i].transform.GetChild(5).GetChild(0).GetComponent<Text>().text = rewards[3, 1] + " " + rewards[3, 0];

                    //Set item4 Sprite
                    if (rewards[3, 0].Equals("Credits"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[0];
                    }
                    if (rewards[3, 0].Equals("Crystals"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[2];
                    }
                    if (rewards[3, 0].Equals("Training Remotes"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[15];
                    }
                    if (rewards[3, 0].Equals("Gold Card Pack"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[17];
                    }
                    if (rewards[3, 0].Equals("Vehicle Blue Print"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[2];
                    }
                    if (rewards[3, 0].Equals("4 Star Jedi Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[12];
                    }
                    if (rewards[3, 0].Equals("4 Star Sith Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[13];
                    }
                    if (rewards[3, 0].Equals("4 Star Great Holocron"))
                    {
                        itemSlots[i].transform.GetChild(5).GetComponent<Image>().sprite = rewardSpriteList[14];
                    }
                }
                else
                {
                    itemSlots[i].transform.GetChild(5).GetChild(0).gameObject.SetActive(false);
                    itemSlots[i].transform.GetChild(5).gameObject.SetActive(false);
                }

            }
        }   
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
