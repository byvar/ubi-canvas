using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventTeleportToCheckpoint : CSerializable {
		[Serialize("sender"            )] public uint sender;
		[Description("ObjectId of the target checkpoint")]
		[Serialize("checkpointObjectId")] public Placeholder checkpointObjectId;
		[Serialize("whiteFade"         )] public bool whiteFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(checkpointObjectId));
			SerializeField(s, nameof(whiteFade), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xECBB3974;
	}
}

