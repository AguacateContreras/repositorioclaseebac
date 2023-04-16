using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    private void Awake()
    {
        x = 0;
        print("Awake");
        Debug.LogError("Hola mundo!");
        Debug.LogWarning("Hola mundo!");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo!");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log("Update");
    }
    private void FixedUpdate()
    {
        Debug.LogError("FixedUpdate");

    }
    private void LateUpdate()
    {
        Debug.LogWarning("LateUpdate");
    }
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }
}
