using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsManage : MonoBehaviour
{
    private GameObject inventory;

    private DisplayImage currentDisplay;

    public GameObject[] ObjectsToMange;
    public GameObject[] UIRenderObjects;


    void Start()
    {
        currentDisplay = GameObject.Find("display").GetComponent<DisplayImage>();

        RenderUI();

        inventory = GameObject.Find("Inventory");
    }

    void Update()
    {
        MangeObjects();
        HideInventory();
    }

    void MangeObjects()
    {
        for (int i = 0; i < ObjectsToMange.Length; i++)
        {
            if (ObjectsToMange[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectsToMange[i].SetActive(true);

            }
            else
            {
                ObjectsToMange[i].SetActive(false);
            }
        }
    }

    void RenderUI()
    {
        for (int i = 0; i < UIRenderObjects.Length; i++)
        {
            UIRenderObjects[i].SetActive(false);
        }
    }

    void HideInventory()
    {
        if ((currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "Experimento") || (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "wall1") || (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "inst") || (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "creditos") || (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "end"))
        {
            inventory.SetActive(false);

        }
        else
            inventory.SetActive(true);

    }
}
