using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateWay : MonoBehaviour
{
    [SerializeField]
    AudioSource audio;
    [SerializeField]
    GameObject house;
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
    char SetCharactors(string tag)
    {
        char ch;
        switch (tag)
        {
            case "HouseA": ch = 'A'; audio.Play(); SceneManager.LoadScene(1); break;
            case "HouseB": ch = 'B'; SceneManager.LoadScene(2); break;
            case "HouseC": ch = 'C'; SceneManager.LoadScene(3); break;
            case "House1": ch = '1'; SceneManager.LoadScene(4); break;
            case "House2": ch = '2'; SceneManager.LoadScene(5); break;
            case "House3": ch = '3'; SceneManager.LoadScene(6); break;
            default: ch = 'A'; break;
        }

        return ch;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Charactor = SetCharactors(house.tag);
          //  SceneManager.LoadScene(1);
            
            
            number.GetComponent<DisplayCharactor>().SetChar(Charactor);
            print(Charactor);
        }
       }
}
    




