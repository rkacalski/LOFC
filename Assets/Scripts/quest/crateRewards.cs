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

    // Start is called before the first frame update
    void Start()
    {
        string[,] test = rewards("bronzeContainer");
        for (int x = 0; x < test.GetLength(0); x++)
        {
            for (int y = 0; y < test.GetLength(1); y++)
            {
                print(test[x, y]);
            }
        }
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
            float value = randomInt(0, 1);
            if (value > 0.02)
            {
                //rewards = 4

                //    1/4
                rewards4[0,0] = ("50");
               // rewards4[0, 1] = bronzePossibleRewards[Random.Range(0,bronzePossibleRewards.Length)];

                //    2/4
                rewards4[1, 0] = ("50");
                //rewards4[1, 1] = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];

                //    3/4
                rewards4[2, 0] = ("50");
               // rewards4[2, 1] = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];

                //    4/4
                rewards4[3, 0] = ("50");
                //rewards4[3, 1] = bronzePossibleRewards[(int)randomInt(0, bronzePossibleRewards.Length)];
            }
            else
            {
                //rewards = 3
            }
        }
        if (typeOfContainer == "goldContainer")
        {
            float value = randomInt(0, 1);
            if (value <= 0.2)
            {
                //rewards = 4
            }
            else
            {
                //rewards = 3
            }
        }
        if (typeOfContainer == "goldContainer")
        {
            float value = randomInt(0, 1);
            if (value <= 0.2)
            {
                //rewards = 4
            }
            if(value > 0.2 && value < 0.9)
            {
                //rewards = 3
            }
            else
            {
                //rewards = 2
            }
        }

        return rewards4;
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
