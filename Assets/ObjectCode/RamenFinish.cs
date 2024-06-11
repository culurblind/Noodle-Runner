using UnityEngine;
using UnityEngine.SceneManagement;

public class RamenFinish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
         Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision with player detected!");

            SceneManager.LoadScene("WinScreen");
        }
    }
}