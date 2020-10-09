using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DjembeComponent_Template : ActorComponent_Template {
		public StringID waveFx;
		public StringID murphyFx;
		public uint LumRewardNb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waveFx = s.SerializeObject<StringID>(waveFx, name: "waveFx");
			murphyFx = s.SerializeObject<StringID>(murphyFx, name: "murphyFx");
			LumRewardNb = s.Serialize<uint>(LumRewardNb, name: "LumRewardNb");
		}
		public override uint? ClassCRC => 0x3319CB46;
	}
}

