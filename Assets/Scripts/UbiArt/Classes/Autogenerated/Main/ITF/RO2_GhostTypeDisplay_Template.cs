using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GhostTypeDisplay_Template : CSerializable {
		[Serialize("friendlyActorInfo"       )] public GraphicActorInfo friendlyActorInfo;
		[Serialize("darkActorInfo"           )] public GraphicActorInfo darkActorInfo;
		[Serialize("rotationSpeed"           )] public float rotationSpeed;
		[Serialize("posOffset"               )] public Vector2 posOffset;
		[Serialize("rotatePosDist"           )] public float rotatePosDist;
		[Serialize("rotatePosDistBlendFactor")] public float rotatePosDistBlendFactor;
		[Serialize("deltaMove"               )] public float deltaMove;
		[Serialize("deltaMoveSpeed"          )] public float deltaMoveSpeed;
		[Serialize("targetTransitionDuration")] public float targetTransitionDuration;
		[Serialize("testNumber"              )] public uint testNumber;
		[Serialize("initStartType"           )] public uint initStartType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(friendlyActorInfo));
			SerializeField(s, nameof(darkActorInfo));
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(posOffset));
			SerializeField(s, nameof(rotatePosDist));
			SerializeField(s, nameof(rotatePosDistBlendFactor));
			SerializeField(s, nameof(deltaMove));
			SerializeField(s, nameof(deltaMoveSpeed));
			SerializeField(s, nameof(targetTransitionDuration));
			SerializeField(s, nameof(testNumber));
			SerializeField(s, nameof(initStartType));
		}
		public override uint? ClassCRC => 0xA1832B53;
	}
}

