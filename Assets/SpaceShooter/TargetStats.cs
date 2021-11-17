using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStats : MonoBehaviour
{
    public int health;
    public int xp;
    public GameObject theShip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bullet")
        {
            transform.localScale *= 0.8f;
            health--;
            xp++;
            Destroy(collision.gameObject);
            theShip.GetComponent<ShipMovement>().xp += xp;
            if (health < 1)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
