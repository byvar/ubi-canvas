using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBlowingBirdLookatBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("uturn"        )] public Placeholder uturn;
		[Serialize("attack"       )] public Placeholder attack;
		[Serialize("beginDuration")] public float beginDuration;
		[Serialize("rotationSpeed")] public Angle rotationSpeed;
		[Serialize("minAngle"     )] public Angle minAngle;
		[Serialize("maxAngle"     )] public Angle maxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uturn));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(beginDuration));
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
		}
		public override uint? ClassCRC => 0x374B614A;
	}
}

