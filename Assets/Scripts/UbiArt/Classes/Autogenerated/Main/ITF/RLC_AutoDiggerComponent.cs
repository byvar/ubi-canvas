using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AutoDiggerComponent : ActorComponent {
		public float DigResistance;
		public float DigImpulsion;
		public float DigImpulsionMax;
		public Spline SpeedCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DigResistance = s.Serialize<float>(DigResistance, name: "DigResistance");
			DigImpulsion = s.Serialize<float>(DigImpulsion, name: "DigImpulsion");
			DigImpulsionMax = s.Serialize<float>(DigImpulsionMax, name: "DigImpulsionMax");
			SpeedCurve = s.SerializeObject<Spline>(SpeedCurve, name: "SpeedCurve");
		}
		public override uint? ClassCRC => 0x57D1D8D9;
	}
}

