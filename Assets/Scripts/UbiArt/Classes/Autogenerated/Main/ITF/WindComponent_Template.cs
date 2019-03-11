using UnityEngine;

namespace UbiArt.ITF {
	public partial class WindComponent_Template : PhysForceModifierComponent_Template {
		[Serialize("windAreas"    )] public CList<PhysForceModifier_Template> windAreas;
		[Serialize("canInverse"   )] public bool canInverse;
		[Serialize("canStop"      )] public bool canStop;
		[Serialize("enableAtStart")] public bool enableAtStart;
		[Serialize("flags"        )] public Enum_flags flags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(windAreas));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(windAreas));
			} else {
				SerializeField(s, nameof(windAreas));
				SerializeField(s, nameof(canInverse));
				SerializeField(s, nameof(canStop));
				SerializeField(s, nameof(enableAtStart));
				SerializeField(s, nameof(flags));
			}
		}
		public enum Enum_flags {
			[Serialize("OnlyApplyIfNotSticked")] OnlyApplyIfNotSticked = 1,
		}
		public override uint? ClassCRC => 0xCB67A691;
	}
}

