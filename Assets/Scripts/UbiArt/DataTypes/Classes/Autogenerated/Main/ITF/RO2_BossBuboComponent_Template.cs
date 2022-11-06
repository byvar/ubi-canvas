using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossBuboComponent_Template : ActorComponent_Template {
		public StringID invisibleAnim;
		public StringID appearAnim;
		public StringID disappearAnim;
		public StringID hitAnim;
		public StringID deathAnim;
		public uint allowedFaction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invisibleAnim = s.SerializeObject<StringID>(invisibleAnim, name: "invisibleAnim");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			disappearAnim = s.SerializeObject<StringID>(disappearAnim, name: "disappearAnim");
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
			allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
		}
		public override uint? ClassCRC => 0x8F4BA3FD;
	}
}

