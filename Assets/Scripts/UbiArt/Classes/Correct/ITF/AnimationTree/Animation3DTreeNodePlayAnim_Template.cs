using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class Animation3DTreeNodePlayAnim_Template : BlendTreeNodeTemplate<Animation3DTreeResult> {
		[Serialize("animationName"     )] public StringID animationName;
		[Serialize("proceduralInput"   )] public ProceduralInputData proceduralInput;
		[Serialize("proceduralPlayRate")] public ProceduralInputData proceduralPlayRate;
		[Serialize("weight"            )] public float weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animationName));
			SerializeField(s, nameof(proceduralInput));
			SerializeField(s, nameof(proceduralPlayRate));
			SerializeField(s, nameof(weight));
		}
		public override uint? ClassCRC => 0x727BBB4E;
	}
}

