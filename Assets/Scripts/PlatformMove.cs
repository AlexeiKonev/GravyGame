using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] 
    static float moveSpeedPlatform = 3f;
  
    public Vector2 _direction = new Vector2(moveSpeedPlatform, 0);
    void Awake()
    {
       
        StartCoroutine(DestroyPlatform());
    }

    // Update is called once per frame
    void  Update()
    {
        gameObject.transform.Translate(_direction * Time.deltaTime);
        //rb.velocity = new Vector2(rb.velocity.x * moveSpeedPlatform*Time.deltaTime, transform.position.y);
        //transform.position = transform. Vector2(transform.position.x * moveSpeedPlatform, transform.position.y);
    }
   private IEnumerator DestroyPlatform() 
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }
}
