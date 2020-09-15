using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class InstructionDialogText : InstructionDialog {
		public StringID actorName;
		public LocalisationId idLoc;
		public string text;
		public uint mood;
		public float sizeText;
		public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorName = s.SerializeObject<StringID>(actorName, name: "actorName");
			idLoc = s.SerializeObject<LocalisationId>(idLoc, name: "idLoc");
			text = s.Serialize<string>(text, name: "text");
			mood = s.Serialize<uint>(mood, name: "mood");
			sizeText = s.Serialize<float>(sizeText, name: "sizeText");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0xD5D2CADB;
	}
}

