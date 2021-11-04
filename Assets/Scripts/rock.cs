using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rock : MonoBehaviour
{
    // Start is called before the first frame update
    float x_rand = 0;
    Transform rock_pos;
    int speed = 10;

    public rock(int speed)
    {
        this.speed = speed;
    }

    Rigidbody2D hor_rock;
    void Start()
    {
        rock_pos = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        if (this.gameObject.tag == "rock2")
        {
            hor_rock.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);

            if (rock_pos.position.x < -7.38f || rock_pos.position.x > 9.25f)
            {
                rock_pos.position = new Vector3(9.25f, -1.4f, 14.03208f);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            x_rand = Random.Range(-7.43f, 9.3f);
            this.gameObject.transform.position = new Vector3(x_rand, 7.06f, 14.03f);

        }

    }
}
