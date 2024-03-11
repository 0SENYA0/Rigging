using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
	public class Bear : MonoBehaviour
	{
		[SerializeField] private List<Rigidbody> _riggingRigidbody;
		[SerializeField] private List<Collider> _riggingColliders;

		[SerializeField] private Animator _animator;
		[SerializeField] private BoxCollider _boxCollider;

		private void Awake() =>
			DisableRigging();

		public void EnableRigging()
		{
			_animator.enabled = false;
			_boxCollider.enabled = false;

			foreach (Rigidbody rigidbody in _riggingRigidbody)
				rigidbody.isKinematic = false;
			
			foreach (Collider collider in _riggingColliders)
				collider.enabled = true;
		}

		public void DisableRigging()
		{
			_animator.enabled = true;
			_boxCollider.enabled = true;

			foreach (Rigidbody rigidbody in _riggingRigidbody)
				rigidbody.isKinematic = true;
			
			foreach (Collider collider in _riggingColliders)
				collider.enabled = false;
		}
	}
}