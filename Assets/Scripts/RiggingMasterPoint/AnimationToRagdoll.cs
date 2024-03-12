using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Оставил нетронутым так как это первая работа с рэегдолом
/// </summary>
public class AnimationToRagdoll : MonoBehaviour
{
	[SerializeField] private List<Rigidbody> _rigidbodies;
	[SerializeField] private Animator _animator;

	private bool _isRigging;

	private void Start() =>
		DisableRagdoll();

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space))
		{
			_isRigging = !_isRigging;
			ChangePersonState();
		}
	}

	private void ChangePersonState()
	{
		if (_isRigging)
			EnableRagdoll();
		else
			DisableRagdoll();
	}

	private void DisableRagdoll()
	{
		_animator.enabled = false;

		foreach (Rigidbody rigidbody in _rigidbodies)
			rigidbody.isKinematic = true;
	}

	private void EnableRagdoll()
	{
		_animator.enabled = true;
		
		foreach (Rigidbody rigidbody in _rigidbodies)
			rigidbody.isKinematic = false;
	}
}