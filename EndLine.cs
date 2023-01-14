using UnityEngine;

public class EndLine : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Periksa apakah objek yang menabrak garis adalah objek yang harus dikendalikan
        if (collision.gameObject.CompareTag("Player"))
        {
            //Kode untuk mengakhiri permainan
            GameManager.Instance.EndGame();
        }
    }
}