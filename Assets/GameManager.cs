using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator Transition;

    public GameObject fire;
    public static bool Fire = true;

    public GameObject gameover;
    public static bool Gameover = true;

    public GameObject normal;
    public static bool Normal = false;

    public float transitionTime = 1f;

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GPGSLeaderboards scorrie;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Fire = false;
            Gameover = false;
            Normal = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);           
        }

    }

    public void Restart()
    {
        StartCoroutine(Restart(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex - 1));
    }

        IEnumerator Restart(int levelIndex)
    {
        //Play animation

        Transition.SetTrigger("Start");

        //Wait

        
        yield return new WaitForSeconds(transitionTime);

        //Load Scene

        Fire = true;
        Gameover = true;
        Normal = false;
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);

    }
    
    void Update ()
    {
        if (Fire)
            fire.SetActive(false);
        else
            fire.SetActive(true);

        if (Gameover)
            gameover.SetActive(false);
        else
            gameover.SetActive(true);

        if (Normal)
            normal.SetActive(false);
        else
            normal.SetActive(true);


    }

}