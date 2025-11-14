using UnityEngine;

public class StartPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
        {
            Debug.Log("スタート地点に触れた");
            GameManager.instance.StartGame();
        }
    }
}
