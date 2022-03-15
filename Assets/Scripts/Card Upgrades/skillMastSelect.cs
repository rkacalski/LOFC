using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillMastSelect : MonoBehaviour
{
    public static int cardPosinList;
    public GameObject selectedPopUpmenu;
    public Text pos1;
    public Image popUpImage;

    public Image image1;



    // Start is called before the first frame update
    void Start()
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
}
