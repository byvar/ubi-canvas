using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraNearFarFadeComponent_Template : ActorComponent_Template {
		[Serialize("inputInterp"   )] public StringID inputInterp;
		[Serialize("inputNear"     )] public StringID inputNear;
		[Serialize("inputFar"      )] public StringID inputFar;
		[Serialize("inputFadeRange")] public StringID inputFadeRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputInterp));
			SerializeField(s, nameof(inputNear));
			SerializeField(s, nameof(inputFar));
			SerializeField(s, nameof(inputFadeRange));
		}
		public override uint? ClassCRC => 0x51381046;
	}
}

