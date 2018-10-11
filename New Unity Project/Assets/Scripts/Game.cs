using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Game : MonoBehaviour
    {
        [SerializeField] float delay;

        Action action = () => { Debug.Log("TEST"); };

        void Start()
        {
            Scheduler.Instance.Schedule(delay, action);
        }
    }
}
