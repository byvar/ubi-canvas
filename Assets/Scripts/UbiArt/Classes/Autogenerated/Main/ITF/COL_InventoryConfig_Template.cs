using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryConfig_Template : CSerializable {
		[Serialize("startingItemIDs"          )] public Placeholder startingItemIDs;
		[Serialize("startingItemIDs_TRIAL"    )] public Placeholder startingItemIDs_TRIAL;
		[Serialize("attachmentBoneName"       )] public StringID attachmentBoneName;
		[Serialize("inventoryRunesTexturePath")] public Path inventoryRunesTexturePath;
		[Serialize("inventoryRunesTexture"    )] public Placeholder inventoryRunesTexture;
		[Serialize("maxLightOrbCount"         )] public uint maxLightOrbCount;
		[Serialize("potionIDs"                )] public Placeholder potionIDs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startingItemIDs));
			SerializeField(s, nameof(startingItemIDs_TRIAL));
			SerializeField(s, nameof(attachmentBoneName));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(inventoryRunesTexturePath));
			}
			SerializeField(s, nameof(inventoryRunesTexture));
			SerializeField(s, nameof(maxLightOrbCount));
			SerializeField(s, nameof(potionIDs));
		}
		public override uint? ClassCRC => 0x4314140A;
	}
}

