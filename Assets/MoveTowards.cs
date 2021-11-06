using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    private Vector3 target = new Vector3(1, 1, 1);
    private float speed = 1;

    public void Start()
    {
        target = new Vector3(Random.Range(-30, 30), Random.Range(5, 30), -30);
        speed = Random.Range(8, 30);
}
    private void Update()
    {
        // Moves the object to target position
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        if (gameObject.transform.position == target)
        {
            Destroy(gameObject);
        }
    }
}