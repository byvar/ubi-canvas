using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FluidFallAIComponent : GraphicComponent {
		[Serialize("uvMode"    )] public UV_MODE uvMode;
		[Serialize("startOpen" )] public bool startOpen;
		[Serialize("widthStart")] public float widthStart;
		[Serialize("widthBase" )] public float widthBase;
		[Serialize("speed"     )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uvMode));
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(widthStart));
				SerializeField(s, nameof(widthBase));
				SerializeField(s, nameof(speed));
			}
		}
		public enum UV_MODE {
			[Serialize("UV_MODE_OPTIMUM")] OPTIMUM = 0,
			[Serialize("UV_MODE_SPEED"  )] SPEED = 1,
		}
		public override uint? ClassCRC => 0x7FC096B9;
	}
}

