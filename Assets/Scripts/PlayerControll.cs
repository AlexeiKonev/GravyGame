//Attach this script to a 2D GameObject (for example a Sprite).
//Attach a Rigidbody component to the GameObject (Click the Add Component button and go to Physics 2D>Rigidbody 2D)

//This script allows you to change the direction of gravity in your Scene by pressing the space key in Play Mode.

using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControll : MonoBehaviour
{
    public enum GravityDirection { Down, Up };
    public Transform groundCheck;
    public Transform groundCheck2;
    public bool isGroundedUp;
    public bool isGroundedDown;
    public GravityDirection m_GravityDirection;
    //public float DelaySwitchTime = 0.3f;
    

    void Start()
    {
         
        m_GravityDirection = GravityDirection.Down;
    }
    private void FixedUpdate()
    {
        CheckGroundUp();
        CheckGroundDown();
     

    

        switch (m_GravityDirection)
        {
            case GravityDirection.Down:

                //Change the gravity to be in a downward direction (default)
                Physics2D.gravity = new Vector2(0, -9.8f);
                //Press the space key to switch to the left direction
                if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 )
                {

                    SwitchDelay();
                    //m_GravityDirection = GravityDirection.Up;

                }
                break;

           

            case GravityDirection.Up:

                //Change the gravity to be in a upward direction
                Physics2D.gravity = new Vector2(0, 9.8f);
                //Press the space key to change the direction
                if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount>0 )
                {

                    SwitchDelay();
                    //m_GravityDirection = GravityDirection.Down;
                   
                }
                break;

            
        }
         void SwitchDelay() 
        {
             
           if(m_GravityDirection==GravityDirection.Up&& isGroundedUp)
            m_GravityDirection = GravityDirection.Down;
           else if (m_GravityDirection == GravityDirection.Down && isGroundedDown)
                m_GravityDirection = GravityDirection.Up;
        }
    }
    void CheckGroundUp()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);

        isGroundedUp = colliders.Length > 1;
        
    } void CheckGroundDown()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck2.position, 0.2f);

        isGroundedDown = colliders.Length > 1;
        
    }
}