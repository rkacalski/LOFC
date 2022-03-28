using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hangerButtons : MonoBehaviour
{
    public void homeButton()
    {
        vehicleSelect.selectedVehicle = null;
        hangerManager.selectedHanger = -1;
        SceneManager.LoadScene("Home Screen");
    }
}
