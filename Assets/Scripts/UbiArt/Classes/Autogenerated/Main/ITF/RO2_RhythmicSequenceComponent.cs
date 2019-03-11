using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RhythmicSequenceComponent : ActorComponent {
		[Serialize("loop"          )] public bool loop;
		[Serialize("easeIn"        )] public float easeIn;
		[Serialize("easeOut"       )] public float easeOut;
		[Serialize("fadeIn"        )] public float fadeIn;
		[Serialize("transitionTime")] public float transitionTime;
		[Serialize("blocTime"      )] public float blocTime;
		[Serialize("type"          )] public uint type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(loop));
			SerializeField(s, nameof(easeIn));
			SerializeField(s, nameof(easeOut));
			SerializeField(s, nameof(fadeIn));
			SerializeField(s, nameof(transitionTime));
			SerializeField(s, nameof(blocTime));
			SerializeField(s, nameof(type));
		}
		public override uint? ClassCRC => 0x483AFD4E;
	}
}

