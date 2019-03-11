using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenWait_Template : TweenInstruction_Template {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
			} else {
			}
		}
		public override uint? ClassCRC => 0x44E6779D;
	}
}

