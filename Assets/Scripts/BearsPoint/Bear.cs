using UnityEngine;

namespace BearsPoint
{
	public class Bear : MonoBehaviour
	{
		[SerializeField] private Ragdoll _ragdoll;
		[SerializeField] private Animator _animator;
		[SerializeField] private BoxCollider _boxCollider;
		
		private void Awake() =>
			DisableRagdoll();

		public void EnableRagdoll()
		{
			_animator.enabled = false;
			_boxCollider.enabled = false;
			_ragdoll.Enable();
		}

		public void DisableRagdoll()
		{
			_animator.enabled = true;
			_boxCollider.enabled = true;
			_ragdoll.Disable();
		}
	}
}