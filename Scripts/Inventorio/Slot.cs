using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory;

    public enum property { usable, displayable, Idisplayable, empty }; 

    public property ItemProperty { get; set; }

    private string displayImage;

    //private GameObject newGameObject2;

    //private string usableItem;
    
    public string combinationItem { get; private set; }

    [HideInInspector]
    public string changeDisplaySprite;

    void Start()
    {

        inventory = GameObject.Find("Inventory");
        
		//if (ItemProperty == property.usable) return;

		//newGameObject2 = inventory.GetComponent<PickUpItem>().newGameObject;
		//newGameObject2.SetActive(false);
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.GetComponent<Inventory>().previousSelectedSlot = inventory.GetComponent<Inventory>().currentSelectedSlot;
        inventory.GetComponent<Inventory>().currentSelectedSlot = this.gameObject;
        //Combine();
        if (ItemProperty == Slot.property.displayable) DisplayItem();
        if (ItemProperty == Slot.property.Idisplayable) IDisplayItem();
        //if (ItemProperty == Slot.property.Rdisplayable) UseObject();

    }

	public void AssignProperty(int orderNumber, string displayImage, string combinationItem, string changeDisplaySprite) //GameObject newGameObject, string usableItem
    {
        ItemProperty = (property)orderNumber;
        this.displayImage = displayImage;
        //this.usableItem = usableItem;
		//this.newGameObject2 = newGameObject;
		this.changeDisplaySprite = changeDisplaySprite;
        this.combinationItem = combinationItem;
    }

    public void DisplayItem()
   {
        inventory.GetComponent<Inventory>().itemDisplayer.SetActive(true);
        inventory.GetComponent<Inventory>().itemDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + displayImage);
       
    }

    public void IDisplayItem()
    {
		inventory.GetComponent<Inventory>().iDisplayer.SetActive(true);
		inventory.GetComponent<Inventory>().iDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/" + displayImage);

    }
		
    void Combine()
    {
        if (inventory.GetComponent<Inventory>().previousSelectedSlot.GetComponent<Slot>().combinationItem == this.gameObject.GetComponent<Slot>().combinationItem && this.gameObject.GetComponent<Slot>().combinationItem != "")
       {
            Debug.Log("combine");
            GameObject combinedItem = Instantiate(Resources.Load<GameObject>("Combined Items/" + combinationItem));
            combinedItem.GetComponent<PickUpItem>().ItemPickUp();

            inventory.GetComponent<Inventory>().previousSelectedSlot.GetComponent<Slot>().ClearSlot();
            ClearSlot();
        }
    }
   
    /*    void UseObject()
        {
            Debug.Log("UseObject");

            if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == usableItem || usableItem == "")
            {
                Debug.Log("if usableItem");

                newGameObject2.SetActive(true);
                this.gameObject.layer = 2;

                inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
                ClearSlot();

            }
        }
        */

    public void ClearSlot()
    {
        ItemProperty = Slot.property.empty;
        displayImage = "";
        //usableItem = "";
        combinationItem = "";
        changeDisplaySprite = "";
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Inventory/empty_item");
    }
}
