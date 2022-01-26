using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
  public GameObject messageBox;
  public Text messageText;
  public string text;
  public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
      {
        if (messageBox.activeInHierarchy)
        {
          messageBox.SetActive(false);
        }
        else
        {
          messageBox.SetActive(true);
          messageText.text = text;
        }
      }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
      if (collider.CompareTag("Player"))
      {
        playerInRange = true;
      }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
      if (collider.CompareTag("Player"))
      {
        playerInRange = false;
        messageBox.SetActive(false);
      }
    }
}
