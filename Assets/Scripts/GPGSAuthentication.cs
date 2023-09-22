using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;

public class GPGSAuthentication : MonoBehaviour
{

    public static PlayGamesPlatform platform;

    // Start is called before the first frame update
    void Start()
    {
        if (platform == null)
        {
            //PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            //PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }

        Social.Active.localUser.Authenticate(succes =>
        {
            if (succes)
            {
                Debug.Log("Logged in succesfully!");

            }
            else
            {
                Debug.Log("Failed to login");
            }
        });
    }
}
