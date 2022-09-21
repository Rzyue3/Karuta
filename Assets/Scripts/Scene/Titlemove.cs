using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Titlemove : MonoBehaviour
{
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A)) 
        {
            StartCoroutine("cutinanim");
        }
    }

    private IEnumerator cutinanim()
    {
        LeftAnim.SetTrigger("1time");
        RightAnim.SetTrigger("1time");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Title");

    }

}
