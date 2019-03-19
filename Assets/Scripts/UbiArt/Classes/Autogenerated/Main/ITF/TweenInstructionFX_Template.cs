using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFX_Template : TweenInstruction_Template {
		[Serialize("duration"   )] public float duration;
		[Serialize("name"       )] public StringID name;
		[Serialize("fx"         )] public StringID fx;
		[Serialize("stop"       )] public int stop;
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("int__1"     )] public int int__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(stop));
			} else {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(int__1));
			}
		}
		public override uint? ClassCRC => 0x6699D058;
	}
}

