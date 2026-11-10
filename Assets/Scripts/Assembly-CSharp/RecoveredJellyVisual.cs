using UnityEngine;

/// <summary>
/// Visual-only placeholder for the recovered jelly. The original 3D character
/// prefab is missing; the red, one-eyed capsule approximates the gameplay videos.
/// This is not a reconstructed original model.
/// </summary>
public class RecoveredJellyVisual : MonoBehaviour
{
    private Transform bodyVisual;
    private CharacterControl movement;
    private Rigidbody physicsBody;
    private Material red;
    private Material eyeWhite;
    private Material pupilBlack;
    private Vector3 settledScale = new Vector3(0.64f, 0.78f, 0.60f);
    private bool created;

    private static Material MakeMaterial(string materialName, Color color)
    {
        Shader shader = Shader.Find("Standard");
        if (shader == null) shader = Shader.Find("Legacy Shaders/Diffuse");
        if (shader == null) shader = Shader.Find("Sprites/Default");
        Material material = new Material(shader);
        material.name = materialName;
        material.color = color;
        return material;
    }

    private static GameObject VisualPart(PrimitiveType primitive, string objectName, Transform parent,
        Vector3 localPosition, Vector3 localScale, Material material)
    {
        GameObject piece = GameObject.CreatePrimitive(primitive);
        piece.name = objectName;
        piece.transform.SetParent(parent, false);
        piece.transform.localPosition = localPosition;
        piece.transform.localRotation = Quaternion.identity;
        piece.transform.localScale = localScale;
        Collider partCollider = piece.GetComponent<Collider>();
        if (partCollider != null) Destroy(partCollider);
        MeshRenderer renderer = piece.GetComponent<MeshRenderer>();
        if (renderer != null) renderer.sharedMaterial = material;
        return piece;
    }

    private void Awake()
    {
        movement = GetComponent<CharacterControl>();
        physicsBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if (created) return;
        created = true;

        red = MakeMaterial("Recovered Jelly red", new Color(0.95f, 0.22f, 0.095f, 1f));
        eyeWhite = MakeMaterial("Recovered Jelly eye", Color.white);
        pupilBlack = MakeMaterial("Recovered Jelly pupil", new Color(0.075f, 0.05f, 0.04f, 1f));

        GameObject body = VisualPart(PrimitiveType.Capsule, "Jelly body (temporary visual)",
            transform, Vector3.zero, settledScale, red);
        bodyVisual = body.transform;

        // Eye faces the 2.5D camera (which looks from negative Z in these levels).
        VisualPart(PrimitiveType.Sphere, "Jelly eye white", bodyVisual,
            new Vector3(0.28f, 0.26f, -0.45f),
            new Vector3(0.29f, 0.28f, 0.16f), eyeWhite);
        VisualPart(PrimitiveType.Sphere, "Jelly pupil", bodyVisual,
            new Vector3(0.35f, 0.26f, -0.55f),
            new Vector3(0.12f, 0.15f, 0.09f), pupilBlack);
        VisualPart(PrimitiveType.Sphere, "Jelly mouth", bodyVisual,
            new Vector3(0.23f, -0.30f, -0.48f),
            new Vector3(0.12f, 0.09f, 0.055f), pupilBlack);
    }

    private void LateUpdate()
    {
        if (!created || bodyVisual == null || movement == null || physicsBody == null) return;
        Vector3 target = settledScale;
        if (!movement.grounded)
        {
            float ascending = Mathf.Clamp01(physicsBody.velocity.y / 10f);
            target = Vector3.Lerp(new Vector3(0.69f, 0.62f, 0.60f),
                new Vector3(0.46f, 1.22f, 0.60f), ascending);
        }
        bodyVisual.localScale = Vector3.Lerp(bodyVisual.localScale, target,
            Mathf.Min(1f, 14f * Time.deltaTime));
    }

    private void OnDestroy()
    {
        if (red != null) Destroy(red);
        if (eyeWhite != null) Destroy(eyeWhite);
        if (pupilBlack != null) Destroy(pupilBlack);
    }
}
