using UnityEngine;

public class ColisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacet(Collision2D c2D)
    {
        Vector3 ballPosition = transform.position;

        Vector3 racetPosition = c2D.gameObject.transform.position;

        float racetHight = c2D.collider.bounds.size.y;

        float x;
        if(c2D.gameObject.name == "LeftRacet")
        {
            x = 1;
        }else
        {
            x = -1;
        }

        float y = (ballPosition.y - racetPosition.y) / racetHight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2 (x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "LeftRacet" || collision.gameObject.name == "RightRacet")
        {
            BounceFromRacet(collision);
        }else if(collision.gameObject.name == "LeftWall" )
        {
            Debug.Log("Collison with LeftWall");
            scoreController.GoalPlayer2();
        }
        else if (collision.gameObject.name == "RightWall")
        {
            Debug.Log("Collison with RightWall");
            scoreController.GoalPlayer1();
        }
    }

}
