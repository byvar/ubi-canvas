using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DestroyComponent_Template : ActorComponent_Template {
		public bool waitForFx;
		public float timeBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitForFx = s.Serialize<bool>(waitForFx, name: "waitForFx");
			timeBeforeDestroy = s.Serialize<float>(timeBeforeDestroy, name: "timeBeforeDestroy");
		}
		public override uint? ClassCRC => 0x22C1A57D;
	}
}

