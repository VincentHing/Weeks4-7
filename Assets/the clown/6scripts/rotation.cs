using UnityEngine;

public class rotation : MonoBehaviour
{
    public float turnSpeed = 130;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //somewhat copied from the 3.1 rotation follow along on slate
        Vector3 spinner = transform.eulerAngles;
        spinner.z += turnSpeed * Time.deltaTime;
        transform.eulerAngles = spinner;
        
    }
}
