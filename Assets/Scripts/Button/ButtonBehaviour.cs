using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour {

	public enum ButtonId
	{
		roomChangeButton, returnW4Button, Button, zoomButton, close
	}

	public ButtonId ThisButtonId;

	private DisplayImage currentDisplay;

	void Start()
	{
		currentDisplay = GameObject.Find("display").GetComponent<DisplayImage>();
	}

	void Update()
	{
		HideDisplay();
		Display();
	}

	void HideDisplay()
	{
        if (ThisButtonId == ButtonId.Button && !(currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "mesaCima" || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "muralZoom" 
            || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "armarioZoom")) 
        {
			GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
				GetComponent<Image>().color.b, 0);
			GetComponent<Button>().enabled = false;
			this.transform.SetSiblingIndex(0);
		}

   /*     if (!(currentDisplay.CurrentState == DisplayImage.State.zoom) && ThisButtonId == ButtonId.zoomButton &&
        !(currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "wall2"))        
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 0);
            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        } */

        if ((currentDisplay.CurrentState == DisplayImage.State.normal || currentDisplay.CurrentState == DisplayImage.State.idle) && 
            (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "wall1") && ThisButtonId == ButtonId.close)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 0);
            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }

        if ((currentDisplay.CurrentState == DisplayImage.State.normal || currentDisplay.CurrentState == DisplayImage.State.idle) && ThisButtonId == ButtonId.returnW4Button &&
            !(currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "resistores" || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "resistores_solve"))
		{
			GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
			GetComponent<Image>().color.b, 0);
			GetComponent<Button>().enabled = false;
			this.transform.SetSiblingIndex(0);
		}

	}

	void Display()
	{
		if (ThisButtonId == ButtonId.Button && (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "mesaCima" || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "muralZoom"
            || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "armarioZoom"))
		{
			GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
				GetComponent<Image>().color.b, 1);
			GetComponent<Button>().enabled = true;
		}

  /*      if (!(currentDisplay.CurrentState == DisplayImage.State.normal || currentDisplay.CurrentState == DisplayImage.State.idle) && ThisButtonId == ButtonId.zoomButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 1);
            GetComponent<Button>().enabled = true;
        }
*/
        if (!(currentDisplay.CurrentState == DisplayImage.State.normal || currentDisplay.CurrentState == DisplayImage.State.idle) && ThisButtonId == ButtonId.returnW4Button &&
            (currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "resistores" || currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "resistores_solve"))
		{
			GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,					
			GetComponent<Image>().color.b, 1);
			GetComponent<Button>().enabled = true;
		}

        if (ThisButtonId == ButtonId.close && !(currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "wall1"))
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
            GetComponent<Image>().color.b, 1);
            GetComponent<Button>().enabled = true;
        }

       /* if (!(currentDisplay.CurrentState == DisplayImage.State.normal || currentDisplay.CurrentState == DisplayImage.State.idle) && ThisButtonId == ButtonId.roomChangeButton &&
            !(currentDisplay.GetComponent<SpriteRenderer>().sprite.name == "menu"))
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 1);
            GetComponent<Button>().enabled = true;
        } */
    }

}
