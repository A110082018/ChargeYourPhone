using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMenu : MonoBehaviour
{

   
    public GameObject startMenuPanel;

    public GameObject startMenuPanel2;

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
           
            startMenuPanel.SetActive(false);
            shouldClosePanel = false;
            Time.timeScale = 1f;
           
        }
    }

   
}

