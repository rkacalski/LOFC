using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscriopt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(vehicleModHelper.selectedVehicle.pilot.cardName);
    }
}
