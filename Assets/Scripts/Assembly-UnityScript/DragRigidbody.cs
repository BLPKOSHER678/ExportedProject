using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Unity 2022-compatible replacement for the legacy UnityScript rigidbody drag helper.
/// Retains the original component name and serialized fields.
/// </summary>
[Serializable]
public class DragRigidbody : MonoBehaviour
{
    public float spring = 50f;
    public float damper = 5f;
    public float drag = 10f;
    public float angularDrag = 5f;
    public float distance = 0.2f;
    public bool attachToCenterOfMass = false;

    private SpringJoint springJoint;
    private Rigidbody draggedBody;
    private float oldDrag;
    private float oldAngularDrag;

    public virtual void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;

        Camera activeCamera = FindCamera();
        if (activeCamera == null)
            return;

        Ray ray = activeCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit, 100f))
            return;

        Rigidbody target = hit.rigidbody;
        if (target == null || target.isKinematic)
            return;

        if (springJoint == null)
        {
            GameObject helper = new GameObject("Rigidbody dragger");
            Rigidbody helperBody = helper.AddComponent<Rigidbody>();
            helperBody.isKinematic = true;
            helperBody.useGravity = false;
            springJoint = helper.AddComponent<SpringJoint>();
            springJoint.autoConfigureConnectedAnchor = false;
        }

        ReleaseDraggedBody();

        springJoint.transform.position = hit.point;
        springJoint.anchor = Vector3.zero;
        springJoint.connectedAnchor = attachToCenterOfMass
            ? target.centerOfMass
            : target.transform.InverseTransformPoint(hit.point);
        springJoint.spring = spring;
        springJoint.damper = damper;
        springJoint.minDistance = 0f;
        springJoint.maxDistance = distance;
        springJoint.connectedBody = target;

        StartCoroutine(DragObject(hit.distance));
    }

    public virtual IEnumerator DragObject(float hitDistance)
    {
        if (springJoint == null || springJoint.connectedBody == null)
            yield break;

        draggedBody = springJoint.connectedBody;
        oldDrag = draggedBody.drag;
        oldAngularDrag = draggedBody.angularDrag;
        draggedBody.drag = drag;
        draggedBody.angularDrag = angularDrag;

        Camera activeCamera = FindCamera();
        while (Input.GetMouseButton(0) &&
               activeCamera != null &&
               springJoint != null &&
               springJoint.connectedBody == draggedBody)
        {
            Ray ray = activeCamera.ScreenPointToRay(Input.mousePosition);
            springJoint.transform.position = ray.GetPoint(hitDistance);
            yield return null;
        }

        ReleaseDraggedBody();
    }

    public virtual Camera FindCamera()
    {
        Camera attachedCamera = GetComponent<Camera>();
        return attachedCamera != null ? attachedCamera : Camera.main;
    }

    private void ReleaseDraggedBody()
    {
        if (draggedBody != null)
        {
            draggedBody.drag = oldDrag;
            draggedBody.angularDrag = oldAngularDrag;
            draggedBody = null;
        }

        if (springJoint != null)
            springJoint.connectedBody = null;
    }

    private void OnDisable()
    {
        StopAllCoroutines();
        ReleaseDraggedBody();
    }

    private void OnDestroy()
    {
        if (springJoint != null)
            Destroy(springJoint.gameObject);
    }

    // Retained for compatibility with references to the original UnityScript class.
    public virtual void Main() { }
}
