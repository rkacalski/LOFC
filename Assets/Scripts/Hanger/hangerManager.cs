using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hangerManager : MonoBehaviour
{
    public GameObject[] hangerSlots;
    public int numSlotsUsed;
    public Text slotsUsedLabel;

    bool slot1Full;
    bool slot2Full;
    bool slot3Full;
    bool slot4Full;

    public static float timer3;
    public bool inHanger3;

    public static int selectedHanger;

    // Start is called before the first frame update
    void Start()
    {
        //Initiate Test vehicles ///////////////////////////////////////
        vehicle tempCard;
        List<vehicle> tempBinder = new List<vehicle>();

        tempBinder = Resources.LoadAll<vehicle>("Prefabs/Vehicles/Level 1").ToList();

        for (int i = 0; i < tempBinder.Count; i++)
        {
            tempCard = GameObject.Instantiate(tempBinder[i]);
            tempCard.built = true;
            playerCards.hanger[i] = tempCard;
        }
        insertHanger1();
        insertHanger2();
        insertHanger3();
        insertHanger4();

        //////////////////////////////////////////////////////////

        for (int i = 0; i < playerCards.hanger.Length; i++)
        {
            if(playerCards.hanger[i] != null)
            {
                numSlotsUsed += 1;
            }
        }

        hangerPannelUI();
        slotsUsedLabel.text = "Slots Used: " + numSlotsUsed + "/4";
    }

    void Update()
    {
        buildTimer3();
    }

    void hangerPannelUI()
    {
        for (int i = 0; i <= 3; i++)
        {
            //Set Art, Name, Level
            if (playerCards.hanger[i] != null)
            {
                hangerSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = playerCards.hanger[i].art;
                hangerSlots[i].transform.GetChild(2).GetComponent<Text>().text = playerCards.hanger[i].displayName;
                hangerSlots[i].transform.GetChild(3).GetComponent<Text>().text = "Level " + playerCards.hanger[i].level.ToString();
                if(playerCards.hanger[i].level.Equals(5))
                {
                    hangerSlots[i].transform.GetChild(3).GetComponent<Text>().text = "Level " + playerCards.hanger[i].level.ToString() + " (MAX)";
                }
                if(playerCards.hanger[i].built == true)
                {
                    hangerSlots[i].transform.GetChild(4).gameObject.SetActive(false);
                }
            }
            else
            {
                hangerSlots[i].transform.GetChild(0).gameObject.SetActive(false);
                hangerSlots[i].transform.GetChild(2).gameObject.SetActive(false);
                hangerSlots[i].transform.GetChild(3).gameObject.SetActive(false);
                hangerSlots[i].transform.GetChild(4).gameObject.SetActive(false);
            }
        }

        //Set slots to true
        for (int i = 0; i < playerCards.hanger.Length; i++)
        {
            if (playerCards.hanger[i] != null)
            {
                if(i.Equals(0))
                {
                    slot1Full = true;
                }
                if (i.Equals(1))
                {
                    slot2Full = true;
                }
                if (i.Equals(2))
                {
                    slot3Full = true;
                }
                if (i.Equals(3))
                {
                    slot4Full = true;
                }
            }
        }

    }

    void vehiclePopUp()
    {
        if(slot1Full == true)
        {
            print("Details");
        }
        if (slot2Full == true)
        {
            print("Details");
        }
        if (slot3Full == true)
        {
            print("Details");
        }
        if (slot4Full == true)
        {
            print("Details");
        }
    }





    public void buildTimer3()
    {
        if ((playerCards.hanger[2] != null) && (playerCards.hanger[2].built == false))
        {
            timer3 = playerCards.hanger[2].buildTime;
            inHanger3 = true;
        }
        if (inHanger3 == true)
        {
            playerCards.hanger[2].built = false;
            hangerSlots[2].transform.GetChild(4).gameObject.SetActive(true);

            if (playerCards.hanger[2].built == false)
            {
                timer3 -= Time.deltaTime * 1f; 
                TimeSpan time = TimeSpan.FromSeconds(timer3);
                hangerSlots[2].transform.GetChild(4).GetComponent<Text>().text = time.ToString("hh':'mm':'ss");
                print(timer3);

                if (timer3 < 0)
                {
                    hangerSlots[2].transform.GetChild(4).gameObject.SetActive(false);
                    playerCards.hanger[2].built = true;
                }

            }
        }
    }

    //Buttons and add new vehicle
    void insertHanger1()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.hanger[selectedHanger] = vehicleSelect.selectedVehicle;
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger2()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.hanger[selectedHanger] = vehicleSelect.selectedVehicle;
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger3()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.hanger[selectedHanger] = vehicleSelect.selectedVehicle;
            playerCards.hanger[selectedHanger].built = false;
            print(playerCards.hanger[selectedHanger].built);
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger4()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.hanger[selectedHanger] = vehicleSelect.selectedVehicle;
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    public void hanger1()
    {
        if (slot1Full == false)
        {
            SceneManager.LoadScene("Vehicle_Select");
            selectedHanger = 0;
        }
    }

    public void hanger2()
    {
        if (slot2Full == false)
        {
            SceneManager.LoadScene("Vehicle_Select");
            selectedHanger = 1;
        }
    }

    public void hanger3()
    {
        if(slot3Full == false)
        {
            SceneManager.LoadScene("Vehicle_Select");
            selectedHanger = 2;
        }
    }

    public void hanger4()
    {
        if (slot4Full == false)
        {
            SceneManager.LoadScene("Vehicle_Select");
            selectedHanger = 3;
        }
    }
}
