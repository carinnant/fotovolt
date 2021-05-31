using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 scanPos;
	private Vector3 offset;

//	void OnMouseDown()
//	{
//		screenPoint = Camera.main.WorldToScreenPoint(scanPos);
//
//		offset = scanPos - Camera.main.ScreenToWorldPoint(
//			new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
//	}
//
//
//	void OnMouseDrag()
//	{
//		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
//
//		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
//		transform.position = curPosition;
//		ConstrainCamera ();
//	}

	float distance = 10; 

//	private bool flag = false;
//	private Vector2 endPoint;
//	private float yAxis;

	void OnMouseDrag() { 

		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance); 
		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); transform.position = objPosition;

		var distanceZ = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceZ)).x;

		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceZ)).x;

		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceZ)).y;

		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, distanceZ)).y;

		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp (transform.position.y, topBorder, bottomBorder),
			transform.position.z
		);
	}

}
