using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateRewards : MonoBehaviour
{

    public string[] bronzePossibleRewards;
    public string[] silverPossibleRewards;
    public string[] goldPossibleRewards;

    // Start is called before the first frame update
    void Start()
    {
        
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
            
                //item1
                string item1 = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];
                int item1Quantity = itemQuantity(item1, "bronzeContainer");

                //item2
                string item2 = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];
                int item2Quantity = itemQuantity(item2, "bronzeContainer");

                //item3
                string item3 = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];
                int item3Quantity = itemQuantity(item3, "bronzeContainer");

                //item4
                string item4 = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];
                int item4Quantity = itemQuantity(item4, "bronzeContainer");

                string[,] rewards4 = new string[4, 2] { { item1, item1Quantity.ToString() }, { item2, item2Quantity.ToString() }, 
                                                        { item3, item3Quantity.ToString() }, { item4, item4Quantity.ToString() } };
                return rewards4;
        }
        if (typeOfContainer == "silverContainer")
        {

            //item1
            string item1 = silverPossibleRewards[(int)randomInt(0, silverPossibleRewards.Length)];
            int item1Quantity = itemQuantity(item1, "silverContainer");

            //item2
            string item2 = silverPossibleRewards[(int)randomInt(0, silverPossibleRewards.Length)];
            int item2Quantity = itemQuantity(item2, "silverContainer");

            //item3
            string item3 = silverPossibleRewards[(int)randomInt(0, silverPossibleRewards.Length)];
            int item3Quantity = itemQuantity(item3, "silverContainer");

            //item4
            string item4 = silverPossibleRewards[(int)randomInt(0, silverPossibleRewards.Length)];
            int item4Quantity = itemQuantity(item4, "silverContainer");

            string[,] rewards4 = new string[4, 2] { { item1, item1Quantity.ToString() }, { item2, item2Quantity.ToString() },
                                                        { item3, item3Quantity.ToString() }, { item4, item4Quantity.ToString() } };
            return rewards4;
        }
        if (typeOfContainer == "goldContainer")
        {

            //item1
            string item1 = goldPossibleRewards[(int)randomInt(0, goldPossibleRewards.Length)];
            int item1Quantity = itemQuantity(item1, "goldContainer");

            //item2
            string item2 = goldPossibleRewards[(int)randomInt(0, goldPossibleRewards.Length)];
            int item2Quantity = itemQuantity(item2, "goldContainer");

            //item3
            string item3 = goldPossibleRewards[(int)randomInt(0, goldPossibleRewards.Length)];
            int item3Quantity = itemQuantity(item3, "goldContainer");

            //item4
            string item4 = goldPossibleRewards[(int)randomInt(0, goldPossibleRewards.Length)];
            int item4Quantity = itemQuantity(item4, "goldContainer");

            string[,] rewards4 = new string[4, 2] { { item1, item1Quantity.ToString() }, { item2, item2Quantity.ToString() },
                                                        { item3, item3Quantity.ToString() }, { item4, item4Quantity.ToString() } };
            return rewards4;
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
                itemQuant = bronzeCredits[(int)randomInt(0, bronzeCredits.Length)];
                return itemQuant;
            }
            if (item.Equals("AP"))
            {
                itemQuant = bronzeAP[(int)randomInt(0, bronzeCredits.Length)];
                return itemQuant;
            }
            if(item.Equals("Crystals"))
            {
                itemQuant = (int)randomInt(1, 8);
                return itemQuant;
            }
            if(item.Equals("1 Star Jedi Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("1 Star Sith Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("1 Star Great Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
        }
        if (containerType.Equals("silverContainer"))
        {
            int[] silverCredits = new int[] { 6000, 7000, 8000, 9000 };
            int[] silverAP = new int[] { 100, 125, 150, 200 };

            if (item.Equals("Credits"))
            {
                itemQuant = silverCredits[(int)randomInt(0, silverCredits.Length)];
                return itemQuant;
            }
            if (item.Equals("AP"))
            {
                itemQuant = silverAP[(int)randomInt(0, silverCredits.Length)];
                return itemQuant;
            }
            if (item.Equals("Crystals"))
            {
                itemQuant = (int)randomInt(8, 17);
                return itemQuant;
            }
            if (item.Equals("Training Remotes"))
            {
                itemQuant = (int)randomInt(2, 10);
                return itemQuant;
            }
            if (item.Equals("Silver Card Pack"))
            {
                itemQuant = 1;
                return itemQuant;
            }
            if (item.Equals("Vehicle Blue Print"))
            {
                itemQuant = 1;
                return itemQuant;
            }
            if (item.Equals("2 Star Jedi Holocron"))
            {
                itemQuant = (int)randomInt(3, 6);
                return itemQuant;
            }
            if (item.Equals("2 Star Sith Holocron"))
            {
                itemQuant = (int)randomInt(3, 6);
                return itemQuant;
            }
            if (item.Equals("2 Star Great Holocron"))
            {
                itemQuant = (int)randomInt(3, 6);
                return itemQuant;
            }
            if (item.Equals("3 Star Jedi Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("3 Star Sith Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("3 Star Great Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }


        }
        if (containerType.Equals("goldContainer"))
        {
            int[] goldCredits = new int[] { 10000, 10500, 11000, 12000 };

            if (item.Equals("Credits"))
            {
                itemQuant = goldCredits[(int)randomInt(0, goldCredits.Length)];
                return itemQuant;
            }
            if (item.Equals("Crystals"))
            {
                itemQuant = (int)randomInt(15, 25);
                return itemQuant;
            }
            if (item.Equals("Training Remotes"))
            {
                itemQuant = (int)randomInt(5, 13);
                return itemQuant;
            }
            if (item.Equals("Vehicle Blue Print"))
            {
                itemQuant = 1;
                return itemQuant;
            }
            if (item.Equals("Gold Card Pack"))
            {
                itemQuant = 1;
                return itemQuant;
            }
            if (item.Equals("4 Star Jedi Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("4 Star Sith Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
            if (item.Equals("4 Star Great Holocron"))
            {
                itemQuant = (int)randomInt(1, 3);
                return itemQuant;
            }
        }
        return 0;
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
