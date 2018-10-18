using UnityEngine;

public class HealthPickup : MonoBehaviour, IPickup
{
    [SerializeField] public float health;

    public void Pick(Character character)
    {
        character.OnPickupEnter(this);
    }
}
