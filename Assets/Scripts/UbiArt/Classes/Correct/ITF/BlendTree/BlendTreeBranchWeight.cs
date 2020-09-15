using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class BlendTreeBranchWeight : CSerializable {
		public float weight;
		public ProceduralInputData proceduralWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			weight = s.Serialize<float>(weight, name: "weight");
			proceduralWeight = s.SerializeObject<ProceduralInputData>(proceduralWeight, name: "proceduralWeight");
		}
	}
}

