using UnityEngine;

namespace UbiArt.ITF {
	public partial class Animation3DTreeNodePlayAnim_Template : BlendTreeNodeTemplate<Animation3DTreeResult> {
		[Serialize("animationName"     )] public StringID animationName;
		[Serialize("proceduralInput"   )] public ProceduralInputData proceduralInput;
		[Serialize("proceduralPlayRate")] public ProceduralInputData proceduralPlayRate;
		[Serialize("weight"            )] public float weight;
		[Serialize("nodeName"          )] public StringID nodeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(animationName));
				SerializeField(s, nameof(proceduralInput));
				SerializeField(s, nameof(proceduralPlayRate));
				SerializeField(s, nameof(weight));
			} else {
				SerializeField(s, nameof(animationName));
				SerializeField(s, nameof(proceduralInput));
				SerializeField(s, nameof(proceduralPlayRate));
				SerializeField(s, nameof(weight));
			}
		}
		public override uint? ClassCRC => 0x727BBB4E;
	}
}

