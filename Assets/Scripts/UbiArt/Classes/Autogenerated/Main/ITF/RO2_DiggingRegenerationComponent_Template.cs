using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DiggingRegenerationComponent_Template : ActorComponent_Template {
		[Serialize("RadiusAdditive"                )] public float RadiusAdditive;
		[Serialize("RadiusRegenerationSafe"        )] public float RadiusRegenerationSafe;
		[Serialize("TruncateRadiusRegenerationSafe")] public float TruncateRadiusRegenerationSafe;
		[Serialize("OffsetRegenerationSafe"        )] public Vector2 OffsetRegenerationSafe;
		[Serialize("RadiusFillingSafe"             )] public float RadiusFillingSafe;
		[Serialize("OffsetFillingSafe"             )] public Vector2 OffsetFillingSafe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(RadiusAdditive));
			}
			SerializeField(s, nameof(RadiusRegenerationSafe));
			SerializeField(s, nameof(TruncateRadiusRegenerationSafe));
			SerializeField(s, nameof(OffsetRegenerationSafe));
			SerializeField(s, nameof(RadiusFillingSafe));
			SerializeField(s, nameof(OffsetFillingSafe));
		}
		public override uint? ClassCRC => 0xAC5B8709;
	}
}

