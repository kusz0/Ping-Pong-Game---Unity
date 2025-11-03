using UnityEngine;

public class RacetPlayer2 : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {

        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * movementSpeed;
    }
}
