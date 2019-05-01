using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlayerCostumeManagerComponent_Template : ActorComponent_Template {
		[Serialize("costumes")] public CArray<CostumeInfo> costumes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumes));
		}
		public override uint? ClassCRC => 0xCCA51CCA;
	}
}

