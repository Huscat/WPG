using UnityEngine;

public class SuperHealthPickup : MonoBehaviour, IPickup
{
    [SerializeField] public float timer;
    [SerializeField] public bool isInvincible;

    public void Pick(Character character)
    {
        character.OnPickupEnter(this);
    }
}
