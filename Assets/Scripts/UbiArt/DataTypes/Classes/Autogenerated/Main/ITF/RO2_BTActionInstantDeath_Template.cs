using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionInstantDeath_Template : BTAction_Template {
		public StringID anim;
		public Path fx;
		public bool spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			fx = s.SerializeObject<Path>(fx, name: "fx");
			spawnOnMarker = s.Serialize<bool>(spawnOnMarker, name: "spawnOnMarker");
		}
		public override uint? ClassCRC => 0xD3E3066E;
	}
}

