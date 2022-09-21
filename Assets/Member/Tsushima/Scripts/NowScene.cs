using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NowScene : MonoBehaviour
{
    [SerializeField]
    private Animator LeftAnim;
    [SerializeField]
    private Animator RightAnim;

    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private Titlemove tmove;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        var SceneName = SceneManager.GetActiveScene().name;
        if(SceneName == "Title" && !tmove.scenemoveflag)
        {
            obj.SetActive(false);
            tmove.scenemoveflag = true;
            Destroy(obj);
        }
        else if(!tmove.scenemoveflag) obj.SetActive(true);

    }

    private IEnumerator cutoutanim()
    {
        Debug.Log("**Command2");
        LeftAnim.SetTrigger("1timeout");
        RightAnim.SetTrigger("1timeout");
        yield return new WaitForSeconds(2);
    }
    
}
