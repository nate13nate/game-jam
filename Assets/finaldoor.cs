using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class finaldoor : MonoBehaviour
{
    public bool isOpen = false;
    public UnityEvent openDoor;

    public void setIsOpen(bool thing) {
        isOpen = thing;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (isOpen) {
            Application.Quit();
        }
    }
}
