using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScore;

    public GameObject newhighscore;
    public GameObject newhighscoresound;
    public GameObject speedup;
    public float newerhighscore;
    public GameObject tutorial;
    public int Poephighscore;
    public GPGSAchievements unlocks;

    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        newerhighscore = PlayerPrefs.GetFloat("HighScore", 0);

        if (newerhighscore > 100000)
        {
            speedup.SetActive(true);
        }
        else
        {
            speedup.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if (player.position.z > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", player.position.z);
        }
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        newerhighscore = PlayerPrefs.GetFloat("HighScore", 0);
        Poephighscore = (int)newerhighscore; 
        PlayerPrefs.SetInt("PoepHighScore", Poephighscore);

        if (newerhighscore < player.position.z + 10)
        {
            newhighscore.SetActive(true);
            newhighscoresound.SetActive(true);
        }

        if (newerhighscore < 5000)
        {
            tutorial.SetActive(true);
        }
        else
        {
            tutorial.SetActive(false);
        }

        if (player.position.z + 10 > 100000)
        {
            speedup.SetActive(false);
        }

    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }


}
