using System;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject knifePrefab;
    public GameObject currentk;
    public knifemove knifeScript;
    

    
    public List<GameObject> knifes;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 4; i++) { 
        currentk = Instantiate(knifePrefab, transform.position, transform.rotation);
    }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 5; i > 0; i--)
        {
            knifeScript = knifes[i].GetComponent<knifemove>();
            if (knifeScript.barrel == false)
            {
                knifes.Remove(knifes[i]);
                Destroy(knifes[i]);
            }
        }

    }
}
