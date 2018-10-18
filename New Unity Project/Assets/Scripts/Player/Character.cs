using Assets.Scripts;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float ammo;
    [SerializeField] float health;

    public void OnPickupEnter(AmmoPickup pickup)
    {
        ammo += 20;
    }

    public void OnPickupEnter(HealthPickup pickup)
    {
        health += pickup.health;
    }

    public void OnPickupEnter(SuperHealthPickup pickup)
    {
        if (pickup.isInvincible)
        {
            Scheduler.Instance.Schedule(pickup.timer, () => pickup.isInvincible = false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        IPickup pickup = collider.GetComponent<IPickup>();
        pickup?.Pick(this);
    }
}
