using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableStackManagerAIComponent : Ray_AIComponent {
		[Serialize("width"       )] public uint width;
		[Serialize("height"      )] public uint height;
		[Serialize("gravityFall" )] public float gravityFall;
		[Serialize("iceMode"     )] public int iceMode;
		[Serialize("syncAnim"    )] public int syncAnim;
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

