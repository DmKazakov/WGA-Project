using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button player;
    public Button robot;
    public Button close;
    public Button mainMenuButton;
    public Button charButton;

    public GameObject canvasMenu;

   

    public void Init()
    {
        charButton.onClick.AddListener(OpenCharPanel);
        mainMenuButton.onClick.AddListener(OpenMainMenu);
        player.onClick.AddListener(ActivePlayer);
        robot.onClick.AddListener(ActiveRobot);
        close.onClick.AddListener(Close);
    }
    private void ActivePlayer()
    {
        gameObject.GetComponent<CharPanelManager>().SwitchUnit(0);
    }
    private void ActiveRobot()
    {
        gameObject.GetComponent<CharPanelManager>().SwitchUnit(1);
    }
    private void Close()
    {
        gameObject.SetActive(false);
    }

    private void OpenMainMenu()
    {
        canvasMenu.GetComponent<PauseMenu>().OpenMenu();
    }
    private void OpenCharPanel()
    {
        gameObject.GetComponent<CharPanelManager>().SwitchUnit(0);
        gameObject.SetActive(true);
    }
}
