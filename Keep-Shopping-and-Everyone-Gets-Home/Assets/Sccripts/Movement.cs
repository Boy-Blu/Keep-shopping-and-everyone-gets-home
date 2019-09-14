using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
   
  public float speed = 10.0F;





  // Start is called before the first frame update
  void Start(){
    Cursor.lockState = CursorLockMode.None;

  }
  // Update is called once per frame
  void Update(){

    if (gameObject.GetComponent<timer>().shouldMove()){  
  	float translation = Input.GetAxis("Vertical") * speed;
  	float strafe = Input.GetAxis("Horizontal") * speed;
	
  	translation *= Time.deltaTime;
  	strafe *= Time.deltaTime;
  	transform.Translate(strafe, 0, translation);
  }
    
   }
}
