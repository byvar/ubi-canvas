using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionHelmet_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID anim;
		public bool useBone;
		public StringID boneName;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			useBone = s.Serialize<bool>(useBone, name: "useBone");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0xD074F292;
	}
}

