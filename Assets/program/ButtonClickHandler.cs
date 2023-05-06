using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject panelToHide;
    public GameObject panelToShow;

    private Button button;
    private bool isPanelVisible = true;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SwitchPanel);
    }

    private void SwitchPanel()
    {
        if (isPanelVisible)
        {
            panelToHide.SetActive(false);
            panelToShow.SetActive(true);
            isPanelVisible = false;
        }
        else
        {
            panelToHide.SetActive(true);
            panelToShow.SetActive(false);
            isPanelVisible = true;
        }
    }
}
