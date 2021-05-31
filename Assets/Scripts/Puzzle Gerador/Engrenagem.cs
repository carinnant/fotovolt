using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Engrenagem : MonoBehaviour {

	public GameObject[] EngrenagemBoxes;
	public int[] Weight = new int[3];

    private GameObject inventory;

    //public GameObject Displayer;

    private GameObject displayImage;
	private Block[] blocks;

	public GameObject enableObject;
	public GameObject desableObject;

	public bool isSolved { get; private set; }

	void Start(){

		enableObject.SetActive(false);
		desableObject.SetActive(true);
	}

	void Awake()
	{
        GameObject.Find("engre1").GetComponent<Image>().enabled = false;
		GameObject.Find("engre2").GetComponent<Image>().enabled = false;

        isSolved = false;
		displayImage = GameObject.Find("display");
		blocks = FindObjectsOfType<Block>();

        inventory = GameObject.Find("Inventory");
    }

	void Update()
	{
		Display();
        VerifyUnlockKey();

		if (VerifySolution() && !isSolved)
		{
			isSolved = true;

			Debug.Log("Engrenagem Solve");

			enableObject.SetActive(true);
			desableObject.SetActive(false);

		}
	}

	void Display()
	{
		if(displayImage.GetComponent<SpriteRenderer>().sprite.name == "wall4") //|| displayImage.GetComponent<SpriteRenderer>().sprite.name == "scale solved")
		{
			for(int i = 0; i < blocks.Length; i++)
			{
				blocks[i].gameObject.SetActive(true);
			}
		}
		else
		{
			for (int i = 0; i < blocks.Length; i++)
			{
				blocks[i].gameObject.SetActive(false);
			}
		}
	}

    void VerifyUnlockKey()
    {

        if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "wall4" && inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == "engre1")
        {
            GameObject.Find("engre1").GetComponent<Image>().enabled = true;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();

        }

		if (displayImage.GetComponent<SpriteRenderer>().sprite.name == "wall4" && inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == "engre2")
        {
			GameObject.Find("engre2").GetComponent<Image>().enabled = true;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();

        }
    }

    bool VerifySolution()
	{
		bool solved = true;

		for(int i = 0; i < EngrenagemBoxes.Length; i++)
		{
			if (blocks[i].indexOfBox != blocks[i].correctBoxIndex)
				solved = false;
		}

		return solved;
	}
}
