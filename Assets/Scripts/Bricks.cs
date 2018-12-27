using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public GameObject gameController;
    public GameObject brick;
    public GameObject bound;
    void Start() {
        LoadMatrix();
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -8.1f)
        {
            Destroy(this.gameObject);
            GameState.instance.brickcout--;
            SceneManager.LoadScene("menu");
        }
    }

    void LoadMatrix()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 1; j++)
            {
                Instantiate(brick,bound.transform);
            }
        }
    }
}
