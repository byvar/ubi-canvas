using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraShakeCurveParams : BaseCurveParams {
		[Serialize("frequency")] public float frequency;
		[Serialize("amplitude")] public float amplitude;
		[Serialize("offset"   )] public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(amplitude));
				SerializeField(s, nameof(offset));
			}
		}
		public override uint? ClassCRC => 0xC2243BF4;
	}
}

