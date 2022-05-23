using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepad : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float SPEED = 0.1f;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        gameObject.transform.position += new Vector3(x * SPEED,  y * SPEED,0);
    }
}
