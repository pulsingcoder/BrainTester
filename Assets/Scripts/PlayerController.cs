using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float lastmoveV;
    float lastmoveH;
    
    private Animator myAnim;
   

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        float moveV = Input.GetAxis("Vertical");
        float moveH = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(0, 0, 0);
        if ((moveH!=0) && moveV == 0)
        {
            movement = new Vector3(moveH, moveV, 0.0f);

            myAnim.SetFloat("Horizontal", moveH);
            myAnim.SetFloat("Vertical", moveV);
            transform.position += movement * Time.deltaTime;
            lastmoveH = moveH;
            lastmoveV = moveV;
        }
        else if ((moveV != 0) && moveH == 0)
        {
            movement = new Vector3(moveH, moveV, 0.0f);

            myAnim.SetFloat("Horizontal", moveH);
            myAnim.SetFloat("Vertical", moveV);
            transform.position += movement * Time.deltaTime;
            lastmoveV = moveV;
            lastmoveH = moveH;
        }
        else if (moveV !=0 && moveH!=0)
        {
            movement = new Vector3(lastmoveH, lastmoveV, 0.0f);

            myAnim.SetFloat("Horizontal", lastmoveH);
            myAnim.SetFloat("Vertical", lastmoveV);
            transform.position += movement * Time.deltaTime;

        }
        else
        {
            myAnim.SetFloat("Horizontal", 0);
            myAnim.SetFloat("Vertical", 0);

        }


    }

    void FixedUpdate()
    {
        
    }
}
