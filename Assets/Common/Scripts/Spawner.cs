using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
