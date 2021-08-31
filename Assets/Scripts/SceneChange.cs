using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public Image NextButton1;
    public Image NextButton2;
    // Start is called before the first frame update
    private void Start()
    {
        NextButton1.enabled = false;
        NextButton2.enabled = false;
    }
    public void Scene1() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("allprojects");
    }
    public void Update()
    {
        StartCoroutine("TurnOnNext");
    }

    IEnumerator TurnOnNext() 
    {

        yield return new WaitForSeconds(1);
        NextButton1.enabled = true;
        NextButton2.enabled = true;

    }
}
