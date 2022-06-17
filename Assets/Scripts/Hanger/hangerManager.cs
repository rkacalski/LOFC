using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hangerManager : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
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
    public int sellHanger;

    // Start is called before the first frame update
    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
        sellHanger = -1;
        //Initiate Test vehicles ///////////////////////////////////////
        /**
        vehicle tempCard;
        List<vehicle> tempBinder = new List<vehicle>();

        tempBinder = Resources.LoadAll<vehicle>("Prefabs/Vehicles/Level 1").ToList();

        for (int i = 0; i < tempBinder.Count; i++)
        {
            tempCard = GameObject.Instantiate(tempBinder[i]);
            tempCard.built = true;
            playerCards.playerHanger.Insert(i, tempCard);
        }
        **/
        insertHanger1();
        insertHanger2();
        insertHanger3();
        insertHanger4();

        //////////////////////////////////////////////////////////

        for (int i = 0; i < playerCards.playerHanger.Count; i++)
        {
            if(playerCards.playerHanger[i] != null)
            {
                numSlotsUsed += 1;
            }
        }
        print("Count: " + playerCards.playerHanger.Count);
        hangerPannelUI();
        slotsUsedLabel.text = "Slots Used: " + numSlotsUsed + "/4";
    }

    void Update()
    {
        
    }

    void hangerPannelUI()
    {
        for (int i = 0; i < 4; i++)
        {
            //Set Art, Name, Level
            if (i < playerCards.playerHanger.Count && !playerCards.playerHanger[i].displayName.Equals(""))
            {
                print("In Loop" + i);
                hangerSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = playerCards.playerHanger[i].art;
                hangerSlots[i].transform.GetChild(2).GetComponent<Text>().text = playerCards.playerHanger[i].displayName;
                hangerSlots[i].transform.GetChild(3).GetComponent<Text>().text = "Level " + playerCards.playerHanger[i].level.ToString();
                if(playerCards.playerHanger[i].level.Equals(5))
                {
                    hangerSlots[i].transform.GetChild(3).GetComponent<Text>().text = "Level " + playerCards.playerHanger[i].level.ToString() + " (MAX)";
                }
                if(playerCards.playerHanger[i].built == true)
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
        for (int i = 0; i < playerCards.playerHanger.Count; i++)
        {
            if (!playerCards.playerHanger[i].displayName.Equals(""))
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



    public void getTimer3()
    {
        if ((playerCards.playerHanger[2] != null) && playerCards.playerHanger[2].built == false)
        {
            timer3 = playerCards.playerHanger[2].buildTime;
            inHanger3 = true;
        }
    }

    //Buttons and add new vehicle
    void insertHanger1()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.playerHanger.Insert(selectedHanger, Instantiate(vehicleSelect.selectedVehicle));

        }
        if(vehicleModHelper.selectedVehicleList.Count > 0)
        {
            print("is destroyed in hanger" + (object)vehicleModHelper.selectedVehicle == null);
            print("Count: " + vehicleModHelper.selectedVehicleList.Count);
            print("Chosen: " + vehicleModHelper.selectedVehicleList[0]);
            playerCards.playerHanger.RemoveAt(0);
            playerCards.playerHanger.Insert(0, vehicleModHelper.selectedVehicleList[0]);
            print((object)vehicleModHelper.selectedVehicleList[0] == null);
            print("Pilot: " + playerCards.playerHanger[0].Pilot[0].displayName);
            print("Working: " + playerCards.playerHanger[0]);
        }

        vehicleSelect.selectedVehicle = null;
        vehicleModHelper.selectedVehicleList.Clear();
        vehicleModHelper.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger2()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.playerHanger.Insert(selectedHanger, vehicleSelect.selectedVehicle);
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger3()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.playerHanger[selectedHanger] = vehicleSelect.selectedVehicle;
            playerCards.playerHanger[selectedHanger].built = false;
            //print(playerCards.playerHanger[selectedHanger].built);
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    void insertHanger4()
    {
        if (vehicleSelect.selectedVehicle != null)
        {
            playerCards.playerHanger[selectedHanger] = vehicleSelect.selectedVehicle;
        }
        vehicleSelect.selectedVehicle = null;
        selectedHanger = -1;
    }

    public void hanger1()
    {
        if (slot1Full == false)
        {
            selectedHanger = 0;
            SceneManager.LoadScene("Vehicle_Select");
        }
        if (slot1Full == true)
        {
            sellHanger = 0;
            selectedHanger = 0;
            displayVehicle(0);
        }
    }

    public void hanger2()
    {
        if (slot2Full == false && slot1Full == true)
        {
            selectedHanger = 1;
            SceneManager.LoadScene("Vehicle_Select");
        }
        if (slot2Full == true)
        {
            sellHanger = 1;
            displayVehicle(1);
        }
    }

    public void hanger3()
    {
        if(slot3Full == false && slot2Full == true && slot1Full == true)
        {
            selectedHanger = 2;
            SceneManager.LoadScene("Vehicle_Select");
        }
        if (slot3Full == true)
        {
            sellHanger = 2;
            displayVehicle(2);
        }
    }

    public void hanger4()
    {
        if (slot4Full == false && slot3Full == true && slot2Full == true && slot1Full == true)
        {
            selectedHanger = 3;
            SceneManager.LoadScene("Vehicle_Select");
        }
        if (slot4Full == true)
        {
            sellHanger = 3;
            displayVehicle(3);
        }
    }

    void displayVehicle(int hangerLocation)
    {
        vehicle vehicle = playerCards.playerHanger[hangerLocation];

        //Set art, pilots, copilots
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).GetComponent<Image>().sprite = vehicle.art;
        if (vehicle.Pilot.Count > 0)
        {
            selectedPopUpmenu.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().sprite = vehicle.Pilot[0].cardArt;
        }

        for(int i = 0; i < vehicle.coPilots.Count; i++)
        {
            if (i <= vehicle.coPilots.Count)
            {
                selectedPopUpmenu.transform.GetChild(7).transform.GetChild(i).GetComponent<Image>().sprite = vehicle.coPilots[i].cardArt;
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(7).transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        //Labels
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = vehicle.displayName;
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(0).GetComponent<Text>().text = "Cost: " + vehicle.cost.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(1).GetComponent<Text>().text = "Attack: " + vehicle.attack.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(2).GetComponent<Text>().text = "Accuracy: " + vehicle.accuracy.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(3).GetComponent<Text>().text = "HP: " + vehicle.HP.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(4).GetComponent<Text>().text = "X-Size: " + vehicle.X.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(5).GetComponent<Text>().text = "# of Attack's: " + vehicle.atkFreq.ToString() + " per turn";
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(6).GetComponent<Text>().text = "Range: " + rangeFormat(vehicle);
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(7).GetComponent<Text>().text = "Defense: " + vehicle.defense.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(8).GetComponent<Text>().text = "Evasion: " + vehicle.evasion.ToString();
        selectedPopUpmenu.transform.GetChild(8).transform.GetChild(10).GetComponent<Text>().text = "Y-Size: " + vehicle.Y.ToString();

        if (vehicle.pilot != null)
        {
            if (vehicle.pilot.skill.Contains("None"))
            {
                selectedPopUpmenu.transform.GetChild(8).transform.GetChild(12).GetComponent<Text>().text = "Skill: " + vehicle.pilot.skill;
            }
        else
            {
                selectedPopUpmenu.transform.GetChild(8).transform.GetChild(12).GetComponent<Text>().text = "Skill: " + vehicle.pilot.skill.ToString() + "<color=#32FF00>" + " (" + vehicle.pilot.skillLevel.ToString() + "%)" + "</color>";
            }
        }

        //Tags
        for(int i = 0; i < 5; i++)
        {
            if (vehicle.pilot != null)
            {
                if (i < vehicle.pilot.tags.Count)
                {
                    selectedPopUpmenu.transform.GetChild(8).transform.GetChild(11).transform.GetChild(i).GetComponent<Image>().sprite = vehicle.pilot.tags[i];
                }
                else
                {
                    selectedPopUpmenu.transform.GetChild(8).transform.GetChild(11).transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            if (vehicle.pilot == null)
            {
                selectedPopUpmenu.transform.GetChild(8).transform.GetChild(11).transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        //Parts (finish when vehicle parts completed)
        //selectedPopUpmenu.transform.GetChild(11).transform.GetChild(i).transform.GetChild(i).GetComponent<Image>().sprite = vehicle.pilot.tags[i];

        //launch popup
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    
    public void closePopUp()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void sellVehicle()
    {
        int hangerLocation = sellHanger;

        //Do Sell logic base ship plus item upgrades

        //return pilots to inventory

        playerCards.playerHanger.RemoveAt(hangerLocation);
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void modifyVehicle()
    {
        vehicleModHelper.selectedVehicle = playerCards.playerHanger[sellHanger];
        SceneManager.LoadScene("vehicleMod");
    }

    public string rangeFormat(vehicle card)
    {
        if (card.range.Equals("S"))
        {
            return "Short";
        }

        if (card.range.Equals("M"))
        {
            return "Medium";
        }

        if (card.range.Equals("L"))
        {
            return "Long";
        }
        return "";
    }
}
