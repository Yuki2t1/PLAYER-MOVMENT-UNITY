using UnityEngine;

public class platermovment : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float jump=1;
    void Start()
    {
        rb.useGravity=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            rb.AddForce(1,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("s")){
            rb.AddForce(-1,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0,0,-1,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(0,0,1,ForceMode.VelocityChange);
        }
        if(Input.GetKey("space")){
            rb.AddForce(0,jump,0,ForceMode.VelocityChange);
        }
        if (rb.position.y<-1f)
    {
        FindObjectOfType<gamemanager>().Gameover();
    }
    }
    
}
