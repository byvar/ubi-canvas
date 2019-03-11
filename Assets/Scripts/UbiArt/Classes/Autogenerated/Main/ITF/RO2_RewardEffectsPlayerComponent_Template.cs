using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RewardEffectsPlayerComponent_Template : ActorComponent_Template {
		[Serialize("pickingLumYellowNormal"    )] public StringID pickingLumYellowNormal;
		[Serialize("pickingLumYellowAccrobatic")] public StringID pickingLumYellowAccrobatic;
		[Serialize("pickingLumRedNormal"       )] public StringID pickingLumRedNormal;
		[Serialize("pickingLumRedAccrobatic"   )] public StringID pickingLumRedAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pickingLumYellowNormal));
			SerializeField(s, nameof(pickingLumYellowAccrobatic));
			SerializeField(s, nameof(pickingLumRedNormal));
			SerializeField(s, nameof(pickingLumRedAccrobatic));
		}
		public override uint? ClassCRC => 0xA0B02B8D;
	}
}

