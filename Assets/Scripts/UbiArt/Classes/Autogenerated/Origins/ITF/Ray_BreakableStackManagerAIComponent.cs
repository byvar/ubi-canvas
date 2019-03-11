using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BreakableStackManagerAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("width"       )] public uint width;
		[Serialize("height"      )] public uint height;
		[Serialize("gravityFall" )] public float gravityFall;
		[Serialize("iceMode"     )] public bool iceMode;
		[Serialize("syncAnim"    )] public bool syncAnim;
		[Serialize("speedIceMode")] public float speedIceMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(width));
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(gravityFall));
			SerializeField(s, nameof(iceMode));
			SerializeField(s, nameof(syncAnim));
			SerializeField(s, nameof(speedIceMode));
		}
		public override uint? ClassCRC => 0x75FDB171;
	}
}

