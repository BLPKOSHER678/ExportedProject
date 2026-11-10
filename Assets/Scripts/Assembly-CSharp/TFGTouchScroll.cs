using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TFGTouchScroll : MonoBehaviour
{
	public enum ScrollDirection
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Serializable]
	public class VectorB
	{
		public bool x;

		public bool y;

		public bool z;

		public VectorB inverseYZ
		{
			get
			{
				return default;
			}
		}

		public VectorB(bool x, bool y, bool z)
		{
		}
	}

	public float offset;

	public Vector3 rotations;

	public VectorB rotSymmetric;

	public Vector3 localTranslations;

	public VectorB localTransSymmetric;

	public Vector3 absoluteTranslations;

	public VectorB absTransSymmetric;

	public float spacing;

	public float startScroll;

	public float touchSensivity;

	public float adjustSpeed;

	public float jumpSpeed;

	public ScrollDirection scrollDirection;

	public float deltaMinOffset;

	public float deltaMaxOffset;

	public bool autoExecute;

	private Transform executed;

	public float selectThreshold;

	private List<Transform> elements;

	private List<Transform> buttons;

	private bool touching;

	private TouchManager.TFGTouch savedTouch;

	public float inertia;

	private float speed;

	public TFGTouchScroll[] connectedScrolls;

	private float adjustSensivity;

	private void Awake()
	{
	}

	public void refreshList()
	{
	}

	private void Update()
	{
	}

	public void moveToItem(int item)
	{
	}

	public Vector3 setAbs(Vector3 vec, float val, VectorB vb)
	{
		return default;
	}

	private void onTouchStay(TouchManager.TFGTouch touch)
	{
	}

	private void onTouchEndedStill(TouchManager.TFGTouch touch)
	{
	}

	public GameObject getElement(int id)
	{
		return default;
	}

	public GameObject getSelectedElement()
	{
		return default;
	}

	public void executeSelected()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
