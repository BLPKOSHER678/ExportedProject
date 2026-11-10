using UnityEngine;

public class CamHotSpot : MonoBehaviour
{
	public float effectDistance;

	public Vector2 effectOffset;

	public float destroyDistance;

	public Vector2 destroyOffset;

	public float playerDistanceToEffect;

	public float playerDistanceToHot;

	public bool destroyable;

	public float zoomMultiplier;

	private void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
