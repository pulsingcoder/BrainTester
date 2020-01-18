using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    private Animator myAnim;
    private char facingDir;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        facingDir = 'd';
    }

    // Update is called once per frame
    void Update()
    {
        float moveV = Input.GetAxis("Vertical");
        float moveH = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveH, moveV, 0.0f);
        
        myAnim.SetFloat("Horizontal", moveH);
        myAnim.SetFloat("Vertical", moveV);
        transform.position += movement * Time.deltaTime;
    }

    void FixedUpdate()
    {
        
    }
}
