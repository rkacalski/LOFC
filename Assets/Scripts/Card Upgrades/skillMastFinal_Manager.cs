using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillMastFinal_Manager : MonoBehaviour
{
    public Image cardArt;
    public GameObject glow;
    public GameObject atkPanel;
    public GameObject defPanel;
    public GameObject button;
    public Text atk_Label;
    public Text def_Label;

    void Start()
    {
        cardArt.sprite = skillManager.card1.cardArt;
        atk_Label.text = skillManager.startingCardLevel.ToString() + " >> " + skillManager.card1.skillLevel.ToString("f1");
        def_Label.text = " Lvl: " + skillManager.startingLvlValue.ToString() + " >> " + skillManager.card1.baseSkillLevel.ToString();
        StartCoroutine(itemsAppear(atk_Label, def_Label, glow, atkPanel, defPanel, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void homeButton()
    {
        updatePlayerCards();
        clearStuff();
        SceneManager.LoadScene("Home Screen");
    }

    void updatePlayerCards()
    {
        skillManager.sortedBinder[skillMastSelect.cardPosinList] = skillManager.card1;
        playerCards.userCards = skillManager.sortedBinder;
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

    void clearStuff()
    {
        //Manager
        skillManager.card1 = null;
        skillManager.card1Originalskill = 0;
        skillManager.card1newskill = 0;
        skillManager.cardSelected = false;
        skillManager.sortedBinder = null;
        skillManager.startingCardLevel = 0;
        skillManager.startingLvlValue = 0;

        //Select
        skillMastSelect.cardPosinList = 0;
    }
}
