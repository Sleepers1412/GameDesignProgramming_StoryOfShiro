using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2MainMenu : MonoBehaviour
{
    public void MainMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
