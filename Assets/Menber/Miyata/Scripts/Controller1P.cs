using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller1P : MonoBehaviour
{
    [SerializeField] private float Speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        gameObject.transform.position += new Vector3(x * Speed,  -y * Speed,0);
    }
}
