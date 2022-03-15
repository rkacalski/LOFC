using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enhanceManager : MonoBehaviour
{
    public Image cardArt;
    public GameObject glow;
    public GameObject atkPanel;
    public GameObject defPanel;
    public GameObject button;
    public Text atk_Label;
    public Text def_Label;

    // Start is called before the first frame update
    void Start()
    {
        cardArt.sprite = cardManager.card1.cardArt;
        atk_Label.text = " ATK: " + cardManager.card1OriginalATK.ToString() + " >> " + cardManager.card1.attack.ToString();
        def_Label.text = " DEF: " + cardManager.card1OrigonalDEF.ToString() + " >> " + cardManager.card1.defense.ToString();
        StartCoroutine(itemsAppear(atk_Label, def_Label, glow, atkPanel, defPanel, 4));
    }

    //button
    public void homeButton()
    {
        clearStuff();
        updatePlayerCards();
        SceneManager.LoadScene("Home Screen");
    }

    IEnumerator itemsAppear(Text atk, Text def, GameObject glw, GameObject aPanel, GameObject dPanel, float delay)
    {
        button.SetActive(false);
        atk.transform.localScale = Vector2.zero;
        def.transform.localScale = Vector2.zero;
        glw.transform.localScale = Vector2.zero;
        aPanel.transform.localScale = Vector2.zero;
        dPanel.transform.localScale = Vector2.zero;

        yield return new WaitForSeconds(delay);

        atk.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        def.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        glw.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        aPanel.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        dPanel.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        button.SetActive(true);
    }

    void updatePlayerCards()
    {
        playerCards.userCards = cardManager.sortedBinder;
    }

    void clearStuff()
    {
        //Manager
        cardManager.card1 = null;
        cardManager.card1OriginalATK = 0;
        cardManager.card1OrigonalDEF = 0;
        cardManager.card1newATK = 0;
        cardManager.card1newDEF = 0;
        cardManager.cardSelected = false;

        //Select
        cardSelect.card1PosinList = -1;
        cardSelect.card2PosinList = -1;
        cardSelect.card1Level = null;
        cardSelect.card2Level = null;
        cardSelect.card1rarity = 0;
        cardSelect.card2rarity = 0;
        cardSelect.card1Name = null;
        cardSelect.card2Name = null;
    }
}
