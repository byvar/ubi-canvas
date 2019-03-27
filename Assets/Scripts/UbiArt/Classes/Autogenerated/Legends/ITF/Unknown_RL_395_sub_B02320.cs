using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_395_sub_B02320 : ActorComponent {
		[Serialize("IsHelpMenuIcon"        )] public bool IsHelpMenuIcon;
		[Serialize("defaultBackgroundColor")] public Color defaultBackgroundColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IsHelpMenuIcon));
			SerializeField(s, nameof(defaultBackgroundColor));
		}
		public override uint? ClassCRC => 0xE640DE7C;
	}
}

