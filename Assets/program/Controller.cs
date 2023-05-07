using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject littlegameplay;
    public GameObject littlecamera;
    public GameObject player;

    private bool gameTriggered = false;

    private void Start()
    {
        HideGameplay();
    }

    public void SetGameTriggered(bool triggered)
    {
        gameTriggered = triggered;

        if (triggered)
        {
            ShowGameplay();
        }
        else
        {
            HideGameplay();
        }
    }
    private void ShowGameplay()
    {
        littlegameplay.SetActive(true);
        littlecamera.SetActive(true);
        player.SetActive(false);
    }

    private void HideGameplay()
    {
        littlegameplay.SetActive(false);
        littlecamera.SetActive(false);
        player.SetActive(true);
    }

    private void Update()
    {
        // 检查小游戏是否过关，如果过关则隐藏小游戏对象
        if (gameTriggered && Littlegamefinal.finish)
        {
            HideGameplay();
        }
    }



    //public GameObject littlegameplay;
    //public GameObject littlecamera;
    //public GameObject littlegameplay2;
    //public GameObject littlecamera2;
    //public GameObject littlegameplay3;
    //public GameObject littlecamera3;
    //public GameObject littlegameplay4;
    //public GameObject littlecamera4;
    //public GameObject littlegameplay5;
    //public GameObject littlecamera5;
    //public GameObject player;
    //private bool isAnyGameTriggered = false; // 是否有小游戏触发

    //// Start is called before the first frame update
    //void Start()
    //{
    //    littlegameplay.SetActive(false);
    //    littlecamera.SetActive(false);
    //    littlegameplay2.SetActive(false);
    //    littlecamera2.SetActive(false);
    //    littlegameplay3.SetActive(false);
    //    littlecamera3.SetActive(false);
    //    littlegameplay4.SetActive(false);
    //    littlecamera4.SetActive(false);
    //    littlegameplay5.SetActive(false);
    //    littlecamera5.SetActive(false);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (isAnyGameTriggered)
    //    {
    //        Playercontroller1.littlegameplayON = true;
    //        player.SetActive(false);
    //    }
    //    else
    //    {
    //        Playercontroller1.littlegameplayON = false;
    //        player.SetActive(true);
    //    }



    //    if (Littlegamefinal.finish == true)
    //    {

    //        Playercontroller1.littlegameplayON = false;
    //        littlegameplay.SetActive(false);
    //        littlecamera.SetActive(false);
    //    }

    //    if (Littlegame2final.finish2 == true)
    //    {

    //        Playercontroller1.littlegameplayON = false;
    //        littlegameplay2.SetActive(false);
    //        littlecamera2.SetActive(false);
    //    }
    //    if (Littlegame3final.finish3 == true)
    //    {

    //        Playercontroller1.littlegameplayON = false;
    //        littlegameplay3.SetActive(false);
    //        littlecamera3.SetActive(false);
    //    }

    //    if (Littlegame4final.finish4 == true)
    //    {

    //        Playercontroller1.littlegameplayON = false;
    //        littlegameplay4.SetActive(false);
    //        littlecamera4.SetActive(false);
    //    }
    //    if (Littlegame5final.finish5 == true)
    //    {

    //        Playercontroller1.littlegameplayON = false;
    //        littlegameplay5.SetActive(false);
    //        littlecamera5.SetActive(false);
    //    }


    //}
    //public void SetGameTriggered(bool value)
    //{
    //    isAnyGameTriggered = value;
    //}
}
