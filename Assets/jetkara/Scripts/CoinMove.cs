using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
	public float Speed;

    void FixedUpdate()
	{
		
		transform.Rotate(new Vector3(0, Speed * Time.deltaTime, 0));
	
		if (transform.position.x <= -7.5f)
		{
			Destroy(gameObject);
		}
	}
}
