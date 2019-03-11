using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenSine_Template : TweenTranslation_Template {
		[Serialize("movement"   )] public Vector3 movement;
		[Serialize("amplitude"  )] public float amplitude;
		[Serialize("cycleCount" )] public float cycleCount;
		[Serialize("cycleOffset")] public float cycleOffset;
		[Serialize("CosinusOnX" )] public bool CosinusOnX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(amplitude));
				SerializeField(s, nameof(cycleCount));
				SerializeField(s, nameof(cycleOffset));
			} else {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(amplitude));
				SerializeField(s, nameof(cycleCount));
				SerializeField(s, nameof(cycleOffset));
				SerializeField(s, nameof(CosinusOnX));
			}
		}
		public override uint? ClassCRC => 0x2D3E7D44;
	}
}

