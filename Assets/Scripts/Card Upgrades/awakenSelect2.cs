using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class awakenSelect2 : MonoBehaviour
{
    public static int card2PosinList;
    public static int origCard2Pos;
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

    public void selectCard()
    {
        awakenManagere.card2Selected = true;
        SceneManager.LoadScene("awakenHome");
    }

    public void selectCardenhanceClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void backButton()
    {
        SceneManager.LoadScene("awakenHome");
    }

    public void selectCardenhancePopup1()
    {
        origCard2Pos = int.Parse(Origpos1.text);
        popUpImage.sprite = image1.sprite;
        card2PosinList = int.Parse(pos1.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup2()
    {
        origCard2Pos = int.Parse(Origpos2.text);
        popUpImage.sprite = image2.sprite;
        card2PosinList = int.Parse(pos2.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup3()
    {
        origCard2Pos = int.Parse(Origpos3.text);
        popUpImage.sprite = image3.sprite;
        card2PosinList = int.Parse(pos3.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup4()
    {
        origCard2Pos = int.Parse(Origpos4.text);
        popUpImage.sprite = image4.sprite;
        card2PosinList = int.Parse(pos4.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup5()
    {
        origCard2Pos = int.Parse(Origpos5.text);
        popUpImage.sprite = image5.sprite;
        card2PosinList = int.Parse(pos5.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup6()
    {
        origCard2Pos = int.Parse(Origpos6.text);
        popUpImage.sprite = image6.sprite;
        card2PosinList = int.Parse(pos6.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup7()
    {
        origCard2Pos = int.Parse(Origpos7.text);
        popUpImage.sprite = image7.sprite;
        card2PosinList = int.Parse(pos7.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup8()
    {
        origCard2Pos = int.Parse(Origpos8.text);
        popUpImage.sprite = image8.sprite;
        card2PosinList = int.Parse(pos8.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup9()
    {
        origCard2Pos = int.Parse(Origpos9.text);
        popUpImage.sprite = image9.sprite;
        card2PosinList = int.Parse(pos9.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup10()
    {
        origCard2Pos = int.Parse(Origpos10.text);
        popUpImage.sprite = image10.sprite;
        card2PosinList = int.Parse(pos10.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
}
