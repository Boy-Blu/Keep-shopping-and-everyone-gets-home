using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

  
public class timer : MonoBehaviour
{
  private string uiText;
  private float mainTimer;

  public float timer1 = 3.0f;
  public float timer2 = 33.0f;

  private string state;
  private bool canCount = true;
  private bool doOnce = false;
  bool move = false;

  void start(){
    state = "start";
  }
  void Update(){
 	// Start 3-sec
  if (timer1 >= 0.0f){
    timer1 =timer1 - Time.deltaTime;
    timer2 = timer2 - Time.deltaTime;
    uiText = timer1.ToString("F");

  }else if (timer2 >= 0.0f){
  	move = true;
  	// "Main" Game
  	timer2 = timer2 - Time.deltaTime;
    uiText = timer2.ToString("F");

  }else{
  	// EndGame
  	move = false;
    uiText = "Game Over";
    timer1 = -1.0f;
  }
 }

  void OnGUI()
  {
    GUI.Label(new Rect(10, 100, 100, 100), uiText.ToString()); 
  }

  public bool shouldMove(){
  	return move;
  }

 
}
