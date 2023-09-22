using GooglePlayGames;
using UnityEngine;

public class GPGSAchievements : MonoBehaviour
{

    public bool vijfentwintigduizend = false;
    public bool vijftigduizend = false;
    public bool vijfenzeventigduizend = false;
    public bool eenmiljone = false;

    public void OpenAchievementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void Unlock250000()
    {
        Social.ReportProgress(GPGSIds.achievement_250000_points, 100f, null);
    }

    public void Unlock500000()
    {
        Social.ReportProgress(GPGSIds.achievement_500000_points, 100f, null);
    }

    public void Unlock750000()
    {
        Social.ReportProgress(GPGSIds.achievement_750000_points, 100f, null);
    }

    public void Unlock1000000()
    {
        Social.ReportProgress(GPGSIds.achievement_1000000_points, 100f, null);
    }

    public void Update()
    {
        if (vijfentwintigduizend == false && PlayerPrefs.GetInt("PoepHighScore") > 250000)
        {
            Unlock250000();
            vijfentwintigduizend = true;
        }

        if (vijftigduizend == false && PlayerPrefs.GetInt("PoepHighScore") > 500000)
        {
            Unlock500000();
            vijftigduizend = true;
        }

        if (vijfenzeventigduizend == false && PlayerPrefs.GetInt("PoepHighScore") > 750000)
        {
            Unlock750000();
            vijfenzeventigduizend = true;
        }

        if (eenmiljone == false && PlayerPrefs.GetInt("PoepHighScore") > 1000000)
        {
            Unlock1000000();
            eenmiljone = true;
        }
    }

}
