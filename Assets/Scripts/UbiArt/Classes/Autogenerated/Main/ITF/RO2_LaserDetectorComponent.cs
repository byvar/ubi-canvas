using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LaserDetectorComponent : ActorComponent {
		[Serialize("Length"            )] public float Length;
		[Serialize("DetectedSizeEffect")] public float DetectedSizeEffect;
		[Serialize("DelaiInactive"     )] public float DelaiInactive;
		[Serialize("LaserSendPafAlone" )] public bool LaserSendPafAlone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Length));
			SerializeField(s, nameof(DetectedSizeEffect));
			SerializeField(s, nameof(DelaiInactive));
			SerializeField(s, nameof(LaserSendPafAlone));
		}
		public override uint? ClassCRC => 0xD6AE6B90;
	}
}

