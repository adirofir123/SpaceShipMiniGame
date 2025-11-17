using UnityEngine;

[RequireComponent(typeof(NumberField))]
public class AmmoDisplay : MonoBehaviour
{
    [SerializeField] private ClickSpawner shooter;
    private NumberField field;

    private void Awake()
    {
        field = GetComponent<NumberField>();
    }

    private void Update()
    {
        if (shooter != null)
        {
            field.SetNumber(shooter.GetAmmo());
        }
    }
}
