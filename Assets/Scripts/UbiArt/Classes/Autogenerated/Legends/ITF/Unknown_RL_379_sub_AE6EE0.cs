using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_379_sub_AE6EE0 : CSerializable {
		[Serialize("ProjectilesDescList")] public Placeholder ProjectilesDescList;
		[Serialize("MaxBullet"          )] public float MaxBullet;
		[Serialize("TimerBeforDown"     )] public float TimerBeforDown;
		[Serialize("MaxYBullet"         )] public float MaxYBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ProjectilesDescList));
			SerializeField(s, nameof(MaxBullet));
			SerializeField(s, nameof(TimerBeforDown));
			SerializeField(s, nameof(MaxYBullet));
		}
		public override uint? ClassCRC => 0x86865CB8;
	}
}

