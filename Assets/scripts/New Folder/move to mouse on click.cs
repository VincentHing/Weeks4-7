using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class movetomouseonclick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




        //was mouse pressed this frame
        if (Mouse.current.leftButton.wasPressedThisFrame==true&& EventSystem.current.IsPointerOverGameObject()==false)
        {
            //y:move there
           Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }

    }
}
