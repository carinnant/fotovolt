using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrollbar :  ButtonHandler {

	private GameObject exp;

	public float sValue;


	// Use this for initialization
	void Start () {
		exp = GameObject.Find("Image");

	}

	// Update is called once per frame
	void Update () {

	}

	public void Slider(float newValue){

		sValue = newValue;

		if (newValue == 1){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp1");
		}

		if (newValue == 0.99f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp2");
		}
		if (newValue == 0.95f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp3");
		}
		if (newValue == 0.9f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp4");
		}

		if (newValue == 0.89f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp5");
		}
		if (newValue == 0.85f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp6");
		}
		if (newValue == 0.8f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp7");
		}

		if (newValue == 0.79f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp8");
		}
		if (newValue == 0.75f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp9");
		}
		if (newValue == 0.7f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp10");
		}

		if (newValue == 0.69f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp11");
		}
		if (newValue == 0.65f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp12");
		}
		if (newValue == 0.6f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp13");
		}

		if (newValue == 0.59f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp14");
		}
		if (newValue == 0.55f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp15");
		}
		if (newValue == 0.5f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp16");
		}

		if (newValue == 0.49f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp17");
		}
		if (newValue == 0.45f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp18");
		}
		if (newValue == 0.4f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp19");
		}

		if (newValue == 0.39f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp20");
		}
		if (newValue == 0.35f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp21");
		}
		if (newValue == 0.3f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp22");
		}

		if (newValue == 0.29f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp23");
		}
		if (newValue == 0.25f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp24");
		}
		if (newValue == 0.2f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp25");
		}

		if (newValue == 0.19f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp26");
		}
		if (newValue == 0.15f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp27");
		}
		if (newValue == 0.1f){// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image>().sprite = Resources.Load<Sprite>("Exp/Exp28");
		}

		if (newValue == 0) {// && enviarOkay == true) {
			Debug.Log ("newValue");
			exp.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Exp/Exp29");

		}

	}

	public void Enviar(DisplayImage currentDisplay){
		
		if (exp.GetComponent<Image>().sprite.name == "Exp29"){
			currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("Sprites/end");
		}
	}
}
