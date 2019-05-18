using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class InGameTextComponent_Template : ActorComponent_Template {
		[Serialize("textBone"             )] public StringID textBone;
		[Serialize("scaleK"               )] public float scaleK;
		[Serialize("scaleD"               )] public float scaleD;
		[Serialize("minScaleNumCharacters")] public uint minScaleNumCharacters;
		[Serialize("maxScaleNumCharacters")] public uint maxScaleNumCharacters;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textBone));
			SerializeField(s, nameof(scaleK));
			SerializeField(s, nameof(scaleD));
			SerializeField(s, nameof(minScaleNumCharacters));
			SerializeField(s, nameof(maxScaleNumCharacters));
		}
		public override uint? ClassCRC => 0xF3801B21;
	}
}

