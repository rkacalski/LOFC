using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wishlistDropDown : MonoBehaviour
{
    public Dropdown dropdown;
    public static int chosenOption;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate
            {
                chosenOption = 0;
                dropDownValueChangedHappened(dropdown);
        });
    }

    public void dropDownValueChangedHappened(Dropdown sender)
    {
        //print("You chose: " + sender.value);
        chosenOption = sender.value;
        //print("You chose: " + chosenOption);
    }
}
