using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIEventShowPopUp : CSerializable {
		[Serialize("sender"         )] public uint sender;
		[Serialize("menuSceneID"    )] public StringID menuSceneID;
		[Serialize("titleLocID"     )] public Placeholder titleLocID;
		[Serialize("msgLocID"       )] public Placeholder msgLocID;
		[Serialize("validateLocID"  )] public Placeholder validateLocID;
		[Serialize("declineLocID"   )] public Placeholder declineLocID;
		[Serialize("openSoundGUID"  )] public StringID openSoundGUID;
		[Serialize("iconTexturePath")] public Path iconTexturePath;
		[Serialize("iconSpriteIndex")] public uint iconSpriteIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(menuSceneID));
			SerializeField(s, nameof(titleLocID));
			SerializeField(s, nameof(msgLocID));
			SerializeField(s, nameof(validateLocID));
			SerializeField(s, nameof(declineLocID));
			SerializeField(s, nameof(openSoundGUID));
			SerializeField(s, nameof(iconTexturePath));
			SerializeField(s, nameof(iconSpriteIndex));
		}
		public override uint? ClassCRC => 0x356AF464;
	}
}

