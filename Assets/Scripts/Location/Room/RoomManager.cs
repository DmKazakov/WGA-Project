﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : Managers
{
    //крепится к менеджеру

    private DialogManager dialog;
    private RoomDialog dialogTXT;
    private GameObject playerAvatar;


    public GameObject sister;

    void Start()
    {

        Init();

        if (Story.chapter == 1.0)
        {
            dialogTXT.Init();
            dialog.StartDialog();
            playerAvatar.GetComponent<Avatar>().AddUnitSquad(0);
            Story.NextChapter();

        }

        else if (Story.chapter == 1.2)
        {
            dialogTXT.Init();
            dialog.StartDialog();
            Story.NextChapter();
        }

        else if (Story.chapter == 1.4)
        {
            dialogTXT.Init();
            dialog.StartDialog();
            Story.NextChapter();
        }
    }
    public void Init()
    {
        dialog = gameObject.GetComponent<DialogManager>();
        dialogTXT = gameObject.GetComponent<RoomDialog>();

        playerAvatar = GameObject.FindGameObjectWithTag("Player");

    }

    public override void EvenDialog()
    {
        if (Story.chapter == 1.5)
        {
            Init();
            dialogTXT.Init();
            dialog.StartDialog();
            Story.NextChapter();
            sister.SetActive(true);

            print(Story.chapter);
        }
        else if (Story.chapter == 1.6)
        {
            print("прописать сообщение концовки игры");
        }
    }
    public static void Restart()
    {

    }

}