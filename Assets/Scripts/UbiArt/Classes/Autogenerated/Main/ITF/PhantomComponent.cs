using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhantomComponent : ShapeComponent {
		[Serialize("depthOffsets")] public CArray<float> depthOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(depthOffsets));
			}
		}
		public override uint? ClassCRC => 0x2B541820;
	}
}

