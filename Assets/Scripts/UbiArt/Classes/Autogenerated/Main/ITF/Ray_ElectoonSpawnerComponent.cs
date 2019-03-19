using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ElectoonSpawnerComponent : CSerializable {
		[Serialize("numToSpawn")] public uint numToSpawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(numToSpawn));
		}
		public override uint? ClassCRC => 0x34065C0A;
	}
}

