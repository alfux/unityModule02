using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
	public float	healthPoints = 5;

    void Start()
    {
		Debug.Log("The base has " + this.healthPoints + "HPs.");
    }

    void Update()
    {
        if (this.healthPoints < 1)
		{
			Debug.Log("Game Over");
			Spawner.Deactivate();
			GameObject.Destroy(this.gameObject);
		}
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Ennemy"))
		{
			this.healthPoints -= 1;
			Debug.Log(
				"Base took damage: "
				+ (this.healthPoints + 1)
				+ " - 1 = "
				+ this.healthPoints
			);
		}
	}
}
