using UnityEngine;

public class BrickMedium : MonoBehaviour
{
    private int hitPoints = 2;
    public int scoreValue = 200;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hitPoints--;

            if (hitPoints <= 0)
            {
                ScoreManager.Instance.AddScore(scoreValue);
                Destroy(gameObject);
            }
           
            
        }
    }
}