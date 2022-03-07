using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questCredits : MonoBehaviour
{
    public float creditsMaps1()
    {
        float creditValue = randomInt(35, 78);
        return creditValue;
    }

    public float creditsMaps2()
    {
        float creditValue = randomInt(122, 184);
        return creditValue;
    }

    public float creditsMaps3()
    {
        float creditValue = randomInt(195, 268);
        return creditValue;
    }

    public float creditsMaps4()
    {
        float creditValue = randomInt(289, 365);
        return creditValue;
    }

    public float creditsMaps5()
    {
        float creditValue = randomInt(366, 412);
        return creditValue;
    }

    public float creditsMaps6()
    {
        float creditValue = randomInt(416, 498);
        return creditValue;
    }

    public float creditsMaps7()
    {
        float creditValue = randomInt(502, 580);
        return creditValue;
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
