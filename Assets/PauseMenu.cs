using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    private Button pausebutton;
    public void Pause()
    {
        UnityEngine.Time.timeScale = 0f;
        
    }
    
    public void Resume()
    {
        UnityEngine.Time.timeScale = 1f;
    }

    void Awake()
    {
        pausebutton = GetComponent<Button>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pausebutton.onClick.Invoke();
        }
    }

    }
