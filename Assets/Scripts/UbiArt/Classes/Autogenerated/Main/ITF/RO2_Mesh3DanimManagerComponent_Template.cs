using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_Mesh3DanimManagerComponent_Template : ActorComponent_Template {
		[Serialize("idleAnim" )] public StringID idleAnim;
		[Serialize("eventAnim")] public StringID eventAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(eventAnim));
		}
		public override uint? ClassCRC => 0xED19208B;
	}
}

