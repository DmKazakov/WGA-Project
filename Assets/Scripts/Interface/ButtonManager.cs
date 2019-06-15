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
    public AudioSource sound;
    public Button[] perkButton; //clinki, splav, reaction



    public GameObject canvasMenu;

    PlayerKeyboardController thePlayer;
    float initSpeed;

    public void Init()
    {
        perkButton[0].GetComponent<Button>().onClick.AddListener(() => PerkListener(0));
        perkButton[1].GetComponent<Button>().onClick.AddListener(() => PerkListener(1));
        perkButton[2].GetComponent<Button>().onClick.AddListener(() => PerkListener(2));

        charButton.onClick.AddListener(OpenCharPanel);
        mainMenuButton.onClick.AddListener(OpenMainMenu);
        player.onClick.AddListener(ActivePlayer);
        robot.onClick.AddListener(ActiveRobot);
        close.onClick.AddListener(Close);


    }
    private void ActivePlayer()
    {
        gameObject.GetComponent<CharPanelManager>().SwitchUnit(0);
        sound.Play();
    }
    private void ActiveRobot()
    {
        gameObject.GetComponent<CharPanelManager>().SwitchUnit(1);
        sound.Play();
    }
    private void Close()
    {
        if (thePlayer != null)
        {
            thePlayer.speed = initSpeed;
        }

        gameObject.SetActive(false);
        sound.Play();
    }

    private void OpenMainMenu()
    {
        canvasMenu.GetComponent<PauseMenu>().OpenMenu();
        sound.Play();
    }

    private void OpenCharPanel()
    {
        if (!gameObject.activeSelf)
        {
            gameObject.GetComponent<CharPanelManager>().SwitchUnit(0);
            SwitchButtonState();
            gameObject.SetActive(true);

            // ограничиваем передсижение
            thePlayer = FindObjectOfType<PlayerKeyboardController>();
            if (thePlayer != null)
            {
                initSpeed = thePlayer.speed;
                thePlayer.speed = 0;
            }
        }
        else
        {
            Close();
        }
        sound.Play();
    }
    private void PerkListener(int num)
    {
        Unit unit = gameObject.GetComponent<CharPanelManager>().currentUnit;
        if (num == 0)
        {
            unit.PerkClinki();
        }
        else if (num == 1)
        {
            unit.PerkSplav();
        }
        else if (num == 2)
        {
            unit.PerkReaction();
        }
        for (int i = 0; i <perkButton.Length; i++)
        {
            SwitchButtonState();
        }
        gameObject.GetComponent<CharPanelManager>().Init();
        sound.Play();
    }
    internal void SwitchButtonState()
    {
        Unit unit = gameObject.GetComponent<CharPanelManager>().currentUnit;
        if (unit.perkEmpty>0)
        {
            InitPerkButton(unit);
        }
        else
        {
            for (int i = 0; i < perkButton.Length; i++)
            {
                perkButton[i].interactable = false;
            }
        }
    }
    private void InitPerkButton(Unit unit)
    {
        for (int i = 0; i <perkButton.Length; i++)
        {
            if (!unit.perkActive[i])
            {
                perkButton[i].interactable = true;
            }
            else
            {
                perkButton[i].interactable = false;
            }
        }
    }

}
