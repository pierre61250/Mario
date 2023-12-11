using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PowerUpBlock : MonoBehaviour
{
    public PowerManager powerManager;
    public Power power;

    private void OnTriggerEnter(Collider entity)
    {
        var isPlayer = entity.gameObject.CompareTag("Player");

        if (isPlayer)
        {
            if (powerManager.SetPower(power))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
