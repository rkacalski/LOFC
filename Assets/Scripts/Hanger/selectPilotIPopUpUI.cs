using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectPilotIPopUpUI : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;
    public Card tempCard;

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

    public static Card pilotCard;

    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void selectCardClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void selectButton()
    {
        SceneManager.LoadSceneAsync("vehicleMod");
    }

    public void popup1()
    {
        tempCard = playerCards.userCards[int.Parse(pos1.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup2()
    {
        tempCard = playerCards.userCards[int.Parse(pos2.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup3()
    {
        tempCard = playerCards.userCards[int.Parse(pos3.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup4()
    {
        tempCard = playerCards.userCards[int.Parse(pos4.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup5()
    {
        tempCard = playerCards.userCards[int.Parse(pos5.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup6()
    {
        tempCard = playerCards.userCards[int.Parse(pos6.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup7()
    {
        tempCard = playerCards.userCards[int.Parse(pos7.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup8()
    {
        tempCard = playerCards.userCards[int.Parse(pos8.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup9()
    {
        tempCard = playerCards.userCards[int.Parse(pos9.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup10()
    {
        tempCard = playerCards.userCards[int.Parse(pos10.text)];
        //vehicleModHelper.selectedVehicle.pilot = tempCard;
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
}
