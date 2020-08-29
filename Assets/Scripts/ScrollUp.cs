using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollUp : MonoBehaviour
{
    public int x;
    public GameObject ImageGroup;

    public GameObject LogInTab;
    public GameObject SignUpTab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Go()
    {
        StartCoroutine(Scroll());
    }

    public void LogIn()
    {
        LogInTab.SetActive(true);
    }

    public void SignUp()
    {
        SignUpTab.SetActive(true);
    }

    public void LogInSuccessful()
    {
        SceneManager.LoadScene("Map");
    }

    public void Cancel()
    {
        SignUpTab.SetActive(false);
        LogInTab.SetActive(false);
    }

    IEnumerator Scroll()
    {
        for (int i = 0; i <= 42; i++)
        {
            x = i;
            ImageGroup.transform.position = new Vector2(ImageGroup.transform.position.x, ImageGroup.transform.position.y+i);
            yield return new WaitForSeconds(0.01f);
        }
        StopCoroutine(Scroll());
    }
}
