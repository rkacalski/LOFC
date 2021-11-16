using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(formationGrid))]
public class formationGridInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    FormationController formController;
    formationGrid formGrid;

    private void Awake()
    {
        formController = FindObjectOfType(typeof(FormationController)) as FormationController;
        formGrid = GetComponent<formationGrid>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        formController.selectedGrid = formGrid;
        //Debug.Log("Pointer Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        formController.selectedGrid = null;
        //Debug.Log("Pointer Exit");
    }
}
