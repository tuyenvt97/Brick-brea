using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOut : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Backgroud")
        {
            Destroy(gameObject);
        }
    }
}
