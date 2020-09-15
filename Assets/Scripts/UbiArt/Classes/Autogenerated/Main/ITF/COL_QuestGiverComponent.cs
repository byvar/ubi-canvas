using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_QuestGiverComponent : CSerializable {
		public StringID questID;
		public string dialogText;
		public LocalisationId tutorialText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			questID = s.SerializeObject<StringID>(questID, name: "questID");
			dialogText = s.Serialize<string>(dialogText, name: "dialogText");
			tutorialText = s.SerializeObject<LocalisationId>(tutorialText, name: "tutorialText");
		}
		public override uint? ClassCRC => 0x34C0C200;
	}
}

