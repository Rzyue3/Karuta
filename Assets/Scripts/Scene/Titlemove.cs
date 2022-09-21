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
    [SerializeField]
    private GameObject obj;
    private string str;

    public bool scenemoveflag;

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
            str = SceneManager.GetActiveScene().name;
            Debug.Log("**ComandA");
            StartCoroutine("cutinanim");

        }
    }

    private IEnumerator cutinanim()
    {
        Debug.Log("**Command2");
        LeftAnim.SetTrigger("1time");
        RightAnim.SetTrigger("1time");
        yield return new WaitForSeconds(2);
        SceneManager.sceneLoaded += SceneLoaded;

        SceneManager.LoadScene("Title");
    }

    void SceneLoaded(Scene next, LoadSceneMode mode)
    {
        var str = SceneManager.GetActiveScene().name;
        if(str == "Title")
        {
            Destroy(obj);
        }

    }



}
