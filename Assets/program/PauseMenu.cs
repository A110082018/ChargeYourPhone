using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private int selectedOption = 0;
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public Button[] menuButtons;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                resume();
            }
            else
            {
                Pause();
            }
        }

        if (GameIsPaused)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                selectedOption--;
                if (selectedOption < 0)
                {
                    selectedOption = 4;
                }

            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                selectedOption++;
                if (selectedOption > 4)
                {
                    selectedOption = 0;
                }

            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                switch (selectedOption)
                {
                    case 0:
                        Debug.Log("Resume Game");
                        resume();
                        break;
                    case 1:
                        Debug.Log("restart");
                        SceneManager.LoadScene(3);
                        break;
                    case 2:
                        Debug.Log("option");
                        SceneManager.LoadScene(2);
                        break;
                    case 3:
                        Debug.Log("Menu");
                        SceneManager.LoadScene(0);
                        break;


                }
            }
        }
    }
        //private void SelectNextOption()
        //{
        //    menuButtons[selectedOption].GetComponent<Image>().color = Color.white; //取消之前选中的按钮的高亮
        //    selectedOption = (selectedOption + 1) % menuButtons.Length; //更新选中项的索引
        //    menuButtons[selectedOption].GetComponent<Image>().color = Color.blue; //高亮新选中的按钮

        //}

        //private void SelectPreviousOption()
        //{

        //    menuButtons[selectedOption].GetComponent<Image>().color = Color.white; //取消之前选中的按钮的高亮
        //    selectedOption = (selectedOption - 1 + menuButtons.Length) % menuButtons.Length; //更新选中项的索引
        //    menuButtons[selectedOption].GetComponent<Image>().color = Color.blue; //高亮新选中的按钮

        //}


        void resume()
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        void Pause()
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

        }

        //public void LoadMenu()
        //{
        //    SceneManager.LoadScene(0);
        //}

        //public void QuitGame()
        //{
        //    Application.Quit();
        //}

        //public void restart()
        //{
        //    SceneManager.LoadScene(3);
        //}

    
}
