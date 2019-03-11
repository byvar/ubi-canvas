using UnityEngine;

namespace UbiArt.ITF {
	public partial class ZInputConfig_Template : TemplateObj {
		[Serialize("inputs")] public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(inputs));
			} else {
			}
		}
		public override uint? ClassCRC => 0x9C26194D;
	}
}

