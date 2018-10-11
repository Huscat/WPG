using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Scheduler : MonoBehaviour
    {
        public static Scheduler Instance { get; private set; }

        void Awake()
        {
            Instance = this;
        }

        public void Schedule(float delay, Action action)
        {
            var coroutine = RunDelayed(delay, action);
            StartCoroutine(coroutine);
        }

        private IEnumerator RunDelayed(float delay, Action action)
        {
            yield return new WaitForSeconds(delay);
            action();
        }
    }
}
