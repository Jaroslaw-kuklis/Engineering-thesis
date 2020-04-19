using UnityEngine;
using System.Collections;

public class InverseDynamics : MonoBehaviour {

	[Header("Rigidbodies")]

	public float drag = 10f;
	public float angularDrag = 10f;
	public int solverIterationCount = 25;
	public bool useGravity;

	[Header("Joints")]
	public bool enablePreprocessing;
	public bool enableCollision = true;

	[Header("ConfigurableJoints")]
	public bool enableProjection = true;
	public float projectionDistance;
	public float projectionAngle;

	[Header("Transforms")]
	public bool fixLocalPositions = true;

	private Rigidbody[] R;
	private Joint[] J;
	private ConfigurableJoint[] CJ;
	private Joint joint;
	private Vector3[] localPositions;

	void Start () {
		R = GetComponentsInChildren<Rigidbody>();
		J = GetComponentsInChildren<Joint>();
		CJ = GetComponentsInChildren<ConfigurableJoint>();

		localPositions = new Vector3[R.Length];
		for (int i = 1; i < R.Length; i++) {
			localPositions[i] = R[i].transform.localPosition;
		}
	}
	
	void FixedUpdate () {
		OnPreFixedUpdate();

		for (int i = 0; i < R.Length; i++) {
			var r = R[i];

			if (!r.isKinematic) {
				r.useGravity = useGravity;
				r.drag = drag;
				r.angularDrag = angularDrag;
				r.solverIterations = solverIterationCount;
                
				r.WakeUp();
			}
		}

		foreach (Joint j in J) {
			j.enablePreprocessing = enablePreprocessing;
			j.enableCollision = enableCollision;
		}

		foreach (ConfigurableJoint cj in CJ) {
			cj.projectionMode = enableProjection? JointProjectionMode.PositionAndRotation: JointProjectionMode.None;
			cj.projectionDistance = projectionDistance;
			cj.projectionAngle = projectionAngle;
		}
	}

	protected virtual void OnPreFixedUpdate() {}

	void LateUpdate() {
		if (!fixLocalPositions) return;

		for (int i = 0; i < R.Length; i++) {
			if (!R[i].isKinematic) {
				R[i].transform.localPosition = localPositions[i];
			}
		}
	}
}
