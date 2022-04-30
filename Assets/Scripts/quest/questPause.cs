using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questPause : MonoBehaviour
{
    public GameObject pausemenu;
    public Transform location;

    // Start is called before the first frame update
    void Start()
    {
        pausemenu.transform.localScale = Vector2.zero;
    }

    public void pauseOpen()
    {
        pausemenu.transform.LeanScale(Vector2.one, 0.9f).setEaseOutQuart();
    }

    public void pauseClose()
    {
        pausemenu.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    public void pauseHome()
    {
        player.questPosX = location.position.x;
        player.questPosY = location.position.y;
        SceneManager.LoadScene("Home Screen");
    }

    public void questComplete()
    {
        player.questPosX = 0;
        player.questPosY = 0;
        questProgCalc(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("questComplete");
    }

    public void questProgCalc(string levelName)
    {
        if(levelName.Equals("questTest"))
        {
            questProgress.tat1_1_complete_L_N = true;
        }
    }
}
