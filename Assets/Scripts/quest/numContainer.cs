using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numContainer : MonoBehaviour
{
    public float minContainers;
    public float maxContainers;
    public GameObject highRollSpawner;

    // Start is called before the first frame update
    void Start()
    {
        //float test = Mathf.Round(randomInt(0, 1));
        float test = randomInt(0, 1);
        print(test);
        if (test <= 0.2)
        {
            test = maxContainers;
            highRollSpawner.SetActive(true);
        }
        else
        {
            test = minContainers;

        }
        print(test);
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
