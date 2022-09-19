using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private KeyCode shootKey;
    //[SerializeField] private Spawner spawner;
    [SerializeField]private Spawner[] spawners;
    private void Awake()
    {
        Debug.Assert(spawners != null);
        Debug.Assert(spawners.Length != 0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            for(int i = 0; i < spawners.Length; i++)
            {
                spawners[i].Spawn();
            }
        }
    }
}
