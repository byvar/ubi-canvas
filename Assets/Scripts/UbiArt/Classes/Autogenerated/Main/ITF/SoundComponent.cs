using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.ROVersion)]
	public partial class SoundComponent : ActorComponent {
		public CList<SoundDescriptor_Template> soundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
			}
		}
		public override uint? ClassCRC => 0x7DD8643C;
	}
}

