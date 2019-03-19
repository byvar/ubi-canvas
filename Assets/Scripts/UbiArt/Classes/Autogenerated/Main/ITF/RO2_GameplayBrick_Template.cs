using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GameplayBrick_Template : RO2_EnduranceBrick_Template {
		[Serialize("ruleTags"        )] public CList<StringID> ruleTags;
		[Serialize("decoBrick"       )] public StringID decoBrick;
		[Serialize("decoBrickFlipped")] public StringID decoBrickFlipped;
		[Serialize("isGapOnly"       )] public bool isGapOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ruleTags));
			SerializeField(s, nameof(decoBrick));
			SerializeField(s, nameof(decoBrickFlipped));
			SerializeField(s, nameof(isGapOnly));
		}
		public override uint? ClassCRC => 0x0FB4A8DA;
	}
}

