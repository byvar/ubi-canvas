using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PrisonerCageLightComponent_Template : RO2_AIComponent_Template {
		public CList<StringID> snapBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			snapBones = s.SerializeObject<CList<StringID>>(snapBones, name: "snapBones");
		}
		public override uint? ClassCRC => 0xB4D1A303;
	}
}

