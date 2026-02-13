using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class balloonM : MonoBehaviour
{
    //animation curve setup
    public AnimationCurve wiggly;
    Vector2 bloonp;
    //end when off screen
    Vector2 startpos = new Vector2(3.78f, -1);
    Vector2 endpos = new Vector2(3.78f, 6);
    //used to hold the balloon at the start for a bit so it can be changed
    public bool bloonAttached = true;
    //timer
    public float clock;
    //looping value between 0 and 1 for the animation curve.
    public float repClock;

    public Slider slidey;
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bloonAttached != true)
        {
            clock += Time.deltaTime;
        //setting up the 2 timers
        repClock += Time.deltaTime;
        if (repClock >= 1)
        {
            repClock = 0;
        }
        //only lets the bloon move if it has been cut
        
            bloonp = transform.position;
            //multiply for 50% more speed
            bloonp.y = Mathf.Lerp(startpos.y, endpos.y, clock / 4);
            //gives the baloon a modifier to it's current x based on the animation curve this was more difficult that it should've been
            bloonp.x = 3.78f + wiggly.Evaluate(repClock);

            transform.position = bloonp;
        }
       
    }

}
