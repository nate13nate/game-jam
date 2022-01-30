using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChangeOnFlip : MonoBehaviour
{
  public UnityEvent onFlipEvent;
  private SpriteRenderer platform;
  private bool active = false;
  private bool canKill = false;

  private void Start() {
    platform = GetComponent<SpriteRenderer>();
  }

  public void flip() {
    if (active) {
      onFlipEvent.Invoke();
      canKill = true;
    }
  }

  public void setActive(bool thing) {
    active = thing;
  }

  public void murderPlayer() {
    if (canKill) {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  }
}
