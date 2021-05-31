using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMirror : MonoBehaviour {

	//private Camera myCam;

	public GameObject manivela;

	void Start()
	{
		//myCam = Camera.main;
	}

	void Update()
	{
			this.transform.eulerAngles = new Vector3 (0, 0, manivela.transform.eulerAngles.z);
	}
}
