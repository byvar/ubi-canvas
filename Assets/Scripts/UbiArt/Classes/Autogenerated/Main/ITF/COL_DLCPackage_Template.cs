using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCPackage_Template : CSerializable {
		[Serialize("name"                    )] public Placeholder name;
		[Serialize("annoncementPopUpTitle"   )] public Placeholder annoncementPopUpTitle;
		[Serialize("annoncementPopUpMsgs"    )] public Placeholder annoncementPopUpMsgs;
		[Serialize("annoncementPopUpValidate")] public Placeholder annoncementPopUpValidate;
		[Serialize("localizationPaths"       )] public Placeholder localizationPaths;
		[Serialize("localizationCommon"      )] public Path localizationCommon;
		[Serialize("steamID"                 )] public uint steamID;
		[Serialize("uplayID"                 )] public uint uplayID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(annoncementPopUpTitle));
			SerializeField(s, nameof(annoncementPopUpMsgs));
			SerializeField(s, nameof(annoncementPopUpValidate));
			SerializeField(s, nameof(localizationPaths));
			SerializeField(s, nameof(localizationCommon));
			SerializeField(s, nameof(steamID));
			SerializeField(s, nameof(uplayID));
		}
		public override uint? ClassCRC => 0x75BC560D;
	}
}

