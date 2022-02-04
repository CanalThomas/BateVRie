using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManager : MonoBehaviour
{
    static public Etat state;

    public enum Etat
    {
        MAIN,
        TUTO_MENU,
        TUTO_FOUR_FIRST,
        TUTO_PLAY,
        TUTO_DEMO,
        FREE_MENU,
        FREE_PLAY
    }

    public void LoadTutoScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TutoScene");
    }


    public void LoadFreeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FreeScene");
    }

    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Cette fonction est appelée lors de l'appui sur le bouton menu de la manette si on est dans la scene de tuto ou la scene libre
    public void ChangeIsPaused()        
    {
        //if (isPaused == true) return;

        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "FreeScene")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }

        else if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "TutoScene")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex); 
        }


        //isPaused = !isPaused;
    }
}