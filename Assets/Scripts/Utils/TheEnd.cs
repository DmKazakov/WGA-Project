using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public void Exit()
    {
        Story.Exit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene("CreatePlayer");
    }
}
