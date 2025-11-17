using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component spawns the given object whenever the player clicks a given key.
 * (Modified to support cooldown + limited ammo)
 */
public class ClickSpawner : MonoBehaviour
{
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;

    [Header("Shooting Settings")]
    [SerializeField] protected float fireCooldown = 0.5f;
    [SerializeField] protected int maxAmmo = 20;
    protected int currentAmmo;
    protected float lastFireTime;

    void OnEnable()
    {
        spawnAction.Enable();
    }
    void OnDisable()
    {
        spawnAction.Disable();
    }

    protected virtual void Start()
    {
        currentAmmo = maxAmmo;
        lastFireTime = -fireCooldown;
    }

    protected virtual bool CanShoot()
    {
        return Time.time - lastFireTime >= fireCooldown
               && currentAmmo > 0;
    }

    protected virtual void Shoot()
    {
        currentAmmo--;
        lastFireTime = Time.time;
    }

    protected virtual GameObject spawnObject()
    {
        Debug.Log("Spawning a new " + prefabToSpawn.name);

        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;
        Quaternion rotationOfSpawnedObject = Quaternion.identity;
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    private void Update()
    {
        if (spawnAction.WasPressedThisFrame())
        {

            if (!CanShoot())
            {
                Debug.Log("Can't shoot: cooldown or no ammo");
                return;
            }

            Shoot();
            spawnObject();
        }
    }

    public void Reload()
    {
        currentAmmo = maxAmmo;
    }

    public int GetAmmo() => currentAmmo;
    public int GetMaxAmmo() => maxAmmo;
}
