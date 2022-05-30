using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hangerModButtons : MonoBehaviour
{
    public void pilotButton()
    {
        SceneManager.LoadScene("pilotSelect");
    }

    public void copilot1Button()
    {
        SceneManager.LoadScene("copilot1Select");
    }
}
