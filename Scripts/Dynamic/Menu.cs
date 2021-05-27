using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	private DisplayImage currentDisplay;

	void Start()
	{
		currentDisplay = GameObject.Find("display").GetComponent<DisplayImage>();
	}
		
    // Update is called once per frame
    void Update()
    {
    }

    public void creditos()
    {
		currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/creditos");
    }
		
    public void jogar()
    {
        // Debug.Log("Jogar");
        currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall2");
        //GameObject.Find("menuDisplay").SetActive(false);
    }

	public void instrucoes()
	{
	//	Debug.Log ("Instruções");
		currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/inst");
       // GameObject.Find("menuDisplay").SetActive(false);
    }


    public void cont()
	{
		//	Debug.Log ("Instruções");
		currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall1");
	}
}
