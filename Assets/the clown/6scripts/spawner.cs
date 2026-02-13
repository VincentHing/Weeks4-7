using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class spawner : MonoBehaviour
{
    //brings the bloon blueprint in
    public GameObject bloonPrefab;
    public GameObject spawnedBloon;
    //brings in script
    public balloonM bloonScript;
    //list of the bloons we have
    public List <GameObject> bloons;

   // public Slider slidey;
    
    
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (bloons.Count > 0)
            {
                //lets the previously immobile bloon move free
                bloons[bloons.Count - 1].GetComponent< balloonM > ().bloonAttached = false;
            }

        spawnedBloon = Instantiate(bloonPrefab);

            bloonScript = GetComponent<balloonM>();

            bloons.Add(spawnedBloon); 
        }
        ////changes the size of the attatched baloon
        //bloons[bloons.Count - 1].GetComponent<balloonM>().transform.localScale *= slidey.value;


        for (int i = bloons.Count - 1; i >= 0; i--)
        {
            //getting access to the current bloon in da list
            GameObject bloon = bloons[i];
            //checks if curren bloon is at end position
            if (bloons[i].transform.position.y >= 6)
            {
                //remove from list
                bloons.Remove(bloon);
                //obliterate the balloon
                Destroy(bloon);
            }
        }
    }
    
}
