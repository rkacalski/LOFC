using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(formGrid))]
public class invenGridInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    formController FormController;
    formGrid FormGrid;

    private void Awake()
    {
        FormController = FindObjectOfType(typeof(formController)) as formController;
        FormGrid = GetComponent<formGrid>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        FormController.selectedGrid = FormGrid;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        FormController.selectedGrid = null;
    }

}
