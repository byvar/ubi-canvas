using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TextAnimScaleComponent_Template : ActorComponent_Template {
		[Serialize("baseSize"   )] public Vector2 baseSize;
		[Serialize("baseSizeMax")] public Vector2 baseSizeMax;
		[Serialize("margeSize"  )] public Vector2 margeSize;
		[Serialize("animInputX" )] public StringID animInputX;
		[Serialize("animInputY" )] public StringID animInputY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(baseSize));
			SerializeField(s, nameof(baseSizeMax));
			SerializeField(s, nameof(margeSize));
			SerializeField(s, nameof(animInputX));
			SerializeField(s, nameof(animInputY));
		}
		public override uint? ClassCRC => 0xFDE11D09;
	}
}

