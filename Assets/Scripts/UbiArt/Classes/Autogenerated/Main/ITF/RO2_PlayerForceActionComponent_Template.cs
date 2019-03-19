using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerForceActionComponent_Template : ActorComponent_Template {
		[Serialize("stackAction"               )] public bool stackAction;
		[Serialize("DRCInteractActorInZoneTest")] public bool DRCInteractActorInZoneTest;
		[Serialize("inShadowTest"              )] public int inShadowTest;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(stackAction));
				SerializeField(s, nameof(inShadowTest));
				SerializeField(s, nameof(DRCInteractActorInZoneTest));
			} else {
				SerializeField(s, nameof(stackAction));
				SerializeField(s, nameof(DRCInteractActorInZoneTest));
			}
		}
		public override uint? ClassCRC => 0xA4A78483;
	}
}

