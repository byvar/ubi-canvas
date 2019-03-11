using UnityEngine;

namespace UbiArt.ITF {
	public partial class MetronomeManager_Template : TemplateObj {
		[Serialize("defaultBPM")] public uint defaultBPM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(defaultBPM));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(defaultBPM));
			} else {
			}
		}
		public override uint? ClassCRC => 0xB33FDC7C;
	}
}

