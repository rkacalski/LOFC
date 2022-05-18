using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youPacksUI : MonoBehaviour
{
    public Text playerAP;
    public Text apCardLabel;
    public Text reqApCardLabel;
    public Text packsLabel;
    public Text packDescrption;
    public Text amntPacksLabel;
    public Image cardPackArt;
    public Dropdown dd;
    public List<Sprite> packSprites = new List<Sprite>(); 

    public int requiredAP;

    public void apOneCard()
    {
        //goto card draw scene
    }

    public void apMultCard()
    {
        int num = apPackCalc();

        if (!num.Equals(1))
        {
            //goto card draw scene
        }
    }

    public int apPackCalc()
    {
        int apAmnt = player.allyPoints;

        if(apAmnt >= 2000)
        {
            requiredAP = 2000;
            return 10;
        }
        if (apAmnt < 2000 && apAmnt >= 1800)
        {
            requiredAP = 1800;
            return 9;
        }
        if (apAmnt < 1800 && apAmnt >= 1600)
        {
            requiredAP = 1600;
            return 8;
        }
        if (apAmnt < 1600 && apAmnt >= 1400)
        {
            requiredAP = 1400;
            return 7;
        }
        if (apAmnt < 1400 && apAmnt >= 1200)
        {
            requiredAP = 1200;
            return 6;
        }
        if (apAmnt < 1200 && apAmnt >= 1000)
        {
            requiredAP = 1000;
            return 5;
        }
        if (apAmnt < 1000 && apAmnt >= 800)
        {
            requiredAP = 800;
            return 4;
        }
        if (apAmnt < 800 && apAmnt >= 600)
        {
            requiredAP = 600;
            return 3;
        }
        if (apAmnt < 600 && apAmnt >= 400)
        {
            requiredAP = 400;
            return 2;
        }
        if (apAmnt < 400 && apAmnt >= 200)
        {
            requiredAP = 200;
            return 1;
        }

        return 0;
    }

    public void HandleInputData()
    {
        if (dd.value == 0)
        {
            cardPackArt.sprite = packSprites[0];
            amntPacksLabel.text = "x" + player.silverCardPack.ToString();
            packDescrption.text = "Silver Tickets will never give you 1 Star cards. However, they almost always give you 2 Star cards. But in some cases, you will get 3 to 5 star cards.";
        }
        if (dd.value == 1)
        {
            cardPackArt.sprite = packSprites[1];
            amntPacksLabel.text = "x" + player.goldCardPack.ToString();
            packDescrption.text = "Gold Card Packs will never give you 1 or 2 star cards and will most likely give you a 3 star card. But in some cases, will give you a 4 star or 5 star card.";
        }
        if (dd.value == 2)
        {
            cardPackArt.sprite = packSprites[2];
            amntPacksLabel.text = "x" + player.gold2CardPack.ToString();
            packDescrption.text = "Gold Card Packs will never give you 1 or 2 star cards and will most likely give you a 3 star card. However, the odds are doubled to obtain a 4 star or 5 star card.";
        }
        if (dd.value == 3)
        {
            cardPackArt.sprite = packSprites[3];
            amntPacksLabel.text = "x" + player.gold3CardPack.ToString();
            packDescrption.text = "Gold Card Packs will never give you 1 or 2 star cards and will most likely give you a 3 star card. However, the odds are boosted by 3 to obtain a 4 star or 5 star card.";
        }
        if (dd.value == 4)
        {
            cardPackArt.sprite = packSprites[4];
            amntPacksLabel.text = "x" + player.gold5CardPack.ToString();
            packDescrption.text = "Gold Card Packs will never give you 1 or 2 star cards and will most likely give you a 3 star card. However, the odds are boosted by 5 to obtain a 4 star or 5 star card.";
        }
        if (dd.value == 5)
        {
            cardPackArt.sprite = packSprites[5];
            amntPacksLabel.text = "x" + player.platCardPack.ToString();
            packDescrption.text = "Platinum Packs will never give you 1,2 or 3 star cards and will most likely give you a 4 star card, but in some cases, a 5 star card.";
        }
        if (dd.value == 6)
        {
            cardPackArt.sprite = packSprites[6];
            amntPacksLabel.text = "x" + player.diamondCardPack.ToString();
            packDescrption.text = "Diamond Card Packs are the rarest kind of Packs. These packs will always give you a 5 star card!";
        }
    }

    void Start()
    {
        //remove for final build
        player.allyPoints = 348;

        playerAP.text = player.allyPoints.ToString() + " AP";
        apCardLabel.text = apPackCalc().ToString() + " Cards";
        reqApCardLabel.text = "Required " + requiredAP.ToString() + " AP";

        amntPacksLabel.text = "x" + player.silverCardPack.ToString();

    }
}
