using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCharactor : MonoBehaviour
{
    static char cha = 'A';
    [SerializeField]
    Sprite sprite1;
    [SerializeField]
    Sprite spriteA;
    [SerializeField]
    Sprite sprite2;
    [SerializeField]
    Sprite spriteB;
    [SerializeField]
    Sprite sprite3;
    [SerializeField]
    Sprite spriteC;

    static SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        /*
        switch (cha)
        {
            case '1': render.sprite = sprite1; break;
            case '2': render.sprite = sprite2; break;
            case '3': render.sprite = sprite3; break;
            case 'A': render.sprite = spriteA; break;
            case 'B': render.sprite = spriteB; break;
            case 'C': render.sprite = spriteC; break;

        }
        if (cha == '1' || cha == '2'  || cha == '3')
        {
            transform.localScale = new Vector3(5f, 5f, 5f);
        }
        else
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        print(cha);*/
    }
    public void SetChar(char ch)
    {
        render = GetComponent<SpriteRenderer>();
        cha = ch;
         switch (cha)
         {
             case '1': render.sprite = sprite1; break;
             case '2': render.sprite = sprite2; break;
             case '3': render.sprite = sprite3; break;
             case 'A': render.sprite = spriteA; break;
             case 'B': render.sprite = spriteB; break;
             case 'C': render.sprite = spriteC; break;

         }
         if (cha == '1' || cha == '2' || cha == '3')
         {
             transform.localScale = new Vector3(5f, 5f, 5f);
         }
         else
         {
             transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
         }
    }
}
