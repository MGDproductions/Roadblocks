using UnityEngine;
using UnityEngine.SceneManagement;
public class GPGSLeaderboards : MonoBehaviour
{
    public void OpenLeaderboard()
    {
        Social.ShowLeaderboardUI();
    }

    public void UpdateLeaderboardScore()
    {  
       Social.ReportScore(PlayerPrefs.GetInt("PoepHighScore"), GPGSIds.leaderboard_highscore, (bool succes) =>
         {
             if (succes)
             {
                 Debug.Log("Lol");
             }
         });

    }


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateLeaderboardScore();
    }
}
