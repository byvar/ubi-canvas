using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryConfig_Template : CSerializable {
		public Placeholder startingItemIDs;
		public Placeholder startingItemIDs_TRIAL;
		public StringID attachmentBoneName;
		public Path inventoryRunesTexturePath;
		public Placeholder inventoryRunesTexture;
		public uint maxLightOrbCount;
		public Placeholder potionIDs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startingItemIDs = s.SerializeObject<Placeholder>(startingItemIDs, name: "startingItemIDs");
			startingItemIDs_TRIAL = s.SerializeObject<Placeholder>(startingItemIDs_TRIAL, name: "startingItemIDs_TRIAL");
			attachmentBoneName = s.SerializeObject<StringID>(attachmentBoneName, name: "attachmentBoneName");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				inventoryRunesTexturePath = s.SerializeObject<Path>(inventoryRunesTexturePath, name: "inventoryRunesTexturePath");
			}
			inventoryRunesTexture = s.SerializeObject<Placeholder>(inventoryRunesTexture, name: "inventoryRunesTexture");
			maxLightOrbCount = s.Serialize<uint>(maxLightOrbCount, name: "maxLightOrbCount");
			potionIDs = s.SerializeObject<Placeholder>(potionIDs, name: "potionIDs");
		}
		public override uint? ClassCRC => 0x4314140A;
	}
}

