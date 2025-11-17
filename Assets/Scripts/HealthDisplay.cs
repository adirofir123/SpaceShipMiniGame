using UnityEngine;

[RequireComponent(typeof(NumberField))]
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] PlayerHealth player;
    private NumberField field;

    private void Awake()
    {
        field = GetComponent<NumberField>();
    }

    private void Update()
    {
        if (player != null)
        {
            field.SetNumber(player.CurrentHealth);
        }
    }
}
