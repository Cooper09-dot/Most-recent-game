using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLook : MonoBehaviour
{

    //mouse direction
    private Vector2 mD;

    //private Transform myBody;
    void Start()
    {
       // myBody = this.transform.parent.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        // If you want to see the mouse again
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        float movement = Input.GetAxis("Vertical");
        movement *= Time.deltaTime; 


        //The range the mouse has moved up or down
        Vector2 mC = new Vector2
            (Input.GetAxisRaw("Mouse X") * 3f,
                Input.GetAxisRaw("Mouse Y") * 3f);

        mD += mC;
          
        

        //myBody.localRotation =
        //Quaternion.AngleAxis(mD.x, Vector3.up);

        Quaternion qR = 
        this.transform.localRotation =
            Quaternion.AngleAxis(mD.x, Vector3.up);
        
        //The actual rotation
        this.transform.localRotation = qR * 
            Quaternion.AngleAxis(-mD.y, Vector3.right);

        this.transform.Translate
        (Vector3.forward * movement); 
    }
}
