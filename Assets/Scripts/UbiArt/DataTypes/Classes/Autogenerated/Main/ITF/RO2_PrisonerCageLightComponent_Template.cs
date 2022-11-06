using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PrisonerCageLightComponent_Template : RO2_AIComponent_Template {
		public CListO<StringID> snapBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			snapBones = s.SerializeObject<CListO<StringID>>(snapBones, name: "snapBones");
		}
		public override uint? ClassCRC => 0xB4D1A303;
	}
}

