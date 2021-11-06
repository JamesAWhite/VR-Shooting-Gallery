using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int score = 0;
    
    RaycastHit hit;
    public void Cast()
    {
        int layerMask = 1 << 3;

        if (Physics.Raycast(this.gameObject.transform.position, this.gameObject.transform.forward, out hit, Mathf.Infinity, layerMask))
        {
            if (hit.transform.gameObject.name.Contains("shittydude"))
            {
                score++;
                Debug.Log(score);
            }
            Debug.Log(hit.transform.gameObject.name);
        }
        else
        {
            Debug.Log("No Hit");
        }
    }
}
