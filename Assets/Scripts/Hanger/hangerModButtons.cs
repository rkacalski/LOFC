using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hangerModButtons : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;
    public int chosenIndex;

    void Start()
    {
        print(vehicleModHelper.selectedVehicle.pilot);
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void removeCardClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void removeButton()
    {
        if (chosenIndex.Equals(0))
        {
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.Pilot[0])].isPilot = false;
            vehicleModHelper.selectedVehicle.Pilot.RemoveAt(0);
            transferStats(1);
            print("updatred attackL piolt " + vehicleModHelper.updatedATKPilot);
        }
        if (chosenIndex.Equals(1))
        {
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.coPilots[0])].isPilot = false;
            vehicleModHelper.selectedVehicle.coPilots.RemoveAt(0);
            transferStats(2);
        }
        if (chosenIndex.Equals(2))
        {
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.coPilots[1])].isPilot = false;
            vehicleModHelper.selectedVehicle.coPilots.RemoveAt(1);
            transferStats(3);
        }
        if (chosenIndex.Equals(3))
        {
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.coPilots[2])].isPilot = false;
            vehicleModHelper.selectedVehicle.coPilots.RemoveAt(2);
            transferStats(4);
        }

        chosenIndex = -1;
        SceneManager.LoadSceneAsync("vehicleMod");
    }

    public void pilotButton()
    {
        if (vehicleModHelper.selectedVehicle.Pilot.Count == 0)
        {
            SceneManager.LoadScene("pilotSelect");
        }

        if(vehicleModHelper.selectedVehicle.Pilot.Count > 0)
        {
            chosenIndex = 0;
            popUpImage.GetComponent<Image>().sprite = vehicleModHelper.selectedVehicle.Pilot[0].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void copilot1Button()
    {
        if(vehicleModHelper.selectedVehicle.coPilots.Count > 0)
        {
            chosenIndex = 1;

            popUpImage.GetComponent<Image>().sprite = vehicleModHelper.selectedVehicle.coPilots[0].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
        else
        {
            SceneManager.LoadScene("copilot1Select");
        }
    }

    public void copilot2Button()
    {
        if (vehicleModHelper.selectedVehicle.coPilots.Count == 1)
        { 
            SceneManager.LoadScene("copilot2Select");
        }
        if (vehicleModHelper.selectedVehicle.coPilots.Count > 1 && vehicleModHelper.selectedVehicle.coPilots.Count < 3)
        {
            chosenIndex = 2;

            popUpImage.GetComponent<Image>().sprite = vehicleModHelper.selectedVehicle.coPilots[1].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    public void copilot3Button()
    {
        if (vehicleModHelper.selectedVehicle.coPilots.Count == 2)
        {
            SceneManager.LoadScene("copilot3Select");
        }
        if (vehicleModHelper.selectedVehicle.coPilots.Count > 2)
        {
            chosenIndex = 3;

            popUpImage.GetComponent<Image>().sprite = vehicleModHelper.selectedVehicle.coPilots[2].cardArt;
            selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        }
    }

    void transferStats(int num)
    {
        if (num.Equals(1))
        {
            vehicleModHelper.updatedATKPilot = 0;
            vehicleModHelper.updatedDEFPilot = 0;
            vehicleModHelper.updatedACCPilot = 0;
            vehicleModHelper.updatedEVAPilot = 0;
            vehicleModHelper.updatedCostPilot = 0;
        }

        if (num.Equals(2))
        {
            if (vehicleModHelper.updatedATKcoPilot2 > 0)
            {
                vehicleModHelper.updatedATKcoPilot1 = vehicleModHelper.updatedATKcoPilot2;
                vehicleModHelper.updatedDEFcoPilot1 = vehicleModHelper.updatedDEFcoPilot2;
                vehicleModHelper.updatedACCcoPilot1 = vehicleModHelper.updatedACCcoPilot2;
                vehicleModHelper.updatedEVAcoPilot1 = vehicleModHelper.updatedEVAcoPilot2;
                vehicleModHelper.updatedCostcoPilot1 = vehicleModHelper.updatedCostcoPilot2;
            }
            if (vehicleModHelper.updatedATKcoPilot2 == 0)
            {
                vehicleModHelper.updatedATKcoPilot1 = 0;
                vehicleModHelper.updatedDEFcoPilot1 = 0;
                vehicleModHelper.updatedACCcoPilot1 = 0;
                vehicleModHelper.updatedEVAcoPilot1 = 0;
                vehicleModHelper.updatedCostcoPilot1 = 0;
            }

            vehicleModHelper.updatedATKcoPilot2 = 0;
            vehicleModHelper.updatedDEFcoPilot2 = 0;
            vehicleModHelper.updatedACCcoPilot2 = 0;
            vehicleModHelper.updatedEVAcoPilot2 = 0;
            vehicleModHelper.updatedCostcoPilot2 = 0;
        }

        if (num.Equals(3))
        {
            if (vehicleModHelper.updatedATKcoPilot3 > 0)
            {
                vehicleModHelper.updatedATKcoPilot2 = vehicleModHelper.updatedATKcoPilot3;
                vehicleModHelper.updatedDEFcoPilot2 = vehicleModHelper.updatedDEFcoPilot3;
                vehicleModHelper.updatedACCcoPilot2 = vehicleModHelper.updatedACCcoPilot3;
                vehicleModHelper.updatedEVAcoPilot2 = vehicleModHelper.updatedEVAcoPilot3;
                vehicleModHelper.updatedCostcoPilot2 = vehicleModHelper.updatedCostcoPilot3;
            }
            if (vehicleModHelper.updatedATKcoPilot3 == 0)
            {
                vehicleModHelper.updatedATKcoPilot2 = 0;
                vehicleModHelper.updatedDEFcoPilot2 = 0;
                vehicleModHelper.updatedACCcoPilot2 = 0;
                vehicleModHelper.updatedEVAcoPilot2 = 0;
                vehicleModHelper.updatedCostcoPilot2 = 0;
            }

            vehicleModHelper.updatedATKcoPilot3 = 0;
            vehicleModHelper.updatedDEFcoPilot3 = 0;
            vehicleModHelper.updatedACCcoPilot3 = 0;
            vehicleModHelper.updatedEVAcoPilot3 = 0;
            vehicleModHelper.updatedCostcoPilot3 = 0;
        }

        if(num.Equals(4))
        {
            vehicleModHelper.updatedATKcoPilot3 = 0;
            vehicleModHelper.updatedDEFcoPilot3 = 0;
            vehicleModHelper.updatedACCcoPilot3 = 0;
            vehicleModHelper.updatedEVAcoPilot3 = 0;
            vehicleModHelper.updatedCostcoPilot3 = 0;
        }
    }
}
