using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTouch : MonoBehaviour
{
    public Rigidbody2D rb;
    public float yatayKuvvet, dikeyKuvvet;


    void Start()
    {
        //Oyun başladığında Top'a Random.Range içindeki yatayKuvvet kadar x ekseninde kuvvet uygula. Yani duvarlara çarpınca geri seksin
        //y ekseninde aynı hızı kalsın 
        rb.velocity = new Vector2(Random.Range(-yatayKuvvet, yatayKuvvet), rb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.velocity = new Vector2(rb.velocity.x, dikeyKuvvet);//Top Player'a çarpınca dikeyKuvvet kadar hız uygulasın
        }

        if (other.gameObject.tag == "LeftWall")
        {
            //Top sol duvara çarpınca yatay kuvvet kadar yan kuvvet uygula
            //Dikey hızını değiştirme
            rb.velocity = new Vector2(yatayKuvvet, rb.velocity.y);
        }

        //Top sağ duvara çarpınca -yatayKuvvet kadar yan kuvvet uygula
        //Dikey hızını değiştirme
        if (other.gameObject.tag == "RightWall")
        {
            rb.velocity = new Vector2(-yatayKuvvet, rb.velocity.y);
        }

        if (other.gameObject.tag == "RestartLine")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
