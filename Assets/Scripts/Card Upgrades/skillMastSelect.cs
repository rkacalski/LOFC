using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillMastSelect : MonoBehaviour
{
    public static int cardPosinList;
    public static int origCardPos;
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
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void closeWindow()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
    }

    public void selectCard()
    {
        skillManager.cardSelected = true;
        SceneManager.LoadScene("skillMastMain");
    }

    public void selectCardenhancePopup1()
    {
        origCardPos = int.Parse(Origpos1.text);
        popUpImage.sprite = image1.sprite;
        cardPosinList = int.Parse(pos1.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup2()
    {
        origCardPos = int.Parse(Origpos2.text);
        popUpImage.sprite = image2.sprite;
        cardPosinList = int.Parse(pos2.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup3()
    {
        origCardPos = int.Parse(Origpos3.text);
        popUpImage.sprite = image3.sprite;
        cardPosinList = int.Parse(pos3.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup4()
    {
        origCardPos = int.Parse(Origpos4.text);
        popUpImage.sprite = image4.sprite;
        cardPosinList = int.Parse(pos4.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup5()
    {
        origCardPos = int.Parse(Origpos5.text);
        popUpImage.sprite = image5.sprite;
        cardPosinList = int.Parse(pos5.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup6()
    {
        origCardPos = int.Parse(Origpos6.text);
        popUpImage.sprite = image6.sprite;
        cardPosinList = int.Parse(pos6.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup7()
    {
        origCardPos = int.Parse(Origpos7.text);
        popUpImage.sprite = image7.sprite;
        cardPosinList = int.Parse(pos7.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup8()
    {
        origCardPos = int.Parse(Origpos8.text);
        popUpImage.sprite = image8.sprite;
        cardPosinList = int.Parse(pos8.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup9()
    {
        origCardPos = int.Parse(Origpos9.text);
        popUpImage.sprite = image9.sprite;
        cardPosinList = int.Parse(pos9.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup10()
    {
        origCardPos = int.Parse(Origpos10.text);
        popUpImage.sprite = image10.sprite;
        cardPosinList = int.Parse(pos10.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
}
