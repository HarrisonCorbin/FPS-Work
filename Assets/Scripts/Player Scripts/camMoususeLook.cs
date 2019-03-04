using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMoususeLook : MonoBehaviour {

    Vector3 mouseLook;
    Vector3 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

   public GameObject character;
   

	// Use this for initialization
	void Start ()
    {
        character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        var md = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector3.Scale(md, new Vector3(sensitivity * smoothing, sensitivity * smoothing, sensitivity*smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        smoothV.z = Mathf.Lerp(smoothV.z, md.z, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);

        if (mouseLook.y >= 45)
        {
            mouseLook.y = 45;
        }

        if (mouseLook.y <= -45)
        {
            mouseLook.y = -45;
        }

        if (mouseLook.z <= 0)
        {
            mouseLook.z = 0;
        }

        if (mouseLook.z >= 0)
        {
            mouseLook.z = 0;
        }

       
    }
}
