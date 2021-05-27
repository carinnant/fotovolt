﻿using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	public Sprite normal;
	public Sprite semiActive;
	public Sprite active;

	bool canEnlight;
	bool enlightened;
	public bool activated;
	int raysPassing;

	private GameObject activeObjs;

	private GameObject disableObjs;

	// Use this for initialization
	void Start () {
		raysPassing = 0;
		enlightened = false;
		activated = false;
		canEnlight = true;

		activeObjs = GameObject.Find("ActiveObjs");
		activeObjs.SetActive(false);

		disableObjs = GameObject.Find("DisableObjs");
		disableObjs.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		raysPassing = 0;

		if(!enlightened){
			GetComponent<SpriteRenderer>().sprite = normal;		
			activated = false;
		}else  { //if(canEnlight){
			GetComponent<SpriteRenderer>().sprite = active;		
			activated = true;
			activeObjs.SetActive(true);
			disableObjs.SetActive(false);
		}/*else{
			GetComponent<SpriteRenderer>().sprite = semiActive;		
		}*/

		enlightened = false;
		canEnlight = true;

	}

	public void React(){
		raysPassing++;
		if(raysPassing > 1)
			enlightened = true;
	}

	public void BlockEnlight(){
		canEnlight = false;
	}
}
