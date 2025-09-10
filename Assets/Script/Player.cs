using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float force = 500f;
    public float speed = 10f;
    public float minX;
    public float maxX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void FixedUpdate()
    {
        // Forward movement (Z axis)
        playerRigidbody.AddForce(0, 0, force * Time.fixedDeltaTime);

        // Left/Right movement
        float move = 0f;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            move = speed;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            move = -speed;

        // MovePosition for smooth Rigidbody movement
        Vector3 newPos = playerRigidbody.position + new Vector3(move * Time.fixedDeltaTime, 0, 0);
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        playerRigidbody.MovePosition(newPos); //.move position(it is method) is use for somoth movment if we use .position it teliporte in rigidBody

    }

    // Update is called once per frame
    // void Update()
    // {
    //     // Debug.Log("hi this is update mathod");

    //     Vector3 playerPos = transform.position;
    //     playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX); //short code for niche wala code;
    //     /*
    //     if(playerPos.x < minX){
    //         playerPos.x = minX;
    //     }
    //     if(playerPos.x > maxX){
    //         playerPos.x = maxX;
    //     }
    //     */
    //     transform.position = playerPos;

    //     // for player left right movement from key
    //     if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    //     {
    //         transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);

    //         // rigidbody.AddForce(1000f*Time.deltaTime,0,0); this not give good movement it is good for car
    //     }
    //     if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    //     {
    //         transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
    //     }
    //     // if(transform.position.y <= -10f){
    //     //     Destroy(gameObject);
    //     // }
    // }

    // void FixedUpdate()
    // {
    //     // change position with rigidbody;
    //     playerRigidbody.AddForce(0, 0, force * Time.deltaTime);

    //     // this for transforming the position in z axis 
    //     /* 
    //     transform.position = transform.position + new Vector3(0, 0, 1f * Time.deltaTime);//time.deltaTime is use for make obj framerate indipdent
    //     */

    // }

}
