using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charactor : MonoBehaviour
{
    public char ch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 2)
        {
            print(ch);
        }
       
    }
    public void SetChar(char c)
    {
        print(c);
        ch = c;
    }
}
