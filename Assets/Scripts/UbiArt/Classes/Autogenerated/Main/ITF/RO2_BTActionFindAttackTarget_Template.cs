using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionFindAttackTarget_Template : BTAction_Template {
		public float radius;
		public StringID fact;
		public bool filterByHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radius = s.Serialize<float>(radius, name: "radius");
			fact = s.SerializeObject<StringID>(fact, name: "fact");
			filterByHeight = s.Serialize<bool>(filterByHeight, name: "filterByHeight");
		}
		public override uint? ClassCRC => 0x9F42330C;
	}
}

