using UnityEngine;

namespace BearsPoint
{
	public class Bullet : MonoBehaviour
	{
		[SerializeField] private Rigidbody _rigidbody;
		[SerializeField] private float _speed;
		
		private void Start() =>
			_rigidbody.velocity = transform.forward * _speed;

		private void OnCollisionEnter(Collision other)
		{
			if (other.collider.TryGetComponent(out Bear bear))
			{
				bear.EnableRagdoll();
				Destroy(gameObject);
			}
		}
	}
}