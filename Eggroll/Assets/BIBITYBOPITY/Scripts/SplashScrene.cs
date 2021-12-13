using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScrene : MonoBehaviour
{
    public Animator ani;
    private Coroutine CoRouteCache;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(CoRouteCache != null)
            {
                StopCoroutine(CoRouteCache);
            }
            CoRouteCache =  StartCoroutine(SceneTransition());
        } 
           
    }
    IEnumerator SceneTransition()
    {
        ani.SetTrigger("TriggerFade");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
}
