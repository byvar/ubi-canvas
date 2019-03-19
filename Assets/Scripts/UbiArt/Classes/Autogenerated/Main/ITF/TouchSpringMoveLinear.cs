using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class TouchSpringMoveLinear : TouchSpringMoveBase {
		[Serialize("totalLength"       )] public float totalLength;
		[Serialize("initPos"           )] public float initPos;
		[Serialize("minPosLimit"       )] public float minPosLimit;
		[Serialize("maxPosLimit"       )] public float maxPosLimit;
		[Serialize("useStartingLength" )] public bool useStartingLength;
		[Serialize("startingLength"    )] public float startingLength;
		[Serialize("axisAngle"         )] public Angle axisAngle;
		[Serialize("useSnap"           )] public bool useSnap;
		[Serialize("snapDistance"      )] public float snapDistance;
		[Serialize("snapMinCursorSpeed")] public float snapMinCursorSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(totalLength));
			SerializeField(s, nameof(initPos));
			SerializeField(s, nameof(minPosLimit));
			SerializeField(s, nameof(maxPosLimit));
			SerializeField(s, nameof(useStartingLength));
			SerializeField(s, nameof(startingLength));
			SerializeField(s, nameof(axisAngle));
			SerializeField(s, nameof(useSnap));
			SerializeField(s, nameof(snapDistance));
			SerializeField(s, nameof(snapMinCursorSpeed));
		}
		public override uint? ClassCRC => 0xC0A14FBF;
	}
}

