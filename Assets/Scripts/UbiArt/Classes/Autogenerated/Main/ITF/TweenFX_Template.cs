using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenFX_Template : TweenInstruction_Template {
		[Serialize("fx"                )] public StringID fx;
		[Serialize("stop"              )] public bool stop;
		[Serialize("duration"          )] public float duration;
		[Serialize("name"              )] public StringID name;
		[Serialize("useLocalInitialPos")] public bool useLocalInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(stop), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(stop), boolAsByte: true);
				SerializeField(s, nameof(useLocalInitialPos), boolAsByte: true);
			} else {
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(stop));
			}
		}
		public override uint? ClassCRC => 0xBC2071D6;
	}
}

