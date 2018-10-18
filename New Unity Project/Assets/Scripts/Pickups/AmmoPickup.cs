using UnityEngine;

public class AmmoPickup : MonoBehaviour, IPickup
{
    public void Pick(Character character)
    {
        character.OnPickupEnter(this);
    }
}
