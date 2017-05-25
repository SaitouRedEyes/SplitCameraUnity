using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
    protected float Fps;

    [SerializeField]
    protected float Speed;

    [SerializeField]
    protected string MoveX, MoveY, BtShoot;
    
	// Use this for initialization
	void Start () 
    {
   
	}

    protected void Move()
    {
        Fps = Time.deltaTime * 60;

        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal") * Fps * this.Speed, Input.GetAxisRaw("Vertical") * Fps * this.Speed);
    }

    /*protected void Shoot()
    {
        if(Input.GetAxisRaw)
        {

        }
    }*/

	// Update is called once per frame
	void Update () 
    {
        Move();
	}
}
