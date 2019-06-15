using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageClick : MonoBehaviour
{
    public NewGame script;
    public AudioSource soundClick;
    public void Apply() {
        soundClick.Play();
        script.StartGame();
    }
    public void Cancel() {
        soundClick.Play();
        gameObject.SetActive(false);
    }
}
