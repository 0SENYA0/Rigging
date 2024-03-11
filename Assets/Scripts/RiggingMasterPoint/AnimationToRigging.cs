using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimationToRigging : MonoBehaviour
{
	[SerializeField] private List<Rigidbody> _rigidbodies;
	[SerializeField] private Animator _animator;

	private bool _isRigging;

	// TODO второй вариает получения _rigidbodies
	// private void Awake()
	// {
	//      _rigidbodies = GetComponentsInChildren<Rigidbody>();
	// }

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
		{
			EnableRagdoll();
			_animator.enabled = false;
		}
		else
		{
			DisableRagdoll();
			_animator.enabled = true;
		}
	}

	private void DisableRagdoll()
	{
		foreach (Rigidbody rigidbody in _rigidbodies)
			rigidbody.isKinematic = true;
	}

	private void EnableRagdoll()
	{
		foreach (Rigidbody rigidbody in _rigidbodies)
			rigidbody.isKinematic = false;
	}
}