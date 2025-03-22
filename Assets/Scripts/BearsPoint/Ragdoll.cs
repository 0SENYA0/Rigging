using UnityEngine;
using System;
using System.Collections.Generic;

namespace BearsPoint
{
	public class Ragdoll : MonoBehaviour
	{
		[SerializeField] private Rigidbody[] _rigidbodies;
		[SerializeField] private Animator _animator;

		private bool _isActive;

		public void SetActive(bool flag)
		{
			_isActive = flag;
			_animator.enabled = !_isActive;

			foreach (Rigidbody rigidbody in _rigidbodies)
				rigidbody.isKinematic = !_isActive;
		}
	}
}