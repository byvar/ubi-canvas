using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DjembeComponent_Template : ActorComponent_Template {
		[Serialize("waveFx"     )] public StringID waveFx;
		[Serialize("murphyFx"   )] public StringID murphyFx;
		[Serialize("LumRewardNb")] public uint LumRewardNb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waveFx));
			SerializeField(s, nameof(murphyFx));
			SerializeField(s, nameof(LumRewardNb));
		}
		public override uint? ClassCRC => 0x3319CB46;
	}
}

