using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Text text;
    static float[] order = { 0, 0, 0, 0, 0, 0 };
    [SerializeField]
    int index;
    static float score=0f;
    float lastmoveV;
    float lastmoveH;
    public Joystick joystick;
    float moveV = 0f;
    float moveH = 0f;
    
    private Animator myAnim;
   

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (joystick.Vertical >= 0.2f)
        {
            moveV = joystick.Vertical;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            moveV = joystick.Vertical;
        }
        else
        {
            moveV = 0f;
        }
        if (joystick.Horizontal >= 0.2f)
        {
            moveH = joystick.Horizontal;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            moveH = joystick.Horizontal;
        }
        else
        {
            moveH = 0f;
        }
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
        
        /*
         For touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
        }*/
        for (int i=0;i<Input.touchCount;i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        }
        text.text = score.ToString();

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        /*
        if (col.gameObject.tag == "Gate")
        {
            
            SceneManager.LoadScene(1);
          
        }*/
        if (col.gameObject.tag == "Gate2")
        {
            SceneManager.LoadScene(0);
        }
     
    }
    public void Score()
    {
        if (index == 0)
        {
            score += 10;
            order[index] = 1;
        }
        else
        {
            if (order[index - 1] == 1)
            {
                score += 10;
                order[index] = 1;
            }
            else
            {
                score -= 5;
            }
        }
        if (score < 0)
        {
            score = 0;
        }

    }
}
