using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionMusicalBounce_Template : BTActionPlayAnim_Template {
		[Serialize("amplitude"       )] public float amplitude;
		[Serialize("syncRatio"       )] public float syncRatio;
		[Serialize("syncOffset"      )] public float syncOffset;
		[Serialize("updateMovement"  )] public bool updateMovement;
		[Serialize("musicalAnimation")] public StringID musicalAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(amplitude));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(syncOffset));
			SerializeField(s, nameof(updateMovement));
			SerializeField(s, nameof(musicalAnimation));
		}
		public override uint? ClassCRC => 0x2CCB5012;
	}
}

