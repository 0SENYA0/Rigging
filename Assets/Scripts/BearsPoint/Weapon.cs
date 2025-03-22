using System;
using UnityEngine;

namespace BearsPoint
{
	public class Weapon : MonoBehaviour
	{
		[SerializeField] private Bullet _bullet;
		[SerializeField] private Transform _shootPoint;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(_bullet, _shootPoint.transform.position, Quaternion.identity);
			}
		}
	}
}