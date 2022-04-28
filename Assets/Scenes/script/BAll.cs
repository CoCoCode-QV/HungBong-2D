using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAll : MonoBehaviour
{
    GameControler m_Controler;


    // Start is called before the first frame update
    void Start()
    {
        m_Controler = FindObjectOfType<GameControler>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_Controler.IncrementScore();
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Line"))
        {
            m_Controler.setisGameOver(true);
            Destroy(gameObject);
        }
    }
}
