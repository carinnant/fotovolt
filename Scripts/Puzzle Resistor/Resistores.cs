using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resistores : MonoBehaviour {

    public GameObject[] ResistoresBoxes;
    public int[] Weight = new int[3];

    public GameObject Displayer;

    private GameObject displayImage;
    private Boxes[] R;

    private GameObject inventory; 

	public GameObject enableObject;
	//public GameObject desableObject;

    public bool isSolved { get; private set; }

	void Start()
	{
		enableObject.SetActive(false);
		//desableObject.SetActive(true);
	}

    void Awake()
    {
        GameObject.Find("Resistor1").GetComponent<Image>().enabled = false;
        GameObject.Find("Resistor2").GetComponent<Image>().enabled = false;
        GameObject.Find("Resistor3").GetComponent<Image>().enabled = false;

        isSolved = false;
		inventory = GameObject.Find("Inventory");
        displayImage = GameObject.Find("display");
		Displayer.SetActive(false);

        R = FindObjectsOfType<Boxes>();
    }

	void Update()
    {
        Display();
        VerifyUnlockKey();

        if (VerifySolution() && !isSolved)
        {
            isSolved = true;

            Debug.Log("Resistores Solve");

			Displayer.SetActive(true);
            
            if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "wall4")
            {
                GameObject.Find("porta_aberta").SetActive(true);
            }

            		enableObject.SetActive(true);
            //	desableObject.SetActive(false);
        }
    }

    void Display()
    {
		if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "resistores")
        {
			GameObject.Find("Resistores").SetActive(true);

            for (int i = 0; i < R.Length; i++)
            {
                R[i].gameObject.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < R.Length; i++)
            {
                R[i].gameObject.SetActive(false);
            }
        }
    }

    void VerifyUnlockKey()
    {

        if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "resistores" && inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == "resistor1")
        {
            Debug.Log("unlockR1");
            GameObject.Find("Resistor1").GetComponent<Image>().enabled = true;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            
        }

        if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "resistores" && inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == "resistor2")
        {
            GameObject.Find("Resistor2").GetComponent<Image>().enabled = true;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
        }

        if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "resistores" && inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == "resistor3")
        {
            GameObject.Find("Resistor3").GetComponent<Image>().enabled = true;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
        }
    }


    bool VerifySolution()
    {
        bool solved = true;

        for (int i = 0; i < ResistoresBoxes.Length; i++)
        {
            if (R[i].indexOfBox != R[i].correctBoxIndex)
                solved = false;
        }

        return solved;
    }
}
