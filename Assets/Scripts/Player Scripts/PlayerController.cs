using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public GameObject Camera;

    public Transform playerCamera;

    public float rotationSpeed;
    public float speed;
    public float JumpForce;

    public float coolDownPeriodInSeconds;
    private float timeStamp;

    private Rigidbody rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        //Movement on X and Z axis
        float moveHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 targetDirection = new Vector3(moveVertical, 0.0f, moveHorizontal);
        targetDirection = Camera.transform.TransformDirection(targetDirection);
        
        rb.AddForce(targetDirection * speed);

        if (targetDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDirection), rotationSpeed);
        }


        //Jumping function
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeStamp)
        {
            var rigid = this.gameObject.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddForce(transform.up * JumpForce, ForceMode.Impulse);     
            }

            timeStamp = Time.time + coolDownPeriodInSeconds;

        }



        //Third Person Camera Function (not 100% finished just yet)
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Camera.transform.localPosition = new Vector3(0, 5, 2);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Camera.transform.localPosition = new Vector3(0, 1, 0);      
        }
    }

}

   
