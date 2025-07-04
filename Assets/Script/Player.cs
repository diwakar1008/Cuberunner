using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float force=1000f;
    public float speed = 10f;
    public float minX;
    public float maxX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("hi this is update mathod");

        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x,minX,maxX); //short code for niche wala code;
        /*
        if(playerPos.x < minX){
            playerPos.x = minX;
        }
        if(playerPos.x > maxX){
            playerPos.x = maxX;
        }
        */
        transform.position = playerPos; 

        // for player left right movement from key
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position+ new Vector3(speed*Time.deltaTime,0,0);
        
            // rigidbody.AddForce(1000f*Time.deltaTime,0,0); this not give good movement it is good for car
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position+ new Vector3(-speed*Time.deltaTime,0,0);
        }
        // if(transform.position.y <= -10f){
        //     Destroy(gameObject);
        // }
    }

    void FixedUpdate()
    {
        // change position with rigidbody;
        playerRigidbody.AddForce(0,0,force*Time.deltaTime);

        // this for transforming the position in z axis 
        /* 
        transform.position = transform.position + new Vector3(0, 0, 1f * Time.deltaTime);//time.deltaTime is use for make obj framerate indipdent
        */
    }
}
