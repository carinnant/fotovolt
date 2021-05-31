using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorPuzzle : MonoBehaviour {

    public string Password;

    public GameObject enableObject;
	public GameObject desableObject;

    private GameObject displayImage;

    [HideInInspector]
    public Sprite[] colorSprites;
    [HideInInspector]
    public int[] currentIndividualIndex = { 0, 0, 0 };

    private bool isOpen;

    void Start()
    {
        displayImage = GameObject.Find("display");
        enableObject.SetActive(false);
		desableObject.SetActive(true);
        isOpen = false;
        LoadSprites();
    }

    void Update()
    {
        OpenLocker();
        LayerManager();
        HideDisplay();
    }

    void LoadSprites()
    {
        colorSprites = Resources.LoadAll<Sprite>("Sprites/colors");
    }


    bool VerifyCorrectCode()
    {
        bool correct = true;

        for (int i = 0; i < 3; i++)
        {
            if (Password[i] != transform.GetChild(i).GetComponent<Image>().sprite.name.Substring(transform.GetChild(i).GetComponent<Image>().sprite.name.Length - 1)[0])
            {
                correct = false;
            }
        }

        return correct;
    }


    void OpenLocker()
    {
        if (isOpen) return;

        if (VerifyCorrectCode())
        {
            isOpen = true;
            enableObject.SetActive(true);
			desableObject.SetActive(false);

        }
    }

    void LayerManager()
    {
        if (isOpen) return;

        if (displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.idle)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = 3;
            }
        }

        else
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = 0;
            }
        }
    }

    void HideDisplay()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            this.gameObject.SetActive(false);
        }

     /*   if (displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.normal)
        {
            this.gameObject.SetActive(false);
        } */
    }

}
