using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        guysLeft = 10
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(waitTime > timer)
        {

        }
        else
        {
            timer = 0.0f;
            waitTime = Random.Range(1.0f, 5.0f);
            Spawn();
        }
    }

    public float waitTime = 0.0f;
    private float timer = 0.0f;
    public int guysLeft;
    private int guysSoFar;

    [Tooltip("The object that will be spawned")]
    public GameObject originalObject = null;

    [Tooltip("The transform where the object is spawned")]
    public Transform spawnPosition = null;

    public void Spawn()
    {
        if (guysLeft <= guysSoFar)
        {
            this.enabled = false;
        }
        Instantiate(originalObject, spawnPosition.position, spawnPosition.rotation);
        guysSoFar++;
    }

    private void OnValidate()
    {
        if (!spawnPosition)
            spawnPosition = transform;
    }
}
