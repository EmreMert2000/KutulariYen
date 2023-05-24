using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject buttonAgain, buttonExit, ball;
    public OnTrigger ontrigger;
    
    public void menu1()
    {
        buttonAgain.SetActive(false);
        buttonExit.SetActive(false);
        SceneManager.LoadScene(0);
        ball.SetActive(true);
    }
    public void exit()
    {
        
        Application.Quit();
    }
    private void Update()
    {
       
    }
    public void scene()
    {

        buttonAgain.SetActive(true);
        buttonExit.SetActive(true);

        ball.SetActive(false);
        
    }
}
