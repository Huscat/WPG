using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;
using Zenject;

public class Bum : MonoBehaviour {

    public Text Text;
    public int Ticks;
    private bool isDetonated;

    private IScheduler _scheduler;

    [Inject]
    void Construct(IScheduler scheduler)
    {
        _scheduler = scheduler;
    }

    void Start ()
    {

        Text.text = Ticks.ToString();
	}

    public void OnDetonate()
    {
        if(!isDetonated)
        {
            isDetonated = true;
            _scheduler.Schedule(1, () =>
            {
                DetonationTick();
            });
        }
    }

    void DetonationTick()
    {
        Ticks--;
        Text.text = Ticks.ToString();
        if(Ticks > 0)
        {
            _scheduler.Schedule(1, () =>
            {
                DetonationTick();
            });
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
