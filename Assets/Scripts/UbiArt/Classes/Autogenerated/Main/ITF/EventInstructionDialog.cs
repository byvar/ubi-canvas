using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventInstructionDialog : Event {
		[Serialize("text"            )] public SmartLocId text;
		[Serialize("mood"            )] public uint mood;
		[Serialize("sizeText"        )] public float sizeText;
		[Serialize("offset"          )] public Vector2 offset;
		[Serialize("durationMin"     )] public float durationMin;
		[Serialize("actorScaleFactor")] public float actorScaleFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(mood));
			SerializeField(s, nameof(sizeText));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(durationMin));
			SerializeField(s, nameof(actorScaleFactor));
		}
		public override uint? ClassCRC => 0x171F42E2;
	}
}

