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
        if(Controller.count == 4) // 當小遊戲計數數到4
        {
            
            //跳出關卡結束的canvas
            panel.SetActive(true);

            GameEnd = true;
        }

    }
}
