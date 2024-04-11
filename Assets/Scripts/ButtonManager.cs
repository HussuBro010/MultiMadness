using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void startSinglePlayer()
    {
        SceneManager.LoadScene("CarSelection");
    }

    public void backToSelection()
    {
        SceneManager.LoadScene("CarSelection");
        Time.timeScale = 1;
    }

    public void backToMainmenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
