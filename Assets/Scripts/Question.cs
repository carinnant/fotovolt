using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Question : MonoBehaviour, IPointerClickHandler {

	public GameObject ScreenPanel;
	public GameObject ObtainItem;

	private bool isCorrectPassword = false;

	private GameObject displayImage;

	public string CorrectPassword;

	private string inputPassword;

	void Start()
	{
		displayImage = GameObject.Find("display");

		ObtainItem.SetActive(false);
		this.gameObject.SetActive(false);
	}

	void Update()
	{
		VerifyPassword();
		HideDisplay();
	}

	void VerifyPassword()
	{
		if (isCorrectPassword) return;

		if (Input.GetKey(KeyCode.Return))
		{
			inputPassword = ScreenPanel.transform.Find("Text").GetComponent<Text>().text;

			ScreenPanel.transform.Find("Text").GetComponent<Text>().text = "";


			if (inputPassword == CorrectPassword)
			{
				isCorrectPassword = true;
				//Destroy(ScreenPanel);
				//GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/chess_solved");
				ObtainItem.SetActive(true);
			}
		}


	}

	void HideDisplay()
	{
		if(Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
		{
			this.gameObject.SetActive(false);
		}

	/*	if(displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.normal)
		{
			this.gameObject.SetActive(false);
		} */
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (isCorrectPassword) return;
		//ScreenPanel.SetActive(false);
	} 
}
