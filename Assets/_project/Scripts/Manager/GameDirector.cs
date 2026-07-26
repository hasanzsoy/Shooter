using System;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public Player player;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            RestartLevel();
        }
        if (Input.GetKeyDown(KeyCode.O)) 
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            LoadPreviousLevel();
        }
    }

    private void LoadPreviousLevel()
    {
        throw new NotImplementedException();
    }

    private void LoadNextLevel()
    {
        throw new NotImplementedException();
    }

    private void RestartLevel()
    {
        levelManager.RestartLevelManager();
        player.RestartPlayer();
    }
}
