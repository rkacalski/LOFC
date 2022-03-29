using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class forTradeSelect : MonoBehaviour
{
    public static int cardPosinList;
    public static int origCardPos;
    public static int cardSlot;
    public GameObject selectedPopUpmenu;
    public Image popUpImage;

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

    public Text Origpos1;
    public Text Origpos2;
    public Text Origpos3;
    public Text Origpos4;
    public Text Origpos5;
    public Text Origpos6;
    public Text Origpos7;
    public Text Origpos8;
    public Text Origpos9;
    public Text Origpos10;

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;

    // Start is called before the first frame update
    void Start()
    {
        print("Should be 0: " + cardSlot);
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void closeWindow()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void selectCard()
    {
        playerCards.forTrade[cardSlot] = playerCards.userCards[origCardPos];
        print("Main Deck" + playerCards.userCards[origCardPos].cardName);
        print("For Trade" + playerCards.forTrade[cardSlot].cardName);
        SceneManager.LoadScene("tradeBlock");
    }

    public void selectCardenhancePopup1()
    {
        origCardPos = int.Parse(Origpos1.text);
        popUpImage.sprite = image1.sprite;
        cardPosinList = int.Parse(pos1.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(origCardPos);
    }
}
