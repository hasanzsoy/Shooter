using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public Player player;

    private void RestartLevel()
    {
        levelManager.RestartLevelManager();
        player.RestartPlayer();
    }
}
