using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
	public Transform airModel;

	public Transform groundModel;

	public Transform wallModel;

	public Transform endingModel;

	public Transform deathEyeModel;

	private Transform airChild;

	private Transform groundChild;

	private Transform wallChild;

	public float airScaleIntensity;

	public float groundScaleIntensity;

	public float impactIntensity;

	public bool compensateDirection;

	private CharacterControl charControl;

	public float skewFactor;

	public float maxSkew;

	public float maxGroundScale;

	public float wallPreSkew;

	public Vector2 minEyeRot;

	public Vector2 maxEyeRot;

	public float dieEyeForce;

	public ParticleSystem splash;

	public ParticleSystem deathSplat;

	public ParticleSystem startParticle;

	public AudioClip deathSplatClip;

	public AudioClip deathHeightClip;

	private bool died;

	public AudioClip[] fallingClips;

	public AudioClip[] hispeedClips;

	public AudioClip[] risingClips;

	public AudioClip[] deathHighClips;

	public AudioClip[] winClips;

	public AudioSource speechSource;

	public AudioClip teleportSound;

	public float hispeedMaxThr;

	public float hispeedMinThr;

	public float fallingMaxThr;

	public float fallingMinThr;

	public float risingMaxThr;

	public float risingMinThr;

	public Texture2D[] jellyTextures;

	public Material jellyMainMaterial;

	private bool canSpeechHispeed;

	private bool canSpeechFalling;

	private bool canSpeechRising;

	public AudioClip[] enemySpeech;

	private bool finished;

	private bool started;

	private int stars;

	private Vector3[] deathEyesStartPosition;

	private Quaternion[] deathEyesStartRotation;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	public void reset()
	{
	}

	private void Update()
	{
	}

	public void levelWin(int stars)
	{
	}

	public void dieEnemy()
	{
	}

	public void dieHeight()
	{
	}

	public void showGroundModel()
	{
	}

	public void showAirModel()
	{
	}

	public void showEndingModel()
	{
	}

	public void showWallModel()
	{
	}

	public void showModel(int model)
	{
	}
}
