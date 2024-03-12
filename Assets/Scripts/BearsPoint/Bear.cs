using UnityEngine;

namespace BearsPoint
{
	public class Bear : MonoBehaviour
	{
		[SerializeField] private Ragdoll _ragdoll;
		[SerializeField] private Animator _animator;
		[SerializeField] private BoxCollider _boxCollider;
		
		// Для объяснения в послднем пункте документа
		private CharacterJoint _joint;
		private ConfigurableJoint _configurableJoint;

		private void Awake() =>
			DisableRigging();

		public void EnableRigging()
		{
			_animator.enabled = false;
			_boxCollider.enabled = false;
			_ragdoll.EnableRigging();
		}

		public void DisableRigging()
		{
			_animator.enabled = true;
			_boxCollider.enabled = true;
			_ragdoll.DisableRigging();
		}
	}
}