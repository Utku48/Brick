using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBrickHealth : MonoBehaviour
{
    public int brickHealth = 1;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            brickHealth--;


        }
        if (brickHealth == 0)
        {
            Destroy(this.gameObject);
            Win.score += 10;
            Win.brokeBrick++;
        }
    }

}
