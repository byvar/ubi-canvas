using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIEventShowPopUp : CSerializable {
		public uint sender;
		public StringID menuSceneID;
		public Placeholder titleLocID;
		public Placeholder msgLocID;
		public Placeholder validateLocID;
		public Placeholder declineLocID;
		public StringID openSoundGUID;
		public Path iconTexturePath;
		public uint iconSpriteIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
			menuSceneID = s.SerializeObject<StringID>(menuSceneID, name: "menuSceneID");
			titleLocID = s.SerializeObject<Placeholder>(titleLocID, name: "titleLocID");
			msgLocID = s.SerializeObject<Placeholder>(msgLocID, name: "msgLocID");
			validateLocID = s.SerializeObject<Placeholder>(validateLocID, name: "validateLocID");
			declineLocID = s.SerializeObject<Placeholder>(declineLocID, name: "declineLocID");
			openSoundGUID = s.SerializeObject<StringID>(openSoundGUID, name: "openSoundGUID");
			iconTexturePath = s.SerializeObject<Path>(iconTexturePath, name: "iconTexturePath");
			iconSpriteIndex = s.Serialize<uint>(iconSpriteIndex, name: "iconSpriteIndex");
		}
		public override uint? ClassCRC => 0x356AF464;
	}
}

