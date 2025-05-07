using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DRAG : MonoBehaviour, IDragHandler
{
    private RectTransform rectTransform;
    public Canvas canva;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        if (canva == null)
            canva = GetComponentInParent<Canvas>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging: " + gameObject.name);

        // »справление ошибки с объ€влением переменной
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        // »справление ошибки Mthf -> Mathf
        mousePosition.x = Mathf.Clamp(
            mousePosition.x, 0 + rectTransform.rect.width / 2,
            Screen.width - rectTransform.rect.width / 2);

        mousePosition.y = Mathf.Clamp(
            mousePosition.y, 0 + rectTransform.rect.height / 2,
            Screen.height - rectTransform.rect.height / 2);

        transform.position = mousePosition;
    }
}
