using System;
using UnityEngine;

[Serializable]
public class TFGTransition
{
	public enum TransitionType
	{
		translation = 0,
		rotation = 1,
		alpha = 2,
		animation = 3
	}

	public TransitionType transitionType;

	public AnimationClip transitionAnimation;

	public AnimationCurve transitionCurve;

	public float transitionSpeed;

	public float alphaFade;

	public float transitionDelay;

	public Vector3 transitionAxis;

	public bool reverse;

	public AudioClip transitionSound;

	private bool soundPlayed;

	private float transitionTime;

	private bool transitioning;

	private Vector3 fromVec;

	private Quaternion fromQuat;

	private Transform transform;

	private TFGWindow owner;

	public Transform targetTransform
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool ended
	{
		get
		{
			return default;
		}
	}

	public void startTransition()
	{
	}

	public void update()
	{
	}

	public void OnDisable()
	{
	}

	public void moveToEnd()
	{
	}
}
