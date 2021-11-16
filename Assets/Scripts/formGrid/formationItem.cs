using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class formationItem : MonoBehaviour
{
    public objectForm objForm;

    internal void Set(objectForm objForm)
    {
        this.objForm = objForm;
        GetComponent<Image>().sprite = objForm.art;
    }
}
