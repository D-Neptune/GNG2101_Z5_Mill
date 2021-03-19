﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    
    public void loadlevel(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }

    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown && e.control && e.keyCode == KeyCode.Z && e.alt)
        {
            SceneManager.LoadScene("LatheMainMenu");
        }
        else if (e.type == EventType.KeyDown && e.control && e.keyCode == KeyCode.C && e.alt)
        {
            SceneManager.LoadScene("Lathe Certificate");
        }
        else if (e.type == EventType.KeyDown && e.keyCode == KeyCode.F11)
        {
            if (!Screen.fullScreen)
            {
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            }
        }
        else if (e.type == EventType.KeyDown && e.keyCode == KeyCode.Escape)
        {
            if (Screen.fullScreen)
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
