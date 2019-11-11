using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Display : MonoBehaviour
{

    public Text key_text;
    [SerializeField]
    public int counter = 0;
    [SerializeField]
    private GameObject KeyDisplay;

    // Start is called before the first frame update
    void Start()
    {
        key_text.text = "KEYS : " + counter;
    }

    public void KeyUpdate()
    {
        key_text.text = "KEYS : " + counter;
    }

    public void DontDisplayKey()
    {

        KeyDisplay.SetActive(false);
    }
}
