using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AreaTrigger : MonoBehaviour
{
    public GameObject panel;
    public float displayTime = 3.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 當玩家進入區域時，顯示Panel
            panel.SetActive(true);
            // 在displayTime秒後，隱藏Panel
            StartCoroutine(HidePanelAfterTime(displayTime));
        }
        if(Endgame.GameEnd ==true)
        {
            panel.SetActive(false);
        }
    }

    IEnumerator HidePanelAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        panel.SetActive(false);
    }
}

