using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        scoreSource = GameObject.Find("Revolver PBR");
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
        txt = GetComponent<Text>();
        s = scoreSource.GetComponent<MyRayScript>().score;
        Debug.Log("Text set called with score " + s);
        txt.text = "Score: " + s.ToString();
    }
}
