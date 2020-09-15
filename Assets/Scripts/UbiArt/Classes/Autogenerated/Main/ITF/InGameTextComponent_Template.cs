using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class InGameTextComponent_Template : ActorComponent_Template {
		public StringID textBone;
		public float scaleK;
		public float scaleD;
		public uint minScaleNumCharacters;
		public uint maxScaleNumCharacters;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textBone = s.SerializeObject<StringID>(textBone, name: "textBone");
			scaleK = s.Serialize<float>(scaleK, name: "scaleK");
			scaleD = s.Serialize<float>(scaleD, name: "scaleD");
			minScaleNumCharacters = s.Serialize<uint>(minScaleNumCharacters, name: "minScaleNumCharacters");
			maxScaleNumCharacters = s.Serialize<uint>(maxScaleNumCharacters, name: "maxScaleNumCharacters");
		}
		public override uint? ClassCRC => 0xF3801B21;
	}
}

