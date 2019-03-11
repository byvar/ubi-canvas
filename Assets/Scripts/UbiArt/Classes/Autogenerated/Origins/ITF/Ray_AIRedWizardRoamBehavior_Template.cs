using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIRedWizardRoamBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		[Serialize("greet"        )] public Placeholder greet;
		[Serialize("greetRange"   )] public float greetRange;
		[Serialize("greetCooldown")] public float greetCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(greet));
			SerializeField(s, nameof(greetRange));
			SerializeField(s, nameof(greetCooldown));
		}
		public override uint? ClassCRC => 0xC9B3A832;
	}
}

