using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

  
public class TimeScript : MonoBehaviour
{
  [SerializeField] private Text uiText;
  [SerializeField] private float mainTimer;

  private float timer = 10.0f;

  private string state;
  private bool canCount = true;
  private bool doOnce = false;

  void start(){
      // timer = 30.0f;
    state = "start";
  }

 void Update(){
  if (timer >= 0.0f && canCount){
    timer =timer - Time.deltaTime;
    uiText.text = timer.ToString("F");
  }else if (timer <= 0.0f && ! doOnce){
    canCount = false;
    doOnce = true;
    uiText.text = "Game Over";
    timer = 0.0f;
  }
 }
}
