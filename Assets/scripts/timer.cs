using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    float start = 60f;
    float current = 0f;
    public Text time;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        current = start;
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        current -= 1 * Time.deltaTime;
        time.text = current.ToString("0");

        if (current <= 0)
        {
            Time.timeScale = 0;
            menu.SetActive(true);
        }
    }
}
