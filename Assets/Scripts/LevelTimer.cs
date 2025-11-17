using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] float levelTimeSeconds = 60f;
    [SerializeField] string gameOverSceneName = "level-game-over";
    [SerializeField] NumberField timerField;

    private float timeLeft;
    private bool isOver = false;

    private void Start()
    {
        timeLeft = levelTimeSeconds;
        UpdateDisplay();
    }

    private void Update()
    {
        if (isOver)
            return;

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            timeLeft = 0f;
            isOver = true;
            SceneManager.LoadScene(gameOverSceneName);
            return;
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (timerField != null)
        {
            int secondsLeft = Mathf.CeilToInt(timeLeft);
            timerField.SetNumber(secondsLeft);
        }
    }
}
