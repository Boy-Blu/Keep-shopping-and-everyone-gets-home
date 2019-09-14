using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 0; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            collision.gameObject.SetActive(false);
            score += 100; 
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
