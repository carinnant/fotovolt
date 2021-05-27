using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{

    public enum State
    {
        normal, zoom, ChangedView, idle
    };

    public State CurrentState { get; set; }

    public int CurrentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 6)
                currentWall = 1;
            else if (value == 0)
                currentWall = 5;
            else
                currentWall = value;
        }
    }

    private int currentWall;
    private int previousWall;

    void Start()
    {
  //      CurrentState = State.idle;
        previousWall = 0;
        
 //       GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/menu");

//        if (GetComponent<SpriteRenderer>().sprite.name == "wall1") 
  //      {
            currentWall = 1;
    }

    void Update()
    {
        if (currentWall != previousWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall" + currentWall.ToString());
        }

        previousWall = currentWall;
    }



}
