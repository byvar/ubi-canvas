using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AngleAnimatedComponent_Template : ActorComponent_Template {
		[Serialize("CounterClockWise")] public bool CounterClockWise;
		[Serialize("AnimRotationName")] public StringID AnimRotationName;
		[Serialize("bool__0"         )] public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
			} else {
				SerializeField(s, nameof(CounterClockWise));
				SerializeField(s, nameof(AnimRotationName));
			}
		}
		public override uint? ClassCRC => 0x132C748D;
	}
}

