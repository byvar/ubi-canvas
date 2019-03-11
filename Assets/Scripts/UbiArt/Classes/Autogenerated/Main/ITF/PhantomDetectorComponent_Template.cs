using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhantomDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("allowDeadActors")] public bool allowDeadActors;
		[Serialize("factionToDetect")] public uint factionToDetect;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
			} else {
				SerializeField(s, nameof(allowDeadActors));
			}
		}
		public override uint? ClassCRC => 0xF530E437;
	}
}

