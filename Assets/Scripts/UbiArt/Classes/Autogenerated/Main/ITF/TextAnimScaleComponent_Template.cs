using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TextAnimScaleComponent_Template : ActorComponent_Template {
		[Serialize("baseSize"   )] public Vec2d baseSize;
		[Serialize("baseSizeMax")] public Vec2d baseSizeMax;
		[Serialize("margeSize"  )] public Vec2d margeSize;
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

