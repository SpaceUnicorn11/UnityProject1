using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{   
    public Controls Controls;
    public GameObject VictoryScreen;
    public GameObject LoseScreen;
    public enum State
    {
        Playing,
        Won,
        Lost,
    }
    public State CurrentState { get; private set; }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt("LevelIndex", 0);
        private set 
        {
            PlayerPrefs.SetInt("LevelIndex", value);
            PlayerPrefs.Save();
        }
    }
    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Lost;
        Controls.enabled = false;
        LoseScreen.SetActive(true);
    }

    public void OnPlayerReachedFinish()
    {
        if(CurrentState != State.Playing) return;

        CurrentState = State.Won;
        LevelIndex++;
        Controls.enabled = false;
        VictoryScreen.SetActive(true);
    }
}
