using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_QuestGiverComponent : CSerializable {
		[Serialize("questID"     )] public StringID questID;
		[Serialize("dialogText"  )] public string dialogText;
		[Serialize("tutorialText")] public LocalisationId tutorialText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(questID));
			SerializeField(s, nameof(dialogText));
			SerializeField(s, nameof(tutorialText));
		}
		public override uint? ClassCRC => 0x34C0C200;
	}
}

