using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueBrick : MonoBehaviour
{
    public int brickhealth;



    MeshRenderer paint;
    public Material greenMaterial;

    void Start()
    {
        paint = GetComponent<MeshRenderer>();
    }
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            brickhealth--;

        }
        if (brickhealth == 1)
        {

            paint.material = greenMaterial;


        }
        if (brickhealth == 0)
        {
            Win.score += 20;
            Win.brokeBrick++;
            Destroy(this.gameObject);

        }



    }
}
