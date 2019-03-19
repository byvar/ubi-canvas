using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFlip_Template : CSerializable {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
			} else {
			}
		}
		public override uint? ClassCRC => 0x608702CF;
	}
}

