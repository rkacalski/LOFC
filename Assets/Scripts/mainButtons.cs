using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainButtons : MonoBehaviour
{
    public void homeButton()
    {
        SceneManager.LoadScene("Home Screen");
    }
}
