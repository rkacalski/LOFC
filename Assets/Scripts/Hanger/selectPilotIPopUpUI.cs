using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectPilotIPopUpUI : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;
    Card tempCard;

    int selectedCard;

    public Text pos1;
    public Text pos2;
    public Text pos3;
    public Text pos4;
    public Text pos5;
    public Text pos6;
    public Text pos7;
    public Text pos8;
    public Text pos9;
    public Text pos10;

    public Text atk1;
    public Text atk2;
    public Text atk3;
    public Text atk4;
    public Text atk5;
    public Text atk6;
    public Text atk7;
    public Text atk8;
    public Text atk9;
    public Text atk10;

    public Text def1;
    public Text def2;
    public Text def3;
    public Text def4;
    public Text def5;
    public Text def6;
    public Text def7;
    public Text def8;
    public Text def9;
    public Text def10;

    public static Card pilotCard;

    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
        print(vehicleModHelper.selectedVehicle.pilot);
    }

    public void selectCardClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void selectButton()
    {
        updateStats();
        print("Selected Card: " + pilotHelper.pilot.cardName);
        vehicleModHelper.selectedVehicle.pilot = pilotHelper.pilot;
        print("Update sleected Card is: " + vehicleModHelper.selectedVehicle.pilot.cardName);
        vehicleModHelper.selectedVehicle.Pilot.Add(pilotHelper.pilot);
        SceneManager.LoadSceneAsync("vehicleMod");
    }

    public void popup1()
    {
        selectedCard = 1;
        tempCard = playerCards.userCards[int.Parse(pos1.text)];
        playerCards.userCards[int.Parse(pos1.text)].isPilot = true;
        pilotHelper.pilot = tempCard;
        print("temp Card: " + tempCard.cardName);
        //vehicleModHelper.selectedVehicle.pilot = playerCards.userCards[int.Parse(pos1.text)];
        print("Set 1 Pilot: " + vehicleModHelper.selectedVehicle.pilot);
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup2()
    {
        selectedCard = 2;
        tempCard = playerCards.userCards[int.Parse(pos2.text)];
        playerCards.userCards[int.Parse(pos2.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup3()
    {
        selectedCard = 3;
        tempCard = playerCards.userCards[int.Parse(pos3.text)];
        playerCards.userCards[int.Parse(pos3.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup4()
    {
        selectedCard = 4;
        tempCard = playerCards.userCards[int.Parse(pos4.text)];
        playerCards.userCards[int.Parse(pos4.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup5()
    {
        selectedCard = 5;
        tempCard = playerCards.userCards[int.Parse(pos5.text)];
        playerCards.userCards[int.Parse(pos5.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup6()
    {
        selectedCard = 6;
        tempCard = playerCards.userCards[int.Parse(pos6.text)];
        playerCards.userCards[int.Parse(pos6.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup7()
    {
        selectedCard = 7;
        tempCard = playerCards.userCards[int.Parse(pos7.text)];
        playerCards.userCards[int.Parse(pos7.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup8()
    {
        selectedCard = 8;
        tempCard = playerCards.userCards[int.Parse(pos8.text)];
        playerCards.userCards[int.Parse(pos8.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup9()
    {
        selectedCard = 9;
        tempCard = playerCards.userCards[int.Parse(pos9.text)];
        playerCards.userCards[int.Parse(pos9.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup10()
    {
        selectedCard = 10;
        tempCard = playerCards.userCards[int.Parse(pos10.text)];
        playerCards.userCards[int.Parse(pos10.text)].isPilot = true;
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void updateStats()
    {
        if(selectedCard.Equals(1))
        {
            string atk1New = atk1.text;
            atk1New = atk1New.Substring(atk1New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk1New);
            vehicleModHelper.updatedATKPilot += updatedATK;
        }

        if (selectedCard.Equals(2))
        {
            string atk2New = atk2.text;
            atk2New = atk2New.Substring(atk2New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk2New);
            vehicleModHelper.updatedATKPilot += updatedATK;
        }
    }
}
