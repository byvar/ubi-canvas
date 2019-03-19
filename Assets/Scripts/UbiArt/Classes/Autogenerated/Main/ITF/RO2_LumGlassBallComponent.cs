using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumGlassBallComponent : ActorComponent {
		[Serialize("SteadyChildren")] public bool SteadyChildren;
		[Serialize("TorqueFriction")] public float TorqueFriction;
		[Serialize("SpeedFriction" )] public float SpeedFriction;
		[Serialize("shape"         )] public EditableShape shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(SteadyChildren));
				SerializeField(s, nameof(TorqueFriction));
				SerializeField(s, nameof(SpeedFriction));
				SerializeField(s, nameof(shape));
			}
		}
		public override uint? ClassCRC => 0x3D3CA6BF;
	}
}

