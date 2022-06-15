using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectcoPilotI2PopUpUI : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;
    public Card tempCard;

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
    }

    public void selectCardClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void selectButton()
    {
        updateStats();
        SceneManager.LoadSceneAsync("vehicleMod");
    }

    public void popup1()
    {
        selectedCard = 1;
        tempCard = playerCards.userCards[int.Parse(pos1.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup2()
    {
        selectedCard = 2;
        tempCard = playerCards.userCards[int.Parse(pos2.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup3()
    {
        selectedCard = 3;
        tempCard = playerCards.userCards[int.Parse(pos3.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup4()
    {
        selectedCard = 4;
        tempCard = playerCards.userCards[int.Parse(pos4.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup5()
    {
        selectedCard = 5;
        tempCard = playerCards.userCards[int.Parse(pos5.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup6()
    {
        selectedCard = 6;
        tempCard = playerCards.userCards[int.Parse(pos6.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup7()
    {
        selectedCard = 7;
        tempCard = playerCards.userCards[int.Parse(pos7.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup8()
    {
        selectedCard = 8;
        tempCard = playerCards.userCards[int.Parse(pos8.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup9()
    {
        selectedCard = 9;
        tempCard = playerCards.userCards[int.Parse(pos9.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup10()
    {
        selectedCard = 10;
        tempCard = playerCards.userCards[int.Parse(pos10.text)];
        popUpImage.GetComponent<Image>().sprite = tempCard.cardArt;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void updateStats()
    {
        if (selectedCard.Equals(1))
        {
            tempCard = playerCards.userCards[int.Parse(pos1.text)];
            playerCards.userCards[int.Parse(pos1.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk1New = atk1.text;
            atk1New = atk1New.Substring(atk1New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk1New);
            string def1New = def1.text;
            def1New = def1New.Substring(def1New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def1New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(2))
        {
            tempCard = playerCards.userCards[int.Parse(pos2.text)];
            playerCards.userCards[int.Parse(pos2.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk2New = atk2.text;
            atk2New = atk2New.Substring(atk2New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk2New);
            string def2New = def2.text;
            def2New = def2New.Substring(def2New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def2New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(3))
        {
            tempCard = playerCards.userCards[int.Parse(pos3.text)];
            playerCards.userCards[int.Parse(pos3.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk3New = atk3.text;
            atk3New = atk3New.Substring(atk3New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk3New);
            string def3New = def3.text;
            def3New = def3New.Substring(def3New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def3New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(4))
        {
            tempCard = playerCards.userCards[int.Parse(pos4.text)];
            playerCards.userCards[int.Parse(pos4.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk4New = atk4.text;
            atk4New = atk4New.Substring(atk4New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk4New);
            string def4New = def4.text;
            def4New = def4New.Substring(def4New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def4New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(5))
        {
            tempCard = playerCards.userCards[int.Parse(pos5.text)];
            playerCards.userCards[int.Parse(pos5.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk5New = atk5.text;
            atk5New = atk5New.Substring(atk5New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk5New);
            string def5New = def5.text;
            def5New = def5New.Substring(def5New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def5New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(6))
        {
            tempCard = playerCards.userCards[int.Parse(pos6.text)];
            playerCards.userCards[int.Parse(pos6.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk6New = atk6.text;
            atk6New = atk6New.Substring(atk6New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk6New);
            string def6New = def6.text;
            def6New = def6New.Substring(def6New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def6New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(7))
        {
            tempCard = playerCards.userCards[int.Parse(pos7.text)];
            playerCards.userCards[int.Parse(pos7.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk7New = atk7.text;
            atk7New = atk7New.Substring(atk7New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk7New);
            string def7New = def7.text;
            def7New = def7New.Substring(def7New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def7New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(8))
        {
            tempCard = playerCards.userCards[int.Parse(pos8.text)];
            playerCards.userCards[int.Parse(pos8.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk8New = atk8.text;
            atk8New = atk8New.Substring(atk8New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk8New);
            string def8New = def8.text;
            def8New = def8New.Substring(def8New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def8New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(9))
        {
            tempCard = playerCards.userCards[int.Parse(pos9.text)];
            playerCards.userCards[int.Parse(pos9.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk9New = atk9.text;
            atk9New = atk9New.Substring(atk9New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk9New);
            string def9New = def9.text;
            def9New = def9New.Substring(def9New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def9New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }

        if (selectedCard.Equals(10))
        {
            tempCard = playerCards.userCards[int.Parse(pos10.text)];
            playerCards.userCards[int.Parse(pos10.text)].isPilot = true;
            vehicleModHelper.selectedVehicle.coPilots.Insert(1, tempCard);

            string atk10New = atk10.text;
            atk10New = atk10New.Substring(atk10New.LastIndexOf("+") + 1);
            int updatedATK = int.Parse(atk10New);
            string def10New = def10.text;
            def10New = def10New.Substring(def10New.LastIndexOf("+") + 1);
            int updatedDEF = int.Parse(def10New);
            vehicleModHelper.updatedATKcoPilot2 += updatedATK;
            vehicleModHelper.updatedDEFcoPilot2 += updatedDEF;
            vehicleModHelper.updatedCostcoPilot2 += tempCard.cost;
        }
    }
}
