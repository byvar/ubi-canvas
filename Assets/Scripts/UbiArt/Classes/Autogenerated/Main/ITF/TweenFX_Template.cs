using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenFX_Template : TweenInstruction_Template {
		[Serialize("fx"      )] public StringID fx;
		[Serialize("stop"    )] public bool stop;
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(stop));
			} else {
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(stop));
			}
		}
		public override uint? ClassCRC => 0xBC2071D6;
	}
}

