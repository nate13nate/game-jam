using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeUnityEvent : MonoBehaviour
{
  public UnityEvent eventThing;

  void Start()
  {
    eventThing.Invoke();
  }
}
