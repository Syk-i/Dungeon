using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {
    //public int damageToGive;
    Vector3 pushDirection;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

    
	}




    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            rb = other.gameObject.GetComponent<Rigidbody2D>();
            Vector2 difference = rb.transform.position - transform.position;
            difference = difference.normalized * 25;
                
            rb.AddForce(difference, ForceMode2D.Impulse);
            Debug.Log("Hurt");
            

            //other.gameObject.GetComponent<Rigidbody2D>().AddForce(pushDirection*-100);

            StartCoroutine(KnockCo(rb));
            





        }

    }
    private IEnumerator KnockCo(Rigidbody2D rb)
    {
        yield return new WaitForSeconds(1);
        rb.velocity = Vector2.zero;
        Debug.Log("KineMatic");
    }
   
    

}
