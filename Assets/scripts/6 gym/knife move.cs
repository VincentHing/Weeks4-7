using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class knifemove : MonoBehaviour
{
    public Vector2 poointer;
    float distance;
    public Boolean barrel = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        poointer = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        distance = Vector2.Distance(poointer, transform.position);
        if (distance <0.75&& Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            barrel = false;
        }
    }
    
   
}
