using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GCW_main_UI : MonoBehaviour
{
    public GCW_checks checks;
    public GameObject DSLocked;
    public GameObject Y4Locked;
    public GameObject HTHLocked;
    public GameObject BESLocked;
    public GameObject ENDLocked;

    public Text tatProg;
    public Text dsProg;
    public Text y4Prog;
    public Text hthProg;
    public Text besProg;
    public Text endProg;

    int count;

    void Start()
    {
        if(checks.DS_L_N_Check() == true || checks.DS_D_N_Check() == true)
        {
            DSLocked.SetActive(false);
        }

        getnumbers(1);
    }


    ///////////// Buttons ///////////////////

    public void GCW_tat_L()
    {
        SceneManager.LoadScene("GCW_tat_L_Select");
    }

    public void GCW_tat_D()
    {
        SceneManager.LoadScene("");

    }

    public void GCW_DS_L()
    {
        if(checks.DS_L_N_Check() == true)
        {
            SceneManager.LoadScene("");

        }
    }

    public void GCW_DS_D()
    {
        if (checks.DS_D_N_Check() == true)
        {
            SceneManager.LoadScene("");
        }
    }

    public void GCW_Y4_L()
    {
        
    }

    public void GCW_Y4_D()
    {

    }

    public void GCW_hth_L()
    {

    }

    public void GCW_hth_D()
    {

    }

    public void GCW_bes_L()
    {

    }

    public void GCW_bes_D()
    {

    }

    public void GCW_end_L()
    {

    }
    public void GCW_end_D()
    {

    }

    public void backButton()
    {
        SceneManager.LoadScene("QuestHome");
    }

    public void getnumbers(int Level)
    {
        if (Level.Equals(1))
        {
            for (int i = 0; i < questProgress.tat1_L_N.Count; i++)
            {
                if (questProgress.tat1_L_N[i] == true)
                {
                    count += 1;
                }
            }

            for (int i = 0; i < questProgress.tat2_L_N.Count; i++)
            {
                if (questProgress.tat2_L_N[i] == true)
                {
                    count += 1;
                }
            }
            for (int i = 0; i < questProgress.tat3_L_N.Count; i++)
            {
                if (questProgress.tat3_L_N[i] == true)
                {
                    count += 1;
                }
            }
            for (int i = 0; i < questProgress.tat4_L_N.Count; i++)
            {
                if (questProgress.tat4_L_N[i] == true)
                {
                    count += 1;
                }
            }
            for (int i = 0; i < questProgress.tat5_L_N.Count; i++)
            {
                if (questProgress.tat5_L_N[i] == true)
                {
                    count += 1;
                }
            }
            for (int i = 0; i < questProgress.tat6_L_N.Count; i++)
            {
                if (questProgress.tat6_L_N[i] == true)
                {
                    count += 1;
                }
            }

            tatProg.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/72";
            count = 0;
        }

        //Do other planet labels when created
    }
}
