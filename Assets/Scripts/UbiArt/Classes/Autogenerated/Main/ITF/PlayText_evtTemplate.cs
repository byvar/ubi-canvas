using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayText_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("Text"          )] public string Text;
		[Serialize("wordTime"      )] public float wordTime;
		[Serialize("mood"          )] public uint mood;
		[Serialize("textOffset"    )] public Vector2 textOffset;
		[Serialize("localisationId")] public LocalisationId localisationId;
		[Serialize("sizeText"      )] public float sizeText;
		[Serialize("Text"          )] public Path Text;
		[Serialize("Params"        )] public Placeholder Params;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(Text));
				SerializeField(s, nameof(Params));
			} else {
				SerializeField(s, nameof(Text));
				SerializeField(s, nameof(wordTime));
				SerializeField(s, nameof(mood));
				SerializeField(s, nameof(textOffset));
				SerializeField(s, nameof(localisationId));
				SerializeField(s, nameof(sizeText));
			}
		}
		public override uint? ClassCRC => 0x77998139;
	}
}

