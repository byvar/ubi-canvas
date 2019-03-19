using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class Trajectory_Template : CSerializable {
		[Serialize("translation")] public Spline translation;
		[Serialize("rotation"   )] public Spline rotation;
		[Serialize("scale"      )] public Spline scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(translation));
			SerializeField(s, nameof(rotation));
			SerializeField(s, nameof(scale));
		}
	}
}

