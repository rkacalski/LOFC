using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class containerSpawner : MonoBehaviour
{
    public int posX;
    public int posY;
    public int spawnNum;
    public string typeContSpawned;

    [SerializeField]
    public GameObject bronzeContainer;
    public GameObject silverContainer;
    public GameObject goldContainer;

    void Start()
    {
        if (!player.mapInProgress == true)
        {
            spawn();
        }
    }

    private void spawn()
    {
        float value = randomInt(0, 1);
        if (value <= 0.1)
        {
            Instantiate(goldContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Gold";
        }
        if (value > 0.1 && value <= 0.4)
        {
            Instantiate(silverContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Silver";
        }
        if (value > 0.4)
        {
            Instantiate(bronzeContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Bronze";
        }
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
