using UnityEngine;
using System;
using System.Collections.Generic;

namespace BearsPoint
{
	[Serializable]
	public class Ragdoll
	{
		[SerializeField] private List<Rigidbody> _rigidbodys;
		[SerializeField] private List<Collider> _colliders; 

		public void Enable()
		{
			foreach (Rigidbody rigidbody in _rigidbodys)
				rigidbody.isKinematic = false;
			
			foreach (Collider collider in _colliders)
				collider.enabled = true;
		}

		public void Disable()
		{
			foreach (Rigidbody rigidbody in _rigidbodys)
				rigidbody.isKinematic = true;
			
			foreach (Collider collider in _colliders)
				collider.enabled = false;
		}
	}
}