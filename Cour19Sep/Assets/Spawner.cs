using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Transform exitTransform;
    public void Spawn()
    {
        Instantiate(objectToSpawn, exitTransform.position, transform.rotation);
    }
}
