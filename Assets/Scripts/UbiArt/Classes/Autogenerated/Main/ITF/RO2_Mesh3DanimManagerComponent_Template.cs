using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_Mesh3DanimManagerComponent_Template : ActorComponent_Template {
		public StringID idleAnim;
		public StringID eventAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			eventAnim = s.SerializeObject<StringID>(eventAnim, name: "eventAnim");
		}
		public override uint? ClassCRC => 0xED19208B;
	}
}

