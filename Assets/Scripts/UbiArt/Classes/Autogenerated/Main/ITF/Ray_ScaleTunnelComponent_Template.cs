using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ScaleTunnelComponent_Template : CSerializable {
		[Serialize("area"    )] public Placeholder area;
		[Serialize("scale"   )] public float scale;
		[Serialize("float__0")] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(area));
				SerializeField(s, nameof(scale));
			} else {
				SerializeField(s, nameof(float__0));
			}
		}
		public override uint? ClassCRC => 0x1A08EAF7;
	}
}

