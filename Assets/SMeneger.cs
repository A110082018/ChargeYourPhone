using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SMeneger : MonoBehaviour
{
    public void Play()
    {
        //進入關卡選擇
        SceneManager.LoadScene(1);
    }

    public void Introduce()
    {
        //操作介紹

    }

    public void Setup()
    {
        //遊戲設定

    }

    public void Quit()
    {
        //離開遊戲
    }
}