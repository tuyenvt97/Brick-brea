using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public GameObject bullet;
    public Transform bulletSp;
    public GameObject gameController;

    public float fireRate;
    private float timeRate;

	void Start () {
        playerPos = transform.position;
	}

    Vector3 playerPos;
	
	// Update is called once per frame
	void Update () {
        float x = transform.position.x + Input.GetAxis("Horizontal") * speed;
        Vector3 newPos = new Vector3(Mathf.Clamp(x, -2.6f, 2.6f), playerPos.y, playerPos.z);
        transform.position = newPos;

        if(Input.GetMouseButton(0) && Time.time>timeRate)
        {
            timeRate = Time.time + fireRate;
            Instantiate(bullet, bulletSp.position, bulletSp.rotation);
        }

    }
}