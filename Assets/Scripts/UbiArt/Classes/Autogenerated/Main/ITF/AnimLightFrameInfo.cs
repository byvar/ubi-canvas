using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class AnimLightFrameInfo : CSerializable {
		public SubAnimFrameInfo subAnimFrameInfo;
		public float weight;
		public bool usePatches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnimFrameInfo = s.SerializeObject<SubAnimFrameInfo>(subAnimFrameInfo, name: "subAnimFrameInfo");
			weight = s.Serialize<float>(weight, name: "weight");
			usePatches = s.Serialize<bool>(usePatches, name: "usePatches");
		}
	}
}

