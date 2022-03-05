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
        spawn();
    }

    private void spawn()
    {
        float value = randomInt(0, 1);
        if (value <= 0.07)
        {
            Instantiate(goldContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Gold";
        }
        if (value > 0.07 && value <= 0.37)
        {
            Instantiate(silverContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Silver";
        }
        if (value > 0.37)
        {
            Instantiate(bronzeContainer, new Vector3(posX, posY, 0), Quaternion.identity);
            typeContSpawned = "Bronze";
        }
    }

    public void contSpawnedCheck()
    {
        //1st container
        if(spawnNum.Equals(1) && player.cont1found == true)
        {
            print("fixed");
        }
        //2nd container
        if (spawnNum.Equals(2) && player.cont2found == true)
        {
            print("fixed");
        }
        //3rd container
        if (spawnNum.Equals(3) && player.cont3found == true)
        {
            print("fixed");
        }
        //4th container
        if (spawnNum.Equals(4) && player.cont4found == true)
        {
            print("fixed");
        }
    }

    float randomInt(float min, float max)
    {
        float numContainers = Random.Range(min, max);
        return numContainers;
    }
}
