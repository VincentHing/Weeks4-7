using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class balloonM : MonoBehaviour
{
    //animation curve setup
    public AnimationCurve wiggly;
    Vector2 bloonp;
    //end when off screen
    Vector2 startpos = new Vector2(3.7f, -1);
    Vector2 endpos = new Vector2(3.7f, 6);
    public float clock;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;

        bloonp = transform.position;
        //multiply for 50% more speed
        bloonp.y = Mathf.Lerp(startpos.y, endpos.y, clock/4);
        transform.position = bloonp;
        
    }
}
