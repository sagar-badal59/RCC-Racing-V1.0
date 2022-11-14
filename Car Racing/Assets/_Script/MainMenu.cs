using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playBtnClicked()
    {
        UIPanelManager.Instance.changeMode(UIPanelManager.ePanel.Lobby);
    }
    public void settingBtnClicked()
    {
        UIPopupManager.Instance.changePopup(UIPopupManager.ePopup.Setting);
    }

    public void mainMenuBtnClicked()
    {
        UIPopupManager.Instance.changePopup(UIPopupManager.ePopup.User_Data);
    }
}
