using UnityEngine;


public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction")]
    [SerializeField] string triggeringTag;

    public event System.Action onHit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enabled) return;

        if (other.tag != triggeringTag && this.tag != triggeringTag)
            return;

        //is one of the sides is the player?
        PlayerHealth playerOnThis  = GetComponent<PlayerHealth>();
        PlayerHealth playerOnOther = other.GetComponent<PlayerHealth>();

        if (playerOnThis != null || playerOnOther != null)
        {
            // who is the player and who needs to be destroyed?
            PlayerHealth player = playerOnThis != null ? playerOnThis : playerOnOther;
            GameObject objectToDestroy =
                (playerOnThis != null) ? other.gameObject : this.gameObject;

            player.TakeDamage(1);           
            Destroy(objectToDestroy);       
            onHit?.Invoke();
            return;
        }

    
        Destroy(this.gameObject);
        Destroy(other.gameObject);
        onHit?.Invoke();
    }

    private void Update()
    {
        
    }
}
