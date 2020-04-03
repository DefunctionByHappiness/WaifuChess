using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenu () {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame(){
        //Application.Quit();
    }
}
