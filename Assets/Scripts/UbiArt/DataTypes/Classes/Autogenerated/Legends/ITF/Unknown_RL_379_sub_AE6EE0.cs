using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_379_sub_AE6EE0 : CSerializable {
		public Placeholder ProjectilesDescList;
		public float MaxBullet;
		public float TimerBeforDown;
		public float MaxYBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ProjectilesDescList = s.SerializeObject<Placeholder>(ProjectilesDescList, name: "ProjectilesDescList");
			MaxBullet = s.Serialize<float>(MaxBullet, name: "MaxBullet");
			TimerBeforDown = s.Serialize<float>(TimerBeforDown, name: "TimerBeforDown");
			MaxYBullet = s.Serialize<float>(MaxYBullet, name: "MaxYBullet");
		}
		public override uint? ClassCRC => 0x86865CB8;
	}
}

