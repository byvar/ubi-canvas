using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSaveGame_Template : CSerializable {
		public Placeholder Id;
		public StringID MapLocation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Id = s.SerializeObject<Placeholder>(Id, name: "Id");
			MapLocation = s.SerializeObject<StringID>(MapLocation, name: "MapLocation");
		}
		public override uint? ClassCRC => 0x548F1F5E;
	}
}

