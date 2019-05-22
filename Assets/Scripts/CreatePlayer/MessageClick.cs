using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageClick : MonoBehaviour
{
    public NewGame script;

    public void Apply() {
        script.StartGame();
    }
    public void Cancel() {
        gameObject.SetActive(false);
    }
}
