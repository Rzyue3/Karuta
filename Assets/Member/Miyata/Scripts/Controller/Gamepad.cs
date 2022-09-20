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
        var posX = x * Time.deltaTime * Speed2;
        var posY = -y * Time.deltaTime * Speed2;
        var min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        var max = Camera.main.ViewportToWorldPoint(Vector2.one);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp( gameObject.transform.position.x + posX, min.x, max.x ),
            Mathf.Clamp( gameObject.transform.position.y + posY, min.y, max.y ),
            0.0f
        );
    }
}
