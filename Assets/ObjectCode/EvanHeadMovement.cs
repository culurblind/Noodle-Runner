using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanHeadMovemenmt : MonoBehaviour
{   
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
