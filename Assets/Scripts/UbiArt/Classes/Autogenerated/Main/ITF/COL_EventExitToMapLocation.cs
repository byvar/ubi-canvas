using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventExitToMapLocation : CSerializable {
		[Serialize("sender"            )] public uint sender;
		[Serialize("unlock"            )] public bool unlock;
		[Serialize("mapLocationId"     )] public StringID mapLocationId;
		[Serialize("mapPath"           )] public PathRef mapPath;
		[Serialize("checkpointIndex"   )] public uint checkpointIndex;
		[Serialize("checkpointObjectId")] public Placeholder checkpointObjectId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(unlock), boolAsByte: true);
			SerializeField(s, nameof(mapLocationId));
			SerializeField(s, nameof(mapPath));
			SerializeField(s, nameof(checkpointIndex));
			SerializeField(s, nameof(checkpointObjectId));
		}
		public override uint? ClassCRC => 0xEDFEA31B;
	}
}

