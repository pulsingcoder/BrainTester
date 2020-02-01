using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWay : MonoBehaviour
{
    [SerializeField]
    char Charactor;
    // Start is called before the first frame update
    [SerializeField]
    GameObject number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            number.GetComponent<DisplayCharactor>().cha  = Charactor;
            print(Charactor);
        }
    }




}
