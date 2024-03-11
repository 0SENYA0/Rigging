using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
	public class Bullet : MonoBehaviour
	{
		[SerializeField] private float _speed;
		[SerializeField] private Rigidbody _rigidbody;
		private Vector3 _direction;
		private bool _canMove = true;

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.collider.TryGetComponent(out Bear bear) == false)
				return;

			bear.EnableRigging();
			_canMove = false;
			gameObject.SetActive(false);
		}

		public void Move(Vector3 direction)
		{
			_direction = direction.normalized;
			StartCoroutine(MoveCoroutine());
		}

		private IEnumerator MoveCoroutine()
		{
			while (_canMove)
			{
				_rigidbody.velocity = _direction * (_speed * Time.deltaTime);
				yield return null;
			}
		}
	}
}