using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    [Tooltip("The object that will be spawned")]
    public GameObject originalObject = null;

    [Tooltip("The transform where the object is spanwed")]
    public Transform spawnPosition = null;

    public void Spawn()
    {
        Instantiate(originalObject, spawnPosition.position, spawnPosition.rotation);
    }

    private void OnValidate()
    {
        if (!spawnPosition)
            spawnPosition = transform;
    }
}
