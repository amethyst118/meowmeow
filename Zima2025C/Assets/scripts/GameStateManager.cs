using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        Paused,
        Running
    }
    public GameState CurrentState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0.0f;
        }
    }
    private void SetGameState(GameState newState)
    {
        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
#Dopuisaæ_resztê
    }
}

