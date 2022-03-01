using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ItemSlotInteraction : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        onClick();
    }

    public Action onClick = () => { };
}