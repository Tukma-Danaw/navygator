using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public GameObject Tracker;
    public GameObject Reporter;
    public GameObject RegionTab;
    public GameObject Maps;
    public int x;
    public bool isPulledDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullDown()
    {
        if (isPulledDown)
        {
            StartCoroutine(PullBack());
        }
        else
        {
            StartCoroutine(Pulled());
            isPulledDown = true;
        }
    }

    public void Track()
    {
        Tracker.SetActive(true);
    }

    public void CloseTracker()
    {
        Tracker.SetActive(false);
    }

    public void Report()
    {
        Reporter.SetActive(true);
    }

    public void CloseReporter()
    {
        Reporter.SetActive(false);
    }

    public void OpenRegion()
    {
        RegionTab.SetActive(true);
    }

    public void CloseRegion()
    {
        RegionTab.SetActive(false);
    }

    public void GoToProfile()
    {
        SceneManager.LoadScene("Profile");
    }

    public void GoToAbout()
    {
        SceneManager.LoadScene("AboutUS");
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Map");
    }

    IEnumerator Pulled()
    {
        for (int i = 0; i <= 21; i++)
        {
            x = i;
            Maps.transform.position = new Vector2(Maps.transform.position.x, Maps.transform.position.y - i);
            yield return new WaitForSeconds(0.01f);
        }
        StopCoroutine(Pulled());
    }

    IEnumerator PullBack()
    {
        for (int i = 0; i <= 21; i++)
        {
            x = i;
            Maps.transform.position = new Vector2(Maps.transform.position.x, Maps.transform.position.y + i);
            yield return new WaitForSeconds(0.01f);
        }
        isPulledDown = false;
        StopCoroutine(PullBack());
    }
}
