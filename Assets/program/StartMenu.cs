using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMenu : MonoBehaviour
{
    public GameObject startMenuPanel;

    private bool shouldClosePanel = false;


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
        }
    }
}

