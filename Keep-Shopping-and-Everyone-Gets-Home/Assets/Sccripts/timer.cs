using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

  
public class timer : MonoBehaviour
{
  [SerializeField] private Text uiText;
  [SerializeField] private float mainTimer;

  private float timer1 = 10.0f;

  private string state;
  private bool canCount = true;
  private bool doOnce = false;

  void start(){
      // timer1 = 30.0f;
    state = "start";
  }

 void Update(){
  if (timer1 >= 0.0f && canCount){
    timer1 =timer1 - Time.deltaTime;
    uiText.text = timer1.ToString("F");
  }else if (timer1 <= 0.0f && ! doOnce){
    canCount = false;
    doOnce = true;
    uiText.text = "Game Over";
    timer1 = 0.0f;
  }
 }
}
