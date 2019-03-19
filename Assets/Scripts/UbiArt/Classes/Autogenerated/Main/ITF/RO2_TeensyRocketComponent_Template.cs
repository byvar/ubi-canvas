using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeensyRocketComponent_Template : ActorComponent_Template {
		[Serialize("snapBone"     )] public StringID snapBone;
		[Serialize("FXBurningWick")] public StringID FXBurningWick;
		[Serialize("FXPutOutWick" )] public StringID FXPutOutWick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(snapBone));
				SerializeField(s, nameof(FXBurningWick));
				SerializeField(s, nameof(FXPutOutWick));
			} else {
				SerializeField(s, nameof(snapBone));
			}
		}
		public override uint? ClassCRC => 0x82F78BCB;
	}
}

