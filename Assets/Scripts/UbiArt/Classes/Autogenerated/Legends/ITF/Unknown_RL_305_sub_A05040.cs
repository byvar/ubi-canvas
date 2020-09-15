using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_305_sub_A05040 : BaseCameraComponent {
		[Serialize("Pos"            )] public Vec3d Pos;
		[Serialize("useInitModifier")] public bool useInitModifier;
		[Serialize("initModifier"   )] public Unknown_RL_38748_sub_A04420 initModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(Pos));
			}
			SerializeField(s, nameof(useInitModifier));
			if (useInitModifier) {
				SerializeField(s, nameof(initModifier));
			}
		}
		public override uint? ClassCRC => 0x9AC515FF;
	}
}

