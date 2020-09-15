using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TouchScreenInputComponent_Template : ShapeComponent_Template {
		public uint priority;
		public bool ignoreZ;
		public StringID interactionBoneID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			priority = s.Serialize<uint>(priority, name: "priority");
			ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
			interactionBoneID = s.SerializeObject<StringID>(interactionBoneID, name: "interactionBoneID");
		}
		public override uint? ClassCRC => 0x866D16A7;
	}
}

