using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PrisonerCageLightComponent_Template : RO2_AIComponent_Template {
		[Serialize("snapBones")] public CList<StringID> snapBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(snapBones));
		}
		public override uint? ClassCRC => 0xB4D1A303;
	}
}

