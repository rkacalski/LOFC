using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questCredits : MonoBehaviour
{
    public string[] maps1;
    public string[] maps2;
    public string[] maps3;
    public string[] maps4;
    public string[] maps5;
    public string[] maps6;
    public string[] maps7;

    public float creditsEarned(string mapName)
    {
        float returnValue;

        if(maps1.Contains(mapName))
        {
            returnValue = creditsMaps1();
            return returnValue;
        }
        if (maps2.Contains(mapName))
        {
            returnValue = creditsMaps2();
            return returnValue;
        }
        if (maps3.Contains(mapName))
        {
            returnValue = creditsMaps3();
            return returnValue;
        }
        if (maps4.Contains(mapName))
        {
            returnValue = creditsMaps4();
            return returnValue;
        }
        if (maps5.Contains(mapName))
        {
            returnValue = creditsMaps5();
            return returnValue;
        }
        if (maps6.Contains(mapName))
        {
            returnValue = creditsMaps6();
            return returnValue;
        }
        if (maps7.Contains(mapName))
        {
            returnValue = creditsMaps7();
            return returnValue;
        }

        returnValue = creditsMaps7();
        return returnValue;
    }

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
