using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    private Vector2 mouse;

    private Vector2 target;

    [SerializeField]
    private Explosion exp;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 100));
        this.transform.position = target;
        if(Input.GetMouseButtonDown(0))
        {
            exp.blowoff(0);
        }

    }
}