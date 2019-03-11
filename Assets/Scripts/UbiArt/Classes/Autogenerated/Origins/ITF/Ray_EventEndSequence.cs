using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventEndSequence : CSerializable {
		[Serialize("playMovie")] public bool playMovie;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playMovie));
		}
		public override uint? ClassCRC => 0xEDE8B3A1;
	}
}

