using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public Player player;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            RestartLevel();
        }
    }
    private void RestartLevel()
    {
        levelManager.RestartLevelManager();
        player.RestartPlayer();
    }
}
