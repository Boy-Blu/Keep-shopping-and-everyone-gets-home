using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 0; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fruit" || collision.gameObject.tag == "SFruit")
        {
            collision.gameObject.SetActive(false);
            if (collision.gameObject.tag == "Fruit")
            {
                score += 100;
            }
            else
            {
                score += 200; 
            }
            Debug.Log("Score increased!");
            Debug.Log(score);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), score.ToString()); 
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
