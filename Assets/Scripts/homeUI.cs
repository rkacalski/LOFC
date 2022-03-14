using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeUI : MonoBehaviour
{
    public GameObject Image;
    public int check;
    public int playerInv;

    public void questButton()
    {
        SceneManager.LoadScene("questTest");
    }

    public void battleButton()
    {
        SceneManager.LoadScene("endor_6.6_N");
    }

    public void cardButton()
    {
        print(check);
        check = 1;
        if(check != 0)
        {
            Image.transform.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            check = 0;
        }
    }

    public void operationsButton()
    {

    }

    public void allyButton()
    {

    }

    public void chatButton()
    {

    }

    public void addStarterCards()
    {
        playerInv = playerCards.userCards.Count;
        if (playerInv == 0)
        {
            playerCards.userCards = Resources.LoadAll<Card>("Prefabs/1Star/Base/nGunray_1Star_base").ToList();
            print(playerCards.userCards.Count);
            print(playerCards.userCards[0].displayName);
        }
        playerInv = 1;
    }

    //Enhance Button
    public void enhance()
    {
        SceneManager.LoadScene("enhanceCardMain");
    }

    // Start is called before the first frame update
    void Start()
    {
        addStarterCards();
        check = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
