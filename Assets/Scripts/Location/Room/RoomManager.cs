using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    // Start is called before the first frame update
    private DialogManager dialog;
    private RoomDialog dialogTXT;
    private GameObject playerAvatar;

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

        if (Story.chapter == 1.2)
        {
            dialogTXT.Init();
            dialog.StartDialog();
        }

        if (Story.chapter == 1.4)
        {
            dialogTXT.Init();
            dialog.StartDialog();
        }

    }


    public void Init()
    {
        Story.roomManager = gameObject;
        dialog = gameObject.GetComponent<DialogManager>();
        dialogTXT = gameObject.GetComponent<RoomDialog>();

        playerAvatar = GameObject.FindGameObjectWithTag("Player");

    }
    public void Restart() { }
}