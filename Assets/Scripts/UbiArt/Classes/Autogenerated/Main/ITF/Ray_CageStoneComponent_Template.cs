using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CageStoneComponent_Template : CSerializable {
		public uint cageID;
		public Path actorToSpawn;
		public float deltaPosX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cageID = s.Serialize<uint>(cageID, name: "cageID");
			actorToSpawn = s.SerializeObject<Path>(actorToSpawn, name: "actorToSpawn");
			deltaPosX = s.Serialize<float>(deltaPosX, name: "deltaPosX");
		}
		public override uint? ClassCRC => 0x8242B6D1;
	}
}

