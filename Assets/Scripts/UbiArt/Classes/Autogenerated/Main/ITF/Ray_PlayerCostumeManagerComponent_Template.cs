using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlayerCostumeManagerComponent_Template : ActorComponent_Template {
		public CArray<CostumeInfo> costumes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumes = s.SerializeObject<CArray<CostumeInfo>>(costumes, name: "costumes");
		}
		public override uint? ClassCRC => 0xCCA51CCA;
	}
}

