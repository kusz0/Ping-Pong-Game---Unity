using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxSpeed;

    int hitCounter = 0;


    void Start()
    {
        StartCoroutine(StartBall());
    }

    void PositionBall(bool isStartingPlayer1)
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0,0);

        if(isStartingPlayer1)
        {
            gameObject.transform.localPosition = new Vector3(-100,0,1);
        }else
        {
            gameObject.transform.localPosition = new Vector3(100, 0, 1);
        }
    }



    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall(isStartingPlayer1);

        hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
        {
            MoveBall(new Vector2(-1, 0));

        } else
        {
            MoveBall(new Vector2(1, 1));
        }
    }
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        
        float speed = movementSpeed + hitCounter * extraSpeedPerHit;

        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();

        rb2D.linearVelocity = direction * speed;
    }
    public void IncreaseHitCounter()
    {
        if(hitCounter * extraSpeedPerHit <= maxSpeed)
        {
            hitCounter++;
        }
    }

}
