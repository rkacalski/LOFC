using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tat_L_N_UI : MonoBehaviour
{
    public tat_L_selChecks_N checks;
    public Text Level1;
    public Text Level2;
    public Text Level3;
    public Text Level4;
    public Text Level5;
    public Text Level6;

    int count;


    // Start is called before the first frame update
    void Start()
    {

        //Update progress
        getnumbers(1);
        getnumbers(2);
        getnumbers(3);
        getnumbers(4);
        getnumbers(5);
        getnumbers(6);
    }

    /////////////  Buttons  ////////////////////
    
    public void enterTat1()
    {
        SceneManager.LoadScene("GCW_tat1_L_Select");
    }

    public void enterTat2()
    {
        if(checks.tat2_check() == true)
        {
            SceneManager.LoadScene("GCW_tat2_L_Select");

            //Send to tat2 Select page
        }
    }

    public void enterTat3()
    {
        if (checks.tat3_check() == true)
        {
            SceneManager.LoadScene("GCW_tat3_L_Select");
            //Send to tat3 Select page
        }
    }

    public void enterTat4()
    {
        if (checks.tat4_check() == true)
        {
            SceneManager.LoadScene("GCW_tat4_L_Select");

            //Send to tat3 Select page
        }
    }

    public void enterTat5()
    {
        if (checks.tat5_check() == true)
        {
            SceneManager.LoadScene("GCW_tat5_L_Select");

            //Send to tat3 Select page
        }
    }

    public void enterTat6()
    {
        if (checks.tat6_check() == true)
        {
            SceneManager.LoadScene("GCW_tat6_L_Select");
            //Send to tat3 Select page
        }
    }

    public void backButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void getnumbers(int Level)
    {
        if(Level.Equals(1))
        {
            for (int i = 0; i < questProgress.tat1_L_N.Count; i++)
            {
                print(i + " Not in loop " + questProgress.tat1_L_N[i]);
                if (questProgress.tat1_L_N[i] == true)
                {
                    print("in Loop ");
                    count += 1;
                }
            }

            Level1.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(2))
        {
            for (int i = 0; i < questProgress.tat2_L_N.Count; i++)
            {
                if (questProgress.tat2_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level2.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(3))
        {
            for (int i = 0; i < questProgress.tat3_L_N.Count; i++)
            {
                if (questProgress.tat3_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level3.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(4))
        {
            for (int i = 0; i < questProgress.tat4_L_N.Count; i++)
            {
                if (questProgress.tat4_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level4.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(5))
        {
            for (int i = 0; i < questProgress.tat5_L_N.Count; i++)
            {
                if (questProgress.tat5_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level5.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(6))
        {
            for (int i = 0; i < questProgress.tat6_L_N.Count; i++)
            {
                if (questProgress.tat6_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level6.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }
    }
}
