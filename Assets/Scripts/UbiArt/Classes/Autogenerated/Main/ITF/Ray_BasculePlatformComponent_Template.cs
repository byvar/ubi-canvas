using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BasculePlatformComponent_Template : CSerializable {
		[Serialize("stiff"           )] public float stiff;
		[Serialize("damp"            )] public float damp;
		[Serialize("weightToAngle"   )] public float weightToAngle;
		[Serialize("maxAngle"        )] public Angle maxAngle;
		[Serialize("weightMultiplier")] public float weightMultiplier;
		[Serialize("forceMultiplier" )] public float forceMultiplier;
		[Serialize("crushMultiplier" )] public float crushMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stiff));
			SerializeField(s, nameof(damp));
			SerializeField(s, nameof(weightToAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(weightMultiplier));
			SerializeField(s, nameof(forceMultiplier));
			SerializeField(s, nameof(crushMultiplier));
		}
		public override uint? ClassCRC => 0xD51FD646;
	}
}

