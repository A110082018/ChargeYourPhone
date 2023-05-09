using UnityEngine;
using UnityEngine.UI;

public class EXIT : MonoBehaviour
{
    public GameObject panel;
    

    void Update()
    {
        // 检测屏幕点击事件
        if (Input.GetMouseButtonDown(0))
        {
            // 关闭Panel
            panel.SetActive(false);
        }
    }

    public void OnButtonClick()
    {
        // 关闭Panel
        panel.SetActive(false);
    }
}
