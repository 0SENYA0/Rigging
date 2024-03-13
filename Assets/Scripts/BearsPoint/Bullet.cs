using System.Collections;
using UnityEngine;

namespace BearsPoint
{
	public class Bullet : MonoBehaviour
	{
		private const float MaxTime = 60; 
		
		[SerializeField] private float _speed;
		[SerializeField] private Rigidbody _rigidbody;
		
		private Vector3 _direction;
		private bool _canMove = true;

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.collider.TryGetComponent(out Bear bear) == false)
				return;

			bear.EnableRagdoll();
			_canMove = false;
			gameObject.SetActive(false);
		}

		public void Initialize(Vector3 direction)
		{
			_direction = direction.normalized;
			StartCoroutine(Move());
		}

		private IEnumerator Move()
		{
			float timer = 0;

			while (_canMove)
			{
				_rigidbody.velocity = _direction * (_speed * Time.deltaTime);
				timer *= Time.deltaTime;
				
				if (timer >= MaxTime)
					_canMove = false;
				
				yield return null;
			}
			
			gameObject.SetActive(false);
		}
	}
}