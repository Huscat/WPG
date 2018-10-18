using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float SpawnRate;
    [SerializeField] Vector3 Range;


    void Start()
    {
        Loop();
    }

    void Loop()
    {
        Spawn();
        Scheduler.Instance.Schedule(SpawnRate, () => Loop());
    }

    void Spawn()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(Random.Range(0,5), Random.Range(0, 5), Random.Range(0, 5));
    }
}
