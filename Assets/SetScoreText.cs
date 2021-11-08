using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Text txt;
    public GameObject scoreSource;
    int s;
    
    public void set()
    {
        int s = scoreSource.GetComponent<MyRayScript>().score;
        txt = GetComponent<Text>();
        Debug.Log("Text set called with score " + s);
        txt.text = "Score: " + s.ToString();
    }
}
