using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverDeathFromHead : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision){//for hits
    if (collision.gameObject.CompareTag("Ground")){//if the head hit the ground
        GameManager.instance.GameOver();
    }
   }
}
