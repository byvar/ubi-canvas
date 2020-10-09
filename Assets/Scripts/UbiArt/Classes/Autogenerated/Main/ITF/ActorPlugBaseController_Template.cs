using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class ActorPlugBaseController_Template : CSerializable {
		public StringID plugID;
		public StringID controllerID;
		public StringID initState;
		public uint faction;
		public uint slotId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			plugID = s.SerializeObject<StringID>(plugID, name: "plugID");
			controllerID = s.SerializeObject<StringID>(controllerID, name: "controllerID");
			initState = s.SerializeObject<StringID>(initState, name: "initState");
			faction = s.Serialize<uint>(faction, name: "faction");
			slotId = s.Serialize<uint>(slotId, name: "slotId");
		}
		public override uint? ClassCRC => 0x19B216C4;
	}
}

