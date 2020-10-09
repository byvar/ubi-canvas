using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DragonBossComponent_Template : ActorComponent_Template {
		public StringID breathBone;
		public float breathLength;
		public float breathWidth;
		public Path flameFx;
		public float hurtDelay;
		public StringID genericEventId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			breathBone = s.SerializeObject<StringID>(breathBone, name: "breathBone");
			breathLength = s.Serialize<float>(breathLength, name: "breathLength");
			breathWidth = s.Serialize<float>(breathWidth, name: "breathWidth");
			flameFx = s.SerializeObject<Path>(flameFx, name: "flameFx");
			hurtDelay = s.Serialize<float>(hurtDelay, name: "hurtDelay");
			genericEventId = s.SerializeObject<StringID>(genericEventId, name: "genericEventId");
		}
		public override uint? ClassCRC => 0xC42ECEF9;
	}
}

