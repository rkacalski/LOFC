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
        vehicleModHelper.selectedVehicle.pilot = tempCard;
        print(vehicleModHelper.selectedVehicle.pilot.cardName);
        SceneManager.LoadScene("vehicleMod");
    }

    public void popup1()
    {
        tempCard = playerCards.userCards[int.Parse(pos1.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();

    }
}
