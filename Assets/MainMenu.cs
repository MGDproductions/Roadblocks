using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Animator Transition;

    public float transitionTime = 1f;

    public void PlayGame()
    {
        StartCoroutine(LoadGame(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadGame(int levelIndex)
    {
        //Play animation

        Transition.SetTrigger("Start");

        //Wait

        yield return new WaitForSeconds(transitionTime);

        //Load Scene

        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelIndex);
        

    }

    public void QuitToMenu()
    {
        StartCoroutine(QuitToMenu(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator QuitToMenu(int levelIndex)
    {
        //Play animation

        Transition.SetTrigger("Start");

        //Wait

        yield return new WaitForSeconds(transitionTime);

        //Load Scene

        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelIndex);


    }



    public void QuitGame()
    {
        {
            Debug.Log("Quit");
            UnityEngine.Application.Quit();
        }
    } 

    
}
