using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class character : MonoBehaviour
{
    Rigidbody2D body;
    public float speed = 200;
    public float JumpForce = 50;
    int points = 0;
    GameObject game_over;
    GameObject[] bananas;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bananas = GameObject.FindGameObjectsWithTag("banana");
        StartCoroutine(activate_banana());
        StartCoroutine(won());
        
    }

    // Update is called once per frame
    private void Update()
    {
        var x_move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x_move, 0, 0) * Time.deltaTime * speed;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(body.velocity.y) < 0.001f)
        {
            body.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
 
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "banana")
        {
            points += 1;
            ScoreScript.instance.AddPoint(); 
            Transform current_banana_pos = collision.gameObject.transform;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "rock")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            var over = GameObject.FindGameObjectWithTag("game_over");
            var render = over.GetComponent<Renderer>();
            render.sortingOrder = 10;
        }

    }

    IEnumerator activate_banana()
    {
        while (true)
        {
            float rand = Random.Range(1f, 5.2f);
            yield return new WaitForSeconds(rand);
            foreach(var item in bananas)
            {
                item.SetActive(true);
            }
        }

    }
    IEnumerator won()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (points == 15)
            {
                var won = GameObject.FindGameObjectWithTag("win");
                var render = won.GetComponent<Renderer>();
                render.sortingOrder = 20;
            }
        }

    }


}
