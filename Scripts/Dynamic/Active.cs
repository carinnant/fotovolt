using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour {

	public GameObject enableObject;

	void Start () {
		enableObject.SetActive(true);
	}

}
