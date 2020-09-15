using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTDeciderHasActorsAlive_Template : BTDecider_Template {
		public bool invert;
		public bool checkAll;
		public StringID factActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invert = s.Serialize<bool>(invert, name: "invert");
			checkAll = s.Serialize<bool>(checkAll, name: "checkAll");
			factActor = s.SerializeObject<StringID>(factActor, name: "factActor");
		}
		public override uint? ClassCRC => 0x038DF1DE;
	}
}

