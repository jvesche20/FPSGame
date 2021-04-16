using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    private int hp = 100;
    public Text text1;

    public GameObject uiBlood;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        text1.text = "HP: " + hp;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "HP: " + hp;
        timer -= Time.deltaTime;
        
        if (timer < .1)
        {
            uiBlood.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dummie")
        {
            if (timer < .1)
            {
                hp -= 10;
                Toggle();
                timer = 5f;
            }
        }
    }

    public void Toggle()
    {
        uiBlood.SetActive(!uiBlood.activeSelf);
    }
}
