using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;
    int currentHealth;

    public int CurrentHealth => currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Player HP: " + currentHealth);
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(0, currentHealth - amount);
        Debug.Log("Player HP (damaged): " + currentHealth);

        if (currentHealth <= 0)
            Die();
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + amount);
        Debug.Log("Player HP (healed): " + currentHealth);
    }
    private void Die()
    {
        Debug.Log("Player died! Loading Game Over...");
        SceneManager.LoadScene("level-game-over");
    }
}
