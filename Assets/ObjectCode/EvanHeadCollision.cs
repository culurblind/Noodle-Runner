using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvanHeadCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something triggered... " + collision);
        Debug.Log("Tag of the thing: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision with player detected!");
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
