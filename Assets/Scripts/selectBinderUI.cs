using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectBinderUI : MonoBehaviour
{
    public GameObject selectedPopUpmenu;
    public Image popUpImage;
    public Card tempCard;
    int tagCount;
    bool showRarity;

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

    public List<Sprite> attackPatterns = new List<Sprite>();
    public Sprite atkPat;

    public string maxLevel(Card card)
    {
        if(card.rarity.Equals(1))
        {
            return "(Max 20)";
        }
        if (card.rarity.Equals(2))
        {
            return "(Max 30)";
        }
        if (card.rarity.Equals(3))
        {
            return "(Max 40)";
        }
        if (card.rarity.Equals(4))
        {
            return "(Max 50)";
        }
        if (card.rarity.Equals(5))
        {
            return "(Max 60)";
        }

        return "";
    }

    public string rangeFormat(Card card)
    {
        if (card.range.Equals("S"))
        {
            return "Short";
        }

        if (card.range.Equals("M"))
        {
            return "Medium";
        }

        if (card.range.Equals("L"))
        {
            return "Long";
        }
        return "";
    }

    public string atkPatternDesc(Card card)
    {
        if (card.atkPatern.Equals("1 -on- 1"))
        {
            atkPat = attackPatterns[0];
            return "Attacks 1 unit within range in the front row.";
        }

        if (card.atkPatern.Equals("sweep"))
        {
            atkPat = attackPatterns[1];
            return "Attacks cards in a single horizontal row.";
        }

        if (card.atkPatern.Equals("pierce"))
        {
            atkPat = attackPatterns[2];
            return "Attacks cards in a single vertical row.";
        }

        if (card.atkPatern.Equals("anti-armor"))
        {
            atkPat = attackPatterns[1];
            return "Attacks one vehicle within range. If there are no vehicles it will attack in a 1 -on- 1 pattern.";
        }

        if (card.atkPatern.Equals("semi-circle"))
        {
            atkPat = attackPatterns[4];
            return "Attacks cards within a semi-circle pattern around one targeted card";
        }

        if (card.atkPatern.Equals("turbolaser"))
        {
            atkPat = attackPatterns[3];
            return "Attacks a random space in the enemy formation (Spaces with Vehicles are prioritized), and units positioned directly in front of, directly behind and adjacent to that space.";
        }
        return "";
    }

    public Sprite atkPatternImage(Card card)
    {
        if (card.atkPatern.Equals("1 -on- 1"))
        {
            atkPat = attackPatterns[0];
            return atkPat;
        }

        if (card.atkPatern.Equals("sweep"))
        {
            atkPat = attackPatterns[1];
            return atkPat;
        }

        if (card.atkPatern.Equals("pierce"))
        {
            atkPat = attackPatterns[2];
            return atkPat;
        }

        if (card.atkPatern.Equals("anti-armor"))
        {
            atkPat = attackPatterns[1];
            return atkPat;
        }

        if (card.atkPatern.Equals("semi-circle"))
        {
            atkPat = attackPatterns[4];
            return atkPat;
        }

        if (card.atkPatern.Equals("turbolaser"))
        {
            atkPat = attackPatterns[3];
            return atkPat;
        }
        return attackPatterns[0]; ;
    }

    public string skillDescription(Card card)
    {
        string descrpt = card.skillDescript;

        //regular
        descrpt = descrpt.Replace("level", "<color=#32FF00>" + card.skillLevel.ToString() + "%" + "</color>");
        return descrpt;
    }

    public string cardType(Card card)
    {
        if(card.cardName.Contains("base"))
        {
            return "";
        }
        if (card.cardName.Contains("evo1"))
        {
            return "<color=#EBD252> Evo1 </color>";
        }
        if (card.cardName.Contains("evo2") && !card.cardName.Contains("+"))
        {
            return "<color=#32FF00> Evo2 </color>";
        }
        if (card.cardName.Contains("evo2+"))
        {
            return "<color=#EBD252> Evo2+ </color>";
        }

        if (card.cardName.Contains("evomax") && !card.cardName.Contains("+"))
        {
            return "<color=#32FF00> evomax </color>";
        }
        if (card.cardName.Contains("evomax+"))
        {
            return "<color=#EBD252> evomax+ </color>";
        }

        if (card.cardName.Contains("awakened") && !card.cardName.Contains("+"))
        {
            return "<color=#32FF00> Awakened </color>";
        }
        if (card.cardName.Contains("awakened+"))
        {
            return "<color=#EBD252> Awakened+ </color>";
        }
        return "";
    }

    void Start()
    {
        selectedPopUpmenu.transform.localScale = Vector2.zero;
        showRarity = true;
    }

    public void selectCardClose()
    {
        selectedPopUpmenu.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
        showRarity = false;
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    public void popup1()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos1.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);

            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup2()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos2.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup3()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos3.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup4()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos4.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup5()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos5.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup6()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos6.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup7()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos7.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup8()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos8.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup9()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos9.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void popup10()
    {
        showRarity = true;
        tempCard = playerCards.userCards[int.Parse(pos10.text)];

        //Card Rarity
        if (showRarity == true)
        {
            if (tempCard.rarity == 1)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 2)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 3)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 4)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            }
            if (tempCard.rarity == 5)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(6).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
        }

        //Card type
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(7).GetComponent<Text>().text = cardType(tempCard);

        //Card Name
        selectedPopUpmenu.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = tempCard.displayName;

        //Card Art
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = tempCard.cardArt;

        //Card Level
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = "Level: " + tempCard.level + " " + maxLevel(tempCard);

        //Card Cost
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Cost: " + tempCard.cost.ToString();

        //Card Range
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Range: " + rangeFormat(tempCard);

        //Card Attack
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(3).GetComponent<Text>().text = "Attack: " + tempCard.attack.ToString();

        //Card Defense
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(4).GetComponent<Text>().text = "Defense: " + tempCard.defense.ToString();

        //Card Accuracy
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(5).GetComponent<Text>().text = "Accuracy: " + tempCard.accuracy.ToString();

        //Card Evasion
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(6).GetComponent<Text>().text = "Evasion: " + tempCard.evasion.ToString();

        //Card num of Attacks
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(7).GetComponent<Text>().text = "Num of Attacks: " + tempCard.NumofATKs.ToString();

        //Card tags
        tagCount = tempCard.tags.Count;
        for (int k = 0; k < 9; k++)
        {
            if (tagCount != 10)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(k).gameObject.SetActive(true);
            }
        }
        for (int j = 0; j < 10; j++)
        {
            if (j < tagCount)
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).GetComponent<Image>().sprite = tempCard.tags[j];
            }
            else
            {
                selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(3).transform.GetChild(j).gameObject.SetActive(false);
            }
        }

        //Card atk pattern image
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(5).GetComponent<Image>().sprite = atkPatternImage(tempCard);

        //card atk pattern label
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(9).GetComponent<Text>().text = "Attack Pattern: " + tempCard.atkPatern.ToString();

        //card atk pattern descript
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(10).GetComponent<Text>().text = atkPatternDesc(tempCard);

        //card skill
        if (tempCard.skill.Contains("None"))
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString();
        }
        else
        {
            selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(14).GetComponent<Text>().text = "Skill: " + tempCard.skill.ToString() + "<color=#32FF00>" + " (" + tempCard.skillLevel.ToString() + "%)" + "</color>";
        }

        //card skill descrption
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(15).GetComponent<Text>().text = skillDescription(tempCard);

        //card bio
        selectedPopUpmenu.transform.GetChild(2).transform.GetChild(0).transform.GetChild(2).transform.GetChild(16).GetComponent<Text>().text = tempCard.cardDescript.ToString();

        selectedPopUpmenu.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }
}
