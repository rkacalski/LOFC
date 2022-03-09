using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cardSelect : MonoBehaviour
{
    public GameObject selectedPopUpmenu;

    public Text index1;
    public Text index2;
    public Text index3;
    public Text index4;
    public Text index5;
    public Text index6;
    public Text index7;
    public Text index8;
    public Text index9;
    public Text index10;

    public Image popUpImage;
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

    public Text index1Level;
    public Text index2Level;
    public Text index3Level;
    public Text index4Level;
    public Text index5Level;
    public Text index6Level;
    public Text index7Level;
    public Text index8Level;
    public Text index9Level;
    public Text index10Level;

    public Text index1Rarity;
    public Text index2Rarity;
    public Text index3Rarity;
    public Text index4Rarity;
    public Text index5Rarity;
    public Text index6Rarity;
    public Text index7Rarity;
    public Text index8Rarity;
    public Text index9Rarity;
    public Text index10Rarity;

    public Text index1name;
    public Text index2name;
    public Text index3name;
    public Text index4name;
    public Text index5name;
    public Text index6name;
    public Text index7name;
    public Text index8name;
    public Text index9name;
    public Text index10name;

    public static int card1PosinList;
    public static int card2PosinList;

    public static string card1Level;
    public static string card2Level;

    public static int card1rarity;
    public static int card2rarity;

    public static string card1Name;
    public static string card2Name;

    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    //Binder


    //Enhance
    public void selectCard()
    {
        cardManager.cardSelected = true;
        SceneManager.LoadScene("enhanceCardMain");
    }
    public void selectCardenhancePopup1()
    {
        card1Name = index1name.text;
        card1PosinList = int.Parse(index1.text);
        card1rarity = int.Parse(index1Rarity.text);
        card1Level = index1Level.text;
        popUpImage.sprite = image1.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();print(card1Level);
    }
    public void selectCardenhancePopup2()
    {
        card1Name = index2name.text;
        card1PosinList = int.Parse(index2.text);
        card1rarity = int.Parse(index2Rarity.text);
        card1Level = index2Level.text;
        popUpImage.sprite = image2.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index2.text);
    }
    public void selectCardenhancePopup3()
    {
        card1Name = index3name.text;
        card1PosinList = int.Parse(index3.text);
        card1rarity = int.Parse(index3Rarity.text);
        card1Level = index3Level.text;
        popUpImage.sprite = image3.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index3.text);
    }
    public void selectCardenhancePopup4()
    {
        card1Name = index4name.text;
        card1PosinList = int.Parse(index4.text);
        card1rarity = int.Parse(index4Rarity.text);
        card1Level = index4Level.text;
        popUpImage.sprite = image4.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index4.text);
    }
    public void selectCardenhancePopup5()
    {
        card1Name = index5name.text;
        card1PosinList = int.Parse(index5.text);
        card1rarity = int.Parse(index5Rarity.text);
        card1Level = index5Level.text;
        popUpImage.sprite = image5.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index5.text);
    }
    public void selectCardenhancePopup6()
    {
        card1Name = index6name.text;
        card1PosinList = int.Parse(index6.text);
        card1rarity = int.Parse(index6Rarity.text);
        card1Level = index6Level.text;
        popUpImage.sprite = image6.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index6.text);
    }
    public void selectCardenhancePopup7()
    {
        card1Name = index7name.text;
        card1PosinList = int.Parse(index7.text);
        card1rarity = int.Parse(index7Rarity.text);
        card1Level = index7Level.text;
        popUpImage.sprite = image7.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index7.text);
    }
    public void selectCardenhancePopup8()
    {
        card1Name = index8name.text;
        card1PosinList = int.Parse(index8.text);
        card1rarity = int.Parse(index8Rarity.text);
        card1Level = index8Level.text;
        popUpImage.sprite = image8.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index8.text);
    }
    public void selectCardenhancePopup9()
    {
        card1Name = index9name.text;
        card1PosinList = int.Parse(index9.text);
        card1rarity = int.Parse(index9Rarity.text);
        card1Level = index9Level.text;
        popUpImage.sprite = image9.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index9.text);
    }
    public void selectCardenhancePopup10()
    {
        card1Name = index10name.text;
        card1PosinList = int.Parse(index10.text);
        card1rarity = int.Parse(index10Rarity.text);
        card1Level = index10Level.text;
        popUpImage.sprite = image10.sprite;
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        print(index10.text);
    }

    public void selectCardenhanceClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    //Evolve


    //Awaken


    //Skill Mastery

}
