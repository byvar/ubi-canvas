using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventShow : Event {
		[Serialize("alpha"         )] public float alpha;
		[Serialize("transitionTime")] public float transitionTime;
		[Serialize("overrideColor" )] public bool overrideColor;
		[Serialize("alpharatio"    )] public bool alpharatio;
		[Serialize("color"         )] public Color color;
		[Serialize("pauseOnEnd"    )] public bool pauseOnEnd;
		[Serialize("destroyOnEnd"  )] public bool destroyOnEnd;
		[Serialize("sender"        )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(overrideColor));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(pauseOnEnd));
				SerializeField(s, nameof(destroyOnEnd));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(overrideColor));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(pauseOnEnd));
				SerializeField(s, nameof(destroyOnEnd));
			} else {
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(overrideColor));
				SerializeField(s, nameof(alpharatio));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(pauseOnEnd));
				SerializeField(s, nameof(destroyOnEnd));
			}
		}
		public override uint? ClassCRC => 0x06A5D850;
	}
}

