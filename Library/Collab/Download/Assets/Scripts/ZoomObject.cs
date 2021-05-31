using System;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObject : MonoBehaviour, IInteractable
{
    public float ZoomRatio = .5f;

    public void Interact(GameObject Mesa)
    {
        Camera.main.orthographicSize *= ZoomRatio;
        
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

}