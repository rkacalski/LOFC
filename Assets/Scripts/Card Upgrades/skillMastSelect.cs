using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillMastSelect : MonoBehaviour
{
    public static int cardPosinList;
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
       popUpImage.sprite = image1.sprite;
       cardPosinList = int.Parse(pos1.text);
       selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup2()
    {
        popUpImage.sprite = image2.sprite;
        cardPosinList = int.Parse(pos2.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup3()
    {
        popUpImage.sprite = image3.sprite;
        cardPosinList = int.Parse(pos3.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup4()
    {
        popUpImage.sprite = image4.sprite;
        cardPosinList = int.Parse(pos4.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup5()
    {
        popUpImage.sprite = image5.sprite;
        cardPosinList = int.Parse(pos5.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup6()
    {
        popUpImage.sprite = image6.sprite;
        cardPosinList = int.Parse(pos6.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup7()
    {
        popUpImage.sprite = image7.sprite;
        cardPosinList = int.Parse(pos7.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup8()
    {
        popUpImage.sprite = image8.sprite;
        cardPosinList = int.Parse(pos8.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup9()
    {
        popUpImage.sprite = image9.sprite;
        cardPosinList = int.Parse(pos9.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
    public void selectCardenhancePopup10()
    {
        popUpImage.sprite = image10.sprite;
        cardPosinList = int.Parse(pos10.text);
        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
}
