using UnityEngine;

namespace UbiArt.ITF {
	public partial class InstructionDialogText : InstructionDialog {
		[Serialize("actorName")] public StringID actorName;
		[Serialize("idLoc"    )] public LocalisationId idLoc;
		[Serialize("text"     )] public string text;
		[Serialize("mood"     )] public uint mood;
		[Serialize("sizeText" )] public float sizeText;
		[Serialize("offset"   )] public Vector2 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorName));
			SerializeField(s, nameof(idLoc));
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(mood));
			SerializeField(s, nameof(sizeText));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0xD5D2CADB;
	}
}

