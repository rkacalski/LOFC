using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tat6_L_N_UI : MonoBehaviour
{
    public tat6_L_baseChecks_N checks;
    public Text Level1;
    public Text Level2;
    public Text Level3;
    public Text Level4;
    public Text Level5;
    public Text Level6;

    // Start is called before the first frame update
    void Start()
    {
        //Check level 1
        if (checks.tat6_1_check() == true)
        {
            Level1.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }
        else
        {
            Level1.GetComponent<UnityEngine.UI.Text>().text = "";

        }

        //Check level 2
        if (checks.tat6_2_check() == true)
        {
            Level2.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            Level2.GetComponent<UnityEngine.UI.Text>().text = "Locked";

        }

        if (questProgress.tat6_2_complete_L_N == true)
        {
            Level2.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }

        //Check level 3
        if (checks.tat6_3_check() == true)
        {
            Level3.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            Level3.GetComponent<UnityEngine.UI.Text>().text = "Locked";

        }

        if (questProgress.tat6_3_complete_L_N == true)
        {
            Level3.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }

        //Check level 4
        if (checks.tat6_4_check() == true)
        {
            Level4.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            Level4.GetComponent<UnityEngine.UI.Text>().text = "Locked";

        }

        if (questProgress.tat6_4_complete_L_N == true)
        {
            Level4.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }

        //Check level 5
        if (checks.tat6_5_check() == true)
        {
            Level5.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            Level5.GetComponent<UnityEngine.UI.Text>().text = "Locked";

        }

        if (questProgress.tat6_5_complete_L_N == true)
        {
            Level5.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }

        //Check level 6
        if (checks.tat6_6_check() == true)
        {
            Level6.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            Level6.GetComponent<UnityEngine.UI.Text>().text = "Locked";

        }

        if (questProgress.tat6_6_complete_L_N == true)
        {
            Level6.GetComponent<UnityEngine.UI.Text>().text = "Cleared";
        }
    }

    ////////////////       Enter Map Buttons     //////////////////

    public void enterTat6_1()
    {
        if (Level1.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level1.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void enterTat6_2()
    {
        if (Level2.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level2.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void enterTat6_3()
    {
        if (Level3.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level3.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void enterTat6_4()
    {
        if (Level4.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level4.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void enterTat6_5()
    {
        if (Level5.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level5.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void enterTat6_6()
    {
        if (Level6.GetComponent<UnityEngine.UI.Text>().text.Equals("") || Level6.GetComponent<UnityEngine.UI.Text>().text.Equals("Cleared"))
        {
            SceneManager.LoadScene("");
        }
    }

    public void backButton()
    {
        SceneManager.LoadScene("GCW_tat_L_Select");
    }
}
