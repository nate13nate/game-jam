using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public bool isOpen = false;
    public UnityEvent openDoor;

    public void setIsOpen(bool thing) {
        isOpen = thing;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(isOpen);
        if (isOpen) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
