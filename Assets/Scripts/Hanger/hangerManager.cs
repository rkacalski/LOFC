using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hangerManager : MonoBehaviour
{
    public GameObject[] hangerSlots;
    public int numSlotsUsed;
    public Text slotsUsedLabel;

    bool slot1Full;
    bool slot2Full;
    bool slot3Full;
    bool slot4Full;

    // Start is called before the first frame update
    void Start()
    {
        //Initiate Test vehicles ///////////////////////////////////////
        vehicle tempCard;
        List<vehicle> tempBinder = new List<vehicle>();

        tempBinder = Resources.LoadAll<vehicle>("Prefabs/Vehicles/Level 1").ToList();

        for (int i = 0; i < tempBinder.Count; i++)
        {
            tempBinder[i].built = true;
            tempCard = GameObject.Instantiate(tempBinder[i]);
            playerCards.hanger[i] = tempCard;
        }

        /////////Time format///////////////////////////////////////////////////////

        float totalSeconds = 228.10803f;
        TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
        //print(time.ToString("hh':'mm':'ss"));

        //////////////////////////////////////////////////////////

        for (int i = 0; i < playerCards.hanger.Length; i++)
        {
            if(playerCards.hanger[i] != null)
            {
                print(playerCards.hanger[i].vehicleName);
                numSlotsUsed += 1;
            }
        }

        hangerPannelUI();
        slotsUsedLabel.text = "Slots Used: " + numSlotsUsed + "/4";

        print(slot1Full);
        print(slot2Full);
        print(slot3Full);
        print(slot4Full);

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

}
