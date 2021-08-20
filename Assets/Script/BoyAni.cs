using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAni : MonoBehaviour
{
    //Variables to use the blend tree
    public float VelX, VelZ;
    Animator Ani;

    // Start is called before the first frame update
    void Start()
    {
        Ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && VelZ <= 1f)
        {
            //Animation will run when W and Shift are both pressed
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W) && VelZ <= 0.5f)
        {
            //Animation will walk when only W is pressed
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (VelZ >= 0)
        {
            //Animation will return to idle when no buttons pressed
            VelZ -= 0.5f * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) && VelX >= -1f)
        {
            //Animation will run to the left when A and Shift are both pressed
            VelX -= 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) && VelX >= -0.5f)
        {
            //Animation will walk left when only A is pressed
            VelX -= 0.5f * Time.deltaTime;
        }
        else if (VelX <= 0)
        {
            //Will return to Idle when no buttons pressed
            VelX += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) && VelX <= 1f)
        {
            //Animation will run right when D and Shift are both pressed
            VelX += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && VelX <= 0.5f)
        {
            //Animation will walk right when only D is pressed
            VelX += 0.5f * Time.deltaTime;
        }
        else if (VelX >= 0)
        {
            //Will return back to Idle when no buttons pressed
            VelX -= 0.5f * Time.deltaTime;
        }

        //Jump is set by a trigger after Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ani.SetTrigger("Jump");
        }

        //Sets the blend tree variables
        Ani.SetFloat("VelocityX", VelX);
        Ani.SetFloat("VelocityZ", VelZ);
    }
}
