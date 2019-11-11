using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Key_Display Key_Display = GameObject.Find("Canvas").GetComponent<Key_Display>();
        Player player = other.GetComponent<Player>();

        if (other.tag == "Player")
        {
            if (player != null)
            {
                player.HasKey = true;
                Key_Display.DontDisplayKey();
                Key_Display.counter++;
                Key_Display.KeyUpdate();
                Destroy(this.gameObject);
            }
        }
    }
}
