using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene("Round 1");
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("level", 0);
        SceneManager.LoadScene("Round 1");
    }

}
