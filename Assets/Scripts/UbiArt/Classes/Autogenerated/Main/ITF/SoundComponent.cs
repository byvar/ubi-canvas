using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class SoundComponent : ActorComponent {
		public CListO<SoundDescriptor_Template> soundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
			} else {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
			}
		}
		public override uint? ClassCRC => 0x7DD8643C;
	}
}

