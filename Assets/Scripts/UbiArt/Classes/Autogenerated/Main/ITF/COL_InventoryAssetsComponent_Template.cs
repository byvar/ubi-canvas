using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryAssetsComponent_Template : CSerializable {
		[Serialize("spawnEquippedItems"   )] public bool spawnEquippedItems;
		[Serialize("renderToParentTexture")] public bool renderToParentTexture;
		[Serialize("wingsMeshName"        )] public string wingsMeshName;
		[Serialize("defaultItems"         )] public Placeholder defaultItems;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnEquippedItems), boolAsByte: true);
			SerializeField(s, nameof(renderToParentTexture), boolAsByte: true);
			SerializeField(s, nameof(wingsMeshName));
			SerializeField(s, nameof(defaultItems));
		}
		public override uint? ClassCRC => 0x01CA259F;
	}
}

