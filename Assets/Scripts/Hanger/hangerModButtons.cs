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
            print(playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.pilot));
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.pilot)].isPilot = false;
            vehicleModHelper.selectedVehicle.pilot = null;
        }
        if (chosenIndex.Equals(1))
        {
            print(playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.coPilots[0]));
            playerCards.userCards[playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.coPilots[0])].isPilot = false;
            vehicleModHelper.selectedVehicle.coPilots.RemoveAt(0);
        }
        if (chosenIndex.Equals(2))
        {
            print(playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.pilot));
        }
        if (chosenIndex.Equals(3))
        {
            print(playerCards.userCards.IndexOf(vehicleModHelper.selectedVehicle.pilot));
        }

        chosenIndex = -1;
        SceneManager.LoadSceneAsync("vehicleMod");
    }

    public void pilotButton()
    {
        if (vehicleModHelper.selectedVehicle.pilot == null)
        {
            SceneManager.LoadScene("pilotSelect");
        }

        if(vehicleModHelper.selectedVehicle.pilot != null)
        {
            chosenIndex = 0;
            popUpImage.GetComponent<Image>().sprite = vehicleModHelper.selectedVehicle.pilot.cardArt;
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
    }

    public void copilot3Button()
    {
        if (vehicleModHelper.selectedVehicle.coPilots.Count == 2)
        {
            SceneManager.LoadScene("copilot3Select");
        }
    }
}
