using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuHandler : MonoBehaviour
{
    private GameStateManager myGameStateManagerRef;

    public Slider MySlider;
    public TMP_Text MyText;
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

    public void OnValue_Changed()
    {
        MyText.text = MySlider.value.ToString("F2");

    }

    public void OnBalueWithParameter_Changed(float value)
    {
        MyText.text = value.ToString("F2");
    }


}