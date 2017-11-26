using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class FoodSharp : NetworkBehaviour 
{

	public GameObject Food;
	public int  totalFood=10;


	public void Start()
	{	



		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =1;
			Vector3 Target = new Vector3 (x*i*2, y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =5;
			Vector3 Target = new Vector3 (x*i*2, y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =1;
			Vector3 Target = new Vector3 (-x*i*2,-y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =5;
			Vector3 Target = new Vector3 (-x*i*2, -y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =1;
			Vector3 Target = new Vector3 (x*i*2,-y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =5;
			Vector3 Target = new Vector3 (x*i*2, -y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =1;
			Vector3 Target = new Vector3 (-x*i*2,+y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}
		for(int i=1;i<totalFood;i++)
		{
			int x = 1;
			int y =5;
			Vector3 Target = new Vector3 (-x*i*2, +y, 0);
			Target.z = 0;

			Instantiate (Food, Target, Quaternion.identity);

		}

	}

	


	





}
