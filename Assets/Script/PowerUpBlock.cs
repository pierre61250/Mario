using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PowerUpBlock : MonoBehaviour
{
    public PowerManager powerManager;

    private void OnTriggerEnter(Collider entity)
    {
        var isPlayer = entity.gameObject.CompareTag("Player");

        if (isPlayer)
        {
            if (powerManager.SetPower())
            {
                Destroy(this.gameObject);
            }
        }
    }
}
