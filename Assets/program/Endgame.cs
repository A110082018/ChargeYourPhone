using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public static bool GameEnd = false;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Controller.count == 4) // ��p�C���p�Ƽƨ�4
        {
            
            //���X���d������canvas
            panel.SetActive(true);

            GameEnd = true;
        }

    }
}
