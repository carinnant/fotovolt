using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    private GameObject Mesa;

    void Start()
    {
        Mesa = GetComponent<GameObject>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable")
            {
                hit.transform.GetComponent<IInteractable>().Interact(Mesa);
            }
        }


    }
}
