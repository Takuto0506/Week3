using UnityEngine;

public class Start : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
        {
            GameManager.instance.StartGame();
        }
    }
}
