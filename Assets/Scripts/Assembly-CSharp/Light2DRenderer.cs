using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Light2DRenderer : MonoBehaviour
{
	private List<Light2DMesh> lightMeshs;

	private void OnDrawGizmos()
	{
	}

	public void SubmitMesh(Light2DMesh mesh)
	{
	}

	public void ForceClearMeshList()
	{
	}

	private void OnPostRender()
	{
	}

	private void CheckForNullMaterial(ref Material material)
	{
	}

	public void ForceRender()
	{
	}

	private void Render()
	{
	}
}
