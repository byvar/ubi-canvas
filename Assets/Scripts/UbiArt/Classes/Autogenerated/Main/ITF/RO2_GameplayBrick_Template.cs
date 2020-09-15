using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GameplayBrick_Template : RO2_EnduranceBrick_Template {
		public CList<StringID> ruleTags;
		public StringID decoBrick;
		public StringID decoBrickFlipped;
		public bool isGapOnly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ruleTags = s.SerializeObject<CList<StringID>>(ruleTags, name: "ruleTags");
			decoBrick = s.SerializeObject<StringID>(decoBrick, name: "decoBrick");
			decoBrickFlipped = s.SerializeObject<StringID>(decoBrickFlipped, name: "decoBrickFlipped");
			isGapOnly = s.Serialize<bool>(isGapOnly, name: "isGapOnly");
		}
		public override uint? ClassCRC => 0x0FB4A8DA;
	}
}

