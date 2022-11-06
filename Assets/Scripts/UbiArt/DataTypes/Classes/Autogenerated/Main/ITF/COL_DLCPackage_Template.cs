using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCPackage_Template : CSerializable {
		public Placeholder name;
		public Placeholder annoncementPopUpTitle;
		public Placeholder annoncementPopUpMsgs;
		public Placeholder annoncementPopUpValidate;
		public Placeholder localizationPaths;
		public Path localizationCommon;
		public uint steamID;
		public uint uplayID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<Placeholder>(name, name: "name");
			annoncementPopUpTitle = s.SerializeObject<Placeholder>(annoncementPopUpTitle, name: "annoncementPopUpTitle");
			annoncementPopUpMsgs = s.SerializeObject<Placeholder>(annoncementPopUpMsgs, name: "annoncementPopUpMsgs");
			annoncementPopUpValidate = s.SerializeObject<Placeholder>(annoncementPopUpValidate, name: "annoncementPopUpValidate");
			localizationPaths = s.SerializeObject<Placeholder>(localizationPaths, name: "localizationPaths");
			localizationCommon = s.SerializeObject<Path>(localizationCommon, name: "localizationCommon");
			steamID = s.Serialize<uint>(steamID, name: "steamID");
			uplayID = s.Serialize<uint>(uplayID, name: "uplayID");
		}
		public override uint? ClassCRC => 0xADFA05EF;
	}
}

