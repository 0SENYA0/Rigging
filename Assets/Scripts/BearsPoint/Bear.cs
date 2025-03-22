using UnityEngine;

namespace BearsPoint
{
	public class Bear : MonoBehaviour
	{
		[SerializeField] private Ragdoll _ragdoll;
		[SerializeField] private BoxCollider _boxCollider;
		
		private void Awake() =>
			DisableRagdoll();

		public void EnableRagdoll()
		{
			_boxCollider.enabled = false;
			_ragdoll.SetActive(true);
		}

		public void DisableRagdoll()
		{
			_boxCollider.enabled = true;
			_ragdoll.SetActive(false);
		}
	}
}