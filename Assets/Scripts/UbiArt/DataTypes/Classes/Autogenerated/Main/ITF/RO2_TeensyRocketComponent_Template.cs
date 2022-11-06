using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_TeensyRocketComponent_Template : ActorComponent_Template {
		public StringID snapBone;
		public StringID FXBurningWick;
		public StringID FXPutOutWick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
				FXBurningWick = s.SerializeObject<StringID>(FXBurningWick, name: "FXBurningWick");
				FXPutOutWick = s.SerializeObject<StringID>(FXPutOutWick, name: "FXPutOutWick");
			} else {
				snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
			}
		}
		public override uint? ClassCRC => 0x82F78BCB;
	}
}

