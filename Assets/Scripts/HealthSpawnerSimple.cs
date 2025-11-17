using UnityEngine;

public class HealthSpawnerSimple : MonoBehaviour
{
    [SerializeField] GameObject healthPickupPrefab;
    [SerializeField] float interval = 10f;
    [SerializeField] Vector2 minPos;
    [SerializeField] Vector2 maxPos;

    void Start()
    {
        InvokeRepeating(nameof(SpawnHealth), interval, interval);
    }

    void SpawnHealth()
    {
        Vector2 pos = new Vector2(
            Random.Range(minPos.x, maxPos.x),
            Random.Range(minPos.y, maxPos.y)
        );
        Instantiate(healthPickupPrefab, pos, Quaternion.identity);
    }
}
