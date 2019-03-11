using UnityEngine;

namespace UbiArt.ITF {
	public partial class WwiseMultiPositionComponent_Template : ActorComponent_Template {
		[Serialize("MultiPositionMode")] public AUDIO_MULTIPOSITION_MODE MultiPositionMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MultiPositionMode));
		}
		public enum AUDIO_MULTIPOSITION_MODE {
			[Serialize("AUDIO_MULTIPOSITION_MODE_SINGLE_SOURCE"   )] SINGLE_SOURCE = 0,
			[Serialize("AUDIO_MULTIPOSITION_MODE_MULTI_SOURCES"   )] MULTI_SOURCES = 1,
			[Serialize("AUDIO_MULTIPOSITION_MODE_MULTI_DIRECTIONS")] MULTI_DIRECTIONS = 2,
		}
		public override uint? ClassCRC => 0x67B9F9C4;
	}
}

