using UnityEngine;

public class HardBrick : MonoBehaviour
{
    private int hitPoints = 3;
    public int scoreValue = 300;

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