using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateRewards : MonoBehaviour
{

    public string[] bronzePossibleRewards;
    public string[] silverPossibleRewards;
    public string[] goldPossibleRewards;

    public string[,] rewards4 = new string[3, 1];
    public string[,] rewards3 = new string[2, 1];
    public string[,] rewards2 = new string[1, 1];
    //public string[,] array2Da;

    // Start is called before the first frame update
    void Start()
    {
        string[,] test = rewards("bronzeContainer");
        print(test[0, 0] + " , " + test[0,1]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public string[,] rewards(string typeOfContainer)
    {
        //string item1;
        if (typeOfContainer == "bronzeContainer")
        {
            float value = 1;//randomInt(0, 1);
            if (value == 1)
            {
                //rewards = 4

                //item1
                string item1 = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length - 1)];
                int item1Quantity = itemQuantity(item1, "bronzeContainer");

                //item2

                //item3

                //item4
                string[,] rewards4 = new string[4, 2] { { item1, item1Quantity.ToString() }, { "3", "4" }, { "5", "6" }, { "7", "8" } };
                return rewards4;
            }
        }
        return null;
    }

    int itemQuantity(string item, string containerType)
    {
        int itemQuant;

        if(containerType.Equals("bronzeContainer"))
        {
            int[] bronzeCredits = new int[] { 3000, 4000, 5000, 6000 };
            int[] bronzeAP = new int[] { 25, 50, 75, 100 };

            if (item.Equals("Credits"))
            {
                itemQuant = bronzeCredits[(int)randomInt(0, bronzeCredits.Length - 1)];
                return itemQuant;
            }
            if (item.Equals("AP"))
            {
                itemQuant = bronzeAP[(int)randomInt(0, bronzeCredits.Length - 1)];
                return itemQuant;
            }

            //bronze t remotes range 1-8
            //Bronze crystals range 1-10
            //Bronze holocrons range 1-5
        }
        return 0;
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
