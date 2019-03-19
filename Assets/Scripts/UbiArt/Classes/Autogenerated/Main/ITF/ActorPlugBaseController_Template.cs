using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class ActorPlugBaseController_Template : CSerializable {
		[Serialize("plugID"      )] public StringID plugID;
		[Serialize("controllerID")] public StringID controllerID;
		[Serialize("initState"   )] public StringID initState;
		[Serialize("faction"     )] public uint faction;
		[Serialize("slotId"      )] public uint slotId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(plugID));
			SerializeField(s, nameof(controllerID));
			SerializeField(s, nameof(initState));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(slotId));
		}
		public override uint? ClassCRC => 0x19B216C4;
	}
}

