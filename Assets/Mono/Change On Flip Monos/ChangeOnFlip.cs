using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeOnFlip : MonoBehaviour
{
  public UnityEvent onFlipEvent;

  public void flip() {
    onFlipEvent.Invoke();
  }
}
