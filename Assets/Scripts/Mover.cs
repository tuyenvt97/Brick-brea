using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{

    // Use this for initialization
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 5.1f)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("OnTriggerEnter2D");
        Destroy(collision.gameObject);
        Destroy(gameObject);
        GameState.instance.brickcout--;
        if (GameState.instance.brickcout == 0)
        {
            GameController.Instance.EndGame1();
            Time.timeScale = 0;
        }

    }
}
