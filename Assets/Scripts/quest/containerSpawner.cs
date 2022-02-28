using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class containerSpawner : MonoBehaviour
{
    public int posX;
    public int posY;

    [SerializeField]
    public GameObject bronzeContainer;
    public GameObject silverContainer;
    public GameObject goldContainer;
    
    void Start()
    {
        spawn();
    }

    private void spawn()
    {
        float value = randomInt(0, 1);
        if (value <= 0.1)
        {
            Instantiate(goldContainer, new Vector3(posX, posY, 0), Quaternion.identity);
        }
        if (value > 0.1 && value <= 0.4)
        {
            Instantiate(silverContainer, new Vector3(posX, posY, 0), Quaternion.identity);
        }
        if (value > 0.41)
        {
            Instantiate(bronzeContainer, new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
