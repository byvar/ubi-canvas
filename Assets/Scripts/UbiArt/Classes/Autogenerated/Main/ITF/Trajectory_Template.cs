using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class Trajectory_Template : CSerializable {
		public Spline translation;
		public Spline rotation;
		public Spline scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			translation = s.SerializeObject<Spline>(translation, name: "translation");
			rotation = s.SerializeObject<Spline>(rotation, name: "rotation");
			scale = s.SerializeObject<Spline>(scale, name: "scale");
		}
	}
}

