using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepad : MonoBehaviour
{
    [SerializeField] private float Speed2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    
        float x = Input.GetAxis("Horizontal2");
        float y = Input.GetAxis("Vertical2");
        gameObject.transform.position += new Vector3(x * Speed2,  -y * Speed2,0);
    }
}
