using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this mono on the game object that holds the entire level
public class LevelFlipper : MonoBehaviour
{
  public void flipLevel() {
    ChangeOnFlip[] thingsToFlip = GetComponentsInChildren<ChangeOnFlip>();

    for (int i = 0; i < thingsToFlip.Length; i++) {
      thingsToFlip[i].flip();
    }
  }
}
