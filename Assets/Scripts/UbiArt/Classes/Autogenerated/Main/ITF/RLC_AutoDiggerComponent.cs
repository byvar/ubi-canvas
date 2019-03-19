using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AutoDiggerComponent : ActorComponent {
		[Serialize("DigResistance"  )] public float DigResistance;
		[Serialize("DigImpulsion"   )] public float DigImpulsion;
		[Serialize("DigImpulsionMax")] public float DigImpulsionMax;
		[Serialize("SpeedCurve"     )] public Spline SpeedCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DigResistance));
			SerializeField(s, nameof(DigImpulsion));
			SerializeField(s, nameof(DigImpulsionMax));
			SerializeField(s, nameof(SpeedCurve));
		}
		public override uint? ClassCRC => 0x57D1D8D9;
	}
}

