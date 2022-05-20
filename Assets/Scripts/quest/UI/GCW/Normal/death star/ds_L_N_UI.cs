using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ds_L_N_UI : MonoBehaviour
{
    public ds_L_selChecks_N checks;
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

    public void enterDs1()
    {
        SceneManager.LoadScene("GCW_ds1_L_Select");
    }

    public void enterDs2()
    {
        if (checks.ds2_check() == true)
        {
            SceneManager.LoadScene("GCW_ds2_L_Select");

            //Send to tat2 Select page
        }
    }

    public void enterDs3()
    {
        if (checks.ds3_check() == true)
        {
            SceneManager.LoadScene("GCW_ds3_L_Select");
            //Send to tat3 Select page
        }
    }

    public void enterDs4()
    {
        if (checks.ds4_check() == true)
        {
            SceneManager.LoadScene("GCW_ds4_L_Select");

            //Send to tat3 Select page
        }
    }

    public void enterDs5()
    {
        if (checks.ds5_check() == true)
        {
            SceneManager.LoadScene("GCW_ds5_L_Select");

            //Send to tat3 Select page
        }
    }

    public void enterDs6()
    {
        if (checks.ds6_check() == true)
        {
            SceneManager.LoadScene("GCW_ds6_L_Select");
            //Send to tat3 Select page
        }
    }

    public void backButton()
    {
        SceneManager.LoadScene("GCW_main_normal");
    }

    public void getnumbers(int Level)
    {
        if (Level.Equals(1))
        {
            for (int i = 0; i < questProgress.ds1_L_N.Count; i++)
            {
                print(i + " Not in loop " + questProgress.ds1_L_N[i]);
                if (questProgress.ds1_L_N[i] == true)
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
            for (int i = 0; i < questProgress.ds2_L_N.Count; i++)
            {
                if (questProgress.ds2_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level2.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(3))
        {
            for (int i = 0; i < questProgress.ds3_L_N.Count; i++)
            {
                if (questProgress.ds3_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level3.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(4))
        {
            for (int i = 0; i < questProgress.ds4_L_N.Count; i++)
            {
                if (questProgress.ds4_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level4.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(5))
        {
            for (int i = 0; i < questProgress.ds5_L_N.Count; i++)
            {
                if (questProgress.ds5_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level5.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }

        if (Level.Equals(6))
        {
            for (int i = 0; i < questProgress.ds6_L_N.Count; i++)
            {
                if (questProgress.ds6_L_N[i] == true)
                {
                    count += 1;
                }
            }
            Level6.GetComponent<UnityEngine.UI.Text>().text = "Cleared: " + count.ToString() + "/6";
            count = 0;
        }
    }
}
