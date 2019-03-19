using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CageStoneComponent_Template : CSerializable {
		[Serialize("cageID"      )] public uint cageID;
		[Serialize("actorToSpawn")] public Path actorToSpawn;
		[Serialize("deltaPosX"   )] public float deltaPosX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cageID));
			SerializeField(s, nameof(actorToSpawn));
			SerializeField(s, nameof(deltaPosX));
		}
		public override uint? ClassCRC => 0x8242B6D1;
	}
}

