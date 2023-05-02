using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMenu : MonoBehaviour
{
    public static bool startgame = false;

    public GameObject startMenuPanel;

    public static bool shouldClosePanel = false;



    private void Start()
    {
        Time.timeScale = 0f;
       
    }

    public void EXITPANEL()
    {
        shouldClosePanel = true;
    }

    private void Update()
    {
        if (shouldClosePanel)
        {
            startgame = true;
            startMenuPanel.SetActive(false);
            shouldClosePanel = false;
            Time.timeScale = 1f;
           
        }
    }

   
}

