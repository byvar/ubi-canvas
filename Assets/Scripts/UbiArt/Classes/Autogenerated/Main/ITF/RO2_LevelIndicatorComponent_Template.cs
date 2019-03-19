using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LevelIndicatorComponent_Template : ActorComponent_Template {
		[Serialize("levels"            )] public CList<SmartLocId> levels;
		[Serialize("displayDuration"   )] public float displayDuration;
		[Serialize("transitionDuration")] public float transitionDuration;
		[Serialize("nbRebound"         )] public uint nbRebound;
		[Serialize("startOffset"       )] public Vector2 startOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(levels));
			SerializeField(s, nameof(displayDuration));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(nbRebound));
			SerializeField(s, nameof(startOffset));
		}
		public override uint? ClassCRC => 0xAC2A915C;
	}
}

