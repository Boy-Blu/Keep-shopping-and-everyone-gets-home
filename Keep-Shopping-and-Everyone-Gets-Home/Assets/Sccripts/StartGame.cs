﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class StartGame : MonoBehaviour
{

      public int timeLeft = 30; //Seconds Overall
  public Text countdown; //UI Text Object
  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; //Just making sure that the timeScale is right
  }
  void Update () {
    countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
  }
  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
      timeLeft--; 
    }
  }
}