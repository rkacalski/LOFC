using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questManager : MonoBehaviour
{
    public static string crate1;
    public static string crate2;
    public static string crate3;
    public static string crate4;
    public static string crate5;
    public static string crate6;
    public static string crate7;
    public static string crate8;
    public static string crate9;
    public static string crate10;
    public static string crate11;
    public static string crate12;

    public containerSpawner spawn1;
    public GameObject spawn1GO;
    public containerSpawner spawn2;
    public GameObject spawn2GO;
    public containerSpawner spawn3;
    public GameObject spawn3GO;
    public containerSpawner spawn4;
    public GameObject spawn4GO;
    public containerSpawner spawn5;
    public GameObject spawn5GO;
    public containerSpawner spawn6;
    public GameObject spawn6GO;
    public containerSpawner spawn7;
    public GameObject spawn7GO;
    public containerSpawner spawn8;
    public GameObject spawn8GO;
    public containerSpawner spawn9;
    public GameObject spawn9GO;
    public containerSpawner spawn10;
    public GameObject spawn10GO;
    public containerSpawner spawn11;
    public GameObject spawn11GO;
    public containerSpawner spawn12;
    public GameObject spawn12GO;

    public GameObject bronzeContainer;
    public GameObject silverContainer;
    public GameObject goldContainer;

    // Start is called before the first frame update
    void Start()
    {
        //print(player.mapInProgress);
        StartCoroutine(getCrateInfo(0.2f));
        if (player.mapInProgress == true)
        {
            spawn1GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn2GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn3GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn4GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn5GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn6GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn7GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn8GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn9GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn10GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn11GO.gameObject.GetComponent<containerSpawner>().enabled = false;
            spawn12GO.gameObject.GetComponent<containerSpawner>().enabled = false;

            print(crate1);

            if (player.cont1found == false && 1 <= numContainer.currentNumContainers)
            {
                if (crate1.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn1.posX, spawn1.posY, 0), Quaternion.identity);
                }
                if (crate1.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn1.posX, spawn1.posY, 0), Quaternion.identity);
                }
                if (crate1.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn1.posX, spawn1.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont2found == false && 2 <= numContainer.currentNumContainers)
            {
                if (crate2.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn2.posX, spawn2.posY, 0), Quaternion.identity);
                }
                if (crate2.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn2.posX, spawn2.posY, 0), Quaternion.identity);
                }
                if (crate2.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn2.posX, spawn2.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont3found == false && 3 <= numContainer.currentNumContainers)
            {
                if (crate3.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn3.posX, spawn3.posY, 0), Quaternion.identity);
                }
                if (crate3.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn3.posX, spawn3.posY, 0), Quaternion.identity);
                }
                if (crate3.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn3.posX, spawn3.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont4found == false && 4 <= numContainer.currentNumContainers)
            {
                if (crate4.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn4.posX, spawn4.posY, 0), Quaternion.identity);
                }
                if (crate4.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn4.posX, spawn4.posY, 0), Quaternion.identity);
                }
                if (crate4.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn4.posX, spawn4.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont5found == false && 5 <= numContainer.currentNumContainers)
            {
                if (crate5.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn5.posX, spawn5.posY, 0), Quaternion.identity);
                }
                if (crate5.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn5.posX, spawn5.posY, 0), Quaternion.identity);
                }
                if (crate5.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn5.posX, spawn5.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont6found == false && 6 <= numContainer.currentNumContainers)
            {
                if (crate6.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn6.posX, spawn6.posY, 0), Quaternion.identity);
                }
                if (crate6.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn6.posX, spawn6.posY, 0), Quaternion.identity);
                }
                if (crate6.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn6.posX, spawn6.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont7found == false && 7 <= numContainer.currentNumContainers)
            {
                if (crate7.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn7.posX, spawn7.posY, 0), Quaternion.identity);
                }
                if (crate7.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn7.posX, spawn7.posY, 0), Quaternion.identity);
                }
                if (crate7.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn7.posX, spawn7.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont8found == false && 8 <= numContainer.currentNumContainers)
            {
                if (crate8.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn8.posX, spawn8.posY, 0), Quaternion.identity);
                }
                if (crate8.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn8.posX, spawn8.posY, 0), Quaternion.identity);
                }
                if (crate4.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn8.posX, spawn8.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont9found == false && 9 <= numContainer.currentNumContainers)
            {
                if (crate9.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn9.posX, spawn9.posY, 0), Quaternion.identity);
                }
                if (crate9.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn9.posX, spawn9.posY, 0), Quaternion.identity);
                }
                if (crate9.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn9.posX, spawn9.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont10found == false && 10 <= numContainer.currentNumContainers)
            {
                if (crate10.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn10.posX, spawn10.posY, 0), Quaternion.identity);
                }
                if (crate10.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn10.posX, spawn10.posY, 0), Quaternion.identity);
                }
                if (crate10.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn10.posX, spawn10.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont11found == false && 11 <= numContainer.currentNumContainers)
            {
                if (crate11.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn11.posX, spawn11.posY, 0), Quaternion.identity);
                }
                if (crate11.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn11.posX, spawn11.posY, 0), Quaternion.identity);
                }
                if (crate11.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn11.posX, spawn11.posY, 0), Quaternion.identity);
                }
            }
            if (player.cont12found == false && 12 <= numContainer.currentNumContainers)
            {
                if (crate12.Equals("Bronze"))
                {
                    Instantiate(bronzeContainer, new Vector3(spawn12.posX, spawn12.posY, 0), Quaternion.identity);
                }
                if (crate12.Equals("Silver"))
                {
                    Instantiate(silverContainer, new Vector3(spawn12.posX, spawn12.posY, 0), Quaternion.identity);
                }
                if (crate12.Equals("Gold"))
                {
                    Instantiate(goldContainer, new Vector3(spawn12.posX, spawn12.posY, 0), Quaternion.identity);
                }
            }
        }
    }

    IEnumerator getCrateInfo(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (player.mapInProgress == false)
        {
            crate1 = spawn1.typeContSpawned;
            crate2 = spawn2.typeContSpawned;
            crate3 = spawn3.typeContSpawned;
            crate4 = spawn4.typeContSpawned;
            crate5 = spawn5.typeContSpawned;
            crate6 = spawn6.typeContSpawned;
            crate7 = spawn7.typeContSpawned;
            crate8 = spawn8.typeContSpawned;
            crate9 = spawn9.typeContSpawned;
            crate10 = spawn10.typeContSpawned;
            crate11 = spawn11.typeContSpawned;
            crate12 = spawn12.typeContSpawned;
        }
    }
}
