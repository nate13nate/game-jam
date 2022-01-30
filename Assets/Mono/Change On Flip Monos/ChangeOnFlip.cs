using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeOnFlip : MonoBehaviour
{
  public UnityEvent onFlipEvent;
  private SpriteRenderer platform;
  private bool active = false;

  private void Start() {
    platform = GetComponent<SpriteRenderer>();
  }

  public void flip() {
    if (active) {
      onFlipEvent.Invoke();
      platform.color = new Color(0.58f, 0, 0.83f, 1);
    }
  }

  public void setActive(bool thing) {
    active = thing;
  }
}
