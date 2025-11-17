using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour
{
    [SerializeField] string triggeringTag = "Player";

    [SerializeField]
    [Tooltip("Name of scene to move to when triggering the given tag")]
    string sceneName = "level-2";

    [Header("Score requirement")]
    [SerializeField] NumberField scoreField;
    [SerializeField] int minScoreToPass = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[GotoNextLevel] Trigger by {other.name}, tag={other.tag}");

        // check if its the player
        if (!other.CompareTag(triggeringTag))
        {
            Debug.Log("[GotoNextLevel] Tag does not match, ignoring.");
            return;
        }

        int currentScore = -999;
        if (scoreField == null)
        {
            Debug.Log("[GotoNextLevel] scoreField is NULL! skipping score check.");
        }
        else
        {
            currentScore = scoreField.GetNumber();
            Debug.Log($"[GotoNextLevel] score={currentScore}, minScoreToPass={minScoreToPass}");
        }

        if (scoreField != null && currentScore < minScoreToPass)
        {
            Debug.Log("[GotoNextLevel] Not enough score to pass.");
            return;
        }

        Debug.Log($"[GotoNextLevel] Loading next level: {sceneName}");
        SceneManager.LoadScene(sceneName);
    }

}
