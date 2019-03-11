using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventShow : Event {
		[Serialize("alpha"         )] public float alpha;
		[Serialize("transitionTime")] public float transitionTime;
		[Serialize("overrideColor" )] public bool overrideColor;
		[Serialize("alpharatio"    )] public bool alpharatio;
		[Serialize("pauseOnEnd"    )] public bool pauseOnEnd;
		[Serialize("destroyOnEnd"  )] public bool destroyOnEnd;
		[Serialize("color"         )] public Color color;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(transitionTime));
				SerializeField(s, nameof(overrideColor));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(pauseOnEnd));
				SerializeField(s, nameof(destroyOnEnd));
			} else if (Settings.s.game == Settings.Game.RL) {
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
				SerializeField(s, nameof(pauseOnEnd));
				SerializeField(s, nameof(destroyOnEnd));
			}
		}
		public override uint? ClassCRC => 0x06A5D850;
	}
}

