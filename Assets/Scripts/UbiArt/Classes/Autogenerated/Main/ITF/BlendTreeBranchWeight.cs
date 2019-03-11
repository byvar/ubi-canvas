using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeBranchWeight : CSerializable {
		[Serialize("weight"          )] public float weight;
		[Serialize("proceduralWeight")] public ProceduralInputData proceduralWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(weight));
			SerializeField(s, nameof(proceduralWeight));
		}
	}
}

