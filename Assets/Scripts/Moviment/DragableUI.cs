using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragableUI : UIBehaviour, IBeginDragHandler, IDragHandler
{

    private GameObject inventory;
    private GameObject slot;

    [HideInInspector]
    public string changeDisplaySprite2;


	void Update(){
		inventory = GameObject.Find("Inventory");
		changeDisplaySprite2 = slot.GetComponent<Slot>().changeDisplaySprite;
	}


    /// <summary>
    /// The RectTransform that we are able to drag around.
    /// if null: the transform this Component is attatched to is used.
    /// </summary>
    [HideInInspector]
    public RectTransform dragObject;

    /// <summary>
    /// The area in which we are able to move the dragObject around.
    /// if null: canvas is used
    /// </summary>
    [HideInInspector]
    public RectTransform dragArea;

    private Vector2 originalLocalPointerPosition;
    private Vector3 originalPanelLocalPosition;

    private RectTransform dragObjectInternal
    {
        get
        {
            if (dragObject == null)
                return (transform as RectTransform);
            else
                return dragObject;
        }
    }

    private RectTransform dragAreaInternal
    {
        get
        {
            if (dragArea == null)
            {
                RectTransform canvas = transform as RectTransform;
                while (canvas.parent != null && canvas.parent is RectTransform)
                {
                    canvas = canvas.parent as RectTransform;
                }
                return canvas;
            }
            else
                return dragArea;
        }
    }

    public void OnBeginDrag(PointerEventData data)
    {
        originalPanelLocalPosition = dragObjectInternal.localPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(dragAreaInternal, data.position, data.pressEventCamera, out originalLocalPointerPosition);
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 localPointerPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(dragAreaInternal, data.position, data.pressEventCamera, out localPointerPosition))
        {
            Vector3 offsetToOriginal = localPointerPosition - originalLocalPointerPosition;
            dragObjectInternal.localPosition = originalPanelLocalPosition + offsetToOriginal;
        }

        ClampToArea();
    }

    // Clamp panel to dragArea
    private void ClampToArea()
    {
        Vector3 pos = dragObjectInternal.localPosition;

        Vector3 minPosition = dragAreaInternal.rect.min - dragObjectInternal.rect.min;
        Vector3 maxPosition = dragAreaInternal.rect.max - dragObjectInternal.rect.max;

        pos.x = Mathf.Clamp(dragObjectInternal.localPosition.x, minPosition.x, maxPosition.x);
        pos.y = Mathf.Clamp(dragObjectInternal.localPosition.y, minPosition.y, maxPosition.y);

        dragObjectInternal.localPosition = pos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Vela")
        {
			inventory.GetComponent<Inventory>().iDisplayer.SetActive(true);
			inventory.GetComponent<Inventory>().iDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + changeDisplaySprite2);
            Debug.Log("Colisão Vela");
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
        }
    }
}