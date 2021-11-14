using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void ResetScore()
    {
        score = 0;
    }

    public int score = 0;
    
    RaycastHit hit;
    [SerializeField] private PlayQuickSound impact = null;

    public void Cast()
    {
        int layerMask = 1 << 3;

        if (Physics.Raycast(this.gameObject.transform.position, this.gameObject.transform.forward, out hit, Mathf.Infinity, layerMask))
        {
            if (hit.transform.gameObject.name.Contains("Guy"))
            {
                score++;
                Debug.Log("Score: " + score);
                Destroy(hit.transform.gameObject);
                impact.Play();
                
            }
        }
        else
        {
            Debug.Log("No Hit. Score: " + score);
        }
    }
}
