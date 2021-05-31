using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Slider : MonoBehaviour
{
    public Slider mainSlider;

    private GameObject exp;

    public float sValue;
    public float newValue;


    public UnityEngine.UI.Slider.SliderEvent onValueChanged;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        exp = GameObject.Find("Image");

    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        sValue = newValue;
        Debug.Log(mainSlider.newValue);
    }
}