using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PlayerCostumeManagerComponent_Template : CSerializable {
		[Serialize("costumes")] public Placeholder costumes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumes));
		}
		public override uint? ClassCRC => 0xCCA51CCA;
	}
}

