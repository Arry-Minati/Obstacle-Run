using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // These variables change the movement speed
    
    [SerializeField] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue =Input.GetAxis("Horizontal");
        float yValue = Input.GetAxis("Vertical");
       transform.Translate(xValue,yValue,zValue); 
    }
}
