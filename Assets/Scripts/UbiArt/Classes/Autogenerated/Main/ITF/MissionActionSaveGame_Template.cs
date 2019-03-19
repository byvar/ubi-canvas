using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSaveGame_Template : CSerializable {
		[Serialize("Id"         )] public Placeholder Id;
		[Serialize("MapLocation")] public StringID MapLocation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(MapLocation));
		}
		public override uint? ClassCRC => 0x548F1F5E;
	}
}

