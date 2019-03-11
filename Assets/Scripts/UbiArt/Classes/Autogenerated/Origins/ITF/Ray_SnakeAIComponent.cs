using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SnakeAIComponent : CSerializable {
		[Serialize("activeMode")] public ActiveMode activeMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activeMode));
		}
		public enum ActiveMode {
			[Serialize("ActiveMode_Default"                    )] Default = 0,
			[Serialize("ActiveMode_AlwaysActiveDeactivateOnEnd")] AlwaysActiveDeactivateOnEnd = 1,
		}
		public override uint? ClassCRC => 0x34A561B8;
	}
}

