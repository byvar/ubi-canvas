using UnityEngine;

namespace UbiArt.ITF {
	public partial class DeformOnTrajectoryComponent_Template : ActorComponent_Template {
		[Serialize("bones"       )] public CList<StringID> bones;
		[Serialize("sampleLength")] public float sampleLength;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(bones));
			} else {
				SerializeField(s, nameof(bones));
				SerializeField(s, nameof(sampleLength));
			}
		}
		public override uint? ClassCRC => 0xCDC7E469;
	}
}

