using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraswitch : MonoBehaviour
{

    public GameObject p1;
    public GameObject p3;
    private bool camerastatus = true;


    // Start is called before the first frame update
    void Start()
    {
       
        p1.SetActive(false);
        p3.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartMenu.startgame == true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                
                camera();
            }
           
        }

    }
    void camera()
    {
        if (camerastatus == true)
        {
            
            p1.SetActive(false);
            p3.SetActive(true);
            camerastatus = false;
            move.ismove = true;
        }
        else if(camerastatus == false)
        {

            p1.SetActive(true);
            p3.SetActive(false);
            camerastatus = true;
            move.ismove = false;
        }
    }

}
