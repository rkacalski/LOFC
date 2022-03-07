using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numContainer : MonoBehaviour
{
    public float minContainers;
    public float maxContainers;
    public int highrolls;
    public static int currentNumContainers;
    public GameObject[] highRollSpawners;

    // Start is called before the first frame update
    void Start()
    {
        if (player.mapInProgress == false)
        {
            float test = randomInt(0, 1);
            if (test <= 0.2)
            {
                //test = maxContainers;
                for (int i = 0; i < highRollSpawners.Length; i++)
                {
                    if (highRollSpawners.Length.Equals(1))
                    {
                        highrolls = 1;
                    }
                    else
                    {
                        float highRoll = randomInt(0, 1);
                        if (highRoll <= 0.5)
                        {
                            highRollSpawners[i].SetActive(true);
                        }
                        highrolls += 1;
                    }
                }
                currentNumContainers = (int)minContainers + highrolls;
            }
            else
            {
                currentNumContainers = (int)minContainers;
            }
        }
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
