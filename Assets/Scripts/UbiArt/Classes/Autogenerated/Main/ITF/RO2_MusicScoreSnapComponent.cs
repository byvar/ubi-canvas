using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MusicScoreSnapComponent : ActorComponent {
		[Serialize("distOnCurve"       )] public float distOnCurve;
		[Serialize("note"              )] public uint note;
		[Serialize("noteIntervalHeight")] public float noteIntervalHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(distOnCurve));
				SerializeField(s, nameof(note));
				SerializeField(s, nameof(noteIntervalHeight));
			}
		}
		public override uint? ClassCRC => 0xB76E3E61;
	}
}

