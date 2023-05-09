using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraUIcontroller : MonoBehaviour
{

    public GameObject cameralookUI;
    // Start is called before the first frame update
    void Start()
    {
        cameralookUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Firstpersoncamera.inFPS == true)
        {
            cameralookUI.SetActive(true);

        }
        if (Firstpersoncamera.inFPS == false)
        {
            cameralookUI.SetActive(false);
        }
        if (Playercontroller1.littlegameplayON == true)
        {
            cameralookUI.SetActive(false);
        }
        if(Endgame.GameEnd == true)
        {
            cameralookUI.SetActive(false);
        }
    }
}
