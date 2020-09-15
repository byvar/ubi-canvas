using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventInstructionDialog : Event {
		[Serialize("text"            )] public SmartLocId text;
		[Serialize("mood"            )] public uint mood;
		[Serialize("sizeText"        )] public float sizeText;
		[Serialize("offset"          )] public Vec2d offset;
		[Serialize("durationMin"     )] public float durationMin;
		[Serialize("actorScaleFactor")] public float actorScaleFactor;
		[Serialize("text"            )] public string textStr;
		[Serialize("snapToScreen"    )] public int snapToScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(textStr));
				SerializeField(s, nameof(mood));
				SerializeField(s, nameof(sizeText));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(snapToScreen));
				SerializeField(s, nameof(durationMin));
				SerializeField(s, nameof(actorScaleFactor));
			} else {
				SerializeField(s, nameof(text));
				SerializeField(s, nameof(mood));
				SerializeField(s, nameof(sizeText));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(durationMin));
				SerializeField(s, nameof(actorScaleFactor));
			}
		}
		public override uint? ClassCRC => 0x171F42E2;
	}
}

