using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questexperimento : MonoBehaviour
{
	public float time = 30.0f;
	public Text tempo;
	public int ctime;

	public static float[] value = new float[1];
	public static bool[] button = new bool[1];

	// Use this for initialization

	private DisplayImage currentDisplay;

	void Start()
	{
		currentDisplay = GameObject.Find("display").GetComponent<DisplayImage>();
	}

	// Update is called once per frame
	void Update()
	{
		if (button[0] = true && value[0] == 1)
		{
			espera();
		}
		time -= 1 * Time.deltaTime;
		ctime = (int)time;
		tempo.text = ctime.ToString();
		if (time <= 0)
		{
			currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/gameover");
		}

	}

	IEnumerator espera()
	{
		yield return new WaitForSeconds(2);
	}

}

