using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vehicleModManager : MonoBehaviour
{
    //vehicle selectedVehicle;
    public Image vehicleImage;
    public Text vehicleName;
    public GameObject pilot;
    public GameObject parts;
    public GameObject labels;

    // Start is called before the first frame update
    void Start()
    {
        vehicleImage.sprite = vehicleModHelper.selectedVehicle.art;
        setVehiclePioltPartsUI();
        labelsUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void setVehiclePioltPartsUI()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i < vehicleModHelper.selectedVehicle.numCoPilots)
            {
                pilot.transform.GetChild(i).gameObject.SetActive(true);
            }
            if (i > vehicleModHelper.selectedVehicle.numCoPilots)
            {
                pilot.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        for(int i = 0; i < 4; i++)
        {
            if (i < vehicleModHelper.selectedVehicle.numParts -1)
            {
                parts.transform.GetChild(i).gameObject.SetActive(true);
            }
            if (i > vehicleModHelper.selectedVehicle.numParts -1)
            {
                parts.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    void labelsUI()
    {
        vehicleName.text = vehicleModHelper.selectedVehicle.displayName + " " + vehicleLevel(vehicleModHelper.selectedVehicle);
        labels.transform.GetChild(0).GetComponent<Text>().text = "Cost: " + vehicleModHelper.selectedVehicle.cost.ToString();
        labels.transform.GetChild(1).GetComponent<Text>().text = "Attack: " + vehicleModHelper.selectedVehicle.attack.ToString();
        labels.transform.GetChild(2).GetComponent<Text>().text = "Accuracy: " + vehicleModHelper.selectedVehicle.accuracy.ToString();
        labels.transform.GetChild(3).GetComponent<Text>().text = "HP: " + vehicleModHelper.selectedVehicle.HP.ToString();
        labels.transform.GetChild(4).GetComponent<Text>().text = "X-Size: " + vehicleModHelper.selectedVehicle.X.ToString();
        labels.transform.GetChild(5).GetComponent<Text>().text = "# of Attack's: " + vehicleModHelper.selectedVehicle.atkFreq.ToString() + " per turn";
        labels.transform.GetChild(6).GetComponent<Text>().text = "Range: Long";
        labels.transform.GetChild(7).GetComponent<Text>().text = "Defense: " + vehicleModHelper.selectedVehicle.defense.ToString();
        labels.transform.GetChild(8).GetComponent<Text>().text = "Evasion: " + vehicleModHelper.selectedVehicle.evasion.ToString();
        labels.transform.GetChild(9).GetComponent<Text>().text = "Y-Size: " + vehicleModHelper.selectedVehicle.Y.ToString();
    }
    
    public string vehicleLevel(vehicle Vehicle)
    {
        if(Vehicle.vehicleName.Contains("lvl_1"))
        {
            return "(Level 1)";
        }
        if (Vehicle.vehicleName.Contains("lvl_2"))
        {
            return "(Level 2)";
        }
        if (Vehicle.vehicleName.Contains("lvl_3"))
        {
            return "(Level 3)";
        }
        if (Vehicle.vehicleName.Contains("lvl_4"))
        {
            return "(Level 4)";
        }
        if (Vehicle.vehicleName.Contains("lvl_5"))
        {
            return "(Level 5 MAX)";
        }
        return "";
    }

}
