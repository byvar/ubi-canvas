using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_MusicScoreSnapComponent : CSerializable {
		[Serialize("distOnCurve" )] public float distOnCurve;
		[Serialize("intervalNote")] public float intervalNote;
		[Serialize("note"        )] public uint note;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(distOnCurve));
				SerializeField(s, nameof(intervalNote));
				SerializeField(s, nameof(note));
			}
		}
		public override uint? ClassCRC => 0x76A9C107;
	}
}

