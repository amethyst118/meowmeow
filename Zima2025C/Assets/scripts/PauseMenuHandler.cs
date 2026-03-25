using UnityEngine;

public class PauseMenuHandler : MonoBehaviour
{
    private GameStateManager myGameStateManagerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var goGameManagerRef = GameObject.FindGameObjectWithTag("GameController");
        myGameStateManagerRef = goGameManagerRef.GetComponent<GameStateManager>();
    }

    public void OnResumeButton_Clicked()
    {
        myGameStateManagerRef.StartGame();
    }
    public void OnExitButton_Clicked()
    {
        Application.Quit();
    }
}