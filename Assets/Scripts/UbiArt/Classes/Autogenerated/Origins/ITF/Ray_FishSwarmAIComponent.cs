using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FishSwarmAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("widthZone"    )] public float widthZone;
		[Serialize("heightZone"   )] public float heightZone;
		[Serialize("frontColor"   )] public Color frontColor;
		[Serialize("frontFogColor")] public Color frontFogColor;
		[Serialize("backColor"    )] public Color backColor;
		[Serialize("backFogColor" )] public Color backFogColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(widthZone));
			SerializeField(s, nameof(heightZone));
			SerializeField(s, nameof(frontColor));
			SerializeField(s, nameof(frontFogColor));
			SerializeField(s, nameof(backColor));
			SerializeField(s, nameof(backFogColor));
		}
		public override uint? ClassCRC => 0x951EF777;
	}
}

