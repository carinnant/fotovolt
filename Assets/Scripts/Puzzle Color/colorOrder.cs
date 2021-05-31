using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorOrder : MonoBehaviour, IInteractable
{

    public void Interact(DisplayImage currentDisplay)
    {
        transform.parent.GetComponent<colorPuzzle>().currentIndividualIndex[transform.GetSiblingIndex()]++;

        if (transform.parent.GetComponent<colorPuzzle>().currentIndividualIndex[transform.GetSiblingIndex()] > 2)
            transform.parent.GetComponent<colorPuzzle>().currentIndividualIndex[transform.GetSiblingIndex()] = 0;

        this.gameObject.GetComponent<Image>().sprite =
            transform.parent.GetComponent<colorPuzzle>().colorSprites[transform.parent.GetComponent<colorPuzzle>().currentIndividualIndex[transform.GetSiblingIndex()]];
    }
}
